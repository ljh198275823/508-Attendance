using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示门禁考勤设备通讯方式的枚举
    /// </summary>
    public enum CommunicationType
    {
        /// <summary>
        /// tcp/ip
        /// </summary>
        TCP_IP=0,
        /// <summary>
        /// rs232/485
        /// </summary>
        RS232_485=1,
        /// <summary>
        /// usb
        /// </summary>
        USB=2
    }
}
