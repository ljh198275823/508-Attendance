using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 考勤结果枚举
    /// </summary>
    public enum AttendanceResultCode
    {
        /// <summary>
        /// 缺勤
        /// </summary>
        Absent = 0,
        /// <summary>
        /// 正常
        /// </summary>
        OK = 1,
        /// <summary>
        /// 迟到
        /// </summary>
        Late = 2,
        /// <summary>
        /// 早退
        /// </summary>
        LeaveEarly = 3,
        /// <summary>
        /// 迟到早退
        /// </summary>
        LateEarly = 4,
    }

    public class AttendanceResultDescription
    {
        public static string GetDescription(AttendanceResultCode ret)
        {
            switch (ret)
            {
                case AttendanceResultCode.Absent:
                    return "缺勤";
                case AttendanceResultCode.OK:
                    return "正常";
                case AttendanceResultCode.Late:
                    return "迟到";
                case AttendanceResultCode.LeaveEarly:
                    return "早退";
                case AttendanceResultCode.LateEarly:
                    return "迟到早退";
                default:
                    return "--";
            }
        }

        public static string GetDescription(string ret)
        {
            if (ret == AttendanceResultCode.Absent.ToString())
            {
                return "缺勤";
            }
            else if (ret == AttendanceResultCode.OK.ToString())
            {
                return "正常";
            }
            else if (ret == AttendanceResultCode.Late.ToString())
            {
                return "迟到";
            }
            else if (ret == AttendanceResultCode.LeaveEarly.ToString())
            {
                return "早退";
            }
            else if (ret == AttendanceResultCode.LateEarly.ToString())
            {
                return "迟到早退";
            }
            else
            {
                return "--";
            }
        }
    }
}
