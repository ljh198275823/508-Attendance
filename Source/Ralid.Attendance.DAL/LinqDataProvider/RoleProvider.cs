using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using Ralid.Attendance.DAL.IDAL;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.GeneralLibrary.ExceptionHandling;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    public class RoleProvider:ProviderBase <Role,string> ,IRoleProvider
    {
        public RoleProvider()
        {
        }

        public RoleProvider(string connStr):base(connStr)
        {
        }

        #region 重写模板方法
        protected override Role GetingItemByID(string id, AttendanceDataContext attendance)
        {
            return attendance.Role.SingleOrDefault(r => r.ID == id);
        }
        #endregion
    }
}
