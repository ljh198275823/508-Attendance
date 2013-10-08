using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    internal class T_ShiftArrange
    {
        #region 构造函数
        public T_ShiftArrange()
        {
        }

        public T_ShiftArrange (Ralid.Attendance .Model .ShiftArrange sa)
        {
            this.StaffID = sa.StaffID;
            this.ShiftID = sa.ShiftID;
            this.ShiftDate = sa.ShiftDate.ToString("yyyyMMdd");
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置人员ID
        /// </summary>
        public int StaffID { get; set; }
        /// <summary>
        /// 获取或设置班次ID
        /// </summary>
        public string ShiftID { get; set; }
        /// <summary>
        /// 获取或设置排班日期
        /// </summary>
        public string ShiftDate { get; set; }
        #endregion
    }
}
