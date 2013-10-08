using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class ShiftTimezone
    {
        #region 构造函数
        public ShiftTimezone()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置人员编号
        /// </summary>
        public int StaffID { get; set; }
        /// <summary>
        /// 获取或设置人员姓名
        /// </summary>
        public string StaffName { get; set; }
        /// <summary>
        /// 获取或设置班次日期
        /// </summary>
        public DateTime ShiftDate { get; set; }
        /// <summary>
        /// 获取或设置班次ID
        /// </summary>
        public string ShiftID { get; set; }
        /// <summary>
        /// 获取或设置班次名称
        /// </summary>
        public string ShiftName { get; set; }
        /// <summary>
        /// 获取或设置单据类型
        /// </summary>
        public string SheetType { get; set; }
        /// <summary>
        /// 获取或设置类别
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        ///获取或设置开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 获取或设置到达时是否需要打卡
        /// </summary>
        public bool LogWhenArrive { get; set; }
        /// <summary>
        /// 获取或设置允许的最大提前刷卡分钟数，即上班前提前多少分钟打卡则记为已上班
        /// </summary>
        public decimal  BeforeStartTime { get; set; }
        /// <summary>
        /// 获取或设置结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 获取或设置时间段的计时时长
        /// </summary>
        public decimal  ShiftTime { get; set; }
        /// <summary>
        /// 获取或设置离开时是否需要打卡
        /// </summary>
        public bool LogWhenLeave { get; set; }
        /// <summary>
        /// 获取或设置最大的延长刷卡分钟，即下班时间过了多少分钟后打卡仍算正常下班
        /// </summary>
        public decimal  AfterEndTime { get; set; }
        /// <summary>
        /// 获取或设置是否计算迟到
        /// </summary>
        public bool EnableLate { get; set; }
        /// <summary>
        /// 获取或设置是否计算早退
        /// </summary>
        public bool EnableLeaveEarly { get; set; }
        /// <summary>
        /// 获取或设置是否计算缺勤
        /// </summary>
        public bool EnableAbsent { get; set; }
        /// <summary>
        /// 获取或设置实际签到时间
        /// </summary>
        public DateTime? OnDutyTime { get; set; }
        /// <summary>
        /// 获取或设置实际离开时间
        /// </summary>
        public DateTime? OffDutyTime { get; set; }
        #endregion

        #region 只读属性
        /// <summary>
        /// 获取最早的上班打卡有效时间
        /// </summary>
        public DateTime EarlyestTime
        {
            get
            {
                return StartTime.AddMinutes(-(double)BeforeStartTime);
            }
        }
        /// <summary>
        /// 获取最晚的下班打卡有效时间
        /// </summary>
        public DateTime LatestTime
        {
            get
            {
                return EndTime.AddMinutes((double)AfterEndTime);
            }
        }
        #endregion

        #region 公共方法
        public ShiftTimezone Clone()
        {
            return this.MemberwiseClone() as ShiftTimezone;
        }
        #endregion
    }
}
