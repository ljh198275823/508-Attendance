﻿using System;
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
    public partial class FrmShiftTemplateMaster : FrmMasterBase
    {
        public FrmShiftTemplateMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditShiftTemplate);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditShiftTemplate);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmShiftTemplateDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<ShiftArrangeTemplate> items = (new ShiftArrangeTemplateBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            return (from item in items
                    orderby item.ID ascending
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            ShiftArrangeTemplate st = item as ShiftArrangeTemplate;
            row.Tag = st;
            row.Cells["colName"].Value = st.Name;
            row.Cells["colMemo"].Value = st.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new ShiftArrangeTemplateBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as ShiftArrangeTemplate);
            if (ret.Result != ResultCode.Successful) MessageBox.Show(ret.Message);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}
