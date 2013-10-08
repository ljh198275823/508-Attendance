using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示班次的类
    /// </summary>
    public class Shift
    {
        #region 构造函数
        public Shift()
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
        /// 获取或设置简称
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 获取或设置班次时段列表
        /// </summary>
        public List<ShiftItem> Items { get; set; }
        #endregion
    }
}
