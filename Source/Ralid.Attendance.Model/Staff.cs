using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class Staff
    {
        #region 构造函数
        public Staff()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置人员在门禁中的部门ID
        /// </summary>
        public string ACSDepartmentID { get; set; }
        /// <summary>
        /// 获取或设置人员在考勤系统中的部门ID
        /// </summary>
        public string DepartmentID { get; set; }
        /// <summary>
        /// 获取或设置员工是否已经离职
        /// </summary>
        public bool Resigned { get; set; }
        /// <summary>
        /// 获取或设置人员职位
        /// </summary>
        public string UserPosition { get; set; }
        /// <summary>
        /// 获取或设置人员的备注信息
        /// </summary>
        public string Memo { get; set; }
        #endregion

        #region 公共方法
        public Staff Clone()
        {
            return this.MemberwiseClone() as Staff;
        }
        #endregion
    }
}