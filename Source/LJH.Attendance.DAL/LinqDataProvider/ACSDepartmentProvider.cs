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
    public class ACSDepartmentProvider : ProviderBase<ACSDepartment, int>, IACSDepartmentProvider
    {
        #region 构造函数
        public ACSDepartmentProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override ACSDepartment GetingItemByID(int id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<ACSDepartment>().SingleOrDefault(item => item.ID == id);
        }
        #endregion
    }
}
