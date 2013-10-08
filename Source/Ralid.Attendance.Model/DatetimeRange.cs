using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示一段时间间隔
    /// </summary>
    public class DatetimeRange
    {
        #region 构造函数
        public DatetimeRange()
        {
        }

        public DatetimeRange(DateTime begin, DateTime end)
        {
            Begin = begin;
            End = end;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 或取或设置开始时间
        /// </summary>
        public DateTime Begin { get; set; }

        /// <summary>
        /// 获取或设置结束时间
        /// </summary>
        public DateTime End { get; set; }

        #endregion

        #region 公共方法
        /// <summary>
        /// 判断某个时间点是否在时间段内
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Contain(DateTime dt)
        {
            bool ret = false;
            if (dt >= Begin && dt <= End)
            {
                ret = true;
            }
            return ret;
        }
        /// <summary>
        /// 判断时间段是否完全包含时间段
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public bool Contain(DatetimeRange dr)
        {
            return this.Contain(dr.Begin) && this.Contain(dr.End);
        }
        /// <summary>
        /// 判断时间段是否完全包含由开始时间和结束时间表示的时间段
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public bool Contain(DateTime begin, DateTime end)
        {
            return this.Contain(begin) && this.Contain(end);
        }
        #endregion
    }
}
