using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Ralid.Attendance.Model
{
    public class Holiday
    {
        #region 构造函数
        public Holiday()
        {
        }
        #endregion

        #region 公共属性
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置节假日的开始日期
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 获取或设置节假日的结束日期
        /// </summary>
        public DateTime EndDate { get; set; }

        public DateTime? WeekendToWorkDay1 { get; set; }

        public DateTime? WeekendToWorkDay2 { get; set; }

        public DateTime? WeekendToWorkDay3 { get; set; }

        public DateTime? WeekendToWorkDay4 { get; set; }

        public DateTime? WeekendToWorkDay5 { get; set; }

        public DateTime? WeekendToWorkDay6 { get; set; }

        /// <summary>
        /// 获取或设置备注信息
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 获取为此节假日调整的周末转工作日
        /// </summary>
        public List<DateTime> WeekendToWorkDays
        {
            get
            {
                List<DateTime> items = new List<DateTime>();
                if (WeekendToWorkDay1 != null) items.Add(WeekendToWorkDay1.Value);
                if (WeekendToWorkDay2 != null) items.Add(WeekendToWorkDay2.Value);
                if (WeekendToWorkDay3 != null) items.Add(WeekendToWorkDay3.Value);
                if (WeekendToWorkDay4 != null) items.Add(WeekendToWorkDay4.Value);
                if (WeekendToWorkDay5 != null) items.Add(WeekendToWorkDay5.Value);
                if (WeekendToWorkDay6 != null) items.Add(WeekendToWorkDay6.Value);
                return items;
            }
        }
        #endregion

        #region 公共方法
        public string GetWeekendToWorkDayString(string split)
        {
            List<DateTime> items = WeekendToWorkDays;
            if (items != null && items.Count > 0)
            {
                string temp = string.Empty;
                for (int i = 0; i < items.Count; i++)
                {
                    if (i > 0)
                    {
                        temp += split;
                    }
                    temp += items[i].ToLongDateString();
                }
                return temp;
            }
            return null;
        }
        #endregion
    }
}
