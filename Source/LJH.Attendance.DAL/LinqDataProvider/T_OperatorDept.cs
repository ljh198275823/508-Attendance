using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    internal class T_OperatorDept
    {
        #region 构造函数
        public T_OperatorDept()
        {
        }
        #endregion

        #region 公共属性
        public string OperatorID { get; set; }

        public string DepartmentID { get; set; }
        #endregion
    }
}
