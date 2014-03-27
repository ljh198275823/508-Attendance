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
    public partial class FrmStaffCategoryDetail : FrmDetailBase
    {
        public FrmStaffCategoryDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaffCategory);
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("名称不能为空");
                txtName.Focus();
                return false;
            }
            return true;
        }

        protected override void ItemShowing()
        {
            StaffCategory ct = UpdatingItem as StaffCategory;
            txtName.Text = ct.Name;
            txtMemo.Text = ct.Memo;
        }

        protected override Object GetItemFromInput()
        {
            StaffCategory ct = UpdatingItem as StaffCategory;
            if (IsAdding)
            {
                ct = new StaffCategory();
                ct.ID = txtName.Text;
            }
            ct.Name = txtName.Text;
            ct.Memo = txtMemo.Text;
            return ct;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new StaffCategoryBLL(AppSettings.CurrentSetting.ConnectUri)).Add(addingItem as StaffCategory);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new StaffCategoryBLL(AppSettings.CurrentSetting.ConnectUri)).Update(updatingItem as StaffCategory);
        }
        #endregion
    }
}
