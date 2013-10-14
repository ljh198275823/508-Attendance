using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示门禁刷卡器
    /// </summary>
    public class Reader
    {
        #region 构造函数
        public Reader()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置是否用于考勤
        /// </summary>
        public bool ForAttendance { get; set; }
        #endregion
    }
}
