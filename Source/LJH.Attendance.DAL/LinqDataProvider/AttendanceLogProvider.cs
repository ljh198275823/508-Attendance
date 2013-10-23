using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.DAL.IDAL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.GeneralLibrary.ExceptionHandling;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class AttendanceLogProvider : ProviderBase<AttendanceLog, string>, IAttendanceLogProvider
    {
        public AttendanceLogProvider()
        {
        }

        public AttendanceLogProvider(string connStr)
            : base(connStr)
        {
        }

        #region 重写模板方法
        protected override List<AttendanceLog> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<AttendanceLog> ret = attendance.GetTable<AttendanceLog>();
            if (search is AttendanceLogSearchCondition)
            {
                AttendanceLogSearchCondition con = search as AttendanceLogSearchCondition;
                if (con.ReadDateTime != null) ret = ret.Where(item => item.ReadDateTime >= con.ReadDateTime.Begin && item.ReadDateTime <= con.ReadDateTime.End);
                if (con.Staff != null && con.Staff.Count > 0) ret = ret.Where(item => con.Staff.Contains(item.StaffID));
                if (con.Readers != null && con.Readers.Count > 0) ret = ret.Where(item => con.Readers.Contains(item.ReaderID) || item.IsManual == true); //人工签卡记录可能没有读卡器ID
            }
            List<AttendanceLog> items = ret.ToList();
            return items;
        }
        #endregion
    }
}
