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
    public partial class FrmShiftDetail : FrmDetailBase
    {
        public FrmShiftDetail()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void ShowShiftItemOnRow(DataGridViewRow row, ShiftItem item)
        {
            row.Tag = item;
            row.Cells["colStartTime"].Value = item.StartTime.ToString();
            row.Cells["colEndTime"].Value = item.NextDay ? "第二天 " + item.EndTime.ToString() : item.EndTime.ToString();
            row.Cells["colBeforeStartTime"].Value =(int) item.BeforeStartTime;
            row.Cells["colAfterEndTime"].Value = (int)item.AfterEndTime;
            row.Cells["colAllowLateTime"].Value = (int)item.AllowLateTime;
            row.Cells["colAllowLeaveEarlyTime"].Value = (int)item.AllowLeaveEarlyTime;
            row.Cells["colDuration"].Value = (int)item.Duration;
        }

        private void AddShiftItemToGridView(ShiftItem item)
        {
            bool exists = false;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                ShiftItem si = row.Tag as ShiftItem;
                if (si.ID == item.ID)
                {
                    ShowShiftItemOnRow(row, item);
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                int row = dataGridView1.Rows.Add();
                ShowShiftItemOnRow(dataGridView1.Rows[row], item);
            }
        }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
            this.dataGridView1.ContextMenuStrip = Operator.CurrentOperator.Permit(Permission.EditShift) ? contextMenuStrip1 : null;
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("班次名称不能为空");
                txtName.Focus();
                return false;
            }
            return true;
        }

        protected override void ItemShowing()
        {
            Shift shift = UpdatingItem as Shift;
            if (shift == null) return;
            txtName.Text = shift.Name;
            txtShortName.Text = shift.ShortName;
            this.dataGridView1.Rows.Clear();
            if (shift.Items != null && shift.Items.Count > 0)
            {
                foreach (ShiftItem item in shift.Items)
                {
                    int row = dataGridView1.Rows.Add();
                    ShowShiftItemOnRow(dataGridView1.Rows[row], item);
                }
            }
        }

        protected override object GetItemFromInput()
        {
            Shift shift = UpdatingItem as Shift;
            if (shift == null)
            {
                shift = new Shift();
            }
            shift.Name = txtName.Text;
            shift.ShortName = txtShortName.Text;
            if (shift.Items == null) shift.Items = new List<ShiftItem>();
            shift.Items.Clear();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                shift.Items.Add(row.Tag as ShiftItem);
            }
            return shift;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new ShiftBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as Shift);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new ShiftBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as Shift);
        }
        #endregion

        private void mnu_Add_Click(object sender, EventArgs e)
        {
            FrmShiftItemDetail frm = new FrmShiftItemDetail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShiftItem item = frm.ShiftItem;
                item.ID = Guid.NewGuid();
                AddShiftItemToGridView(item);
            }
        }

        private void mnu_Delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows != null && this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    this.dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShiftItem item = dataGridView1.Rows[e.RowIndex].Tag as ShiftItem;
                FrmShiftItemDetail frm = new FrmShiftItemDetail();
                frm.ShiftItem = item;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ShiftItem item1 = frm.ShiftItem;
                    AddShiftItemToGridView(item1);
                }
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    if (!dataGridView1.Rows[e.RowIndex].Selected)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Selected = false;
                        }
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                }
            }
        }
    }
}
