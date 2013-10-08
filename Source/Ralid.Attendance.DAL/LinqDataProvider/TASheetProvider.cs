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
    public class TASheetProvider : ProviderBase<TASheet, int>, ITASheetProvider
    {
        #region 构造函数
        public TASheetProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override TASheet GetingItemByID(int id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<TASheet>().SingleOrDefault(item => item.ID == id);
        }

        protected override List<TASheet> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<TASheet> ret = attendance.GetTable<TASheet>();
            if (search is TASheetSearchCondition)
            {
                TASheetSearchCondition con = search as TASheetSearchCondition;
                if (con.SheetID != null) ret = ret.Where(item => item.SheetID == con.SheetID.Value);
                if (con.StaffID != null) ret = ret.Where(item => item.StaffID == con.StaffID.Value);
                if (!string.IsNullOrEmpty(con.SheetType)) ret = ret.Where(item => item.SheetType == con.SheetType);
                if (!string.IsNullOrEmpty(con.Department)) ret = ret.Where(item => item.Department == con.Department);
                if (con.StartDate != null) ret = ret.Where(item => item.StartDate >= con.StartDate.Begin && item.StartDate <= con.StartDate.End);
            }
            return ret.ToList();
        }
        #endregion
    }
}
