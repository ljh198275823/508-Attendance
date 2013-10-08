using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class Parameter
    {
        #region 构造函数
        public Parameter()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置参数ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置参数值
        /// </summary>
        public string Value { get; set; }
        #endregion
    }
}
