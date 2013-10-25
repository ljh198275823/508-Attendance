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
    public partial class FrmReaderMaster : FrmMasterBase 
    {
        public FrmReaderMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            //btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditReader);
            //btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditReader);
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmReaderDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<Reader> items = (new ReaderBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            return (from item in items
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            Reader reader = item as Reader;
            row.Tag = item;
            row.Cells["colCheck"].Value = reader.ForAttendance;
            row.Cells["colID"].Value = reader.ID;
            row.Cells["colName"].Value = reader.Name;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new ReaderBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as Reader);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}
