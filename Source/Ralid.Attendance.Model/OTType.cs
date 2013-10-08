using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class OTType
    {
        #region 构造函数
        public OTType()
        {
        }
        #endregion

        #region 公共属性
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置加班的工资倍数
        /// </summary>
        public decimal Multiple { get; set; }
        /// <summary>
        ///获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion
    }
}
