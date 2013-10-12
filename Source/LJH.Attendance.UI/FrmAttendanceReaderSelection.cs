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
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmAttendanceReaderSelection : Form
    {
        public FrmAttendanceReaderSelection()
        {
            InitializeComponent();
        }

        private void FrmAttendanceDoors_Load(object sender, EventArgs e)
        {
            List<Reader> items = (new ReaderBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            List<AttendanceReader> readers = (new AttendanceReaderBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            foreach (Reader item in items)
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Tag = item;
                dataGridView1.Rows[row].Cells["colCheck"].Value = readers.Exists(it => it.ID == item.ID);
                dataGridView1.Rows[row].Cells["colID"].Value = item.ID;
                dataGridView1.Rows[row].Cells["colName"].Value = item.Name;
            }
            this.dataGridView1.Rows[0].Selected = false;
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", dataGridView1.Rows.Count);
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text;
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool visible = false;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "colCheck")
            {
                DataGridViewCheckBoxCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool value = Convert.ToBoolean(cell.EditingCellFormattedValue);
                Reader reader = dataGridView1.Rows[e.RowIndex].Tag as Reader;
                AttendanceReader ar = new AttendanceReader() { ID = reader.ID, Name = reader.Name };
                if (value)
                {
                    (new AttendanceReaderBLL(AppSettings.CurrentSetting.ConnectString)).Add(ar);
                }
                else
                {
                    (new AttendanceReaderBLL(AppSettings.CurrentSetting.ConnectString)).Delete(ar);
                }
            }
        }
    }
}
