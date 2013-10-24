using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class AttendanceResultProvider : ProviderBase<AttendanceResult, Guid>, IAttendanceResultProvider
    {
        #region 构造函数
        public AttendanceResultProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override AttendanceResult GetingItemByID(Guid id, AttendanceDataContext attendance)
        {
            DataLoadOptions opts = new DataLoadOptions();
            opts.LoadWith<AttendanceResult>(item => item.AbsentItems);
            attendance.LoadOptions = opts;
            AttendanceResult sa = attendance.GetTable<AttendanceResult>().SingleOrDefault(item => item.ID == id);
            return sa;
        }

        protected override List<AttendanceResult> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            DataLoadOptions opts = new DataLoadOptions();
            opts.LoadWith<AttendanceResult>(item => item.AbsentItems);
            attendance.LoadOptions = opts;
            IQueryable<AttendanceResult> ret = attendance.GetTable<AttendanceResult>();
            if (search is StaffAttendanceResultSearchCondition)
            {
                StaffAttendanceResultSearchCondition con = search as StaffAttendanceResultSearchCondition;
                if (con.ShiftDate != null)
                    ret = ret.Where(item => item.ShiftDate >= con.ShiftDate.Begin && item.ShiftDate <= con.ShiftDate.End);
                if (con.Staff != null && con.Staff.Count > 0) ret = ret.Where(item => con.Staff.Contains(item.StaffID));
                if (con.ShiftID != null) ret = ret.Where(item => item.ShiftID == con.ShiftID);
            }
            return ret.ToList();
        }

        protected override void UpdatingItem(AttendanceResult newVal, AttendanceResult original, AttendanceDataContext attendance)
        {
            attendance.GetTable<AttendanceResult>().Attach(newVal, original);
            foreach (AbsentItem item in newVal.AbsentItems)
            {
                AbsentItem old = original.AbsentItems.SingleOrDefault(it => it.ID == item.ID);
                if (old != null)
                {
                    attendance.GetTable<AbsentItem>().Attach(item, old);
                }
                else
                {
                    attendance.GetTable<AbsentItem>().InsertOnSubmit(item);
                }
            }
            foreach (AbsentItem item in original.AbsentItems)
            {
                if (newVal.AbsentItems.SingleOrDefault(it => it.ID == item.ID) == null)
                {
                    attendance.GetTable<AbsentItem>().Attach(item);
                    attendance.GetTable<AbsentItem>().DeleteOnSubmit(item);
                }
            }
        }

        protected override void DeletingItem(AttendanceResult info, AttendanceDataContext attendance)
        {
            attendance.GetTable<AttendanceResult>().Attach(info);
            attendance.GetTable<AttendanceResult>().DeleteOnSubmit(info);
            if (info.AbsentItems != null && info.AbsentItems.Count > 0)
            {
                foreach (AbsentItem item in info.AbsentItems)
                {
                    attendance.GetTable<AbsentItem>().Attach(item);
                    attendance.GetTable<AbsentItem>().DeleteOnSubmit(item);
                }
            }
        }
        #endregion
    }
}
