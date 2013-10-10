using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.BLL
{
    public class AttendanceResultBLL
    {
        #region 构造函数
        public AttendanceResultBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<AttendanceResult> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IAttendanceResultProvider>(_RepoUri).GetItems(con);
        }
        /// <summary>
        /// 增加考勤结果，此用户在此时间段内的所以考勤结果都清除，再写入新结果
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="range"></param>
        /// <param name="arranges"></param>
        /// <returns></returns>
        public CommandResult Add(int userID, DatetimeRange range, List<AttendanceResult> arranges)
        {
            IAttendanceResultProvider provider = ProviderFactory.Create<IAttendanceResultProvider>(_RepoUri);
            StaffAttendanceResultSearchCondition con = new StaffAttendanceResultSearchCondition();
            con.Staff = new List<int>();
            con.Staff.Add(userID);
            con.ShiftDate = range;
            List<AttendanceResult> items = provider.GetItems(con).QueryObjects;
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            foreach (AttendanceResult item in items)
            {
                provider.Delete(item, unitWork);
            }
            if (arranges != null && arranges.Count > 0)
            {
                foreach (AttendanceResult item in arranges)
                {
                    if (item.AbsentItems != null && item.AbsentItems.Count > 0) item.AbsentItems.ForEach(it => it.ResultID = item.ID);
                    provider.Insert(item, unitWork);
                }
            }
            return unitWork.Commit();
        }

        public CommandResult Delete(AttendanceResult info)
        {
            return ProviderFactory.Create<IAttendanceResultProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}