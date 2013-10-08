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
    public partial class FrmVacationTypeMaster : FrmMasterBase
    {
        public FrmVacationTypeMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditVacationType);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditVacationType);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmVacationTypeDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<VacationType> items = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            return (from item in items
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            VacationType VacationType = item as VacationType;
            row.Tag = VacationType;
            row.Cells["colName"].Value = VacationType.Name;
            row.Cells["colMemo"].Value = VacationType.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as VacationType);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}