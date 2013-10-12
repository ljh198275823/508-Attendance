using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using LJH.Attendance.DAL.IDAL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.GeneralLibrary.ExceptionHandling;

namespace LJH.Attendance.DAL.LinqDataProvider
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
