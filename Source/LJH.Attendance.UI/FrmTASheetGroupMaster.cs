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
using LJH.Attendance.Model.SearchCondition;

namespace LJH.Attendance.UI
{
    public partial class FrmTASheetGroupMaster : FrmMasterBase
    {
        public FrmTASheetGroupMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.dataGridView1.ContextMenuStrip = null; //不要显示右键菜单
            btn_OTSheet.Enabled = Operator.CurrentOperator.Permit(Permission.EditTASheet);
            btn_VacationSheet.Enabled = Operator.CurrentOperator.Permit(Permission.EditTASheet);
            btn_TripSheet.Enabled = Operator.CurrentOperator.Permit(Permission.EditTASheet);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditTASheet);
        }
        protected override FrmDetailBase GetDetailForm()
        {
            FrmTASheetGroupDetail frm = new FrmTASheetGroupDetail();
            frm.SheetType = "A";
            return frm;
        }

        protected override List<object> GetDataSource()
        {
            TASheetSearchCondition con = new TASheetSearchCondition();
            List<TASheet> items = (new TASheetBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con).QueryObjects;
            List<TASheetGroup> groups = TASheetGroup.Group(items);
            if (groups != null)
            {
                return (from item in groups
                        orderby item.StartDate descending
                        select (object)item).ToList();
            }
            else
            {
                return null;
            }
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            TASheetGroup group = item as TASheetGroup;
            row.Tag = group;
            row.Cells["colStartDate"].Value = group.StartDate.ToLongDateString();
            row.Cells["colEndDate"].Value = group.EndDate.ToLongDateString();
            row.Cells["colCategory"].Value = group.Category;
            row.Cells["colStaff"].Value = group.GetStaffNameString(",");
            row.Cells["colMemo"].Value = group.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new TASheetBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as TASheetGroup);
            return ret.Result == ResultCode.Successful;
        }
        #endregion

        #region 事件处理程序
        private void btn_OTSheet_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTASheetGroupDetail frm = new FrmTASheetGroupDetail();
                frm.SheetType = "A";
                frm.IsAdding = true;
                DataGridViewRow row = null;
                frm.ItemAdded += delegate(object obj, ItemAddedEventArgs args)
                {
                    row = Add_A_Row(args.AddedItem, true);
                };
                frm.ItemUpdated += delegate(object obj, ItemUpdatedEventArgs args)
                {
                    ShowItemInGridViewRow(row, args.UpdatedItem);
                };
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_VacationSheet_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTASheetGroupDetail frm = new FrmTASheetGroupDetail();
                frm.SheetType = "B";
                frm.IsAdding = true;
                DataGridViewRow row = null;
                frm.ItemAdded += delegate(object obj, ItemAddedEventArgs args)
                {
                    row = Add_A_Row(args.AddedItem, true);
                };
                frm.ItemUpdated += delegate(object obj, ItemUpdatedEventArgs args)
                {
                    ShowItemInGridViewRow(row, args.UpdatedItem);
                };
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_TripSheet_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTASheetGroupDetail frm = new FrmTASheetGroupDetail();
                frm.SheetType = "C";
                frm.IsAdding = true;
                DataGridViewRow row = null;
                frm.ItemAdded += delegate(object obj, ItemAddedEventArgs args)
                {
                    row = Add_A_Row(args.AddedItem, true);
                };
                frm.ItemUpdated += delegate(object obj, ItemUpdatedEventArgs args)
                {
                    ShowItemInGridViewRow(row, args.UpdatedItem);
                };
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion
    }
}