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
    public class ShiftBLL
    {
        #region 构造函数
        public ShiftBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<Shift> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IShiftProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(Shift info)
        {
            string id = ProviderFactory.Create<IStringIDCreater>(_RepoUri).CreateID("S", 3, "Shift");
            if (!string.IsNullOrEmpty(id))
            {
                info.ID = id;
                if (info.Items != null && info.Items.Count > 0) info.Items.ForEach(item => item.ShiftID = id);
                return ProviderFactory.Create<IShiftProvider>(_RepoUri).Insert(info);
            }
            else
            {
                return new CommandResult(ResultCode.Fail, "创建ID失败");
            }
        }

        public CommandResult Update(Shift info)
        {
            Shift original = ProviderFactory.Create<IShiftProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                if (info.Items != null && info.Items.Count > 0) info.Items.ForEach(item => item.ShiftID = info.ID);
                return ProviderFactory.Create<IShiftProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(Shift info)
        {
            return ProviderFactory.Create<IShiftProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}