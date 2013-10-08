using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示人员某天的排班
    /// </summary>
    public class ShiftArrange
    {
        #region 构造函数
        public ShiftArrange()
        {
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
        /// 获取或设置班次信息
        /// </summary>
        public Shift Shift { get; set; }
        /// <summary>
        /// 获取或设置排班日期
        /// </summary>
        public DateTime ShiftDate { get; set; }
        #endregion
    }
}
