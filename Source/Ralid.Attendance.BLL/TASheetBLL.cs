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
    public class TASheetBLL
    {
        #region 构造函数
        public TASheetBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<TASheet> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<ITASheetProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Save(TASheetGroup info)
        {
            TASheetSearchCondition con = new TASheetSearchCondition();
            con.SheetID = info.SheetID;
            ITASheetProvider provider = ProviderFactory.Create<ITASheetProvider>(_RepoUri);
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            List<TASheet> items = provider.GetItems(con).QueryObjects;
            foreach (TASheet item in items)
            {
                provider.Delete(item, unitWork);
            }
            List<TASheet> sheets = TASheetGroup.UnGroup(info);
            foreach (TASheet sheet in sheets)
            {
                provider.Insert(sheet, unitWork);
            }
            return unitWork.Commit();
        }

        public CommandResult Add(TASheet info)
        {
            return ProviderFactory.Create<ITASheetProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(TASheet info)
        {
            TASheet original = ProviderFactory.Create<ITASheetProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<ITASheetProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(TASheet info)
        {
            return ProviderFactory.Create<ITASheetProvider>(_RepoUri).Delete(info);
        }

        public CommandResult Delete(TASheetGroup info)
        {
            TASheetSearchCondition con = new TASheetSearchCondition();
            con.SheetID = info.SheetID;
            ITASheetProvider provider = ProviderFactory.Create<ITASheetProvider>(_RepoUri);
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            List<TASheet> items = provider.GetItems(con).QueryObjects;
            foreach (TASheet item in items)
            {
                provider.Delete(item, unitWork);
            }
            return unitWork.Commit();
        }
        #endregion
    }
}