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
    public partial class FrmShiftResultDetail : FrmMasterBase
    {
        public FrmShiftResultDetail()
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
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
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
                        orderby item.StaffName ascending, item.ShiftDate ascending
                        select (object)item).ToList();
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            AttendanceResult sar = item as AttendanceResult;
            row.Tag = sar;
            row.Cells["colStaff"].Value = sar.StaffName;
            row.Cells["colShift"].Value = sar.ShiftName;
            row.Cells["colShiftDate"].Value = sar.ShiftDate.ToString("yyyy-MM-dd");
            row.Cells["colShiftOnDuty"].Value = sar.StartTime.ToString("HH:mm:ss");
            row.Cells["colShiftOffDuty"].Value = sar.EndTime.ToString("HH:mm:ss");
            row.Cells["colOnduty"].Value = sar.OnDutyTime == null ? "--" : sar.OnDutyTime.Value.ToString("HH:mm:ss");
            row.Cells["colOffDuty"].Value = sar.OffDutyTime == null ? "--" : sar.OffDutyTime.Value.ToString("HH:mm:ss");
            row.Cells["colShiftTime"].Value = sar.ShiftTime;
            row.Cells["colPresent"].Value = sar.Present;
            row.Cells["colAbsent"].Value = sar.Absent;
            row.Cells["colBelate"].Value = sar.Belate;
            row.Cells["colLeaveEarly"].Value = sar.LeaveEarly;
            row.Cells["colMemo"].Value = sar.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as OTType);
            return ret.Result == ResultCode.Successful;
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
