using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class ShiftArrangeProvider : ProviderBase<ShiftArrange, ShiftArrangeID>, IShiftArrangeProvider
    {
        #region 构造函数
        public ShiftArrangeProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override ShiftArrange GetingItemByID(ShiftArrangeID id, AttendanceDataContext attendance)
        {
            ShiftArrange sa = attendance.GetTable<ShiftArrange>().SingleOrDefault(item => item.StaffID == id.StaffID && item.ShiftDate == id.ShiftDate && item.ShiftID == id.ShiftID);
            if (sa != null)
            {
                sa.Shift = (new ShiftProvider(ConnectStr)).GetByID(sa.ShiftID).QueryObject;
            }
            return sa;
        }

        protected override List<ShiftArrange> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<ShiftArrange> ret = attendance.GetTable<ShiftArrange>();
            if (search is ShiftArrangeSearchCondition)
            {
                ShiftArrangeSearchCondition con = search as ShiftArrangeSearchCondition;
                if (con.ShiftDate != null)
                    ret = ret.Where(item => item.ShiftDate >= con.ShiftDate.Begin && item.ShiftDate <= con.ShiftDate.End);
                if (con.StaffID!=null) ret = ret.Where(item => item.StaffID == con.StaffID);
                if (con.ShiftID != null) ret = ret.Where(item => item.ShiftID == con.ShiftID);
            }
            List<ShiftArrange> items = ret.ToList();
            if (items != null && items.Count > 0)
            {
                List<Shift> shifts = (new ShiftProvider(ConnectStr)).GetItems(null).QueryObjects;
                foreach (ShiftArrange item in items)
                {
                    item.Shift = shifts.SingleOrDefault(it => it.ID == item.ShiftID);
                }
            }
            return items.Where(item => item.Shift != null).ToList();
        }
        #endregion
    }
}
