using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class HolidaySetting
    {
        /// <summary>
        /// 获取或设置系统当前的节假日选项
        /// </summary>
        public static HolidaySetting Current { get; set; }

        /// <summary>
        /// 获取节假日列表
        /// </summary>
        public List<Holiday> Holidays { get; set; }
        /// <summary>
        /// 判断日期是否节假日
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsHoliday(DateTime dt)
        {
            bool ret = false;
            if (Holidays != null && Holidays.Count > 0)
            {
                foreach (Holiday holiday in Holidays)
                {
                    if (holiday.StartDate <= dt && holiday.EndDate >= dt)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }
        /// <summary>
        /// 判断日期是否是周未（一般是指周六日，但由法定节假日调整为工作日的周末不计在内)
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsWeekend(DateTime dt)
        {
            if (IsHoliday(dt)) return true;
            if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday) //如果是周末,则只要周末不在节假日调整后的工作日内就当成是周末
            {
                if (Holidays != null && Holidays.Count > 0)
                {
                    foreach (Holiday holiday in Holidays)
                    {
                        List<DateTime> items = holiday.WeekendToWorkDays;
                        if (items != null && items.Count > 0)
                        {
                            foreach (DateTime item in items)
                            {
                                if (item.Date == dt.Date) return false;
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
