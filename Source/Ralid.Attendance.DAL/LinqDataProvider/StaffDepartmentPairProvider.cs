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
    public class StaffDepartmentPairProvider : ProviderBase<StaffDepartmentPair, StaffDepartmentPair>, IStaffDepartmentPairProvider
    {
        #region 构造函数
        public StaffDepartmentPairProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override StaffDepartmentPair GetingItemByID(StaffDepartmentPair id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<StaffDepartmentPair>().SingleOrDefault(item => item.StaffID == id.StaffID && item.DepartmentID == id.DepartmentID);
        }

        protected override List<StaffDepartmentPair> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<StaffDepartmentPair> ret = attendance.GetTable<StaffDepartmentPair>();
            if (search is StaffDepartmentPairSearchCondition)
            {
                StaffDepartmentPairSearchCondition con = search as StaffDepartmentPairSearchCondition;
                if (con.StaffID != null) ret = ret.Where(item => item.StaffID == con.StaffID.Value);
                if (!string.IsNullOrEmpty(con.DepartmentID)) ret = ret.Where(item => item.DepartmentID == con.DepartmentID);
            }
            return ret.ToList();
        }
        #endregion
    }
}
