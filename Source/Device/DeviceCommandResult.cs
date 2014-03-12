using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Device
{
    public class DeviceCommandResult
    {
        #region 构造函数
        public DeviceCommandResult ()
        {
        }
        #endregion

        #region 公共属性
        public int ResultCode { get; set; }

        public int Result { get; set; }
        #endregion
    }
}
