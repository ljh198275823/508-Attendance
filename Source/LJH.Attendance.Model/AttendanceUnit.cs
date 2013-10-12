using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示考勤用的一些单位
    /// </summary>
    public enum AttendanceUnit
    {
        /// <summary>
        /// 小时
        /// </summary>
        Hour = 0,
        /// <summary>
        /// 分钟
        /// </summary>
        Minute = 1,
        /// <summary>
        /// 工作日
        /// </summary>
        WorkDay = 2,
    }

    public class AttendanceUnitDescription
    {
        public static String GetDescription(AttendanceUnit unit)
        {
            switch (unit)
            {
                case AttendanceUnit.Hour:
                    return "小时";
                case AttendanceUnit.Minute:
                    return "分";
                case AttendanceUnit.WorkDay:
                    return "工作日";
                default:
                    return string.Empty;
            }
        }
    }
}
