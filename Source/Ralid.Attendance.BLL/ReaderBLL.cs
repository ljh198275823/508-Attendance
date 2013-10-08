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
        #endregion
    }
}
