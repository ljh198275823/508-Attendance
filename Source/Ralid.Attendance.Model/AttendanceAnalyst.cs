using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 考勤结果分析类，这个类的作用是把人员的考勤记录和排班管理，节假日，请假申请，加班申请等进行综合分析，得出某天的考勤结果
    /// </summary>
    public class AttendanceAnalyst
    {
        #region 构造函数

        #endregion

        #region 私有方法
        private List<AttendanceResult> CreateTimezones(Staff staff, List<ShiftArrange> sas)
        {
            List<AttendanceResult> timezones = new List<AttendanceResult>();
            foreach (ShiftArrange item in sas)
            {
                List<AttendanceResult> items = CreateAttendanceResult(staff, item);
                if (items != null && items.Count > 0) timezones.AddRange(items);
            }
            return timezones;
        }

        private void AddTASheetsToTimezones(Staff staff, List<AttendanceResult> timezones, List<TASheet> sheets, DatetimeRange range)
        {
            List<TASheet> items = sheets.Where(item => item.SheetType != "A").ToList();
            if (items != null && items.Count > 0)
            {
                foreach (TASheet sheet in items)
                {
                    ExcludeTASheet(timezones, sheet, range);
                }
            }

            items = sheets.Where(item => item.SheetType == "A").ToList();
            if (items != null && items.Count > 0)
            {
                foreach (TASheet sheet in items)
                {
                    MergeTASheet(staff, timezones, sheet, range);
                }
            }
        }

        private void ExcludeTASheet(List<AttendanceResult> timezones, TASheet sheet, DatetimeRange range)
        {
            List<AttendanceResult> items = new List<AttendanceResult>();
            if (!range.Contain(sheet.StartDate) && !range.Contain(sheet.EndDate)) return;
            DateTime dt = sheet.StartDate;
            while (range.Contain(dt))
            {
                DateTime dt1 = dt.AddHours(sheet.StartTime.Hour).AddMinutes(sheet.StartTime.Minute).AddSeconds(sheet.StartTime.Second);
                DateTime dt2 = dt.AddHours(sheet.EndTime.Hour).AddMinutes(sheet.EndTime.Minute).AddSeconds(sheet.EndTime.Second);
                DatetimeRange dr = new DatetimeRange(dt1, dt2);
                List<AttendanceResult> sts = timezones.Where(it => it.ShiftDate == dt).ToList();
                if (sts != null && sts.Count > 0)
                {
                    foreach (AttendanceResult item in sts)
                    {
                        DatetimeRange drItem = new DatetimeRange(item.StartTime, item.EndTime);
                        if (dr.Contain(drItem))
                        {
                            if (!(sheet.SheetType == "C" && AttendanceRules.Current != null && AttendanceRules.Current.ShiftTimeIncludeWaiChu))
                            {
                                item.Present = 0;
                            }
                            item.Category = sheet.CategoryID;
                            item.LogWhenArrive = false;
                            item.LogWhenLeave = false;
                            AbsentItem ai = new AbsentItem()
                            {
                                Category = sheet.CategoryID,
                                Duration = item.ShiftTime
                            };
                            item.AbsentItems.Add(ai);
                        }
                        else if (drItem.Contain(dr))
                        {
                            if (!(sheet.SheetType == "C" && AttendanceRules.Current != null && AttendanceRules.Current.ShiftTimeIncludeWaiChu))
                            {
                                item.Present -= dr.TotalMinutes;
                            }
                            AbsentItem ai = new AbsentItem()
                            {
                                Category = sheet.CategoryID,
                                Duration = dr.TotalMinutes
                            };
                            item.AbsentItems.Add(ai);
                        }
                        else if (drItem.Contain(dr.Begin))
                        {
                            DatetimeRange drTemp = new DatetimeRange(dr.Begin, drItem.End);
                            if (!(sheet.SheetType == "C" && AttendanceRules.Current != null && AttendanceRules.Current.ShiftTimeIncludeWaiChu))
                            {
                                item.Present -= drTemp.TotalMinutes;
                            }
                            item.EndTime = dr.Begin;
                            AbsentItem ai = new AbsentItem()
                            {
                                Category = sheet.CategoryID,
                                Duration = drTemp.TotalMinutes
                            };
                            item.AbsentItems.Add(ai);
                        }
                        else if (drItem.Contain(dr.End))
                        {
                            DatetimeRange drTemp = new DatetimeRange(drItem.Begin, dr.End);
                            if (!(sheet.SheetType == "C" && AttendanceRules.Current != null && AttendanceRules.Current.ShiftTimeIncludeWaiChu))
                            {
                                item.Present -= drTemp.TotalMinutes;
                            }
                            item.StartTime = dr.End;
                            AbsentItem ai = new AbsentItem()
                            {
                                Category = sheet.CategoryID,
                                Duration = drTemp.TotalMinutes
                            };
                            item.AbsentItems.Add(ai);
                        }
                    }
                }
                dt = dt.AddDays(1);
            }
            if (items.Count > 0) timezones.AddRange(items);
        }

        private void MergeTASheet(Staff staff, List<AttendanceResult> timezones, TASheet sheet, DatetimeRange range)
        {
            List<AttendanceResult> items = new List<AttendanceResult>();
            if (!range.Contain(sheet.StartDate) && !range.Contain(sheet.EndDate)) return;
            DateTime dt = sheet.StartDate;
            while (range.Contain(dt))
            {
                AttendanceResult st = CreateAttendanceResult(staff, dt, sheet);
                DateTime dt1 = dt.AddHours(sheet.StartTime.Hour).AddMinutes(sheet.StartTime.Minute).AddSeconds(sheet.StartTime.Second);
                DateTime dt2 = dt.AddHours(sheet.EndTime.Hour).AddMinutes(sheet.EndTime.Minute).AddSeconds(sheet.EndTime.Second);
                DatetimeRange dr = new DatetimeRange(dt1, dt2);
                List<AttendanceResult> sts = timezones.Where(it => it.ShiftDate == st.ShiftDate).ToList();
                if (sts != null && sts.Count > 0)
                {
                    foreach (AttendanceResult item in sts)
                    {
                        DatetimeRange drItem = new DatetimeRange(item.StartTime, item.EndTime);
                        if (!drItem.Contain(dr)) //检查是否有全部重合的情况，如果与上班时间全部重合，则加班无效。
                        {
                            if (drItem.Contain(dr.Begin)) //如果加班的开始时间与普通上班时间有重叠，加班时间要截取掉重合部分，并且普通上班下班不用再打卡。
                            {
                                item.LogWhenLeave = false;
                                st.StartTime = drItem.End;
                                st.ShiftTime = (new DatetimeRange(st.StartTime, st.EndTime)).TotalMinutes;
                                st.Present = (new DatetimeRange(st.StartTime, st.EndTime)).TotalMinutes;
                                st.LogWhenArrive = false;
                            }
                            if (drItem.Contain(dr.End))
                            {
                                st.EndTime = drItem.Begin;
                                st.ShiftTime = (new DatetimeRange(st.StartTime, st.EndTime)).TotalMinutes;
                                st.Present = (new DatetimeRange(st.StartTime, st.EndTime)).TotalMinutes;
                                st.LogWhenLeave = false;
                                item.LogWhenArrive = false;
                            }
                            items.Add(st);
                        }
                    }
                }
                else
                {
                    items.Add(st);
                }
                dt = dt.AddDays(1);
            }
            if (items.Count > 0) timezones.AddRange(items);
        }

        private List<AttendanceResult> CreateAttendanceResult(Staff staff, ShiftArrange item)
        {
            List<AttendanceResult> items = new List<AttendanceResult>();
            if (item.Shift != null && item.Shift.Items != null && item.Shift.Items.Count > 0)
            {
                foreach (ShiftItem si in item.Shift.Items)
                {
                    AttendanceResult st = new AttendanceResult();
                    st.StaffID = staff.ID;
                    st.StaffName = staff.Name;
                    st.ShiftDate = item.ShiftDate;
                    st.ShiftID = item.ShiftID;
                    st.ShiftName = item.Shift.Name;
                    MyTime mt = si.StartTime;
                    st.ShiftStartTime = item.ShiftDate.AddHours(mt.Hour).AddMinutes(mt.Minute).AddSeconds(mt.Second);
                    st.StartTime = st.ShiftStartTime;
                    mt = si.EndTime;
                    st.ShiftEndTime = item.ShiftDate.AddHours(mt.Hour).AddMinutes(mt.Minute).AddSeconds(mt.Second);
                    if (si.NextDay) st.ShiftEndTime = st.ShiftEndTime.AddDays(1);
                    st.EndTime = st.ShiftEndTime;
                    st.ShiftTime = si.Duration; //设置班次时段的上班时间
                    st.Present = si.Duration;
                    st.EarlyestTime = st.StartTime.AddMinutes((int)-si.BeforeStartTime);
                    st.LatestTime = st.EndTime.AddMinutes((int)si.AfterEndTime);
                    st.AllowLateTime = si.AllowLateTime;
                    st.AllowLeaveEarlyTime = si.AllowLeaveEarlyTime;

                    st.LogWhenArrive = true;
                    st.LogWhenLeave = true;
                    st.EnableLate = true;
                    st.EnableLeaveEarly = true;
                    st.EnableAbsent = true;
                    items.Add(st);
                }
            }
            return items;
        }

        private AttendanceResult CreateAttendanceResult(Staff staff, DateTime shiftDate, TASheet sheet)
        {
            DateTime dt1 = shiftDate.AddHours(sheet.StartTime.Hour).AddMinutes(sheet.StartTime.Minute).AddSeconds(sheet.StartTime.Second);
            DateTime dt2 = shiftDate.AddHours(sheet.EndTime.Hour).AddMinutes(sheet.EndTime.Minute).AddSeconds(sheet.EndTime.Second);
            if (dt1 > dt2) dt2 = dt2.AddDays(1); //跨天
            AttendanceResult st = new AttendanceResult();
            st.StaffID = staff.ID;
            st.StaffName = staff.Name;
            st.ShiftDate = shiftDate;
            st.Category = sheet.CategoryID;
            st.ShiftStartTime = dt1;
            st.StartTime = dt1;
            st.ShiftEndTime = dt2;
            st.EndTime = dt2;
            if (AttendanceRules.Current != null)
            {
                st.EarlyestTime = st.StartTime.AddMinutes(-(int)AttendanceRules.Current.BeforeOTStartTime);
                st.LatestTime = st.EndTime.AddMinutes((int)AttendanceRules.Current.AfterOTEndTime);
            }
            else
            {
                st.EarlyestTime = st.StartTime.AddMinutes(-30);
                st.LatestTime = st.EndTime.AddMinutes(30);
            }
            st.ShiftTime = sheet.Duration;
            st.Present = sheet.Duration;

            st.LogWhenArrive = true;
            st.LogWhenLeave = true;
            st.EnableLate = true;
            st.EnableLeaveEarly = true;
            st.EnableAbsent = true;
            return st;
        }

        private void AttachAttendanceReocrds(List<AttendanceResult> timezones, List<AttendanceLog> ars)
        {
            for (int i = 0; i < timezones.Count; i++)
            {
                AttendanceResult item = timezones[i];
                AttendanceLog record = null;
                //上班时间
                if (item.LogWhenArrive)
                {
                    DateTime dt1 = item.EarlyestTime; //最早上班时间
                    //获取上班打卡时间,如果之前有已经计算好的时间段，则当前时间段的上班时间需要从上一个时间段的刷卡时间后开始算起,
                    //并要注意上班时间不能小于上一班次的下班时间
                    if (i > 0)
                    {
                        AttendanceResult stPre = timezones[i - 1];
                        if (stPre.EndTime >= dt1) dt1 = stPre.EndTime.AddMilliseconds(1);
                        if (stPre.OffDutyTime != null && stPre.OffDutyTime.Value >= dt1) dt1 = stPre.OffDutyTime.Value.AddMilliseconds(1);
                    }
                    record = (from it in ars
                              where it.ReadDateTime >= dt1 && it.ReadDateTime < item.EndTime
                              orderby it.ReadDateTime ascending
                              select it).FirstOrDefault();
                    if (record != null)
                    {
                        item.OnDutyTime = record.ReadDateTime;
                        DateTime dtTemp = record.ReadDateTime;
                        if (AttendanceRules.Current != null)
                        {
                            if (!string.IsNullOrEmpty(item.ShiftID))
                            {
                                dtTemp = dtTemp.AddMinutes(AttendanceRules.Current.MinShiftMinute);
                            }
                            else
                            {
                                dtTemp = dtTemp.AddMinutes(AttendanceRules.Current.MinOTMinute);
                            }
                        }
                        else
                        {
                            dtTemp = dtTemp.AddMinutes(1);
                        }
                        ars.RemoveAll(it => it.ReadDateTime <= dtTemp); //去掉所有前面的读卡记录，下面计算时会越来越快
                    }
                }

                if (item.LogWhenLeave)
                {
                    //获取下班时间
                    DateTime dt2 = item.LatestTime;
                    if (i < timezones.Count - 1)
                    {
                        AttendanceResult stNext = timezones[i + 1];
                        if (dt2 >= stNext.StartTime) dt2 = stNext.StartTime.AddMilliseconds(-1);
                        List<AttendanceLog> items = (from it in ars
                                                     where it.ReadDateTime >= item.EndTime && it.ReadDateTime <= dt2
                                                     orderby it.ReadDateTime descending
                                                     select it).ToList();
                        if (items.Count == 1) item.OffDutyTime = items[0].ReadDateTime;
                        if (items.Count > 1) //如果有多条记录，则下班时间计算到最长，保留最后一条用作下一个班次的上班时间就可以了。
                        {
                            if (items[0].ReadDateTime >= stNext.EarlyestTime)
                            {
                                item.OffDutyTime = items[1].ReadDateTime;
                            }
                            else
                            {
                                item.OffDutyTime = items[0].ReadDateTime;
                            }
                            ars.RemoveAll(it => it.ReadDateTime <= item.OffDutyTime); //去掉所有前面的读卡记录，下面计算时会越来越快
                        }
                    }
                    if (item.OffDutyTime == null)
                    {
                        record = (from it in ars
                                  where it.ReadDateTime > item.StartTime && it.ReadDateTime <= dt2
                                  orderby it.ReadDateTime descending
                                  select it).FirstOrDefault();
                        if (record != null)
                        {
                            item.OffDutyTime = record.ReadDateTime;
                            ars.RemoveAll(it => it.ReadDateTime <= item.OffDutyTime);//去掉所有前面的读卡记录，下面计算时会越来越快
                        }
                    }
                }
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 根据某个员工的排班记录，刷卡记录，请假单，加班单等原始资料生成指定时间段内的考勤结果
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="sas"></param>
        /// <param name="ars"></param>
        /// <param name="vss"></param>
        /// <returns></returns>
        public List<AttendanceResult> Analist(Staff staff, List<ShiftArrange> sas, List<AttendanceLog> ars, List<TASheet> sheets, DatetimeRange range)
        {
            //根据排班记录，加班单，请假外出单等生成整个时期的要标记的时间段
            List<AttendanceResult> results = CreateTimezones(staff, sas);

            //与加班单和请假外出单等合并,得出最后每个上下班时间的准确日期
            AddTASheetsToTimezones(staff, results, sheets, range);
            //为那些所有需要记录上下班时间的时间段附加签到和签退
            List<AttendanceResult> items = (from item in results
                                            where item.LogWhenArrive || item.LogWhenLeave
                                            orderby item.StartTime ascending
                                            select item).ToList();
            //对每个时间段附加上实际的打卡时间
            AttachAttendanceReocrds(results, ars);
            ////对最终需要上班的时间段和实际的刷卡记录进行分析，得出每个时间段的考勤结果
            results.ForEach(item => item.CreateResult());
            return results;
        }
        #endregion
    }
}
