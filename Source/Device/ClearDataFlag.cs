using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Device
{
    [Flags]
    public enum ClearDataFlag
    {
        /// <summary>
        /// 全部
        /// </summary>
        None = 0,
        /// <summary>
        /// 考勤记录/刷卡记录
        /// </summary>
        AttendanceLog = 0x01,
        /// <summary>
        /// 指纹模板
        /// </summary>
        FPTemplate = 0x02,
        /// <summary>
        /// 操作记录
        /// </summary>
        OperatorLog = 0x04,
        /// <summary>
        /// 用户信息
        /// </summary>
        UserInfo = 0x08,
        /// <summary>
        /// 全部
        /// </summary>
        All = 0xFFFF,
    }
}
