using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model.SearchCondition
{
    public class AttendanceLogSearchCondition:SearchCondition 
    {
        public List<int> Staff { get; set; }

        public List<string> Cards { get; set; }

        public DatetimeRange ReadDateTime { get; set; }

        public List<string> Readers { get; set; }

        public bool ContainManualLogs { get; set; }
    }
}
