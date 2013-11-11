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
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmStaffMaster : FrmMasterBase 
    {
        public FrmStaffMaster()
        {
            InitializeComponent();
        }

        #region 重写基类方法和处理事件
        protected override FrmDetailBase GetDetailForm()
        {
            return new FrmStaffDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<Staff> staffs = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects.ToList();
            return (from staff in staffs
                    orderby staff.Name ascending
                    select (object)staff).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            Staff info = item as Staff;
            row.Tag = info;
            row.Cells["colName"].Value = info.Name;
            row.Cells["colDepartment"].Value = info.Department != null ? info.Department.Name : string.Empty;
            row.Cells["colCertificate"].Value = info.Certificate;
            row.Cells["colUserPosition"].Value = info.UserPosition;
            row.Cells["colSex"].Value = info.Sex;
            row.Cells["colHireDate"].Value = info.HireDate.ToString("yyyy-MM-dd");
            row.Cells["colResigned"].Value = info.Resigned ? "离职" : string.Empty;
            row.DefaultCellStyle.ForeColor = info.Resigned ? Color.Red : Color.Black;
            row.Cells["colMemo"].Value = info.Memo;
        }

        protected override bool DeletingItem(object item)
        {
            Staff info = (Staff)item;
            CommandResult ret = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).Delete(info);
            if (ret.Result != ResultCode.Successful)
            {
                MessageBox.Show(ret.Message,LJH.Attendance.UI.Properties.Resources.Form_Alert, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret.Result == ResultCode.Successful;
        }

        protected override void Init()
        {
            base.Init();
            btn_Add.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
            btn_Delete.Enabled = Operator.CurrentOperator.Permit(Permission.EditStaff);
        }
        #endregion
    }
}
