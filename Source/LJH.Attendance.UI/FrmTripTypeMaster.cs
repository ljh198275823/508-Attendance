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
    public partial class FrmTripTypeMaster : FrmMasterBase
    {
        public FrmTripTypeMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ContextMenu.Items["mnu_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditTripType);
            this.ContextMenu.Items["mnu_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditTripType);
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditTripType);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditTripType);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmTripTypeDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<TripType> items = (new TripTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            return (from item in items
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            TripType TripType = item as TripType;
            row.Tag = TripType;
            row.Cells["colName"].Value = TripType.Name;
            row.Cells["colMemo"].Value = TripType.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new TripTypeBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as TripType);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}