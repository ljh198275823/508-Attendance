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
    public class StaffBLL
    {
        #region 构造函数
        public StaffBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<Staff> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IStaffProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(Staff info)
        {
            return ProviderFactory.Create<IStaffProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(Staff info)
        {
            Staff original = ProviderFactory.Create<IStaffProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IStaffProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(Staff info)
        {
            return ProviderFactory.Create<IStaffProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}

