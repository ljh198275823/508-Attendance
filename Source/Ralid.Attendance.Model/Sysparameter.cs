using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class Sysparameter
    {
        #region 构造函数
        public Sysparameter()
        {
        }
        #endregion

        #region 公共属性
        public string ID { get; set; }

        public string Value { get; set; }

        public string DefaultValue { get; set; }

        public string Memo { get; set; }
        #endregion

        #region 公共方法
        public Sysparameter Clone()
        {
            return this.MemberwiseClone() as Sysparameter;
        }
        #endregion
    }
}
