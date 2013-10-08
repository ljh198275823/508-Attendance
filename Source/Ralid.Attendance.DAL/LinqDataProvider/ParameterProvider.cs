using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    public class ParameterProvider : ProviderBase<Parameter, string>, IParameterProvider
    {
        #region 构造函数
        public ParameterProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override Parameter GetingItemByID(string id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<Parameter>().SingleOrDefault(item => item.ID == id);
        }
        #endregion
    }
}
