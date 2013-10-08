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

        #region 私有变量
        private string _StartTime;
        private string _EndTime;
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
        public int AllowLate { get; set; }
        /// <summary>
        /// 获取或设置允许的最大提前刷卡分钟数，即上班前提前多少分钟打卡则记为已上班
        /// </summary>
        public int BeforeStartTime { get; set; }
        /// <summary>
        /// 获取或设置允许在上班时间多少分钟后刷卡，超过这个时间的打卡记录忽略
        /// </summary>
        public int AfterStartTime { get; set; }
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
        public int AllowEarly { get; set; }
        /// <summary>
        /// 下班时间提前多久的打卡开始有效，早于此时间的打卡忽略
        /// </summary>
        public int BeforeEndTime { get; set; }
        /// <summary>
        /// 获取或设置最大的延长刷卡分钟，即下班时间过了多少分钟后打卡仍算正常下班
        /// </summary>
        public int AfterEndTime { get; set; }
        /// <summary>
        /// 获取或设置班次的出勤分钟数
        /// </summary>
        public int ShiftDuration { get; set; }
        /// <summary>
        /// 获取或设置是否允许加班
        /// </summary>
        public bool AllowOT { get; set; }
        /// <summary>
        /// 获取或设置最小加班分钟数
        /// </summary>
        public int MinOTTime { get; set; }
        /// <summary>
        /// 获取或设置最大加班分钟数
        /// </summary>
        public int MaxOTTime { get; set; }
        #endregion
    }
}
