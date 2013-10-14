using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LJH.Attendance.Model
{
    [Serializable()]
    public class Role
    {
        #region 私有变量
        private readonly string Admin = "SysAdmin"; //系统管理员
        private List<Permission> _rights;
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置角色ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置角色名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置权限
        /// </summary>
        public string Permission { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion

        #region 只读属性
        /// <summary>
        /// 是否可以删除,系统默认的角色(系统管理员,卡片操作员,进出口操作员)不能删除
        /// </summary>
        public bool CanDelete
        {
            get
            {
                return !IsAdmin;
            }
        }

        /// <summary>
        /// 是否可以编辑,系统默认的角色(系统管理员)不能编辑
        /// </summary>
        public bool CanEdit
        {
            get
            {
                return !IsAdmin;
            }
        }
        /// <summary>
        /// 是否是系统管理员
        /// </summary>
        public bool IsAdmin
        {
            get { return ID.ToUpper() == Admin.ToUpper(); }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 查看此角色是否被授予此权限
        /// </summary>
        public bool Permit(Permission right)
        {
            if (Permission == "all" || IsAdmin)
            {
                return true;
            }
            else
            {
                if (_rights == null)
                {
                    _rights = new List<Permission>();
                    if (!string.IsNullOrEmpty(Permission))
                    {
                        foreach (string str in Permission.Split(','))
                        {
                            int i;
                            if (int.TryParse(str, out i))
                            {
                                _rights.Add((Permission)i);
                            }
                        }
                    }
                }
                return _rights.Exists(r => r == right);
            }
        }
        #endregion

    }
}
