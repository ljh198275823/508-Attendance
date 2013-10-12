using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.BLL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;

namespace LJH.Attendance.UI
{
    public partial class FrmDepartmentMaster : Form
    {
        public FrmDepartmentMaster()
        {
            InitializeComponent();
        }

        private Department _UpdatingItem;

        private void FrmDepartmentMaster_Load(object sender, EventArgs e)
        {
            this.departmentTreeview1.Init();
            this.departmentTreeview1.ContextMenuStrip = contextMenuStrip1;
            mnu_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditDepartment);
            mnu_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditDepartment);
            btnSave.Enabled = Operator.CurrentOperator.Permit(Permission.EditDepartment);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentTreeview1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            departmentTreeview1.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Left)
            {
                Department dept = e.Node.Tag as Department;
                if (dept != null)
                {
                    txtDeptID.Text = dept.ID;
                    txtDeptID.Enabled = false;
                    txtDeptName.Text = dept.Name;
                    txtDeptName.Focus();
                    txtMemo.Text = dept.Memo;
                    txtParentID.Text = dept.ParentID;
                    _UpdatingItem = dept;
                }
            }
        }

        private void mnu_Add_Click(object sender, EventArgs e)
        {
            _UpdatingItem = null;
            Department parent = null;
            if (departmentTreeview1.SelectedNode != null) parent = departmentTreeview1.SelectedNode.Tag as Department;
            txtDeptID.Text = (new DepartmentBLL(AppSettings.CurrentSetting.ConnectString)).CreateADeptID(parent);
            txtDeptName.Text = string.Empty;
            txtDeptName.Focus();
            txtMemo.Text = string.Empty;
            txtParentID.Text = parent != null ? parent.ID : string.Empty;
        }

        private void mnu_Delete_Click(object sender, EventArgs e)
        {
            if (departmentTreeview1.SelectedNode != null && departmentTreeview1.SelectedNode.Tag != null)
            {
                DialogResult ret = MessageBox.Show(Resource1.FrmMasterBase_DeleteQuery, Resource1.Form_Query, MessageBoxButtons.YesNo);
                if (ret == DialogResult.Yes)
                {
                    Department dept = departmentTreeview1.SelectedNode.Tag as Department;
                    CommandResult result = (new DepartmentBLL(AppSettings.CurrentSetting.ConnectString)).Delete(dept);
                    if (result.Result == ResultCode.Successful)
                    {
                        departmentTreeview1.SelectedNode.Parent.Nodes.Remove(departmentTreeview1.SelectedNode);
                    }
                    else
                    {
                        MessageBox.Show(result.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Department dept = _UpdatingItem;
            if (dept == null)
            {
                dept = new Department();
            }
            dept.ID = txtDeptID.Text;
            dept.Name = txtDeptName.Text;
            dept.Memo = txtMemo.Text;
            dept.ParentID = txtParentID.Text;
            if (_UpdatingItem == null)
            {
                CommandResult ret = (new DepartmentBLL(AppSettings.CurrentSetting.ConnectString)).Add(dept);
                if (ret.Result == ResultCode.Successful)
                {
                    TreeNode node = new TreeNode(string.Format("[{0}] {1}", dept.ID, dept.Name));
                    node.Tag = dept;
                    if (departmentTreeview1.SelectedNode == null)
                    {
                        departmentTreeview1.Nodes[0].Nodes.Add(node);
                    }
                    else
                    {
                        departmentTreeview1.SelectedNode.Nodes.Add(node);
                    }
                    if (!Operator.CurrentOperator.IsAdmin)
                    {
                        Operator.CurrentOperator.Depts.Add(dept.ID);
                        (new OperatorBll(AppSettings.CurrentSetting.ConnectString)).Update(Operator.CurrentOperator);
                    }
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
            else
            {
                CommandResult ret = (new DepartmentBLL(AppSettings.CurrentSetting.ConnectString)).Update(dept);
                if (ret.Result == ResultCode.Successful)
                {
                    this.departmentTreeview1.SelectedNode.Text = string.Format("[{0}] {1}", dept.ID, dept.Name);
                    this.departmentTreeview1.SelectedNode.Tag = dept;
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
        }
    }
}
