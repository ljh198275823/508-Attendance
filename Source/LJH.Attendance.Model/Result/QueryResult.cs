using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model.Result
{
    /// <summary>
    /// 查询数据返回单个对象
    /// </summary>
    public class QueryResult<T>
    {
        private ResultCode _result;
        private T _queryObject;


        public QueryResult()
        {
        }

        public QueryResult(ResultCode code, T obj)
        {
            this._result = code;
            this._queryObject = obj;
        }

        public QueryResult(ResultCode code, string msg, T obj)
        {
            this._result = code;
            this._msg = msg;
            this._queryObject = obj;
        }

        #region IQueryResult<T> 成员

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

        public T QueryObject
        {
            get
            {
                return this._queryObject;
            }
            set
            {
                this._queryObject = value;
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
