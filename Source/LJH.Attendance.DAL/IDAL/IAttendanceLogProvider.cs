using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.DAL.IDAL
{
    public interface IAttendanceLogProvider : IProvider<LJH.Attendance.Model.AttendanceLog, int>
    {
    }
}
