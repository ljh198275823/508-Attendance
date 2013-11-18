using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 操作员的权限枚举
    /// </summary>
    public enum Permission
    {
        #region 基本资料 1-99
        /// <summary>
        /// 查看多级部门
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看多级部门")]
        ReadDepartment = 1,
        /// <summary>
        /// 编辑多级部门
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑多级部门")]
        EditDepartment = 2,
        /// <summary>
        /// 查看人员
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看人员")]
        ReadStaff = 3,
        /// <summary>
        /// 人员归组
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "人员归组")]
        EditStaff = 4,
        /// <summary>
        /// 查看加班类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看加班类别")]
        ReadOTType = 5,
        /// <summary>
        /// 编辑加班类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑加班类别")]
        EditOTType = 6,
        /// <summary>
        /// 查看请假类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看请假类别")]
        ReadVacationType = 7,
        /// <summary>
        /// 编辑请假类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑请假类别")]
        EditVacationType = 8,
        /// <summary>
        /// 查看外出类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看外出类别")]
        ReadTripType = 9,
        /// <summary>
        /// 编辑外出类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑外出类别")]
        EditTripType = 10,
        /// <summary>
        /// 查看请假单
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看申请单")]
        ReadTASheet = 11,
        /// <summary>
        /// 编辑请假单
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑申请单")]
        EditTASheet = 12,
        /// <summary>
        /// 查看节假日
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看节假日")]
        ReadHoliday = 13,
        /// <summary>
        /// 编辑节假日
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑节假日")]
        EditHoliday = 14,
        /// <summary>
        /// 选择考勤点
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "选择考勤点")]
        SelectAttendanceReader = 15,
        /// <summary>
        /// 查看系统选项
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看系统选项")]
        ReadOptions = 16,
        /// <summary>
        /// 编辑系统选项
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑系统选项")]
        EditOptions = 17,
        /// <summary>
        /// 查看人员类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "查看人员类别")]
        ReadStaffCategory = 18,
        /// <summary>
        /// 编辑人员类别
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Description = "编辑人员类别")]
        EditStaffCategory = 19,
        #endregion

        #region 考勤管理 100-199
        /// <summary>
        /// 查看班次信息
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "查看班次信息")]
        ReadShift = 100,
        /// <summary>
        /// 编辑班次信息
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "编辑班次信息")]
        EditShift = 101,
        /// <summary>
        /// 查看排班信息
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "查看排班信息")]
        ReadShiftArrange = 102,
        /// <summary>
        /// 人员排班
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "人员排班")]
        ShiftArrange = 103,
        /// <summary>
        /// 补签
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "补签")]
        ManualLog = 104,
        /// <summary>
        /// 生成考勤结果
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "生成考勤结果")]
        AttendanceAnalyst = 105,
        /// <summary>
        /// 查看排班模板
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "查看排班模板")]
        ReadShiftTemplate = 106,
        /// <summary>
        /// 编辑排班模板
        /// </summary>
        [OperatorRight(Catalog = "考勤管理", Description = "编辑排班模板")]
        EditShiftTemplate = 107,
        #endregion

        #region 安全管理 200-299
        /// <summary>
        /// 查看操作员信息
        /// </summary>
        [OperatorRight(Catalog = "安全管理", Description = "查看操作员信息")]
        ReadOperaotor = 200,
        /// <summary>
        /// 编辑操作员信息
        /// </summary>
        [OperatorRight(Catalog = "安全管理", Description = "编辑操作员信息")]
        EditOperator = 201,
        /// <summary>
        /// 查看角色信息
        /// </summary>
        [OperatorRight(Catalog = "安全管理", Description = "查看角色信息")]
        ReadRole = 202,
        /// <summary>
        /// 编辑角色信息
        /// </summary>
        [OperatorRight(Catalog = "安全管理", Description = "编辑角色信息")]
        EditRole = 203,
        #endregion

        #region 报表 300-399
        /// <summary>
        /// 月考勤统计表
        /// </summary>
        [OperatorRight(Catalog = "报表", Description = "月考勤统计表")]
        ShiftResultStatistics = 300,
        /// <summary>
        /// 月考勤明细表
        /// </summary>
        [OperatorRight(Catalog = "报表", Description = "月考勤明细表")]
        ShiftResultStatistics2 = 301,
        /// <summary>
        /// 日考勤明细表
        /// </summary>
        [OperatorRight(Catalog = "报表", Description = "日考勤明细表")]
        ResultDetail = 302,
        /// <summary>
        /// 原始考勤记录查询
        /// </summary>
        [OperatorRight(Catalog = "报表", Description = "原始考勤记录查询")]
        AttendanceLogReport = 303,
        #endregion
    }

    public class OperatorRightAttribute : Attribute
    {
        /// <summary>
        /// 权限的类别
        /// </summary>
        public string Catalog { get; set; }
        /// <summary>
        /// 权限的说明
        /// </summary>
        public string Description { get; set; }

        public OperatorRightAttribute()
        {
        }
    }
}
