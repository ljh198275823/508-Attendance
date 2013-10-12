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
    public class HolidayBLL
    {
        #region 构造函数
        public HolidayBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<Holiday> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IHolidayProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(Holiday info)
        {
            return ProviderFactory.Create<IHolidayProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(Holiday info)
        {
            Holiday original = ProviderFactory.Create<IHolidayProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IHolidayProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(Holiday info)
        {
            return ProviderFactory.Create<IHolidayProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}