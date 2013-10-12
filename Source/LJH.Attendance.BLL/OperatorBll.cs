using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.BLL
{
    public class OperatorBll
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="repoUri">存储层的资源标识(可以是数据库连接字符串或文件名等，根据存储层的不同可以设置不同的值)</param>
        public OperatorBll(string repoUri)
        {
            provider = ProviderFactory.Create<IOperatorProvider>(repoUri);
        }
        #endregion

        #region 私有变量
        private IOperatorProvider provider;
        #endregion

        #region 公共方法
        /// <summary>
        /// 登录验证
        /// </summary>
        public bool Authentication(string logName, string pwd)
        {
            Operator info = GetByID(logName).QueryObject;
            if (info != null)
            {
                if (info.ID.ToUpper() == logName.ToUpper() && info.Password.ToUpper() == pwd.ToUpper())
                {
                    Operator.CurrentOperator = info;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据操作员ID获取操作员
        /// </summary>
        /// <param name="optID"></param>
        /// <returns></returns>
        public QueryResult<Operator> GetByID(string optID)
        {
            return provider.GetByID(optID);
        }
        /// <summary>
        /// 获取所有操作员
        /// </summary>
        /// <returns></returns>
        public QueryResultList<Operator> GetAllOperators()
        {
            return provider.GetItems(null);
        }
        /// <summary>
        /// 增加操作员,如果操作员编号已被使用,抛出InvalidOperationException
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommandResult Insert(Operator info)
        {
            List<Operator> allOpt = GetAllOperators().QueryObjects;
            if (allOpt.Exists(opt => opt.ID == info.ID))
            {
                throw new InvalidOperationException(string.Format(Resource1.OperatorBll_IDbeUsed, info.ID));
            }
            if (allOpt.Exists(opt => opt.Name == info.Name))
            {
                throw new InvalidOperationException(string.Format(Resource1.OperatorBll_NamebeUsed, info.Name));
            }
            CommandResult ret = provider.Insert(info);
            return ret;
        }
        /// <summary>
        /// 修改操作员,如果操作员编号已被使用,抛出InvalidOperationException
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public CommandResult Update(Operator info)
        {
            List<Operator> allOpt = GetAllOperators().QueryObjects;
            if (allOpt.Exists(opt => opt.ID != info.ID && opt.Name == info.Name))
            {
                throw new InvalidOperationException(string.Format(Resource1.OperatorBll_NamebeUsed, info.Name));
            }
            Operator original = GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return provider.Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }
        /// <summary>
        /// 删除操作员
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref=" "></exception>
        public CommandResult Delete(Operator info)
        {
            if (info.IsAdmin)
            {
                return new CommandResult(ResultCode.Fail, string.Format(Resource1.OperatorBll_CannotDelete, info.ID));
            }
            return provider.Delete(info);
        }
        #endregion
    }
}
