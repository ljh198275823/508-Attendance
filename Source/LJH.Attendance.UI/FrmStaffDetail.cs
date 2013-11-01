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
    public partial class FrmStaffDetail : FrmDetailBase 
    {
        public FrmStaffDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void ItemShowing()
        {
            Staff staff = UpdatingItem as Staff;
            txtName.Text = staff.Name;
            txtCertificate.Text = staff.Certificate;
            if (staff.Department != null) departmentComboBox1.DepartmentID = staff.Department.ID;
            txtUserPosition.Text = staff.UserPosition;
            rdUnResign.Checked = !staff.Resigned;
            rdResign.Checked = staff.Resigned;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as Staff);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as Staff);
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty (txtName .Text ))
            {
                MessageBox.Show("没有设置用户名称",LJH.Attendance.UI.Properties.Resources.Form_Alert,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (departmentComboBox1.SelectecDepartment == null)
            {
                MessageBox.Show("没有设置用户部门",LJH.Attendance.UI.Properties.Resources.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        protected override Object GetItemFromInput()
        {
            Staff info;
            if (UpdatingItem == null)
            {
                info = new Staff();
            }
            else
            {
                info = UpdatingItem as Staff;
            }
            info.Name = txtName.Text;
            info.Certificate = txtCertificate.Text;
            Department dept = departmentComboBox1.SelectecDepartment;
            if (dept != null)
            {
                info.DepartmentID = dept.ID;
                info.Department = dept;
            }
            info.UserPosition = txtUserPosition.Text;
            info.Resigned = rdResign.Checked;
            return info;
        }

        protected override void InitControls()
        {
            base.InitControls();
            this.departmentComboBox1.Init();
            this.btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            FrmFingerResgister frm = new FrmFingerResgister();
            frm.ShowDialog();
        }
    }
}
