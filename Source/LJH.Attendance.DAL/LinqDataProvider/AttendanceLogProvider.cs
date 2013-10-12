using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using LJH.Attendance.DAL.IDAL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.GeneralLibrary.ExceptionHandling;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class AttendanceLogProvider : ProviderBase<AttendanceLog, int>, IAttendanceLogProvider
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
                if (con.Readers != null && con.Readers.Count > 0) ret = ret.Where(item => con.Readers.Contains(item.ReaderID)); //人工签卡记录可能没有读卡器ID
            }
            List<AttendanceLog> items = ret.ToList();

            if (search is AttendanceLogSearchCondition)
            {
                AttendanceLogSearchCondition con = search as AttendanceLogSearchCondition;
                if (con.ContainManualLogs)
                {
                    IQueryable<T_TAManualLog> ret1 = attendance.GetTable<T_TAManualLog>();
                    if (con.ReadDateTime != null) ret1 = ret1.Where(item => item.ReadDateTime >= con.ReadDateTime.Begin && item.ReadDateTime <= con.ReadDateTime.End);
                    if (con.Staff != null && con.Staff.Count > 0) ret1 = ret1.Where(item => con.Staff.Contains(item.StaffID));
                    List<T_TAManualLog> logs = ret1.ToList();
                    if (logs != null && logs.Count > 0)
                    {
                        foreach (T_TAManualLog log in logs)
                        {
                            AttendanceLog item = new AttendanceLog()
                            {
                                ID = log.ID,
                                StaffID = log.StaffID,
                                StaffName = log.StaffName,
                                ReadDateTime = log.ReadDateTime,
                                ReaderID = log.ReaderID,
                                IsManual = log.IsManual,
                                Memo = log.Memo
                            };
                            items.Add(item);
                        }
                    }
                }
            }
            return items;
        }

        protected override void InsertingItem(AttendanceLog info, AttendanceDataContext attendance)
        {
            T_TAManualLog item = new T_TAManualLog(info);
            attendance.GetTable<T_TAManualLog>().InsertOnSubmit(item);
        }

        protected override void UpdatingItem(AttendanceLog newVal, AttendanceLog original, AttendanceDataContext attendance)
        {
            attendance.GetTable<T_TAManualLog>().Attach(new T_TAManualLog(newVal), new T_TAManualLog(original));
        }

        protected override void DeletingItem(AttendanceLog info, AttendanceDataContext attendance)
        {
            T_TAManualLog item = new T_TAManualLog(info);
            attendance.GetTable<T_TAManualLog>().Attach(item);
            attendance.GetTable<T_TAManualLog>().DeleteOnSubmit(item);
        }
        #endregion
    }
}
