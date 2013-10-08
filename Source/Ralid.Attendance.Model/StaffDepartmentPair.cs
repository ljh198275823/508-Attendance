using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class StaffDepartmentPair
    {
        #region 构造函数
        public StaffDepartmentPair()
        {
        }
        #endregion

        #region 公共方法
        public int StaffID { get; set; }

        public string DepartmentID { get; set; }
        #endregion
    }
}
