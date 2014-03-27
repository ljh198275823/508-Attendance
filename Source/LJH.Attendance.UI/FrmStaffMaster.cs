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
    public partial class FrmStaffMaster : FrmMasterBase
    {
        public FrmStaffMaster()
        {
            InitializeComponent();
        }

        #region 私有变量
        private string _SelectedDept;
        private List<Staff> _AllStaff;
        #endregion

        #region 私有方法
        private void SelectNode(TreeNode node)
        {
            if (!object.ReferenceEquals(departmentTreeview1.SelectedNode, node))
            {
                if (departmentTreeview1.SelectedNode != null)
                {
                    departmentTreeview1.SelectedNode.BackColor = Color.White;
                    departmentTreeview1.SelectedNode.ForeColor = Color.Black;
                }
                departmentTreeview1.SelectedNode = node;
                departmentTreeview1.SelectedNode.BackColor = Color.Blue;  //Color.FromArgb(128, 128, 255);
                departmentTreeview1.SelectedNode.ForeColor = Color.White;

                Department dept = node.Tag as Department;
                _SelectedDept = dept != null ? dept.ID : null;
                List<object> items = null;
                if (!string.IsNullOrEmpty(_SelectedDept))
                {
                    items = (from staff in _AllStaff
                             where staff.DepartmentID == _SelectedDept
                             orderby staff.Name ascending
                             select (object)staff).ToList();
                }
                else
                {
                    items = (from staff in _AllStaff
                             orderby staff.Name ascending
                             select (object)staff).ToList();
                }
                ShowItemsOnGrid(items);
            }
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            departmentTreeview1.Init();
            this.ContextMenu.Items["mnu_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
            this.ContextMenu.Items["mnu_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            FrmStaffDetail frm = new FrmStaffDetail();
            if (departmentTreeview1.SelectedNode != null) frm.Department = departmentTreeview1.SelectedNode.Tag as Department;
            return frm;
        }

        protected override List<object> GetDataSource()
        {
            _AllStaff = (new StaffBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects.ToList();
            if (Operator.CurrentOperator.ID.ToUpper() != "ADMIN" && Operator.CurrentOperator.Depts != null)
            {
                _AllStaff = _AllStaff.Where(it => Operator.CurrentOperator.Depts.Contains(it.DepartmentID)).ToList();
            }
            if (!string.IsNullOrEmpty(_SelectedDept))
            {
                return (from staff in _AllStaff
                        where staff.DepartmentID == _SelectedDept
                        orderby staff.Name ascending
                        select (object)staff).ToList();
            }
            else
            {
                return (from staff in _AllStaff
                        orderby staff.Name ascending
                        select (object)staff).ToList();
            }
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            Staff info = item as Staff;
            row.Tag = info;
            row.Cells["colName"].Value = info.Name;
            row.Cells["colCardID"].Value = info.CardID;
            row.Cells["colDepartment"].Value = info.Department != null ? info.Department.Name : string.Empty;
            row.Cells["colCertificate"].Value = info.Certificate;
            row.Cells["colUserPosition"].Value = info.UserPosition;
            row.Cells["colSex"].Value = info.Sex;
            row.Cells["colIsAdmin"].Value = info.IsAdmin != null && info.IsAdmin.Value ? "是" : string.Empty;
            row.Cells["colHireDate"].Value = info.HireDate.ToString("yyyy-MM-dd");
            row.Cells["colResigned"].Value = info.Resigned ? "离职" : string.Empty;
            row.DefaultCellStyle.ForeColor = info.Resigned ? Color.Red : Color.Black;
        }

        protected override bool DeletingItem(object item)
        {
            Staff info = (Staff)item;
            CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectUri)).Delete(info);
            if (ret.Result != ResultCode.Successful)
            {
                MessageBox.Show(ret.Message, LJH.Attendance.UI.Properties.Resources.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret.Result == ResultCode.Successful;
        }
        #endregion

        #region 事件处理程序
        private void departmentTreeview1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectNode(e.Node);
        }

        private void GridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Operator.CurrentOperator.Permit(Permission.EditStaff))  //是否有编辑员工信息的权限
            {
                if (e.Button == MouseButtons.Left && e.ColumnIndex == 0 && e.RowIndex >= 0) //按住网格第一列时才可以拖动
                {
                    List<Staff> staff = new List<Staff>();
                    foreach (DataGridViewRow row in GridView.SelectedRows)
                    {
                        if (row.Tag != null) staff.Add(row.Tag as Staff);
                    }
                    if (staff.Count > 0)
                    {
                        GridView.DoDragDrop((object)staff, DragDropEffects.Copy | DragDropEffects.Move);
                    }
                }
            }
        }

        private void departmentTreeview1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect != DragDropEffects.None) e.Effect = DragDropEffects.Copy;
        }

        private void departmentTreeview1_DragDrop(object sender, DragEventArgs e)
        {
            Point p = departmentTreeview1.PointToClient(new Point(e.X, e.Y));
            TreeNode node = departmentTreeview1.GetNodeAt(p);
            if (node != null && (node.Tag == null || node.Tag is Department))
            {
                string[] s = e.Data.GetFormats();
                if (s.Length > 0)
                {
                    object o = e.Data.GetData(s[0]);
                    if (o is List<Staff>)
                    {
                        Department dept = node.Tag as Department;
                        List<Staff> staff = o as List<Staff>;
                        if (staff != null && staff.Count > 0)
                        {
                            StaffBLL bll = new StaffBLL(AppSettings.CurrentSetting.ConnectUri);
                            foreach (Staff st in staff)
                            {
                                st.DepartmentID = dept.ID;
                                st.Department = dept;
                                bll.Update(st);
                            }
                        }
                    }
                }
                SelectNode(node);
            }
        }
        #endregion
    }
}
