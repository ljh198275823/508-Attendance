using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using LJH.Attendance.DAL.IDAL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.SearchCondition;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class HolidayProvider : ProviderBase<Holiday,string>, IHolidayProvider
    {
        #region 构造函数
        public HolidayProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override Holiday GetingItemByID(string id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<Holiday>().SingleOrDefault(item => item.ID == id);
        }

        protected override List<Holiday> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<Holiday> ret = attendance.GetTable<Holiday>();
            return ret.ToList();
        }
        #endregion
    }
}
