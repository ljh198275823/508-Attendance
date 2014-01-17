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

        #region 重写基类方法和处理事件
        protected override void Init()
        {
            base.Init();
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
            _AllStaff = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects.ToList();
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
            row.Cells["colDepartment"].Value = info.Department != null ? info.Department.Name : string.Empty;
            row.Cells["colCertificate"].Value = info.Certificate;
            row.Cells["colUserPosition"].Value = info.UserPosition;
            row.Cells["colSex"].Value = info.Sex;
            row.Cells["colHireDate"].Value = info.HireDate.ToString("yyyy-MM-dd");
            row.Cells["colResigned"].Value = info.Resigned ? "离职" : string.Empty;
            row.DefaultCellStyle.ForeColor = info.Resigned ? Color.Red : Color.Black;
            row.Cells["colMemo"].Value = info.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            Staff info = (Staff)item;
            CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Delete(info);
            if (ret.Result != ResultCode.Successful)
            {
                MessageBox.Show(ret.Message, LJH.Attendance.UI.Properties.Resources.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret.Result == ResultCode.Successful;
        }
        #endregion

        private void departmentTreeview1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!object.ReferenceEquals(departmentTreeview1.SelectedNode, e.Node))
            {
                if (departmentTreeview1.SelectedNode != null)
                {
                    departmentTreeview1.SelectedNode.BackColor = Color.White;
                    departmentTreeview1.SelectedNode.ForeColor = Color.Black;
                }
                departmentTreeview1.SelectedNode = e.Node;
                departmentTreeview1.SelectedNode.BackColor = Color.Blue;  //Color.FromArgb(128, 128, 255);
                departmentTreeview1.SelectedNode.ForeColor = Color.White;

                Department dept = e.Node.Tag as Department;
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
    }
}
