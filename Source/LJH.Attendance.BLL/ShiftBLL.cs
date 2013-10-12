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

        #region 私有方法
        private string CreateShiftID()
        {
            List<Shift> shifts = ProviderFactory.Create<IShiftProvider>(_RepoUri).GetItems(null).QueryObjects;
            for (int i = 1; i < 10000; i++) //shiftID为四位
            {
                if (!shifts.Exists(item => item.ID == i.ToString("D4"))) return i.ToString("D4");
            }
            return null;
        }
        #endregion

        #region 公共方法
        public QueryResultList<Shift> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IShiftProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(Shift info)
        {
            string shiftID = CreateShiftID();
            if (!string.IsNullOrEmpty(shiftID))
            {
                info.ID = shiftID;
                if (info.Items != null && info.Items.Count > 0) info.Items.ForEach(item => item.ShiftID = shiftID);
                return ProviderFactory.Create<IShiftProvider>(_RepoUri).Insert(info);
            }
            else
            {
                return new CommandResult(ResultCode.Fail, "创建班次ID失败");
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