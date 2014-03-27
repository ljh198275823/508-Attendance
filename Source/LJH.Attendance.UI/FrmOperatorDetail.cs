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
    public partial class FrmOperatorDetail:FrmDetailBase 
    {
        private OperatorBll bll = new OperatorBll(AppSettings.CurrentSetting.ConnectUri); 
        private string _subPwd = new string('*', 10);

        public FrmOperatorDetail()
        {
            InitializeComponent();
        }

        #region 重写基类的方法
        protected override void InitControls()
        {
            comRoleList.Init();
            departmentTreeview1.Init();
            if (IsAdding)
            {
                this.Text =LJH.Attendance.UI.Properties.Resources.Form_Add;
                this.btnChangePwd.Visible = false;
                this.txtPassword.Size = this.txtOperatorName.Size;
            }
            Role role = Operator.CurrentOperator.Role;
            this.btnOk.Enabled = role.Permit(Permission.EditOperator);
        }

        protected override void ItemShowing()
        {
            Operator info = (Operator)UpdatingItem;
            this.txtOperatorID.Text = info.ID;
            this.txtOperatorID.Enabled = false;
            this.txtOperatorID.BackColor = Color.White;
            this.txtOperatorName.Text = info.Name;
            this.txtPassword.Text = _subPwd;
            this.txtPassword.Enabled = false;
            this.txtPassword.BackColor = Color.White;
            this.comRoleList.SelectedRoleID = info.RoleID;
            this.Text = info.ID;

            if (info.IsAdmin)
            {
                this.departmentTreeview1.SelectAllDepts();
            }
            else
            {
                this.departmentTreeview1.SelectDepts(info.Depts);
            }
            this.departmentTreeview1.Enabled = !info.IsAdmin;
            this.comRoleList.Enabled = !info.IsAdmin;
        }

        protected override object GetItemFromInput()
        {
            Operator info = null;
            if (CheckInput())
            {
                if (IsAdding)
                {
                    info = new Operator();
                    info.Password = txtPassword.Text.Trim();
                }
                else
                {
                    info = UpdatingItem as Operator;
                    if (txtPassword.Text.Trim() != _subPwd)
                    {
                        info.Password = txtPassword.Text.Trim();
                    }
                }
                info.ID = txtOperatorID.Text.Trim();
                info.Name = txtOperatorName.Text.Trim();
                info.Role = comRoleList.Role;
                info.RoleID = comRoleList.SelectedRoleID;
                List<Department> depts = departmentTreeview1.SelectedDepartments;
                info.Depts = depts.Select(item => item.ID).ToList();
            }
            return info;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return bll.Insert((Operator)addingItem);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return  bll.Update(updatingItem as Operator );
        }

        protected override bool CheckInput()
        {
            if (txtOperatorID.Text.Trim().Length == 0)
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmOperatorDetail_InvalidUserID);
                return false;
            }

            if (txtOperatorName.Text.Trim().Length == 0)
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmOperatorDetail_InvalidUserName);
                return false;
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmOperatorDetail_InvalidPwd);
                return false;
            }
            return true;
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            FrmChangePwd frm = new FrmChangePwd();
            frm.Operator = UpdatingItem as Operator;
            frm.ShowDialog();
        }
        #endregion
    }
}
