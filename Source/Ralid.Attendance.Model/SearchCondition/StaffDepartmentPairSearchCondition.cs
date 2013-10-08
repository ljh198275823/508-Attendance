using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model.SearchCondition
{
    public class StaffDepartmentPairSearchCondition:SearchCondition 
    {
        #region 公共方法
        public int? StaffID { get; set; }

        public string DepartmentID { get; set; }
        #endregion
    }
}
