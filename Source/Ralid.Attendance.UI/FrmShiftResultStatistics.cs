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

        #region 私有方法
        private void InitGridViewColumns()
        {
            List<OTType> ots = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (ots != null && ots.Count > 0)
            {
                foreach (OTType ot in ots)
                {
                    AddAColumn(ot.Name);
                }
            }
            List<VacationType> vts = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (vts != null && vts.Count > 0)
            {
                foreach (VacationType vt in vts)
                {
                    AddAColumn(vt.Name);
                }
            }
            List<TripType> tts = (new TripTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (tts != null && tts.Count > 0)
            {
                foreach (TripType vt in tts)
                {
                    AddAColumn(vt.Name);
                }
            }
        }

        private void AddAColumn(string name)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Tag = name;
            col.Name = name;
            col.Width = 80;
            col.ReadOnly = true;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            col.HeaderText = name;
            GridView.Columns.Add(col);
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.ShowResigedStaff = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();

            InitGridViewColumns();
            base.Init();
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
                List<IGrouping<int, AttendanceResult>> groups = arranges.GroupBy(item => item.StaffID).ToList();
                return (from g in groups
                        select (object)g).ToList();
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            IGrouping<int, AttendanceResult> group = item as IGrouping<int, AttendanceResult>;
            row.Tag = group;
            row.Cells["colStaff"].Value = group.First().StaffName;
            decimal shiftTime = group.Sum(sar => AttendanceRules.Current.GetDuarationFrom(sar.ShiftTime, false).Value);
            decimal present = group.Sum(sar => AttendanceRules.Current.GetDuarationFrom(sar.Present, false).Value);
            row.Cells["colShiftTime"].Value = shiftTime;
            row.Cells["colPresent"].Value = present;
            row.Cells["colAbsent"].Value = shiftTime - present > 0 ? (shiftTime - present).ToString() : string.Empty;
            int lateCount = group.Count(sar => sar.Result == AttendanceResultCode.Late || sar.Result == AttendanceResultCode.LateEarly);
            int leaveEarlyCount = group.Count(sar => sar.Result == AttendanceResultCode.LeaveEarly || sar.Result == AttendanceResultCode.LateEarly);
            row.Cells["colBelateCount"].Value = lateCount > 0 ? lateCount.ToString() : string.Empty;
            row.Cells["colLeaveEarlyCount"].Value = leaveEarlyCount > 0 ? leaveEarlyCount.ToString() : string.Empty;
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
