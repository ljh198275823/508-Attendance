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
    public partial class FrmTripTypeDetail : FrmDetailBase
    {
        public FrmTripTypeDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditTripType);
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
            TripType ct = UpdatingItem as TripType;
            txtName.Text = ct.Name;
            txtMemo.Text = ct.Memo;
        }

        protected override Object GetItemFromInput()
        {
            TripType ct = UpdatingItem as TripType;
            if (IsAdding)
            {
                ct = new TripType();
                ct.ID = txtName.Text;
            }
            ct.Name = txtName.Text;
            ct.Memo = txtMemo.Text;
            return ct;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new TripTypeBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as TripType);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new TripTypeBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as TripType);
        }
        #endregion
    }
}
