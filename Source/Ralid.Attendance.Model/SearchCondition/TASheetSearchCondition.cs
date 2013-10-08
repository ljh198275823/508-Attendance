using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model.SearchCondition
{
    public class TASheetSearchCondition : SearchCondition
    {
        public Guid? SheetID { get; set; }

        public int? StaffID { get; set; }

        public string SheetType { get; set; }

        public string Department { get; set; }

        public DatetimeRange StartDate { get; set; }
    }
}
