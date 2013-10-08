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
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<Staff> _AllStaff;
        #endregion

        #region 私有方法
        private void FreshUnGroupedStaff()
        {
            dataGridView1.Rows.Clear();
            if (_AllStaff != null && _AllStaff.Count > 0)
            {
                List<Staff> staff = _AllStaff.Where(item => item.DepartmentID == null).ToList();
                if (staff != null && staff.Count > 0)
                {
                    foreach (Staff item in staff)
                    {
                        int row = dataGridView1.Rows.Add();
                        dataGridView1.Rows[row].Tag = item;
                        dataGridView1.Rows[row].Cells["colID1"].Value = item.ID;
                        dataGridView1.Rows[row].Cells["colName1"].Value = item.Name;
                        dataGridView1.Rows[row].Cells["colUserPosition1"].Value = item.UserPosition;
                        dataGridView1.Rows[row].Cells["colMemo1"].Value = item.Memo;
                    }
                }
            }
            txtKeyWord_TextChanged(null, null);
        }

        private void SetCurrentDepartment(Department dept)
        {
            GridView.Rows.Clear();
            List<Staff> staff = null;
            if (SystemOptions.Current.UsingACSDept)
            {
                staff = _AllStaff.Where(item => item.ACSDepartmentID == dept.ID).ToList();
            }
            else
            {
                staff = _AllStaff.Where(item => item.DepartmentID == dept.ID).ToList();
            }
            foreach (Staff item in staff)
            {
                int row = GridView.Rows.Add();
                GridView.Rows[row].Tag = item;
                GridView.Rows[row].Cells["colID"].Value = item.ID;
                GridView.Rows[row].Cells["colName"].Value = item.Name;
                GridView.Rows[row].Cells["colUserPosition"].Value = item.UserPosition;
                GridView.Rows[row].Cells["colMemo"].Value = item.Memo;
            }
            this.toolStripStatusLabel1.Text = string.Format("{1}   总共 {0} 项", GridView.Rows.Count, dept.Name);
            contextMenuStrip2.Items["mnu_Add"].Text = "添加到 " + dept.Name;
            contextMenuStrip2.Items["mnu_Add"].Visible = true;
        }

        private List<Staff> GetSelectedStaff(DataGridView grid)
        {
            List<Staff> items = new List<Staff>();
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                items.Add(row.Tag as Staff);
            }
            return items;
        }
        #endregion

        #region 事件处理程序
        private void FrmStaff_Load(object sender, EventArgs e)
        {
            GridView.ContextMenuStrip = SystemOptions.Current.UsingACSDept ? null : contextMenuStrip1; //右键菜单
            panel3.Visible = SystemOptions.Current.UsingACSDept ? false : true; //未归组人员容器
            departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            departmentTreeview1.Init();
            _AllStaff = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            FreshUnGroupedStaff();

            mnu_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
            mnu_Remove.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
        }

        private void departmentTreeview1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!object.ReferenceEquals(departmentTreeview1.SelectedNode, e.Node))
            {
                departmentTreeview1.SelectedNode.BackColor = Color.White;
                departmentTreeview1.SelectedNode.ForeColor = Color.Black;
                departmentTreeview1.SelectedNode = e.Node;
                departmentTreeview1.SelectedNode.BackColor = Color.Blue;  //Color.FromArgb(128, 128, 255);
                departmentTreeview1.SelectedNode.ForeColor = Color.White;

                Department dept = e.Node.Tag as Department;
                if (dept != null && _AllStaff != null)
                {
                    SetCurrentDepartment(dept);
                }
                else
                {
                    GridView.Rows.Clear();
                    this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", GridView.Rows.Count);
                    contextMenuStrip2.Items["mnu_Add"].Visible = false;
                }
            }
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

        private void mnu_Add_Click(object sender, EventArgs e)
        {
            TreeNode node = departmentTreeview1.SelectedNode;
            Department dept = node.Tag as Department;
            if (dept != null)
            {
                List<Staff> items = GetSelectedStaff(dataGridView1);
                if (items != null && items.Count > 0)
                {
                    foreach (Staff item in items)
                    {
                        item.DepartmentID = dept.ID;
                        CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Update(item);
                    }
                }
                FreshUnGroupedStaff();
                SetCurrentDepartment(dept);
            }
            else
            {
                MessageBox.Show("没有指定当前部门，请指定一个部门");
            }
        }

        private void mnu_Remove_Click(object sender, EventArgs e)
        {
            List<Staff> items = GetSelectedStaff(GridView);
            if (items != null && items.Count > 0)
            {
                foreach (Staff item in items)
                {
                    item.DepartmentID = null;
                    CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Update(item);
                }
            }
            FreshUnGroupedStaff();
            TreeNode node = departmentTreeview1.SelectedNode;
            Department dept = node.Tag as Department;
            if (dept != null)
            {
                SetCurrentDepartment(dept);
            }
        }

        private void GridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    DataGridView grid = sender as DataGridView;
                    if (grid != null)
                    {
                        if (!grid.Rows[e.RowIndex].Selected)
                        {
                            foreach (DataGridViewRow row in grid.Rows)
                            {
                                row.Selected = false;
                            }
                            grid.Rows[e.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }
        #endregion
    }
}
