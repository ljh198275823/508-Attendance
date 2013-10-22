using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    public class ShiftArrangeID
    {
        #region 构造函数
        public ShiftArrangeID()
        {
        }

        public ShiftArrangeID(string staffID, string shiftID, DateTime shiftDate)
        {
            this.StaffID = staffID;
            this.ShiftID = shiftID;
            this.ShiftDate = shiftDate;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置人员ID
        /// </summary>
        public string StaffID { get; set; }
        /// <summary>
        /// 获取或设置班次ID
        /// </summary>
        public string ShiftID { get; set; }
        /// <summary>
        /// 获取或设置排班日期
        /// </summary>
        public DateTime ShiftDate { get; set; }
        #endregion
    }
}
