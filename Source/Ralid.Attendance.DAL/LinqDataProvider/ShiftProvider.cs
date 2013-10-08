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
            return attendance.GetTable<Shift>().SingleOrDefault(item => item.ID == id);
        }
        #endregion
    }
}
