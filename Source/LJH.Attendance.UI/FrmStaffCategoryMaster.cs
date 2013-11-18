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
    public partial class FrmStaffCategoryMaster : FrmMasterBase
    {
        public FrmStaffCategoryMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaffCategory);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaffCategory);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmStaffCategoryDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<StaffCategory> items = (new StaffCategoryBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            return (from item in items
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            StaffCategory StaffCategory = item as StaffCategory;
            row.Tag = StaffCategory;
            row.Cells["colName"].Value = StaffCategory.Name;
            row.Cells["colMemo"].Value = StaffCategory.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new StaffCategoryBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as StaffCategory);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}