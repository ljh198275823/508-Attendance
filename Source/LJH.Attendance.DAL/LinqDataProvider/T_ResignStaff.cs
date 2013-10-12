using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    /// <summary>
    /// 表示离职员工
    /// </summary>
    internal class T_ResignStaff
    {
        #region 构造函数
        public T_ResignStaff()
        {
        }
        #endregion

        #region 公共属性
        public int StaffID { get; set; }
        #endregion
    }
}
