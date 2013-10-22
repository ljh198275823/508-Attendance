using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    public class TASheetItem
    {
        #region 构造函数
        public TASheetItem()
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
        public Guid SheetID { get; set; }
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
        /// 获取或设置结束时间是否在第二天
        /// </summary>
        public bool NextDay { get; set; }
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
        /// 获取或设置班次的出勤分钟数
        /// </summary>
        public decimal Duration { get; set; }
        #endregion
    }
}
