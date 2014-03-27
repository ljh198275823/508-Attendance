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
    public partial class FrmShiftMaster : FrmMasterBase
    {
        public FrmShiftMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ContextMenu.Items["mnu_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
            this.ContextMenu.Items["mnu_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmShiftDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<Shift> items = (new ShiftBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            return (from item in items
                    orderby item.ID ascending
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            Shift shift = item as Shift;
            row.Tag = shift;
            row.Cells["colName"].Value = shift.Name;
            row.Cells["colShortName"].Value = shift.ShortName;
            row.Cells["colMemo"].Value = string.Empty;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new ShiftBLL(AppSettings.CurrentSetting.ConnectUri)).Delete(item as Shift);
            if (ret.Result != ResultCode.Successful) MessageBox.Show(ret.Message);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}
