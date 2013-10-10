using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    /// <summary>
    /// 表示员工某天某个班次的考勤结果
    /// </summary>
    public class AttendanceResult
    {
        #region 构造函数
        public AttendanceResult()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置人员ID
        /// </summary>
        public int StaffID { get; set; }
        /// <summary>
        /// 获取或设置人员姓名
        /// </summary>
        public string StaffName { get; set; }
        /// <summary>
        /// 获取或设置排班日期
        /// </summary>
        public DateTime ShiftDate { get; set; }
        /// <summary>
        /// 获取或设置班次ID
        /// </summary>
        public string ShiftID { get; set; }
        /// <summary>
        /// 获取或设置班次信息
        /// </summary>
        public string ShiftName { get; set; }
        /// <summary>
        /// 获取或设置加班类别
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 获取或设置班次时段的上班时间
        /// </summary>
        public DateTime ShiftStartTime { get; set; }
        /// <summary>
        /// 获取或设置班次时段的下班时间
        /// </summary>
        public DateTime ShiftEndTime { get; set; }
        /// <summary>
        /// 获取或设置天文班次时段的上班时间
        /// </summary>
        public decimal ShiftTime { get; set; }
        /// <summary>
        /// 获取或设置需要签到的时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 获取或设置需要签退的时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 获取或设置最早的上班打卡有效时间
        /// </summary>
        public DateTime EarlyestTime{get;set;}
        /// <summary>
        /// 获取或设置最晚的下班打卡有效时间
        /// </summary>
        public DateTime LatestTime{get;set;}
        /// <summary>
        /// 获取或设置允许迟到分钟数（即迟到时间小于这个数时不记录为迟到）
        /// </summary>
        public decimal AllowLateTime { get; set; }
        /// <summary>
        /// 获取或设置允许的早退分钟数，（即提前下班时间小于这个数时不记为早退）
        /// </summary>
        public decimal AllowLeaveEarlyTime { get; set; }
        #endregion

        #region 考勤结果
        /// <summary>
        /// 获取或设置实际上班时间
        /// </summary>
        public DateTime? OnDutyTime { get; set; }
        /// <summary>
        /// 获取或设置实际下班时间
        /// </summary>
        public DateTime? OffDutyTime { get; set; }
        /// <summary>
        /// 获取或设置实出勤时间
        /// </summary>
        public decimal Present { get; set; }
        /// <summary>
        /// 获取或设置实际缺勤时间
        /// </summary>
        public decimal Absent { get; set; }
        /// <summary>
        /// 获取或设置迟到时间
        /// </summary>
        public decimal Belate { get; set; }
        /// <summary>
        /// 获取或设置早退时间
        /// </summary>
        public decimal LeaveEarly { get; set; }
        /// <summary>
        /// 获取或设置加班时间
        /// </summary>
        public decimal OTTime { get; set; }
        /// <summary>
        /// 获取或设置考勤结果
        /// </summary>
        public AttendanceResultCode Result { get; set; }
        /// <summary>
        /// 获取或设置记录是否被修改过
        /// </summary>
        public bool Modified { get; set; }
        /// <summary>
        /// 获取或设置修改人
        /// </summary>
        public string Modifier { get; set; }
        /// <summary>
        /// 获取或设置修改时间
        /// </summary>
        public DateTime? ModifiedTime { get; set; }
        /// <summary>
        /// 获取或设置记录修改后的审核人员
        /// </summary>
        public string Approval { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 获取或设置班次时间段内缺勤的项的列表，缺勤项包括请假，外出，迟到早退等缺勤。
        /// </summary>
        public List<AbsentItem> AbsentItems { get; set; }
        #endregion

        #region 生成考勤中间结果时的一些属性
        /// <summary>
        /// 获取或设置到达时是否需要打卡
        /// </summary>
        public bool LogWhenArrive { get; set; }
        /// <summary>
        /// 获取或设置离开时是否需要打卡
        /// </summary>
        public bool LogWhenLeave { get; set; }
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
        #endregion

        #region 只读属性
        public string ResultDescr
        {
            get
            {
                return AttendanceResultDescription.GetDescription(Result);
            }
        }
        #endregion

        #region 公共方法
        public AttendanceResult  Clone()
        {
            return this.MemberwiseClone() as AttendanceResult;
        }
        #endregion
    }

    /// <summary>
    /// 表示缺勤项
    /// </summary>
    public class AbsentItem
    {
        #region 构造函数
        public AbsentItem()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置缺勤类别
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 获取或设置缺勤时间
        /// </summary>
        public decimal Duration { get; set; }
        #endregion
    }
}
