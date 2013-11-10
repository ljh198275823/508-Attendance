using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmShiftResultDetail_Old : FrmMasterBase
    {
        public FrmShiftResultDetail_Old()
        {
            InitializeComponent();
        }

        #region 私有方法
        private string GetShiftString(List<AttendanceResult> items)
        {
            if (items == null || items.Count == 0) return string.Empty;
            string ret = string.Empty;
            int count = 0;
            foreach (AttendanceResult item in items)
            {
                if (count > 0) ret += ",";
                ret += item.ResultDescr;
                count++;
            }
            return ret;
        }


        private string AbsentItemsDescr(AttendanceResult sar)
        {
            if (sar.AbsentItems != null && sar.AbsentItems.Count > 0)
            {
                string temp = string.Empty;
                for (int i = 0; i < sar.AbsentItems.Count; i++)
                {
                    if (i > 0) temp += ",";
                    AttendanceDuration dur = AttendanceRules.Current.GetDuarationFrom(sar.AbsentItems[i].Duration, true);
                    temp += string.Format("{0} {1} {2}", sar.AbsentItems[i].Category, dur.Value, dur.Unit);
                }
                return temp;
            }
            return null;
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.ShowResigedStaff = true;
            this.departmentTreeview1.Init();
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return null;
        }

        protected override List<object> GetDataSource()
        {
            List<Staff> users = departmentTreeview1.SelectedStaff;
            if (users != null && users.Count > 0)
            {
                List<int> staff = users.Select(item => item.ID).ToList();
                StaffAttendanceResultSearchCondition con = new StaffAttendanceResultSearchCondition();
                con.Staff = staff;
                con.ShiftDate = new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
                List<AttendanceResult> arranges = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con).QueryObjects;
                return (from item in arranges
                        orderby item.StaffName ascending, item.ShiftDate ascending
                        select (object)item).ToList();
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            AttendanceResult sar = item as AttendanceResult;
            row.Tag = sar;
            row.Cells["colDept"].Value = departmentTreeview1.GetDepartmentName(sar.StaffID);
            row.Cells["colStaff"].Value = sar.StaffName;
            row.Cells["colShift"].Value = sar.ShiftName;
            row.Cells["colShiftDate"].Value = sar.ShiftDate.ToString("yyyy-MM-dd");
            row.Cells["colShiftOnDuty"].Value = sar.StartTime.ToString("HH:mm:ss");
            row.Cells["colShiftOffDuty"].Value = sar.EndTime.ToString("HH:mm:ss");
            row.Cells["colOnduty"].Value = sar.OnDutyTime == null ? string.Empty : sar.OnDutyTime.Value.ToString("HH:mm:ss");
            row.Cells["colOnduty"].Style.ForeColor = (sar.Result == AttendanceResultCode.Late || sar.Result == AttendanceResultCode.LateEarly) ? Color.Red : Color.Black;
            row.Cells["colOffDuty"].Value = sar.OffDutyTime == null ? string.Empty : sar.OffDutyTime.Value.ToString("HH:mm:ss");
            row.Cells["colOffDuty"].Style.ForeColor = (sar.Result == AttendanceResultCode.LeaveEarly || sar.Result == AttendanceResultCode.LateEarly) ? Color.Red : Color.Black;
            row.Cells["colShiftTime"].Value = AttendanceRules.Current.GetDuarationFrom(sar.ShiftTime, false).Value;
            row.Cells["colPresent"].Value = AttendanceRules.Current.GetDuarationFrom(sar.Present, false).Value;
            row.Cells["colResult"].Value = sar.ResultDescr;
            row.Cells["colResult"].Style.ForeColor = sar.Result == AttendanceResultCode.OK ? Color.Blue : Color.Red;
            row.Cells["colMemo"].Value = (!string.IsNullOrEmpty(sar.ShiftID)) ? AbsentItemsDescr(sar) : sar.Category;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as OTType);
            return ret.Result == ResultCode.Successful;
        }

        public override void Fresh(SearchCondition search)
        {
            if (search != null && search is StaffAttendanceResultSearchCondition)
            {
                StaffAttendanceResultSearchCondition con = search as StaffAttendanceResultSearchCondition;
                if (con.ShiftDate != null)
                {
                    this.ucDateTimeInterval1.StartDateTime = con.ShiftDate.Begin;
                    this.ucDateTimeInterval1.EndDateTime = con.ShiftDate.End;
                }
                if (con.Staff != null && con.Staff.Count > 0)
                {
                    this.departmentTreeview1.SelectedStaffIDs = con.Staff;
                }
            }
            base.Fresh(search);
        }
        #endregion

        #region 事件处理程序
        private void btnFresh_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            List<object> items = GetDataSource();
            ShowItemsOnGrid(items);
            this.GridView.Sort(this.GridView.Columns["colDept"], ListSortDirection.Ascending);
        }
        #endregion
    }
}
