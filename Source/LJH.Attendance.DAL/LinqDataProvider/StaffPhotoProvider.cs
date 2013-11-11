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
    public class StaffPhotoProvider : ProviderBase<StaffPhoto, int>, IStaffPhotoProvider
    {
        public StaffPhotoProvider()
        {
        }

        public StaffPhotoProvider(string connStr)
            : base(connStr)
        {
        }

        #region 重写基类成员
        protected override StaffPhoto GetingItemByID(int id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<StaffPhoto>().SingleOrDefault(item => item.StaffID == id);
        }
        #endregion
    }
}
