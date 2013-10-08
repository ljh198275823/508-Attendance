using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.DAL.IDAL
{
    public interface IAttendanceLogProvider : IProvider<Ralid.Attendance.Model.AttendanceLog, int>
    {
    }
}
