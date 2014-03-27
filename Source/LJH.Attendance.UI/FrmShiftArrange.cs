using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance .Model .SearchCondition ;
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmShiftArrange : Form
    {
        public FrmShiftArrange()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<DataGridViewColumn> _DateColumns = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _ShiftColumns = new List<DataGridViewColumn>();
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
                col.Width = 30;
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
            for (int i = 0; i < _DateColumns.Count; i++)
            {
                GridView.Columns.Insert(i + 1, _DateColumns[i]);
            }
        }

        private void ShowUserShiftArrangesOnRow(Staff user, List<ShiftArrange> arranges, DataGridViewRow row)
        {
            row.Cells["colUser"].Value = user.Name;
            row.Tag = user;
            foreach (DataGridViewColumn col in _DateColumns)
            {
                DateTime dt = Convert.ToDateTime(col.Tag);
                List<Shift> shifts = null;
                if (arranges != null && arranges.Count > 0)
                {
                    shifts = arranges.Where(item => item.ShiftDate == dt).Select(item => item.Shift).ToList();
                }
                row.Cells[col.Index].Value = GetShiftString(shifts);
                row.Cells[col.Index].Tag = shifts;
            }
        }

        private string GetShiftString(List<Shift> items)
        {
            if (items == null || items.Count == 0) return string.Empty;
            string ret = string.Empty;
            int count = 0;
            foreach (Shift item in items)
            {
                if (count > 0) ret += ",";
                ret += !string.IsNullOrEmpty(item.ShortName) ? item.ShortName : item.Name;
                count++;
            }
            return ret;
        }

        private Point GetFrmSelectionPosition(Rectangle editCell, Form frm)
        {
            Rectangle r = Screen.FromHandle(this.Handle).WorkingArea;
            Point p = GridView.PointToScreen(editCell.Location);
            if (p.X + frm.Width > r.Width)
            {
                p.X -= frm.Width;
            }
            if (p.Y + editCell.Height + frm.Height <= r.Height)
            {
                p.Y += editCell.Height;
            }
            else
            {
                p.Y -= frm.Height;
            }
            return p;
        }
        #endregion

        #region 事件处理程序
        private void FrmShiftArrange_Load(object sender, EventArgs e)
        {
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();

            InitGridColumns(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);

            mnu_CopyToOtherDate.Enabled = Operator.CurrentOperator.Permit(Permission.ShiftArrange);
            mnu_CopyToOtherStaff.Enabled = Operator.CurrentOperator.Permit(Permission.ShiftArrange);
            mnu_ApplyTemplate.Enabled = Operator.CurrentOperator.Permit(Permission.ShiftArrange);
            mnu_Clear.Enabled = Operator.CurrentOperator.Permit(Permission.ShiftArrange);
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            InitGridColumns(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);

            List<Staff> users = departmentTreeview1.SelectedStaff;
            if (users != null && users.Count > 0)
            {
                ShiftArrangeSearchCondition con = new ShiftArrangeSearchCondition();
                con.ShiftDate = new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
                List<ShiftArrange> arranges = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(con).QueryObjects;
                foreach (Staff user in users)
                {
                    int row = GridView.Rows.Add();
                    List<ShiftArrange> items = arranges.Where(item => item.StaffID == user.ID).ToList();
                    ShowUserShiftArrangesOnRow(user, items, GridView.Rows[row]);
                    arranges.RemoveAll(item => item.StaffID == user.ID);
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", GridView.Rows.Count);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!_DateColumns.Contains(GridView.Columns[e.ColumnIndex])) return;
            if (!Operator.CurrentOperator.Permit(Permission.ShiftArrange)) return;
            Staff staff = GridView.Rows[e.RowIndex].Tag as Staff;
            DateTime dt = Convert.ToDateTime(GridView.Columns[e.ColumnIndex].Tag);
            if (staff.HireDate.Date > dt.Date) return;  //人员入职日期之前不必排班
            List<Shift> shifts = GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag as List<Shift>;
            FrmShiftSelection frm = new FrmShiftSelection();
            frm.SelectedShifts = shifts;
            frm.StartPosition = FormStartPosition.Manual;
            //让选择窗体刚好位于单元格下方,或者当下方显示不下时显示在上方
            Rectangle r = GridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            frm.Location = GetFrmSelectionPosition(r, frm);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Shift> selectedItems = frm.SelectedShifts;
                CommandResult ret = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectUri)).ShiftArrange(staff.ID, dt, selectedItems);
                if (ret.Result == ResultCode.Successful)
                {
                    GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = GetShiftString(selectedItems);
                    GridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = selectedItems;
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
        }

        private void mnu_CopyToOtherDate_Click(object sender, EventArgs e)
        {
            if (GridView.SelectedCells != null && GridView.SelectedCells.Count == 1)
            {
                DataGridViewCell cell = GridView.SelectedCells[0];
                if (_DateColumns.Contains(GridView.Columns[cell.ColumnIndex]))
                {
                    DateTime dt = Convert.ToDateTime(GridView.Columns[cell.ColumnIndex].Tag);
                    Staff staff = GridView.Rows[cell.RowIndex].Tag as Staff;
                    List<Shift> shifts = cell.Tag as List<Shift>;
                    FrmCopyToDate frm = new FrmCopyToDate();
                    frm.Staff = staff;
                    frm.SourceDate = dt;
                    frm.SourceShifts = shifts;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ShiftArrangeSearchCondition con = new ShiftArrangeSearchCondition();
                        con.StaffID = staff.ID;
                        con.ShiftDate = new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
                        List<ShiftArrange> items = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(con).QueryObjects;
                        ShowUserShiftArrangesOnRow(staff, items, GridView.Rows[cell.RowIndex]);
                    }
                }
            }
        }

        private void mnu_Clear_Click(object sender, EventArgs e)
        {
            List<ShiftArrange> sas = new List<ShiftArrange>();
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                if (cell.Tag is List<Shift>) //人员排班的单元格
                {
                    DateTime dt = Convert.ToDateTime(GridView.Columns[cell.ColumnIndex].Tag);
                    Staff staff = GridView.Rows[cell.RowIndex].Tag as Staff;
                    List<Shift> shifts = cell.Tag as List<Shift>;
                    foreach (Shift shift in shifts)
                    {
                        ShiftArrange sa = new ShiftArrange();
                        sa.StaffID = staff.ID;
                        sa.ShiftDate = dt;
                        sa.ShiftID = shift.ID;
                        sa.Shift = shift;
                        sas.Add(sa);
                    }
                }
            }
            ShiftArrangeBLL bll = new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectUri);
            CommandResult ret = bll.Delete(sas);
            btnFresh_Click(btnFresh, EventArgs.Empty);
        }
        #endregion

        private void mnu_CopyToOtherStaff_Click(object sender, EventArgs e)
        {
            FrmCopyToOtherStaff frm = new FrmCopyToOtherStaff();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                btnFresh.PerformClick();
            }
        }

        private void mnu_ApplyTemplate_Click(object sender, EventArgs e)
        {
            FrmShiftTemplateApply frm = new FrmShiftTemplateApply();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                btnFresh.PerformClick();
            }
        }
    }
}
