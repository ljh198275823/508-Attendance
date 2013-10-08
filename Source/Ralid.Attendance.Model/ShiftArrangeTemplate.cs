﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance .Model ;

namespace Ralid.Attendance.Model
{
    public class ShiftArrangeTemplate
    {
        #region 构造函数
        public ShiftArrangeTemplate()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置模板名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置排班选项
        /// </summary>
        public TemplateOptions Options { get; set; }
        /// <summary>
        /// 获取或设置模板的班次列表
        /// </summary>
        public List<TemplateItem> Items { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion

        #region 公共方法
        public List<ShiftArrange> ApplyTemplateTo(Staff staff, DatetimeRange range)
        {
            if (Items.Exists(it => it.Duration <= 0)) return null; //如果存在某个班次持续时间小于0,直接退出
            List<ShiftArrange> sas = new List<ShiftArrange>();
            if (this.Items != null && this.Items.Count > 0)
            {
                DateTime dt = range.Begin;
                while (dt <= range.End)
                {
                    foreach (TemplateItem item in Items)
                    {
                        int duration = 1;
                        while (duration <= item.Duration)
                        {
                            if (HolidaySetting.Current != null &&
                                HolidaySetting.Current.IsHoliday(dt) &&
                                (this.Options & TemplateOptions.HolidayShifted) == 0) //节假日不排班
                            {
                                dt = dt.AddDays(1);
                            }
                            else if (HolidaySetting.Current != null &&
                                HolidaySetting.Current.IsWeekend(dt) &&
                                (this.Options & TemplateOptions.WeekendShifted) == 0)//周末不排班
                            {
                                dt = dt.AddDays(1);
                            }
                            else
                            {
                                duration++;
                                if (item.Shifts != null && item.Shifts.Count > 0)
                                {
                                    foreach (Shift shift in item.Shifts)
                                    {
                                        ShiftArrange sa = new ShiftArrange();
                                        sa.StaffID = staff.ID;
                                        sa.ShiftDate = dt;
                                        sa.ShiftID = shift.ID;
                                        sa.Shift = shift;
                                        sas.Add(sa);
                                    }
                                }
                                dt = dt.AddDays(1);
                            }
                            if (dt > range.End) return sas;
                        }
                        for (int i = 1; i <= item.RestDays; i++)
                        {
                            dt = dt.AddDays(1);
                            if (dt > range.End) return sas;
                        }
                    }
                }
            }
            return sas;
        }
        #endregion
    }

    public class TemplateItem
    {
        #region 构造函数
        public TemplateItem()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置班次
        /// </summary>
        public List<Shift> Shifts { get; set; }
        /// <summary>
        /// 获取或设置班次持续的次数
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// 获取或设置班次过后休息的天数
        /// </summary>
        public int RestDays { get; set; }
        #endregion
    }

    /// <summary>
    /// 表示排班模板选项
    /// </summary>
    [Flags]
    public enum TemplateOptions
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,
        /// <summary>
        /// 节假日排班
        /// </summary>
        HolidayShifted = 1,
        /// <summary>
        /// 周末排班
        /// </summary>
        WeekendShifted = 2
    }
}
