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
    public class ReaderBLL
    {
        #region 构造函数
        public ReaderBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<Reader> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IReaderProvider>(_RepoUri).GetItems(con);
        }

        public QueryResultList<Reader> GetAttendanceReaders()
        {
            QueryResultList<Reader> ret = ProviderFactory.Create<IReaderProvider>(_RepoUri).GetItems(null);
            List<Reader> items = ret.QueryObjects;
            if (items != null && items.Count > 0)
            {
                items = items.Where(item => item.ForAttendance).ToList();
            }
            return new QueryResultList<Reader>(ret.Result, items);
        }

        public CommandResult Add(Reader info)
        {
            return ProviderFactory.Create<IReaderProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(Reader info)
        {

            Reader original = ProviderFactory.Create<IReaderProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IReaderProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(Reader info)
        {
            return ProviderFactory.Create<IReaderProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}
