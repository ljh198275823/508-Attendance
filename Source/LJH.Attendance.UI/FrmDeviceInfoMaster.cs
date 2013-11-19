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
    public partial class FrmDeviceInfoMaster : FrmMasterBase 
    {
        public FrmDeviceInfoMaster()
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
            return new FrmDeviceInfoDetail();
        }

        protected override List<object> GetDataSource()
        {
            List<DeviceInfo> items = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            return (from item in items
                    select (object)item).ToList();
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            DeviceInfo reader = item as DeviceInfo;
            row.Tag = item;
            row.Cells["colCheck"].Value = reader.ForAttendance;
            row.Cells["colID"].Value = reader.ID;
            row.Cells["colName"].Value = reader.Name;
            row.Cells["colDeviceType"].Value = reader.DeviceType;
            row.Cells["colSerial"].Value = reader.Serial;
            row.Cells["colCommunication"].Value = reader.Communication;
            row.Cells["colIP"].Value = reader.IP;
            row.Cells["colPort"].Value = reader.ControlPort;
            row.Cells["colCommport"].Value = reader.Commport;
            row.Cells["colBaud"].Value = reader.Baud;
            row.Cells["colAddress"].Value = reader.Address;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as DeviceInfo);
            return ret.Result == ResultCode.Successful;
        }
        #endregion
    }
}
