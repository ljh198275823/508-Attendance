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
    public partial class FrmShiftResultDetail : FrmMasterBase
    {
        public FrmShiftResultDetail()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<DataGridViewColumn> _OTCols = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _VacationCols = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _TripCols = new List<DataGridViewColumn>();
        #endregion

        #region 私有方法
        private void InitGridViewColumns()
        {
            _OTCols.Clear();
            _TripCols.Clear();
            _VacationCols.Clear();
            List<OTType> ots = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (ots != null && ots.Count > 0)
            {
                foreach (OTType ot in ots)
                {
                    DataGridViewColumn col = AddAColumn(ot.ID, ot.Name, "O");
                    _OTCols.Add(col);
                }
            }
            List<VacationType> vts = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (vts != null && vts.Count > 0)
            {
                foreach (VacationType vt in vts)
                {
                    DataGridViewColumn col = AddAColumn(vt.ID, vt.Name, "V");
                    _VacationCols.Add(col);
                }
            }
            List<TripType> tts = (new TripTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
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
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col.HeaderText = name;
            GridView.Columns.Add(col);
            return col;
        }

        private decimal SumOfAbsent(List<AttendanceResult> group, string id)
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

        private decimal SumOfOT(List<AttendanceResult> group, string id)
        {
            List<AttendanceResult> items = group.Where(sar => !string.IsNullOrEmpty(id) && id == sar.Category).ToList();
            if (items != null && items.Count > 0)
            {
                return items.Sum(it => AttendanceRules.Current.GetDuarationFrom(it.Present, true).Value);
            }
            return 0;
        }

        private int SumOfForget(List<AttendanceResult> group)
        {
            int count = 0;
            foreach (AttendanceResult sar in group)
            {
                if (sar.LogWhenArrive && sar.OnDutyTime == null) count++;
                if (sar.LogWhenLeave && sar.OffDutyTime == null) count++;
            }
            return count;
        }
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
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.ShowResigedStaff = true;
            this.departmentTreeview1.Init();
            InitGridViewColumns();
            base.Init(); //放在后面是想让某些不想显示的列生效
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
                List<object> items = new List<object>();
                foreach (Staff s in users)
                {
                    List<AttendanceResult> rets = (from it in arranges where it.StaffID == s.ID orderby it.StartTime ascending select it).ToList();
                    if (rets != null && rets.Count > 0)
                    {
                        List<IGrouping<DateTime, AttendanceResult>> groups = rets.GroupBy(item => item.ShiftDate).ToList();
                        List<object> sas = (from g in groups select (object)g).ToList();
                        items.AddRange(sas);
                    }
                }
                return items;
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            IGrouping<DateTime, AttendanceResult> g = item as IGrouping<DateTime, AttendanceResult>;
            List<AttendanceResult> sar = (from it in g orderby it.StartTime ascending select it).ToList();
            row.Tag = sar;
            row.Cells["colDept"].Value = departmentTreeview1.GetDepartmentName(sar[0].StaffID);
            row.Cells["colStaff"].Value = sar[0].StaffName;
            row.Cells["colShift"].Value = sar[0].ShiftName;
            row.Cells["colShiftDate"].Value = sar[0].ShiftDate.ToString("yyyy-MM-dd");
            if (sar.Count >= 1)
            {
                row.Cells["colShiftDuty1"].Value = sar[0].StartTime.ToString("HH:mm") + "--" + sar[0].EndTime.ToString("HH:mm");
                row.Cells["colOnduty1"].Value = (sar[0].OnDutyTime != null ? sar[0].OnDutyTime.Value.ToString("HH:mm") : new string(' ', 5)) + "--" +
                                                   (sar[0].OffDutyTime != null ? sar[0].OffDutyTime.Value.ToString("HH:mm") : new string(' ', 5));
                row.Cells["colOnduty1"].Style.ForeColor = sar[0].Result == AttendanceResultCode.OK ? Color.Black : Color.Red;
            }
            if (sar.Count >= 2)
            {
                row.Cells["colShiftDuty2"].Value = sar[1].StartTime.ToString("HH:mm") + "--" + sar[1].EndTime.ToString("HH:mm");
                row.Cells["colOnduty2"].Value = (sar[1].OnDutyTime != null ? sar[1].OnDutyTime.Value.ToString("HH:mm") : new string(' ', 5)) + "--" +
                                                   (sar[1].OffDutyTime != null ? sar[1].OffDutyTime.Value.ToString("HH:mm") : new string(' ', 5));
                row.Cells["colOnduty2"].Style.ForeColor = sar[1].Result == AttendanceResultCode.OK ? Color.Black : Color.Red;
            }
            if (sar.Count >= 3)
            {
                row.Cells["colShiftDuty3"].Value = sar[2].StartTime.ToString("HH:mm") + "--" + sar[2].EndTime.ToString("HH:mm");
                row.Cells["colOnduty3"].Value = (sar[2].OnDutyTime != null ? sar[2].OnDutyTime.Value.ToString("HH:mm") : new string(' ', 5)) + "--" +
                                                   (sar[2].OffDutyTime != null ? sar[2].OffDutyTime.Value.ToString("HH:mm") : new string(' ', 5));
                row.Cells["colOnduty3"].Style.ForeColor = sar[2].Result == AttendanceResultCode.OK ? Color.Black : Color.Red;
            }

            row.Cells["colShiftTime"].Value = sar.Where(it => !string.IsNullOrEmpty(it.ShiftID)).Sum(it => AttendanceRules.Current.GetDuarationFrom(it.ShiftTime, false).Value).Trim();
            row.Cells["colPresent"].Value = sar.Where(it => !string.IsNullOrEmpty(it.ShiftID)).Sum(it => AttendanceRules.Current.GetDuarationFrom(it.Present, false).Value).Trim();
            int belate = sar.Count(it => it.Belate > 0);
            int leaveEarly = sar.Count(it => it.LeaveEarly > 0);
            int forget = sar.Count(it => (it.LogWhenArrive && it.OnDutyTime == null) || (it.LogWhenLeave && it.OffDutyTime == null));
            row.Cells["colBelateCount"].Value = belate > 0 ? belate.ToString() : null;
            row.Cells["colLeaveEarlyCount"].Value = leaveEarly > 0 ? leaveEarly.ToString() : null;
            row.Cells["colForgetCount"].Value = forget > 0 ? forget.ToString() : null;

            foreach (DataGridViewColumn col in _OTCols)
            {
                decimal sum = SumOfOT(sar, col.Tag.ToString()).Trim(); //加班
                row.Cells[col.Index].Value = sum > 0 ? sum.ToString() : null;
            }
            foreach (DataGridViewColumn col in _VacationCols)
            {
                decimal sum = SumOfAbsent(sar, col.Tag.ToString()).Trim();
                row.Cells[col.Index].Value = sum > 0 ? sum.ToString() : null;
            }
            foreach (DataGridViewColumn col in _TripCols)
            {
                decimal sum = SumOfAbsent(sar, col.Tag.ToString()).Trim();
                row.Cells[col.Index].Value = sum > 0 ? sum.ToString() : null;
            }
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
