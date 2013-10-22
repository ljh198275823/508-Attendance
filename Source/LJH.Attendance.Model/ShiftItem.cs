using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示班次的时段项
    /// </summary>
    public class ShiftItem
    {
        #region 构造函数
        public ShiftItem()
        {
        }
        #endregion

        #region 私有变量
        private string _StartTime;
        private string _EndTime;
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string ShiftID { get; set; }
        /// <summary>
        /// 获取或设置上班时间
        /// </summary>
        public MyTime StartTime
        {
            get
            {
                if (_StartTime != null && _StartTime.Length == 6)
                {
                    int hour = 0;
                    int minute = 0;
                    int second = 0;
                    if (int.TryParse(_StartTime.Substring(0, 2), out hour) &&
                        int.TryParse(_StartTime.Substring(2, 2), out minute) &&
                        int.TryParse(_StartTime.Substring(4, 2), out second))
                    {
                        return new MyTime(hour, minute, second);
                    }
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    _StartTime = null;
                }
                else
                {
                    _StartTime = value.ToShortString();
                }
            }
        }
        /// <summary>
        /// 获取或设置允许迟到分钟数（即迟到时间小于这个数时不记录为迟到）
        /// </summary>
        public decimal AllowLateTime { get; set; }
        /// <summary>
        /// 获取或设置允许的最大提前刷卡分钟数，即上班前提前多少分钟打卡则记为已上班
        /// </summary>
        public decimal BeforeStartTime { get; set; }
        /// <summary>
        /// 获取或设置下班时间
        /// </summary>
        public MyTime EndTime
        {
            get
            {
                if (_EndTime != null && _EndTime.Length == 6)
                {
                    int hour = 0;
                    int minute = 0;
                    int second = 0;
                    if (int.TryParse(_EndTime.Substring(0, 2), out hour) &&
                        int.TryParse(_EndTime.Substring(2, 2), out minute) &&
                        int.TryParse(_EndTime.Substring(4, 2), out second))
                    {
                        return new MyTime(hour, minute, second);
                    }
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    _EndTime = null;
                }
                else
                {
                    _EndTime = value.ToShortString();
                }
            }
        }
        /// <summary>
        /// 获取或设置下班时间是否在第二天
        /// </summary>
        public bool NextDay { get; set; }
        /// <summary>
        /// 获取或设置允许的早退分钟数，（即提前下班时间小于这个数时不记为早退）
        /// </summary>
        public decimal AllowLeaveEarlyTime { get; set; }
        /// <summary>
        /// 获取或设置最大的延长刷卡分钟，即下班时间过了多少分钟后打卡仍算正常下班
        /// </summary>
        public decimal AfterEndTime { get; set; }
        /// <summary>
        /// 获取或设置班次的出勤分钟数
        /// </summary>
        public decimal Duration { get; set; }
        #endregion
    }
}
