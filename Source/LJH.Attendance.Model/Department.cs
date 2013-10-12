using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    public class Department
    {
        #region 构造函数
        public Department()
        {
            TopDeptID = string.Empty;
            DeptLevel = 0;
        }
        #endregion

        #region 私有变量
        #region 这两个字段软件用不到，但由于数据库中有这两个字段，所以暂时加在这里。
        private string TopDeptID { get; set; }

        private bool? IsBottom { get; set; }

        private int DeptLevel { get; set; }
        #endregion
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置父ID
        /// </summary>
        public string ParentID { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion
    }
}
