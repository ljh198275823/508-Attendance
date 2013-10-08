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
    public partial class FrmVacationTypeDetail : FrmDetailBase
    {
        public FrmVacationTypeDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditVacationType);
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
            VacationType ct = UpdatingItem as VacationType;
            txtName.Text = ct.Name;
            txtMemo.Text = ct.Memo;
        }

        protected override Object GetItemFromInput()
        {
            VacationType ct = UpdatingItem as VacationType;
            if (IsAdding)
            {
                ct = new VacationType();
                ct.ID = txtName.Text;
            }
            ct.Name = txtName.Text;
            ct.Memo = txtMemo.Text;
            return ct;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as VacationType);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as VacationType);
        }
        #endregion
    }
}
