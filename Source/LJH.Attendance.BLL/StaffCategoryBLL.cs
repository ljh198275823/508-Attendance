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
    public class StaffCategoryBLL
    {
        #region 构造函数
        public StaffCategoryBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<StaffCategory> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IStaffCategoryProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(StaffCategory info)
        {
            return ProviderFactory.Create<IStaffCategoryProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(StaffCategory info)
        {
            StaffCategory original = ProviderFactory.Create<IStaffCategoryProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IStaffCategoryProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(StaffCategory info)
        {
            return ProviderFactory.Create<IStaffCategoryProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}
