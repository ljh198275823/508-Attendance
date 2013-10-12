using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model.Result
{
    /// <summary>
    /// 查询数据返回结果集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable()]
    public class QueryResultList<T>
    {
        public QueryResultList()
        {
        }

        public QueryResultList(ResultCode code, List<T> list)
        {
            this._result = code;
            this.QueryObjects = list;
        }

        public QueryResultList(ResultCode code, string msg, List<T> list)
        {
            this._result = code;
            this._msg = msg;
            this._queryList = list;
        }

        #region IQueryResultList<T> 成员

        private ResultCode _result;
        public ResultCode Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        private List<T> _queryList;
        public List<T> QueryObjects
        {
            get
            {
                return this._queryList;
            }
            set
            {
                this._queryList = value;
            }
        }

        private string _msg;
        public string Message
        {
            get { return _msg; }
            set
            {
                _msg = value;
            }
        }
        #endregion
    }
}
