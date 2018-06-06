using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using zkemkeeper;
using ZKFPEngXControl;
using LJH.Attendance.Model;

namespace LJH.Attendance.Device
{
    /// <summary>
    /// 表示中控彩屏指纹读卡器
    /// </summary>
    public class ZKFingerKeeper : IReader
    {
        #region 构造函数
        public ZKFingerKeeper()
        {
        }

        public ZKFingerKeeper(LJH.Attendance.Model.DeviceInfo para)
        {
            Parameter = para;
        }
        #endregion

        #region 私有变量
        private zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();
        ZKFPEngXControl.ZKFPEngX _ZKEngine = new ZKFPEngX();

        private bool _Connected = false;

        private int iMachineNumber = 1;
        #endregion

        #region 私有方法
        /// <summary>
        /// 查看设置是否能ping通
        /// </summary>
        /// <returns></returns>
        private bool Pingable(string strIp)
        {
            try
            {
                Ping ping = new Ping();
                IPAddress ip;
                if (IPAddress.TryParse(strIp, out ip))
                {
                    PingReply reply = ping.Send(ip, 200);  //超时间设置成200毫秒
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            return false;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置设备的参数
        /// </summary>
        public LJH.Attendance.Model.DeviceInfo Parameter { get; set; }
        #endregion

        #region 实现接口
        /// <summary>
        /// 连接设备
        /// </summary>
        public void Connect()
        {
            if (Parameter != null && !_Connected)
            {
                if (Parameter.Communication == CommunicationType.TCP_IP && !string.IsNullOrEmpty(Parameter.IP) && Parameter.ControlPort != null)
                {
                    if (Pingable(Parameter.IP))
                    {
                        _Connected = axCZKEM1.Connect_Net(Parameter.IP, Parameter.ControlPort.Value);
                        axCZKEM1.BASE64 = 1;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (Parameter.Communication == CommunicationType.RS232_485 && Parameter.Commport != null && Parameter.Baud != null)
                {
                    _Connected = axCZKEM1.Connect_Com(Parameter.Commport.Value, iMachineNumber, Parameter.Baud.Value);
                }
                if (!_Connected)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "连接设备失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
        }
        /// <summary>
        /// 断开设备
        /// </summary>
        public void Disconnect()
        {
            if (_Connected)
            {
                axCZKEM1.Disconnect();
            }
        }
        /// <summary>
        /// 获取是否连接成功
        /// </summary>
        public bool IsConnected
        {
            get
            {
                return _Connected;
            }
        }
        /// <summary>
        /// 获取机器上的考勤记录
        /// </summary>
        /// <param name="range">考勤记录的日期时间范围,为null表示获取所有记录</param>
        /// <returns></returns>
        public List<AttendanceLog> GetAttendanceLogs(DatetimeRange range)
        {
            int idwErrorCode = 0;
            List<AttendanceLog> logs = new List<AttendanceLog>();
            try
            {
                axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
                if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
                {
                    int idwTMachineNumber = 0;
                    int idwEnrollNumber = 0;
                    int idwEMachineNumber = 0;
                    int idwVerifyMode = 0;
                    int idwInOutMode = 0;
                    int idwYear = 0;
                    int idwMonth = 0;
                    int idwDay = 0;
                    int idwHour = 0;
                    int idwMinute = 0;
                    while (axCZKEM1.GetGeneralLogData(iMachineNumber, ref idwTMachineNumber, ref idwEnrollNumber,
                            ref idwEMachineNumber, ref idwVerifyMode, ref idwInOutMode, ref idwYear, ref idwMonth, ref idwDay, ref idwHour, ref idwMinute))//get records from the memory
                    {
                        DateTime dt = new DateTime(idwYear, idwMonth, idwDay, idwHour, idwMinute, 0);
                        if (range == null || range.Contain(dt))
                        {
                            AttendanceLog log = new AttendanceLog()
                            {
                                StaffID = idwEnrollNumber,
                                StaffName = string.Empty,
                                ReaderID = Parameter.ID,
                                ReaderName = Parameter.Name,
                                ReadDateTime = dt,
                            };
                            logs.Add(log);
                        }
                    }
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);

                    if (idwErrorCode != 0)
                    {
                        LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "获取考勤记录失败，ErrorCode=" + idwErrorCode.ToString());
                    }
                    else
                    {
                        LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "无考勤记录，ErrorCode=" + idwErrorCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            }
            return logs;
        }
        /// <summary>
        /// 保存用户
        /// </summary>
        /// <param name="staff"></param>
        public void SetUserInfo(Staff staff)
        {
            if (!_Connected)
            {
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "保存用户信息失败，未连接设备");
                return;
            }

            bool ret =true;
            byte[] reserved = new byte[10];
            if (!string.IsNullOrEmpty(staff.CardID)) ret = axCZKEM1.SetStrCardNumber(staff.CardID);
            string pwd = !string.IsNullOrEmpty(staff.Password) ? staff.Password : "8888";
            int pri = staff.IsAdmin != null && staff.IsAdmin.Value ? 3 : 0;
            if (ret) ret = axCZKEM1.SetUserInfo(iMachineNumber, staff.ID, staff.Name, pwd, pri, true);
            if (ret && ((int)Parameter.VerifyCode) > 0) ret = axCZKEM1.SetUserInfoEx(iMachineNumber, staff.ID, 128 + (int)staff.VerifyCode, ref reserved[0]); //0-15是验证模式，但设置组的验证方式的时候用0-15，用户的验证方式用128-143
            if (!ret)
            {
                int idwErrorCode = 0;
                axCZKEM1.GetLastError(ref idwErrorCode);
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "保存用户信息失败，ErrorCode=" + idwErrorCode.ToString());
            }
        }
        /// <summary>
        /// 保存用户指纹
        /// </summary>
        /// <param name="template"></param>
        public void SetUserTemplate(StaffBioTemplate template)
        {
            if (!_Connected)
            {
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "保存用户指纹失败，未连接设备");
                return;
            }
            string temp = null;
            int size = 0;
            if (template.IsBiokey && template.Version == "9.0")
            {
                bool r = axCZKEM1.FPTempConvertNewStr(template.Template, ref temp, ref size);
                if (!r)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "biokey指纹转换失败，ErrorCode=" + idwErrorCode.ToString());
                }
            }
            else
            {
                temp = template.Template;
            }
            if (!string.IsNullOrEmpty(temp))
            {
                int fingerIndex = (int)template.BioSource;
                if (fingerIndex >= 0 && fingerIndex <= 9) //指纹
                {
                    bool isTFT = axCZKEM1.IsTFTMachine(iMachineNumber);
                    bool ret = axCZKEM1.SetUserTmpExStr(iMachineNumber, template.StaffID.ToString(), fingerIndex, 1, temp);
                    if (!ret)
                    {
                        int idwErrorCode = 0;
                        axCZKEM1.GetLastError(ref idwErrorCode);
                        LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "保存用户指纹失败，ErrorCode=" + idwErrorCode.ToString());
                    }
                }
            }
        }
        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="flag"></param>
        public void ClearData(ClearDataFlag flag)
        {
            if (!_Connected)
            {
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空失败，未连接设备");
                return;
            }
            bool ret = false;
            if ((flag & ClearDataFlag.AttendanceLog) == ClearDataFlag.AttendanceLog)
            {
                ret = axCZKEM1.ClearData(iMachineNumber, 1);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空考勤记录失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
            if ((flag & ClearDataFlag.FPTemplate) == ClearDataFlag.FPTemplate)
            {
                ret = axCZKEM1.ClearData(iMachineNumber, 2);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空指纹模板失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
            if ((flag & ClearDataFlag.OperatorLog) == ClearDataFlag.OperatorLog)
            {
                ret = axCZKEM1.ClearData(iMachineNumber, 4);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空操作记录失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
            if ((flag & ClearDataFlag.UserInfo) == ClearDataFlag.UserInfo)
            {
                ret = axCZKEM1.ClearData(iMachineNumber, 5);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空用户信息失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
        }
        /// <summary>
        /// 设置时间
        /// </summary>
        /// <param name="dt"></param>
        public void SetTime(DateTime dt)
        {
            if (!_Connected)
            {
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "设置时间失败，未连接设备");
                return;
            }
            int idwErrorCode = 0;
            if (axCZKEM1.SetDeviceTime2(iMachineNumber, dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "设置时间失败，,ErrorCode=" + idwErrorCode.ToString());
            }
        }
        /// <summary>
        /// 重启
        /// </summary>
        public void Restart()
        {
            if (!_Connected)
            {
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "重启失败，未连接设备");
                return;
            }
            if (!axCZKEM1.RestartDevice(iMachineNumber) == true)
            {
                int idwErrorCode = 0;
                axCZKEM1.GetLastError(ref idwErrorCode);
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "重启失败，ErrorCode=" + idwErrorCode.ToString());
            }
        }
        /// <summary>
        /// 关机
        /// </summary>
        public void PowerOff()
        {
            if (!_Connected)
            {
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "关机失败，未连接设备");
                return;
            }
            if (!axCZKEM1.PowerOffDevice(iMachineNumber) == true)
            {
                int idwErrorCode = 0;
                axCZKEM1.GetLastError(ref idwErrorCode);
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "关机失败，ErrorCode=" + idwErrorCode.ToString());
            }
        }
        /// <summary>
        /// 重新设置IP地址
        /// </summary>
        /// <param name="newIP"></param>
        public void SetIP(string newIP)
        {
            if (!_Connected)
            {
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "设置IP失败，未连接设备");
                return;
            }
            if (!axCZKEM1.SetDeviceIP(iMachineNumber, newIP) == true)
            {
                int idwErrorCode = 0;
                axCZKEM1.GetLastError(ref idwErrorCode);
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "设置IP失败，ErrorCode=" + idwErrorCode.ToString());
            }
        }
        /// <summary>
        /// 启用或禁用设备
        /// </summary>
        /// <param name="enable"></param>
        public void EnableDevice(bool enable)
        {
            axCZKEM1.EnableDevice(iMachineNumber, enable);
        }
        /// <summary>
        /// 更新数据,一般在保存了用户信息等后,调用此方法使数据生效
        /// </summary>
        public void RefreshData()
        {
            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
        }
        #endregion
    }
}
