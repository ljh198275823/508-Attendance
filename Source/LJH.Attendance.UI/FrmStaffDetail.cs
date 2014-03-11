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

        #region 私有变量
        private List<StaffBioTemplate> _BioTemplates;

        private void AddTemplateToGrid(StaffBioTemplate sbt)
        {
            int row = templateGrid.Rows.Add();
            templateGrid.Rows[row].Tag = sbt;
            templateGrid.Rows[row].Cells["colBiosource"].Value = sbt.StrBioSource;
            templateGrid.Rows[row].Cells["colVersion"].Value = sbt.Version;
            templateGrid.Rows[row].Cells["colMemo"].Value = sbt.Memo;
        }
        #endregion

        #region 公共属性
        public Department Department { get; set; }
        #endregion

        #region 重写基类方法
        protected override void ItemShowing()
        {
            Staff staff = UpdatingItem as Staff;
            txtName.Text = staff.Name;
            txtCertificate.Text = staff.Certificate;
            if (staff.Department != null) departmentComboBox1.DepartmentID = staff.Department.ID;
            txtUserPosition.Text = staff.UserPosition;
            rdMale.Checked = staff.Sex == "男";
            rdFemale.Checked = staff.Sex == "女";
            dtHireDate.Value = staff.HireDate;
            rdUnResign.Checked = !staff.Resigned;
            rdResign.Checked = staff.Resigned;

            StaffPhoto sp = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetPhoto(staff.ID).QueryObject;
            if (sp != null)
            {
                picPhoto.Image = sp.Photo;
            }

            _BioTemplates = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetBioTemplates(staff.ID).QueryObjects;
            if (_BioTemplates != null && _BioTemplates.Count > 0)
            {
                templateGrid.Rows.Clear();
                foreach (StaffBioTemplate sbt in _BioTemplates)
                {
                    AddTemplateToGrid(sbt);
                }
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
            if (templateGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in templateGrid.Rows)
                {
                    StaffBioTemplate sbt = row.Tag as StaffBioTemplate;
                    sbt.StaffID = staff.ID;
                    CommandResult ret1 = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).SaveTemplate(sbt);
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
            info.Sex = rdMale.Checked ? "男" : "女";
            info.UserPosition = txtUserPosition.Text;
            info.HireDate = dtHireDate.Value;
            info.Resigned = rdResign.Checked;
            return info;
        }

        protected override void InitControls()
        {
            base.InitControls();
            this.departmentComboBox1.Init();
            if (Department != null) this.departmentComboBox1.DepartmentID = Department.ID;
            this.btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
        }
        #endregion

        #region 事件处理程序
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

        private void mnu_AddTemplate_Click(object sender, EventArgs e)
        {
            FrmFingerResgister frm = new FrmFingerResgister();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                StaffBioTemplate sbt = new StaffBioTemplate();
                sbt.ID = Guid.NewGuid();
                sbt.BioSource = (BioSource)frm.BioSource;
                sbt.Version = frm.Version;
                sbt.Template = frm.Template;
                sbt.IsBiokey = true;
                if (UpdatingItem != null)
                {
                    Staff staff = UpdatingItem as Staff;
                    sbt.StaffID = staff.ID;
                    CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).SaveTemplate(sbt);
                    if (ret.Result != ResultCode.Successful)
                    {
                        MessageBox.Show(ret.Message);
                    }
                    else
                    {
                        AddTemplateToGrid(sbt);
                    }
                }
                else
                {
                    AddTemplateToGrid(sbt);
                }
            }
        }

        private void mnu_DelTemplate_Click(object sender, EventArgs e)
        {
            if (UpdatingItem != null)
            {
                foreach (DataGridViewRow row in templateGrid.SelectedRows)
                {
                    StaffBioTemplate sbt = row.Tag as StaffBioTemplate;
                    CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).DeleteTemplate(sbt);
                    if (ret.Result != ResultCode.Successful)
                    {
                        MessageBox.Show(ret.Message);
                    }
                    else
                    {
                        templateGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in templateGrid.SelectedRows)
                {
                    templateGrid.Rows.Remove(row);
                }

            }
        }
        #endregion
    }
}
