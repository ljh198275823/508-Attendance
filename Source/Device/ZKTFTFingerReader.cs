using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zkemkeeper;
using LJH.Attendance.Model;

namespace LJH.Attendance.Device
{
    /// <summary>
    /// 表示中控彩屏指纹读卡器
    /// </summary>
    public class ZKTFTFingerReader : IReader
    {
        #region 构造函数
        public ZKTFTFingerReader()
        {
        }

        public ZKTFTFingerReader(LJH.Attendance.Model.DeviceInfo para)
        {
            Parameter = para;
        }
        #endregion

        #region 私有变量
        private zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();

        private bool _Connected = false;

        private int _MachineNumber = 1;
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
                    _Connected = axCZKEM1.Connect_Net(Parameter.IP, Parameter.ControlPort.Value);
                }
                else if (Parameter.Communication == CommunicationType.RS232_485 && Parameter.Commport != null && Parameter.Baud != null)
                {
                    _Connected = axCZKEM1.Connect_Com(Parameter.Commport.Value, _MachineNumber, Parameter.Baud.Value);
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


        public List<AttendanceLog> GetAttendanceLogs()
        {
            throw new NotImplementedException();
        }

        public void SetUserInfo(Staff staff)
        {
            throw new NotImplementedException();
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
                ret = axCZKEM1.ClearData(_MachineNumber, 1);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空考勤记录失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
            if ((flag & ClearDataFlag.FPTemplate) == ClearDataFlag.FPTemplate)
            {
                ret = axCZKEM1.ClearData(_MachineNumber, 2);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空指纹模板失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
            if ((flag & ClearDataFlag.OperatorLog) == ClearDataFlag.OperatorLog)
            {
                ret = axCZKEM1.ClearData(_MachineNumber, 4);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空操作记录失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
            if ((flag & ClearDataFlag.UserInfo) == ClearDataFlag.UserInfo)
            {
                ret = axCZKEM1.ClearData(_MachineNumber, 5);
                if (!ret)
                {
                    int idwErrorCode = 0;
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    LJH.GeneralLibrary.LOG.FileLog.Log(Parameter.Name, "清空用户信息失败,ErrorCode=" + idwErrorCode.ToString());
                }
            }
        }
        #endregion
    }
}
