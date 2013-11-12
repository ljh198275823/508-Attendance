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
    public class StaffBioTemplateProvider : ProviderBase<StaffBioTemplate, Guid>, IStaffBioTemplateProvider
    {
        #region 构造函数
        public StaffBioTemplateProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override StaffBioTemplate GetingItemByID(Guid id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<StaffBioTemplate>().SingleOrDefault(item => item.ID == id);
        }

        protected override List<StaffBioTemplate> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<StaffBioTemplate> ret = attendance.GetTable<StaffBioTemplate>();
            if (search is StaffBioTemplateSearchCondition)
            {
                StaffBioTemplateSearchCondition con = search as StaffBioTemplateSearchCondition;
                if (con.StaffID != null) ret = ret.Where(item => item.StaffID == con.StaffID.Value);
                if (!string.IsNullOrEmpty(con.Version)) ret = ret.Where(item => item.Version == con.Version);
                if (con.Staff != null && con.Staff.Count > 0) ret = ret.Where(item => con.Staff.Contains(item.StaffID));
            }
            return ret.ToList();
        }
        #endregion
    }
}
