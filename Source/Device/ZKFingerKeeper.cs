using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using zkemkeeper;
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
        /// 
        /// </summary>
        /// <returns></returns>
        public List<AttendanceLog> GetAttendanceLogs()
        {
            throw new NotImplementedException();
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
            bool ret = axCZKEM1.SetUserInfo(iMachineNumber, staff.ID, staff.Name, "8888", 0, true);
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
            string temp = string.Empty;
            int size = 0;
            if (axCZKEM1.FPTempConvertNewStr(template.Template, ref temp, ref size)) //biokey模板转换成指纹机模板
            {
                int fingerIndex = (int)template.BioSource;
                if (fingerIndex >= 0 && fingerIndex <= 9) //指纹
                {
                    bool ret = axCZKEM1.SetUserTmpStr(iMachineNumber, template.StaffID, fingerIndex, temp);
                    if (!ret)
                    {
                        int idwErrorCode = 0;
                        axCZKEM1.GetLastError(ref idwErrorCode);
                        LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "保存用户指纹失败，ErrorCode=" + idwErrorCode.ToString());
                    }
                }
            }
            else
            {
                int idwErrorCode = 0;
                axCZKEM1.GetLastError(ref idwErrorCode);
                LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "转换指纹模板失败，ErrorCode=" + idwErrorCode.ToString());
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

        public void EnableDevice(bool enable)
        {
            axCZKEM1.EnableDevice(iMachineNumber, enable);
        }

        public void RefreshData()
        {
            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
        }
        #endregion
    }
}
