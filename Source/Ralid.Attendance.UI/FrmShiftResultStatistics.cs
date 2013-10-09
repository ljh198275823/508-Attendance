using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.BLL;

namespace Ralid.Attendance.UI
{
    public partial class FrmShiftResultStatistics : FrmMasterBase
    {
        public FrmShiftResultStatistics()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.ShowResigedStaff = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
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
                        orderby item.StaffID ascending, item.ShiftDate ascending
                        select (object)item).ToList();
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            //StaffAttendanceResult sar = item as StaffAttendanceResult;
            //row.Tag = sar;
            //row.Cells["colStaff"].Value = sar.StaffID;// sar.StaffName;
            //row.Cells["colShift"].Value = sar.Shift == null ? "--" : sar.Shift.Name;
            //row.Cells["colShiftDate"].Value = sar.ShiftDate.ToString("yyyy-MM-dd");
            //row.Cells["colShiftOnDuty"].Value = sar.Shift == null ? "--" : sar.Shift.StartTime.ToString();
            //row.Cells["colShiftOffDuty"].Value = sar.Shift == null ? "--" : sar.Shift.EndTime.ToString();
            //row.Cells["colOnduty"].Value = sar.OnDutyTime;
            //row.Cells["colOffDuty"].Value = sar.OffDutyTime;
            //row.Cells["colShiftHour"].Value = sar.ShiftHour;
            //row.Cells["colBelate"].Value = sar.BelateTime;
            //row.Cells["colLeaveEarly"].Value = sar.LeaveEarlyTime;
            //row.Cells["colOT"].Value = sar.OTTime;
            //row.Cells["colShiftResult"].Value = sar.ResultDescr;
            //row.Cells["colIsModified"].Value = sar.Modified;
            //row.Cells["colModifier"].Value = (sar.Modified != null && sar.Modified.Value) ? sar.Modifier : string.Empty;
            //row.Cells["colModifyDateTime"].Value = sar.ModifiedTime.ToString("yyyy-MM-dd HH:mm:ss");
            //row.Cells["colMemo"].Value = sar.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            return false;
        }
        #endregion

        #region 事件处理程序
        private void btnFresh_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            List<object> items = GetDataSource();
            ShowItemsOnGrid(items);
        }
        #endregion
    }
}
