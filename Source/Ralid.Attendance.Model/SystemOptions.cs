using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class SystemOptions
    {
        #region 静态属性
        public static SystemOptions Current { get; set; }
        #endregion

        #region 构造函数
        public SystemOptions()
        {
            UsingACSDept = true;
        }
        #endregion

        #region 公共属性
        public bool UsingACSDept { get; set; }
        #endregion
    }
}
