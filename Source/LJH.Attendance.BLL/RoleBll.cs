using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.BLL
{
    public class RoleBll
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="repoUri">存储层的资源标识(可以是数据库连接字符串或文件名等，根据存储层的不同可以设置不同的值)</param>
        public RoleBll(string repoUri)
        {
            _RepoUri = repoUri;
            provider = ProviderFactory.Create<IRoleProvider>(repoUri);
        }
        #endregion

        #region 私有变量
        private IRoleProvider provider;
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResult<Role> GetRoleInfoByID(string roleID)
        {
            return provider.GetByID(roleID);
        }

        public QueryResultList<Role> GetAllRoles()
        {
            return provider.GetItems(null);
        }

        public CommandResult Add(Role info)
        {
            return ProviderFactory.Create<IRoleProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(Role newVal)
        {
            Role original = GetRoleInfoByID(newVal.ID).QueryObject;
            if (original != null)
            {
                return provider.Update(newVal, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(Role info)
        {
            if (!info.CanDelete)
            {
                return new CommandResult(ResultCode.Fail, string.Format(Resource1.RoleBll_CannotDelete, info.Name));
            }
            else
            {
                OperatorBll bll = new OperatorBll(_RepoUri);
                QueryResultList<Operator> result = bll.GetAllOperators();
                if (result.Result == ResultCode.Successful && result.QueryObjects.Exists(opt => opt.RoleID == info.ID))
                {
                    return new CommandResult(ResultCode.Fail, string.Format(Resource1.RoleBll_RoleBeUsed, info.ID, info.ID));
                }
            }
            return provider.Delete(info);
        }
        #endregion
    }
}
