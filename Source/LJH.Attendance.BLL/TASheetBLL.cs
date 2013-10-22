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
                provider.Delete(item);
            }
            List<TASheet> sheets = TASheetGroup.UnGroup(info);
            foreach (TASheet sheet in sheets)
            {
                sheet.ID = Guid.NewGuid();
                provider.Insert(sheet, unitWork);
                if (sheet.Items != null && sheet.Items.Count > 0) sheet.Items.ForEach(it => it.ID = Guid.NewGuid());
            }
            return unitWork.Commit();
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
                provider.Delete(item);
            }
            return unitWork.Commit();
        }
        #endregion
    }
}