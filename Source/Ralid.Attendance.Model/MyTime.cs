using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示时间,时分秒
    /// </summary>
    public class MyTime
    {
        #region 构造函数
        public MyTime()
        {
        }

        public MyTime(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置小时数
        /// </summary>
        public int Hour { get; set; }
        /// <summary>
        /// 获取或设置分钟数
        /// </summary>
        public int Minute { get; set; }
        /// <summary>
        /// 获取或设置秒数
        /// </summary>
        public int Second { get; set; }
        #endregion

        #region 重写基类方法
        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
        }
        /// <summary>
        /// 显示短字符串格式，时分秒都用两位表示，中间没有分隔符，如120302
        /// </summary>
        /// <returns></returns>
        public String ToShortString()
        {
            return string.Format("{0:D2}{1:D2}{2:D2}", Hour, Minute, Second);
        }
        #endregion
    }
}
