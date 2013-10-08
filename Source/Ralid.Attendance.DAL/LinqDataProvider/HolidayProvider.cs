using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using Ralid.Attendance.DAL.IDAL;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.SearchCondition;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    public class HolidayProvider:ProviderBase <Holiday ,int> ,IHolidayProvider 
    {
        #region 构造函数
        public HolidayProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override Holiday GetingItemByID(int id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<Holiday>().SingleOrDefault(item => item.ID == id);
        }

        protected override List<Holiday> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            //DataLoadOptions opt = new DataLoadOptions();
            //opt.LoadWith<Holiday>(item => item.HolidayToWorkDays);
            //attendance.LoadOptions = opt;
            IQueryable<Holiday> ret = attendance.GetTable<Holiday>();
            return ret.ToList();
        }

        //protected override void UpdatingItem(Holiday newVal, Holiday original, AttendanceDataContext attendance)
        //{
        //    attendance.GetTable<Holiday>().Attach(newVal, original);
        //    foreach (HolidayToWorkDay item in newVal.HolidayToWorkDays)
        //    {
        //        HolidayToWorkDay old = original.HolidayToWorkDays.SingleOrDefault(it => it.ID == item.ID);
        //        if (old != null)
        //        {
        //            attendance.GetTable<HolidayToWorkDay>().Attach(item, old);
        //        }
        //        else
        //        {
        //            item.HolidayID = newVal.ID;
        //            attendance.GetTable<HolidayToWorkDay>().InsertOnSubmit(item);
        //        }
        //    }
        //    foreach (HolidayToWorkDay item in original.HolidayToWorkDays)
        //    {
        //        if (newVal.HolidayToWorkDays.SingleOrDefault(it => it.ID == item.ID) == null)
        //        {
        //            attendance.GetTable<HolidayToWorkDay>().Attach(item);
        //            attendance.GetTable<HolidayToWorkDay>().DeleteOnSubmit(item);
        //        }
        //    }
        //}

        //protected override void DeletingItem(Holiday info, AttendanceDataContext attendance)
        //{
        //    attendance.GetTable<Holiday>().Attach(info);
        //    attendance.GetTable<Holiday>().DeleteOnSubmit(info);
        //    foreach (HolidayToWorkDay item in info.HolidayToWorkDays)
        //    {
        //        attendance.GetTable<HolidayToWorkDay>().Attach(item);
        //        attendance.GetTable<HolidayToWorkDay>().DeleteOnSubmit(item);
        //    }
        //}
        #endregion
    }
}
