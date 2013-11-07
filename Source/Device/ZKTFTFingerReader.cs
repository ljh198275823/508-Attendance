using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Device
{
    /// <summary>
    /// 表示中控彩屏指纹读卡器
    /// </summary>
    public class ZKTFTFingerReader : IReader
    {
        #region 实现接口
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected
        {
            get { throw new NotImplementedException(); }
        }

        public List<Model.AttendanceLog> GetAttendanceLogs()
        {
            throw new NotImplementedException();
        }

        public void SetUserInfo(Model.Staff staff)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
