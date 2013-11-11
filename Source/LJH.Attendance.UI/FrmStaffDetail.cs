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
            txtSex.Text = staff.Sex;
            dtHireDate.Value = staff.HireDate;
            rdUnResign.Checked = !staff.Resigned;
            rdResign.Checked = staff.Resigned;
            StaffPhoto sp = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetPhoto(staff.ID).QueryObject;
            if (sp != null)
            {
                picPhoto.Image = sp.Photo;
            }
        }

        protected override CommandResult AddItem(object addingItem)
        {
            Staff staff = addingItem as Staff;
            CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Add(staff);
            if (ret.Result == ResultCode.Successful && picPhoto.Tag != null)
            {
                CommandResult ret1 = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).SavePhoto(staff.ID, picPhoto.Tag.ToString());
                if (ret1.Result != ResultCode.Successful)
                {
                    MessageBox.Show("人员信息增加成功，但人员照片保存失败，失败原因:" + ret1.Message);
                }
            }
            return ret;
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            Staff staff = updatingItem as Staff;
            CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Update(staff);
            if (ret.Result == ResultCode.Successful && picPhoto.Tag != null)
            {
                CommandResult ret1 = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).SavePhoto(staff.ID, picPhoto.Tag.ToString());
                if (ret1.Result != ResultCode.Successful)
                {
                    MessageBox.Show("人员信息增加成功，但人员照片保存失败，失败原因:" + ret1.Message);
                }
            }
            return ret;
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("没有设置用户名称", LJH.Attendance.UI.Properties.Resources.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (departmentComboBox1.SelectecDepartment == null)
            {
                MessageBox.Show("没有设置用户部门", LJH.Attendance.UI.Properties.Resources.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            info.Sex = txtSex.Text;
            info.UserPosition = txtUserPosition.Text;
            info.HireDate = dtHireDate.Value;
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

        private void btnDelPhoto_Click(object sender, EventArgs e)
        {
            if (UpdatingItem != null)
            {
                Staff staff = UpdatingItem as Staff;
                CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).DeletePhoto(staff.ID);
                if (ret.Result == ResultCode.Successful)
                {
                    picPhoto.Image = null;
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
            else
            {
                picPhoto.Image = null;
            }
        }

        private void btnBrowserPhoto_Click(object sender, EventArgs e)
        {
            if (picPhoto.Image != null)
            {
                MessageBox.Show("员工照片已经存在，请先删除旧照片");
                return;
            }
            try
            {
                OpenFileDialog saveFileDialog1 = new OpenFileDialog();
                saveFileDialog1.Filter = "JPG文件|*.jpg|所有文件(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    picPhoto.Image = Image.FromFile(path);
                    picPhoto.Tag = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
