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
    public class TripTypeBLL
    {
        #region 构造函数
        public TripTypeBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<TripType> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<ITripTypeProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(TripType info)
        {
            return ProviderFactory.Create<ITripTypeProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(TripType info)
        {
            TripType original = ProviderFactory.Create<ITripTypeProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<ITripTypeProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(TripType info)
        {
            return ProviderFactory.Create<ITripTypeProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}