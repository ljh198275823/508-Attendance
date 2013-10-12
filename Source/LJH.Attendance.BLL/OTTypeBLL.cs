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
    public class OTTypeBLL
    {
        #region 构造函数
        public OTTypeBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<OTType> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IOTTypeProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(OTType info)
        {
            return ProviderFactory.Create<IOTTypeProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(OTType info)
        {
            OTType original = ProviderFactory.Create<IOTTypeProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IOTTypeProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(OTType info)
        {
            return ProviderFactory.Create<IOTTypeProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}