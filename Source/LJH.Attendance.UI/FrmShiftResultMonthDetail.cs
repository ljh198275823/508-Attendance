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
    public partial class FrmShiftResultMonthDetail : Form
    {
        public FrmShiftResultMonthDetail()
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
            for (int i = 0; i < _DateColumns.Count; i++)
            {
                GridView.Columns.Insert(i + 1, _DateColumns[i]);
            }
        }

        private void ShowUserStaffAttendanceResultsOnRow(Staff user, List<AttendanceResult> arranges, DataGridViewRow row)
        {
            row.Cells["colUser"].Value = user.Name;
            row.Cells["colUser"].Tag = user;
            foreach (DataGridViewColumn col in _DateColumns)
            {
                DateTime dt = Convert.ToDateTime(col.Tag);
                List<AttendanceResult> shifts = arranges.Where(item => item.ShiftDate == dt).ToList();
                row.Cells[col.Index].Value = GetShiftString(shifts);
                row.Cells[col.Index].Tag = shifts;
                row.Cells[col.Index].Style.ForeColor = shifts.Exists(it => it.Result != AttendanceResultCode.OK) ? Color.Red : Color.Blue;
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

        #region 事件处理程序
        private void FrmShiftResultStatistics_Load(object sender, EventArgs e)
        {
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.ShowResigedStaff = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();

            InitGridColumns(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            InitGridColumns(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);

            List<Staff> users = departmentTreeview1.SelectedStaff;
            if (users != null && users.Count > 0)
            {
                StaffAttendanceResultSearchCondition con = new StaffAttendanceResultSearchCondition();
                con.ShiftDate = new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
                List<AttendanceResult> arranges = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con).QueryObjects;
                foreach (Staff user in users)
                {
                    List<AttendanceResult> items = arranges.Where(item => item.StaffID == user.ID).ToList();
                    if (items != null && items.Count > 0)
                    {
                        int row = GridView.Rows.Add();
                        ShowUserStaffAttendanceResultsOnRow(user, items, GridView.Rows[row]);
                        arranges.RemoveAll(item => item.StaffID == user.ID);
                    }
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", GridView.Rows.Count);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!_DateColumns.Contains(GridView.Columns[e.ColumnIndex])) return;
            Staff staff = GridView.Rows[e.RowIndex].Cells[0].Tag as Staff;
            DateTime dt = Convert.ToDateTime(GridView.Columns[e.ColumnIndex].Tag);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = this.GridView;
                if (view != null)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel文档|*.xls|所有文件(*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog1.FileName;
                        if (LJH.GeneralLibrary.WinformControl.DataGridViewExporter.Export(view, path, false))
                        {
                            MessageBox.Show("导出成功");
                        }
                        else
                        {
                            MessageBox.Show("保存到电子表格时出现错误!");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (GridView == null) return;
            string keyword = string.Empty;
            if (sender is ToolStripTextBox)
            {
                keyword = (sender as ToolStripTextBox).Text;
            }
            int count = 0;
            DataGridView grid = this.GridView;
            foreach (DataGridViewRow row in grid.Rows)
            {
                bool visible = false;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (
                        string.IsNullOrEmpty(keyword) ||
                        ((row.Cells[col.Index] is DataGridViewTextBoxCell) && row.Cells[col.Index].Value != null && row.Cells[col.Index].Value.ToString().Contains(keyword))
                        )
                    {
                        visible = true;
                        count++;
                        break;
                    }
                }
                row.Visible = visible;
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", count);
        }
        #endregion
    }
}
