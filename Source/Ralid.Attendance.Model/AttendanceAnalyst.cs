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
        private List<ShiftTimezone> CreateTimezones(Staff staff, List<ShiftArrange> sas)
        {
            List<ShiftTimezone> timezones = new List<ShiftTimezone>();
            foreach (ShiftArrange item in sas)
            {
                List<ShiftTimezone> items = CreateShiftTimezone(staff, item);
                if (items != null && items.Count > 0) timezones.AddRange(items);
            }
            return timezones;
        }

        private void AddTASheetsToTimezones(List<ShiftTimezone> timezones, List<TASheet> sheets, DatetimeRange range)
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
                    MergeTASheet(timezones, sheet, range);
                }
            }
        }

        private void ExcludeTASheet(List<ShiftTimezone> timezones, TASheet sheet, DatetimeRange range)
        {
            List<ShiftTimezone> items = new List<ShiftTimezone>();
            if (!range.Contain(sheet.StartDate) && !range.Contain(sheet.EndDate)) return;
            DateTime dt = sheet.StartDate;
            while (range.Contain(dt))
            {
                ShiftTimezone st = CreateShiftTimezone(dt, sheet);
                DatetimeRange dr = new DatetimeRange(st.StartTime, st.EndTime);
                List<ShiftTimezone> sts = timezones.Where(it => it.ShiftDate == st.ShiftDate).ToList();
                if (sts != null && sts.Count > 0)
                {
                    foreach (ShiftTimezone item in sts)
                    {
                        DatetimeRange drItem = new DatetimeRange(item.StartTime, item.EndTime);
                        if (dr.Contain(drItem))
                        {
                            item.SheetType = sheet.SheetType;
                            item.Category = sheet.CategoryID;
                            item.LogWhenArrive = false;
                            item.LogWhenLeave = false;
                        }
                        else if (drItem.Contain(dr))
                        {
                            ShiftTimezone item1 = item.Clone();
                            item.EndTime = dr.Begin;
                            item.LogWhenLeave = false;
                            item1.StartTime = dr.End;
                            item1.LogWhenArrive = false;
                            items.Add(item1);
                            items.Add(st);
                        }
                        else if (drItem.Contain(dr.Begin))
                        {
                            item.EndTime = dr.Begin;
                            items.Add(st);
                        }
                        else if (drItem.Contain(dr.End))
                        {
                            item.StartTime = dr.End;
                            items.Add(st);
                        }
                    }
                }
                dt = dt.AddDays(1);
            }
            if (items.Count > 0) timezones.AddRange(items);
        }

        private void MergeTASheet(List<ShiftTimezone> timezones, TASheet sheet, DatetimeRange range)
        {
            List<ShiftTimezone> items = new List<ShiftTimezone>();
            if (!range.Contain(sheet.StartDate) && !range.Contain(sheet.EndDate)) return;
            DateTime dt = sheet.StartDate;
            while (range.Contain(dt))
            {
                ShiftTimezone st = CreateShiftTimezone(dt, sheet);
                DatetimeRange dr = new DatetimeRange(st.StartTime, st.EndTime);
                List<ShiftTimezone> sts = timezones.Where(it => it.ShiftDate == st.ShiftDate).ToList();
                if (sts != null && sts.Count > 0)
                {
                    foreach (ShiftTimezone item in sts)
                    {
                        DatetimeRange r = new DatetimeRange(item.StartTime, item.EndTime);
                        if (!r.Contain(dr)) //检查是否有全部重合的情况，如果与上班时间全部重合，则加班无效。
                        {
                            if (r.Contain(dr.Begin)) //如果加班的开始时间与普通上班时间有重叠，加班时间要截取掉重合部分，并且普通上班下班不用再打卡。
                            {
                                item.LogWhenLeave = false;
                                st.StartTime = r.End;
                            }
                            if (r.Contain(dr.End))
                            {
                                st.EndTime = r.Begin;
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

        private List<ShiftTimezone> CreateShiftTimezone(Staff staff, ShiftArrange item)
        {
            List<ShiftTimezone> items = new List<ShiftTimezone>();
            if (item.Shift != null && item.Shift .Items !=null && item.Shift .Items .Count >0)
            {
                foreach (ShiftItem si in item.Shift.Items)
                {
                    ShiftTimezone st = new ShiftTimezone();
                    st.StaffID = staff.ID;
                    st.ShiftDate = item.ShiftDate;
                    st.ShiftID = item.ShiftID;
                    st.ShiftName = item.Shift.Name;
                    MyTime mt = si.StartTime;
                    if (mt != null) st.StartTime = item.ShiftDate.AddHours(mt.Hour).AddMinutes(mt.Minute).AddSeconds(mt.Second);
                    st.LogWhenArrive = true;
                    st.BeforeStartTime = si.BeforeStartTime;
                    mt = si.EndTime;
                    if (mt != null)
                    {
                        st.EndTime = item.ShiftDate.AddHours(mt.Hour).AddMinutes(mt.Minute).AddSeconds(mt.Second);
                        if (si.NextDay) st.EndTime = st.EndTime.AddDays(1);
                    }
                    st.LogWhenLeave = true;
                    st.AfterEndTime = si.AfterEndTime;
                    st.EnableLate = true;
                    st.EnableLeaveEarly = true;
                    st.EnableAbsent = true;
                    items.Add(st);
                }
            }
            return items;
        }

        private ShiftTimezone CreateShiftTimezone(DateTime shiftDate, TASheet sheet)
        {
            DateTime dt1 = shiftDate.AddHours(sheet.StartTime.Hour).AddMinutes(sheet.StartTime.Minute).AddSeconds(sheet.StartTime.Second);
            DateTime dt2 = shiftDate.AddHours(sheet.EndTime.Hour).AddMinutes(sheet.EndTime.Minute).AddSeconds(sheet.EndTime.Second);
            if (dt1 > dt2) dt2 = dt2.AddDays(1); //跨天
            ShiftTimezone st = new ShiftTimezone();
            st.ShiftDate = shiftDate;
            st.StartTime = dt1;
            st.LogWhenArrive = sheet.SheetType == "A";
            st.BeforeStartTime = 30;
            st.EndTime = dt2;
            st.LogWhenLeave = sheet.SheetType == "A";
            st.AfterEndTime = 30;
            st.SheetType = sheet.SheetType;
            st.Category = sheet.CategoryID;
            st.ShiftTime = sheet.Duration;
            return st;
        }

        private void AttachAttendanceReocrds(List<ShiftTimezone> timezones, List<AttendanceLog> ars)
        {
            for (int i = 0; i < timezones.Count; i++)
            {
                ShiftTimezone item = timezones[i];
                AttendanceLog record = null;
                //上班时间
                if (item.LogWhenArrive)
                {
                    DateTime dt1 = item.EarlyestTime; //最早上班时间
                    //获取上班打卡时间,如果之前有已经计算好的时间段，则当前时间段的上班时间需要从上一个时间段的刷卡时间后开始算起,
                    //并要注意上班时间不能小于上一班次的下班时间
                    if (i > 0)
                    {
                        ShiftTimezone stPre = timezones[i - 1];
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
                        ars.RemoveAll(it => it.ReadDateTime <= item.OnDutyTime); //去掉所有前面的读卡记录，下面计算时会越来越快
                    }
                }

                if (item.LogWhenLeave)
                {
                    //获取下班时间
                    DateTime dt2 = item.LatestTime;
                    if (i < timezones.Count - 1)
                    {
                        ShiftTimezone stNext = timezones[i + 1];
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

        private List<AttendanceResult> Analyst(Staff staff, List<ShiftTimezone> timezones)
        {
            List<AttendanceResult> results = new List<AttendanceResult>();
            if (timezones != null && timezones.Count > 0)
            {
                foreach (ShiftTimezone item in timezones)
                {
                    AttendanceResult ret = CreateResult(staff, item);
                    results.Add(ret);
                }
            }
            return results;
        }

        private AttendanceResult CreateResult(Staff staff, ShiftTimezone timezone)
        {
            AttendanceResult ret = new AttendanceResult();
            ret.StaffID = staff.ID;
            ret.StaffName = staff.Name;
            ret.ShiftDate = timezone.ShiftDate;
            ret.ShiftID = timezone.ShiftID;
            ret.ShiftName = timezone.ShiftName;
            ret.StartTime = timezone.StartTime;
            ret.EndTime = timezone.EndTime;
            ret.OnDutyTime = timezone.OnDutyTime;
            ret.OffDutyTime = timezone.OffDutyTime;
            ret.ShiftTime = timezone.ShiftTime;
            ret.Present = timezone.ShiftTime;  //计算实际出勤时间之前 出勤时间等于应出勤时间

            if (ret.OnDutyTime != null && ret.OffDutyTime != null) //计算上班时间
            {
                TimeSpan ts = new TimeSpan(ret.OffDutyTime.Value.Ticks - ret.OnDutyTime.Value.Ticks);
                ret.ShiftTime = (int)Math.Floor(ts.TotalMinutes);
            }
            if (timezone.LogWhenArrive && timezone.EnableLate)  ////计算迟到时间
            {
                if (ret.OnDutyTime != null && ret.StartTime != null && ret.OnDutyTime.Value > ret.StartTime)
                {
                    TimeSpan ts = new TimeSpan(ret.OnDutyTime.Value.Ticks - ret.StartTime.Ticks);
                    int min = (int)Math.Floor(ts.TotalMinutes);
                    //ret.Belate = min > timezone.AllowLate ? min : 0; //大于允许迟到时间才算迟到
                }
            }
            if (timezone.LogWhenLeave && timezone.EnableLeaveEarly) //计算早退时间
            {
                if (ret.OffDutyTime != null && ret.EndTime != null && ret.OffDutyTime.Value < ret.EndTime)
                {
                    TimeSpan ts = new TimeSpan(ret.EndTime.Ticks - ret.OffDutyTime.Value.Ticks);
                    int min = (int)Math.Floor(ts.TotalMinutes);
                    //ret.LeaveEarly = min > timezone.AllowEarly ? min : 0; //大于允许早退时间才算早退
                }
            }
            if (timezone.LogWhenArrive && timezone.OnDutyTime == null)
            {
                ret.Present = 0;
            }
            if (timezone.LogWhenLeave && timezone.OffDutyTime == null)
            {
                ret.Present = 0;
            }
            return ret;
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
            List<ShiftTimezone> timezones = CreateTimezones(staff, sas);

            //与加班单和请假外出单等合并,得出最后每个上下班时间的准确日期
            AddTASheetsToTimezones(timezones, sheets, range);
            //为那些所有需要记录上下班时间的时间段附加签到和签退
            List<ShiftTimezone> items = (from item in timezones
                                         where item.LogWhenArrive || item.LogWhenLeave
                                         orderby item.StartTime ascending
                                         select item).ToList();
            //对每个时间段附加上实际的打卡时间
            AttachAttendanceReocrds(timezones, ars);
            ////对最终需要上班的时间段和实际的刷卡记录进行分析，得出每个时间段的考勤结果
            List<AttendanceResult> results = Analyst(staff, timezones);
            return results;
        }
        #endregion
    }
}
