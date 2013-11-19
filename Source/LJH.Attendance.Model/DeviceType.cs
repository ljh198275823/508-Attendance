using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示门禁考勤设备类型的枚举
    /// </summary>
    public enum DeviceType
    {
        /// <summary>
        /// 中控考勤门禁机
        /// </summary>
        ZKAttendanceMachine=0,
        /// <summary>
        /// 中控iface指纹门禁系列
        /// </summary>
        ZKIFace=1,
        /// <summary>
        /// 致远IPC系统门禁控制器
        /// </summary>
        IPC=2,
    }
}
