using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance .Model ;

namespace LJH.Attendance.Device
{
    public interface IReader
    {
        void Connect();
        void Disconnect();
        bool IsConnected { get; }
        List<AttendanceLog> GetAttendanceLogs(DatetimeRange range);
        void SetUserInfo(Staff staff);
    }
}
