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
    public partial class FrmDeviceInfoDetail : FrmDetailBase
    {
        public FrmDeviceInfoDetail()
        {
            InitializeComponent();
        }

        #region 公共属性
        public DeviceGroup ParentGroup { get; set; }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            txtIPMask.IP = "255.255.255.0";
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("名称不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(comDeviceType.Text))
            {
                MessageBox.Show("产品型号不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(comCommunication.Text))
            {
                MessageBox.Show("通讯方式不能为空");
                return false;
            }
            if (txtIP.Enabled && txtIP.IP == "0.0.0.0")
            {
                MessageBox.Show("IP 地址不能为空");
                return false;
            }
            if (txtPort.Enabled && txtPort.IntergerValue == 0)
            {
                MessageBox.Show("端口号不能为空");
                return false;
            }
            if (txtCommport.Enabled && txtCommport.IntergerValue == 0)
            {
                MessageBox.Show("串口号不能为空");
                return false;
            }
            if (txtBaud.Enabled && txtBaud.IntergerValue == 0)
            {
                MessageBox.Show("波特率不能为空");
                return false;
            }
            return true;
        }

        protected override void ItemShowing()
        {
            DeviceInfo info = UpdatingItem as DeviceInfo;
            txtName.Text = info.Name;
            comDeviceType.SelectedIndex = (int)info.DeviceType;
            comCommunication.SelectedIndex = (int)info.Communication;
            txtSerial.Text = info.Serial;
            if (info.Communication == CommunicationType.TCP_IP)
            {
                gpTCPIP.Enabled = true;
                gpRS232.Enabled = false;
                txtIP.IP = info.IP != null ? info.IP : "0.0.0.0";
                txtPort.IntergerValue = info.ControlPort != null ? info.ControlPort.Value : 0;
                txtIPMask.IP = info.IPMask != null ? info.IPMask : "255.255.255.0";
                txtGateway.IP = info.Gateway != null ? info.Gateway : "0.0.0.0";
            }
            else if (info.Communication == CommunicationType.RS232_485)
            {
                gpTCPIP.Enabled = false;
                gpRS232.Enabled = true;
                txtCommport.IntergerValue = info.Commport != null ? info.Commport.Value : 0;
                txtBaud.IntergerValue = info.Baud != null ? info.Baud.Value : 0;
                txtAddress.IntergerValue = info.Address != null ? info.Address.Value : 0;
            }
            chkForAttendance.Checked = info.ForAttendance;
            if (info.LastEventDt != null) lblLastEventDt.Text = "已上传的最后一条考勤记录时间：" + info.LastEventDt.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        protected override Object GetItemFromInput()
        {
            DeviceInfo info;
            if (UpdatingItem == null)
            {
                info = new DeviceInfo();
                info.ForAttendance = true;
                info.GroupID = ParentGroup != null ? ParentGroup.ID : null;
            }
            else
            {
                info = UpdatingItem as DeviceInfo;
            }
            info.Name = txtName.Text;
            info.DeviceType =(DeviceType ) comDeviceType.SelectedIndex ;
            info.Communication = (CommunicationType)comCommunication.SelectedIndex;
            info.Serial = txtSerial.Text;
            if (gpTCPIP.Enabled)
            {
                info.IP = txtIP.IP;
                info.ControlPort = txtPort.IntergerValue;
                info.IPMask = txtIPMask.IP;
                info.Gateway = txtGateway.IP;
            }
            if (gpRS232.Enabled)
            {
                info.Commport = txtCommport.IntergerValue;
                info.Baud = txtBaud.IntergerValue;
                info.Address = txtAddress.IntergerValue;
            }
            info.ForAttendance = chkForAttendance.Checked;
            return info;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectUri)).Add(addingItem as DeviceInfo);
            return ret;
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectUri)).Update(updatingItem as DeviceInfo);
            return ret;
        }
        #endregion

        private void comCommunication_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpRS232.Enabled = comCommunication.Text == "RS232/485";
            gpTCPIP.Enabled = comCommunication.Text == "TCP/IP";
        }
    }
}
