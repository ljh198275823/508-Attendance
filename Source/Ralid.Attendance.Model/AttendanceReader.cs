using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示考勤打卡点
    /// </summary>
    public class AttendanceReader
    {
        #region 构造函数
        public AttendanceReader()
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
        #endregion
    }
}
