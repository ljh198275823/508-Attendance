using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示考勤规则
    /// </summary>
    public class AttendanceRules
    {
        #region 静态属性
        public static AttendanceRules Current { get; set; }
        #endregion

        #region 构造函数
        public AttendanceRules()
        {
            ShiftTimeIncludeWaiChu = true;
            MinShiftMinute = 30;
            MinOTMinute = 30;
            BeforeOTStartTime = 120;
            AfterOTEndTime = 120;
            MinutesOfWorkDay = 480;
            MinAttendanceTime = 0.1m;

            MinShiftTime = 0.1m;
            MinVacationTime = 0.1m;
            MinOTTime = 0.1m;
            MinWaichuTime = 0.1m;
            MinLateLeaveEarlyTime = 0.1m;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置迟到时间位于某个时间内
        /// </summary>
        public int? MinLate { get; set; }
        /// <summary>
        /// 获取或设置迟到时间位于某个时间内计多少缺勤
        /// </summary>
        public int MinLateAsAbsentMinute { get; set; }
        /// <summary>
        /// 获取或设置早退时间位于某个时间内
        /// </summary>
        public int? MinLeaveEarly { get; set; }
        /// <summary>
        /// 获取或设置早退时间位于某个时间内计多少缺勤
        /// </summary>
        public int MinLeaveEarlyAsAbsentMinute { get; set; }
        /// <summary>
        /// 获取或设置迟到多少分钟后计为缺勤
        /// </summary>
        public int? LateAsAbsent { get; set; }
        /// <summary>
        /// 获取或设置早退多少分钟后计为缺勤
        /// </summary>
        public int? LeaveEarlyAsAbsent { get; set; }
        /// <summary>
        /// 获取或设置迟到早退是否扣除出勤时间
        /// </summary>
        public bool ShiftTimeIncludeLateOrLeaveEarly { get; set; }
        /// <summary>
        /// 获取或设置外出是否同时计为出勤
        /// </summary>
        public bool ShiftTimeIncludeWaiChu { get; set; }
        /// <summary>
        /// 获取或设置最小的上班时间
        /// </summary>
        public int MinShiftMinute { get; set; }
        /// <summary>
        /// 获取或设置最小的加班分钟数
        /// </summary>
        public int MinOTMinute { get; set; }
        /// <summary>
        /// 获取或设置加班允许提前多少分钟打卡
        /// </summary>
        public int BeforeOTStartTime { get; set; }
        /// <summary>
        /// 获取或设置加班允许延后多少分钟打卡
        /// </summary>
        public int AfterOTEndTime { get; set; }
        /// <summary>
        /// 获取或设置一个工作日的分钟数
        /// </summary>
        public int MinutesOfWorkDay { get; set; }
        /// <summary>
        /// 获取或设置考勤结果的时间单位
        /// </summary>
        public AttendanceUnit AttendanceUnit { get; set; }
        /// <summary>
        /// 获取或设置考勤结果的最小值
        /// </summary>
        public decimal MinAttendanceTime { get; set; }

        #region 暂时不用
        /// <summary>
        /// 获取或设置出勤的时间单位
        /// </summary>
        public AttendanceUnit ShiftUnit { get; set; }
        /// <summary>
        /// 获取或设置出勤时间的最小值
        /// </summary>
        public decimal MinShiftTime { get; set; }
        /// <summary>
        /// 获取或设置请假的时间单位
        /// </summary>
        public AttendanceUnit VacationUnit { get; set; }
        /// <summary>
        /// 获取或设置请假时间的最小值
        /// </summary>
        public decimal MinVacationTime { get; set; }
        /// <summary>
        /// 获取或设置加班的时间单位
        /// </summary>
        public AttendanceUnit OTUnit { get; set; }
        /// <summary>
        /// 获取或设置加班时间的最小值
        /// </summary>
        public decimal MinOTTime { get; set; }
        /// <summary>
        ///  获取或设置外出的时间单位
        /// </summary>
        public AttendanceUnit WaichuUnit { get; set; }
        /// <summary>
        ///  获取或设置外出时间的最小值
        /// </summary>
        public decimal MinWaichuTime { get; set; }
        /// <summary>
        ///  获取或设置出差的时间单位
        /// </summary>
        public AttendanceUnit ChuchaiUnit { get; set; }
        /// <summary>
        ///  获取或设置出差时间的最小值
        /// </summary>
        public decimal MinChuChaiTime { get; set; }
        /// <summary>
        ///  获取或设置迟到早退的时间单位
        /// </summary>
        public AttendanceUnit LateLeaveEarlyUnit { get; set; }
        /// <summary>
        ///  获取或设置迟到早退的最小值
        /// </summary>
        public decimal MinLateLeaveEarlyTime { get; set; }
        #endregion
        #endregion

        #region 公共方法
        public AttendanceDuration GetDuarationFrom(decimal minutes, bool isCeiling)
        {
            AttendanceDuration duration = new AttendanceDuration();
            duration.Unit = AttendanceUnitDescription.GetDescription(this.AttendanceUnit);
            decimal temp = minutes;
            if (this.AttendanceUnit == AttendanceUnit.Hour)
            {
                temp = temp / 60;
            }
            else if (this.AttendanceUnit == AttendanceUnit.WorkDay)
            {
                temp = temp / MinutesOfWorkDay;
            }
            if (this.MinAttendanceTime > 0)
            {
                decimal value = temp / this.MinAttendanceTime;
                int count = (int)Math.Floor(value);
                if (value > count && isCeiling)
                {
                    count++;
                }
                duration.Value = count * MinAttendanceTime;
            }
            return duration;
        }
        #endregion
    }
}
