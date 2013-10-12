using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示缺勤项
    /// </summary>
    public class AbsentItem
    {
        #region 构造函数
        public AbsentItem()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 考勤结果的ID
        /// </summary>
        public Guid ResultID { get; set; }
        /// <summary>
        /// 获取或设置缺勤类别
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 获取或设置缺勤时间
        /// </summary>
        public decimal Duration { get; set; }
        #endregion
    }
}
