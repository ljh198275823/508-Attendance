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
    public class AttendanceResultProvider : ProviderBase<AttendanceResult,int>, IAttendanceResultProvider
    {
        #region 构造函数
        public AttendanceResultProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override AttendanceResult GetingItemByID(int id, AttendanceDataContext attendance)
        {
            AttendanceResult sa = attendance.GetTable<AttendanceResult>().SingleOrDefault(item => item.ID == id);
            return sa;
        }

        protected override List<AttendanceResult> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<AttendanceResult> ret = attendance.GetTable<AttendanceResult>();
            if (search is StaffAttendanceResultSearchCondition)
            {
                StaffAttendanceResultSearchCondition con = search as StaffAttendanceResultSearchCondition;
                if (con.ShiftDate != null)
                    ret = ret.Where(item => item.ShiftDate >= con.ShiftDate.Begin && item.ShiftDate <= con.ShiftDate.End);
                if (con.Staff != null) ret = ret.Where(item => con.Staff.Contains(item.StaffID));
                if (con.ShiftID != null) ret = ret.Where(item => item.ShiftID == con.ShiftID);
            }
            return ret.ToList();
        }
        #endregion
    }
}
