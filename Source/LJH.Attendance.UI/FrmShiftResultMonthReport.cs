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
using LJH.GeneralLibrary;

namespace LJH.Attendance.UI
{
    public partial class FrmShiftResultMonthReport : FrmMasterBase
    {
        public FrmShiftResultMonthReport()
        {
            InitializeComponent();
        }

        #region 私有变量
        //private List<DataGridViewColumn> _DateColumns = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _OTCols = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _VacationCols = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _TripCols = new List<DataGridViewColumn>();
        #endregion

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

        private void InitGridViewColumns()
        {
            foreach (DataGridViewColumn col in _OTCols)
            {
                this.GridView.Columns.Remove(col);
            }
            _OTCols.Clear();
            foreach (DataGridViewColumn col in _TripCols)
            {
                this.GridView.Columns.Remove(col);
            }
            _TripCols.Clear();
            foreach (DataGridViewColumn col in _VacationCols)
            {
                this.GridView.Columns.Remove(col);
            }
            _VacationCols.Clear();
            List<OTType> ots = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            if (ots != null && ots.Count > 0)
            {
                foreach (OTType ot in ots)
                {
                    DataGridViewColumn col = AddAColumn(ot.ID, ot.Name, "O");
                    _OTCols.Add(col);
                }
            }
            List<VacationType> vts = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            if (vts != null && vts.Count > 0)
            {
                foreach (VacationType vt in vts)
                {
                    DataGridViewColumn col = AddAColumn(vt.ID, vt.Name, "V");
                    _VacationCols.Add(col);
                }
            }
            List<TripType> tts = (new TripTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            if (tts != null && tts.Count > 0)
            {
                foreach (TripType tt in tts)
                {
                    DataGridViewColumn col = AddAColumn(tt.ID, tt.Name, "T");
                    _TripCols.Add(col);
                }
            }
        }

        private DataGridViewColumn AddAColumn(string id, string name, string type)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = string.Format("col{0}_{1}", id, type);
            col.Tag = id;
            col.MinimumWidth = 40;
            col.Width = 40;
            col.ReadOnly = true;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None ;
            col.HeaderText = name;
            GridView.Columns.Add(col);
            return col;
        }

        private decimal SumOfAbsent(IGrouping<int, AttendanceResult> group, string id)
        {
            List<AbsentItem> items = new List<AbsentItem>();
            foreach (AttendanceResult sar in group)
            {
                if (sar.AbsentItems != null && sar.AbsentItems.Count > 0)
                {
                    items.AddRange(sar.AbsentItems.Where(it => it.Category == id));
                }
            }
            return items.Sum(it => AttendanceRules.Current.GetDuarationFrom(it.Duration, true).Value);
        }

        private decimal SumOfOT(IGrouping<int, AttendanceResult> group, string id)
        {
            List<AttendanceResult> items = group.Where(sar => !string.IsNullOrEmpty(id) && id == sar.Category).ToList();
            if (items != null && items.Count > 0)
            {
                return items.Sum(it => AttendanceRules.Current.GetDuarationFrom(it.Present, true).Value);
            }
            return 0;
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();
            InitGridViewColumns();
            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.ShowResigedStaff = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();
            base.Init();
            this.GridView.ContextMenuStrip = null;  //不要显示右键菜单
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
                List<AttendanceResult> arranges = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(con).QueryObjects;
                List<IGrouping<int, AttendanceResult>> groups = arranges.GroupBy(item => item.StaffID).ToList();
                List<object> items = new List<object>();
                foreach (Staff s in users)
                {
                    IGrouping<int, AttendanceResult> group = groups.SingleOrDefault(item => item.Key == s.ID);
                    if (group != null) items.Add(group);
                }
                return items;
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            IGrouping<int, AttendanceResult> group = item as IGrouping<int, AttendanceResult>;
            row.Tag = group;
            row.Cells["colDept"].Value = departmentTreeview1.GetDepartmentName(group.First().StaffID);
            row.Cells["colStaff"].Value = group.First().StaffName;
            for (int i = 1; i <= 31; i++)
            {
                List<AttendanceResult> shifts = group.Where(it => it.ShiftDate.Day == i).ToList();
                row.Cells["colDay" + i.ToString("D2")].Value = GetShiftString(shifts);
                row.Cells["colDay" + i.ToString("D2")].Style.ForeColor = shifts.Exists(it => it.Result != AttendanceResultCode.OK) ? Color.Red : Color.Blue;
            }
            decimal shiftTime = group.Where(sar => !string.IsNullOrEmpty(sar.ShiftID)).Sum(sar => AttendanceRules.Current.GetDuarationFrom(sar.ShiftTime, false).Value).Trim();
            decimal present = group.Where(sar => !string.IsNullOrEmpty(sar.ShiftID)).Sum(sar => AttendanceRules.Current.GetDuarationFrom(sar.Present, false).Value).Trim();
            row.Cells["colShiftTime"].Value = shiftTime;
            row.Cells["colPresent"].Value = present;

            int belate = group.Count(it => it.Belate > 0);
            int leaveEarly = group.Count(it => it.LeaveEarly > 0);
            int forget = group.Count(it => (it.LogWhenArrive && it.OnDutyTime == null) || (it.LogWhenLeave && it.OffDutyTime == null));
            row.Cells["colBelateCount"].Value = belate > 0 ? belate.ToString() : null;
            row.Cells["colLeaveEarlyCount"].Value = leaveEarly > 0 ? leaveEarly.ToString() : null;
            row.Cells["colForgetCount"].Value = forget > 0 ? forget.ToString() : null;
            foreach (DataGridViewColumn col in _OTCols)
            {
                decimal sum = SumOfOT(group, col.Tag.ToString()).Trim(); //加班
                row.Cells[col.Index].Value = sum > 0 ? sum.ToString() : null;
            }
            foreach (DataGridViewColumn col in _VacationCols)
            {
                decimal sum = SumOfAbsent(group, col.Tag.ToString()).Trim();
                row.Cells[col.Index].Value = sum > 0 ? sum.ToString() : null;
            }
            foreach (DataGridViewColumn col in _TripCols)
            {
                decimal sum = SumOfAbsent(group, col.Tag.ToString()).Trim();
                row.Cells[col.Index].Value = sum > 0 ? sum.ToString() : null;
            }
        }

        protected override bool DeletingItem(object item)
        {
            return false;
        }

        protected override void ShowRowBackColor()
        {
            //重写这个方法，主要是因为想让节假日和周末的列与其它的列显示不同的颜色
            //如果不重写这个方法，则上面这种效果就会被行的背景覆盖
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
            InitGridViewColumns();
            List<object> items = GetDataSource();
            ShowItemsOnGrid(items);
        }
        #endregion
    }
}
