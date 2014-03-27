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
    public partial class FrmDeviceGroupDetail : FrmDetailBase
    {
        public FrmDeviceGroupDetail()
        {
            InitializeComponent();
        }

        #region 公共属性
        public DeviceGroup ParentGroup { get; set; }
        #endregion

        #region 重写基类方法
        protected override void ItemShowing()
        {
            DeviceGroup info = UpdatingItem as DeviceGroup;
            txtDeptName.Text = info.Name;
            txtMemo.Text = info.Memo;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectUri)).Add(addingItem as DeviceGroup);
            return ret;
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectUri)).Update(updatingItem as DeviceGroup);
            return ret;
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtDeptName.Text))
            {
                MessageBox.Show("名称不能为空", LJH.Attendance.UI.Properties.Resources.Form_Alert,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        protected override Object GetItemFromInput()
        {
            DeviceGroup info;
            if (UpdatingItem == null)
            {
                info = new DeviceGroup();
                info.ParentID = ParentGroup != null ? ParentGroup.ID : null;
            }
            else
            {
                info = UpdatingItem as DeviceGroup;
            }
            info.Name = txtDeptName.Text;
            info.Memo = txtMemo.Text;
            return info;
        }
        #endregion
    }
}
