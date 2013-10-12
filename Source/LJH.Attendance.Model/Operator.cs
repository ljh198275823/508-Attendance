using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using LJH.GeneralLibrary.SoftDog;
using LJH.GeneralLibrary.ExceptionHandling;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 操作员
    /// </summary>
    [Serializable()]
    [DataContract]
    public class Operator
    {
        #region 静态变量
        private static Operator currentOperator;
        /// <summary>
        /// 获取或设置当前的操作员
        /// </summary>
        public static Operator CurrentOperator
        {
            get { return currentOperator; }
            set { currentOperator = value; }
        }
        #endregion

        #region 构造函数
        public Operator()
        {

        }
        #endregion

        #region 私有变量
        [DataMember]
        private string _Password;
        #endregion

        #region 公共属性
        /// <summary>
        /// 操作员登录名
        /// </summary>
        [DataMember]
        public string ID { get; set; }
        /// <summary>
        /// 操作员名
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 操作员登录密码
        /// </summary>
        public string Password
        {
            get
            {
                if (_Password.Length > 14)
                {
                    return (new DTEncrypt()).DSEncrypt(_Password);
                }
                else
                {
                    return _Password;
                }
            }
            set
            {
                _Password = (new DTEncrypt()).Encrypt(value);
            }
        }
        /// <summary>
        /// 操作员角色ID
        /// </summary>
        [DataMember]
        public string RoleID { get; set; }
        /// <summary>
        /// 操作员角色
        /// </summary>
        [DataMember]
        public Role Role { get; set; }
        /// <summary>
        ///获取或设置用户ID
        /// </summary>
        public int StaffID { get; set; }
        /// <summary>
        /// 获取或设置操作员能看到或操作的部门
        /// </summary>
        public List<string> Depts { get; set; }
        #endregion

        #region 只读属性
        public bool IsAdmin
        {
            get
            {
                return (ID.ToUpper() == "ADMIN");
            }
        }

        /// <summary>
        /// 查看此操作员是否被授予此权限
        /// </summary>
        public bool Permit(Permission right)
        {
            if (this.Role != null)
            {
                return Role.Permit(right);
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}