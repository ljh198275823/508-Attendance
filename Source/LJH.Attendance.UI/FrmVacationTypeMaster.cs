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
            this.ContextMenu.Items["mnu_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditVacationType);
            this.ContextMenu.Items["mnu_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditVacationType);
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditVacationType);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditVacationType);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmVacationTypeDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<VacationType> items = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
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
            CommandResult ret = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectUri)).Delete(item as VacationType);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}