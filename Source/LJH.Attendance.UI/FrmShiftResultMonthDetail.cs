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
    public partial class FrmShiftResultMonthDetail : FrmMasterBase
    {
        public FrmShiftResultMonthDetail()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<DataGridViewColumn> _DateColumns = new List<DataGridViewColumn>();
        #endregion

        #region 私有方法
        private void InitGridColumns(DateTime begin, DateTime end)
        {
            if (_DateColumns != null && _DateColumns.Count > 0)
            {
                foreach (DataGridViewColumn col in _DateColumns)
                {
                    this.GridView.Columns.Remove(col);
                }
                _DateColumns.Clear();
            }
            while (end >= begin)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Tag = begin;
                col.Width = 40;
                col.ReadOnly = true;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                col.HeaderText = begin.Day.ToString("D2");
                if (HolidaySetting.Current != null && (HolidaySetting.Current.IsHoliday(begin) || HolidaySetting.Current.IsWeekend(begin)))
                {
                    col.DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    col.DefaultCellStyle.BackColor = Color.White;
                }
                _DateColumns.Add(col);
                begin = begin.AddDays(1);
            }
            foreach(DataGridViewColumn col in _DateColumns )
            {
                GridView.Columns.Add(col);
            }
        }

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
            InitGridColumns(this.ucDateTimeInterval1.StartDateTime, this.ucDateTimeInterval1.EndDateTime);

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
            row.Cells["colDept"].Value = departmentTreeview1.GetDepartmentName(group.First().StaffID);
            row.Cells["colStaff"].Value = group.First().StaffName;
            foreach (DataGridViewColumn col in _DateColumns)
            {
                DateTime dt = Convert.ToDateTime(col.Tag);
                List<AttendanceResult> shifts = group.Where(it => it.ShiftDate == dt).ToList();
                row.Cells[col.Index].Value = GetShiftString(shifts);
                row.Cells[col.Index].Tag = shifts;
                row.Cells[col.Index].Style.ForeColor = shifts.Exists(it => it.Result != AttendanceResultCode.OK) ? Color.Red : Color.Blue;
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
            InitGridColumns(this.ucDateTimeInterval1.StartDateTime, this.ucDateTimeInterval1.EndDateTime);
            List<object> items = GetDataSource();
            ShowItemsOnGrid(items);
            this.GridView.Sort(this.GridView.Columns["colDept"], ListSortDirection.Ascending);
        }
        #endregion
    }
}
