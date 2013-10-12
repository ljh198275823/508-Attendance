using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model.SearchCondition
{
    public class ShiftArrangeSearchCondition : SearchCondition
    {
        public int? UserID { get; set; }

        public string ShiftID { get; set; }

        public DatetimeRange ShiftDate { get; set; }
    }
}
