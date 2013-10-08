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
    public partial class FrmOTTypeDetail : FrmDetailBase
    {
        public FrmOTTypeDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditOTType);
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
            OTType ct = UpdatingItem as OTType;
            txtName.Text = ct.Name;
            txtMultiple.DecimalValue = ct.Multiple;
            txtMemo.Text = ct.Memo;
        }

        protected override Object GetItemFromInput()
        {
            OTType ct = UpdatingItem as OTType;
            if (IsAdding)
            {
                ct = new OTType();
                ct.ID = txtName.Text;
            }
            ct.Name = txtName.Text;
            ct.Multiple = txtMultiple.DecimalValue;
            ct.Memo = txtMemo.Text;
            return ct;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as OTType);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as OTType);
        }
        #endregion
    }
}
