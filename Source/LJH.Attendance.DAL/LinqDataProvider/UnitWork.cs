using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance .Model.Result;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    /// <summary>
    /// 单元操作
    /// </summary>
    public class UnitWork : IUnitWork
    {
        private AttendanceDataContext _attendance;

        public UnitWork(string connStr)
        {
            _attendance = AttendanceDataContextFactory.Createattendance(connStr);
        }

        public AttendanceDataContext attendance
        {
            get
            {
                return _attendance;
            }
        }

        public CommandResult Commit()
        {
            try
            {
                attendance.SubmitChanges();
                return new CommandResult(ResultCode.Successful, "成功");

            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex, "UnitWork.Commit()");
                return new CommandResult(ResultCode.Fail, ex.Message);
            }
        }
    }
}
