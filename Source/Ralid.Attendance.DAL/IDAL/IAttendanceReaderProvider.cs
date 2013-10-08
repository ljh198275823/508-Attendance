using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.DAL.IDAL
{
    public interface IAttendanceReaderProvider : IProvider<Ralid.Attendance.Model.AttendanceReader, string>
    {
    }
}
