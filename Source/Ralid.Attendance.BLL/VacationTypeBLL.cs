using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.BLL
{
    public class VacationTypeBLL
    {
        #region 构造函数
        public VacationTypeBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<VacationType> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IVacationTypeProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(VacationType info)
        {
            return ProviderFactory.Create<IVacationTypeProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(VacationType info)
        {
            VacationType original = ProviderFactory.Create<IVacationTypeProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IVacationTypeProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(VacationType info)
        {
            return ProviderFactory.Create<IVacationTypeProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}