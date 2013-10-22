using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model.SearchCondition
{
    public class TASheetSearchCondition : SearchCondition
    {
        public string SheetID { get; set; }

        public string  StaffID { get; set; }

        public string SheetType { get; set; }

        public string Department { get; set; }

        public DatetimeRange StartDate { get; set; }
    }
}
