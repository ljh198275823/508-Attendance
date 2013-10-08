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
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmShiftDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<Shift> items = (new ShiftBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
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
            row.Cells["colStartTime"].Value = shift.StartTime.ToString();
            row.Cells["colEndTime"].Value = shift.NextDay ? "第二天 " + shift.EndTime.ToString() : shift.EndTime.ToString();
            row.Cells["colBeforeStartTime"].Value = shift.BeforeStartTime;
            row.Cells["colAfterEndTime"].Value = shift.AfterEndTime;
            row.Cells["colShiftTime"].Value = shift.ShiftDuration;
            row.Cells["colMemo"].Value = string.Empty;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new ShiftBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as Shift);
            if (ret.Result != ResultCode.Successful) MessageBox.Show(ret.Message);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}
