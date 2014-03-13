using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
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
        /// 获取或设置人员在考勤系统中的部门ID
        /// </summary>
        public string DepartmentID { get; set; }
        /// <summary>
        /// 获取或设置部门
        /// </summary>
        public Department Department { get; set; }
        /// <summary>
        /// 获取或设置
        /// </summary>
        public string CardID { get; set; }
        /// <summary>
        /// 获取或设置密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 获取或设置是否是管理员(考勤机相关)
        /// </summary>
        public bool? IsAdmin { get; set; }
        /// <summary>
        /// 获取或设置员工姓别 1表示男，2表示女
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 获取或设置员工的生日
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 获取或设置人员编号
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// 获取或设置人员职位
        /// </summary>
        public string UserPosition { get; set; }
        /// <summary>
        /// 获取或设置入职日期
        /// </summary>
        public DateTime HireDate { get; set; }
        /// <summary>
        /// 获取或设置员工是否已经离职
        /// </summary>
        public bool Resigned { get; set; }
        /// <summary>
        /// 或取或设置离职日期
        /// </summary>
        public DateTime? ResignDate { get; set; }
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