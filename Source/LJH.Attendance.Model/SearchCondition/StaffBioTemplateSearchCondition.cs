using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model.SearchCondition
{
    public class StaffBioTemplateSearchCondition : SearchCondition
    {
        public int? StaffID { get; set; }

        public string Version { get; set; }

        public List<int> Staff { get; set; }
    }
}
