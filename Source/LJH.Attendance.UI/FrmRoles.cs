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
    public partial class FrmRoles : FrmMasterBase
    {
        private List<Role> roles;

        public FrmRoles()
        {
            InitializeComponent();
        }

        #region 重写基类方法及事件处理
        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmRoleDetail();
        }
        protected override bool DeletingItem(object item)
        {
            RoleBll bll = new RoleBll(AppSettings.CurrentSetting.ConnectString);
            Role info = (Role)item;
            CommandResult result = bll.Delete(info);
            if (result.Result != ResultCode.Successful)
            {
                MessageBox.Show(result.Message, Resource1.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result.Result == ResultCode.Successful;
        }

        protected override List<object> GetDataSource()
        {
            RoleBll roleBll = new RoleBll(AppSettings.CurrentSetting.ConnectString);
            roles = roleBll.GetAllRoles().QueryObjects.ToList();
            List<object> source = new List<object>();
            foreach (object o in roles)
            {
                source.Add(o);
            }
            return source;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            Role info = item as Role;
            row.Tag = item;
            row.Cells["colName"].Value = info.Name;
            row.Cells["colMemo"].Value = info.Memo;
        }

        protected override void Init()
        {
            base.Init();
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditRole);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditRole);
        }
        #endregion
    }
}
