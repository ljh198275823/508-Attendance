using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.DAL.LinqDataProvider
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
        #endregion
    }
}
