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
    public class ShiftProvider : ProviderBase<Shift, string>, IShiftProvider
    {
        #region 构造函数
        public ShiftProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override Shift GetingItemByID(string id, AttendanceDataContext attendance)
        {
            DataLoadOptions opts = new DataLoadOptions();
            opts.LoadWith<Shift>(item => item.Items);
            attendance.LoadOptions = opts;
            return attendance.GetTable<Shift>().SingleOrDefault(item => item.ID == id);
        }

        protected override List<Shift> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            DataLoadOptions opts = new DataLoadOptions();
            opts.LoadWith<Shift>(item => item.Items);
            attendance.LoadOptions = opts;
            IQueryable<Shift> ret = attendance.GetTable<Shift>();
            return ret.ToList();
        }

        protected override void UpdatingItem(Shift newVal, Shift original, AttendanceDataContext attendance)
        {
            attendance.GetTable<Shift>().Attach(newVal, original);
            foreach (ShiftItem item in newVal.Items)
            {
                ShiftItem old = original.Items.SingleOrDefault(it => it.ID == item.ID);
                if (old != null)
                {
                    attendance.GetTable<ShiftItem>().Attach(item, old);
                }
                else
                {
                    attendance.GetTable<ShiftItem>().InsertOnSubmit(item);
                }
            }
            foreach (ShiftItem item in original.Items)
            {
                if (newVal.Items.SingleOrDefault(it => it.ID == item.ID) == null)
                {
                    attendance.GetTable<ShiftItem>().Attach(item);
                    attendance.GetTable<ShiftItem>().DeleteOnSubmit(item);
                }
            }
        }

        protected override void DeletingItem(Shift info, AttendanceDataContext attendance)
        {
            attendance.GetTable<Shift>().Attach(info);
            attendance.GetTable<Shift>().DeleteOnSubmit(info);
            if (info.Items != null && info.Items.Count > 0)
            {
                foreach (ShiftItem si in info.Items)
                {
                    attendance.GetTable<ShiftItem>().Attach(si);
                    attendance.GetTable<ShiftItem>().DeleteOnSubmit(si);
                }
            }
        }
        #endregion
    }
}
