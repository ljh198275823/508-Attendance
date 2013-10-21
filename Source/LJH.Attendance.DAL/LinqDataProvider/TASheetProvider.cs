using System;
using System.Collections.Generic;
using System.Linq;
using DbLinq.Data.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.LinqDataProvider
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
            DataLoadOptions opts = new DataLoadOptions();
            opts.LoadWith<TASheet>(item => item.Items);
            attendance.LoadOptions = opts;
            return attendance.GetTable<TASheet>().SingleOrDefault(item => item.ID == id);
        }

        protected override List<TASheet> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            DataLoadOptions opts = new DataLoadOptions();
            opts.LoadWith<TASheet>(item => item.Items);
            attendance.LoadOptions = opts;
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

        protected override void UpdatingItem(TASheet newVal, TASheet original, AttendanceDataContext attendance)
        {
            attendance.GetTable<TASheet>().Attach(newVal, original);
            foreach (TASheetItem item in newVal.Items)
            {
                TASheetItem old = original.Items.SingleOrDefault(it => it.ID == item.ID);
                if (old != null)
                {
                    attendance.GetTable<TASheetItem>().Attach(item, old);
                }
                else
                {
                    attendance.GetTable<TASheetItem>().InsertOnSubmit(item);
                }
            }
            foreach (TASheetItem item in original.Items)
            {
                if (newVal.Items.SingleOrDefault(it => it.ID == item.ID) == null)
                {
                    attendance.GetTable<TASheetItem>().Attach(item);
                    attendance.GetTable<TASheetItem>().DeleteOnSubmit(item);
                }
            }
        }

        protected override void DeletingItem(TASheet info, AttendanceDataContext attendance)
        {
            attendance.GetTable<TASheet>().Attach(info);
            attendance.GetTable<TASheet>().DeleteOnSubmit(info);
            if (info.Items != null && info.Items.Count > 0)
            {
                foreach (TASheetItem si in info.Items)
                {
                    attendance.GetTable<TASheetItem>().Attach(si);
                    attendance.GetTable<TASheetItem>().DeleteOnSubmit(si);
                }
            }
        }
        #endregion
    }
}
