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
using Ralid.Attendance.BLL;

namespace Ralid.Attendance.UI
{
    public partial class FrmRoleDetail : FrmDetailBase
    {
        private RoleBll bll = new RoleBll(AppSettings.CurrentSetting.ConnectString);

        public FrmRoleDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                MessageBox.Show(Resource1.FrmRoleDetail_InvalidRoleID);
                return false;
            }
            return true;
        }

        protected override void InitControls()
        {
            this.funcTree.Init();
            if (IsAdding)
            {
                this.Text = Resource1.Form_Add;
            }
            Role role = Operator.CurrentOperator.Role;
            this.btnOk.Enabled = role.Permit(Permission.EditRole);
        }

        protected override void ItemShowing()
        {
            Role info = (Role)UpdatingItem;
            this.txtName.Text = info.Name;
            this.txtName.BackColor = Color.White;
            this.txtDescription.Text = info.Memo;
            this.funcTree.SelectedRights = info.IsAdmin ? "all" : info.RWPermission;
            this.funcTree.Enabled = info.CanEdit;//角色不可编辑,用于系统管理员,用户不可以更改
        }

        protected override object GetItemFromInput()
        {
            Role info;
            if (UpdatingItem == null)
            {
                info = new Role();
                info.ID = this.txtName.Text.Trim();
            }
            else
            {
                info = UpdatingItem as Role;
            }
            info.Name = this.txtName.Text.Trim();
            info.Memo = this.txtDescription.Text;
            info.RWPermission = this.funcTree.SelectedRights;
            return info;
        }

        protected override CommandResult AddItem(object item)
        {
            return bll.Add((Role)item);
        }

        protected override CommandResult UpdateItem(object item)
        {
            return bll.Update(item as Role);
        }
        #endregion
    }
}
