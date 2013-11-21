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
            deviceTree1.Init();
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

        #region 事件处理程序
        private void deviceTree1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            deviceTree1.SelectedNode = e.Node;
            if (e.Node.Tag is DeviceInfo)
            {
                mnu_AddDevice.Enabled = false;
                mnu_AddGroup.Enabled = false;
            }
            else
            {
                mnu_AddDevice.Enabled = true;
                mnu_AddGroup.Enabled = true;
            }
        }

        private void mnu_AddGroup_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                DeviceGroup group = node.Tag as DeviceGroup;
                FrmDeviceGroupDetail frm = new FrmDeviceGroupDetail();
                frm.Parent = group;
                frm.IsAdding = true;
                frm.ItemAdded += delegate(object o, ItemAddedEventArgs args)
                {
                    DeviceGroup dg = args.AddedItem as DeviceGroup;
                    TreeNode child = new TreeNode();
                    child.Tag = dg;
                    deviceTree1.FreshNode(child);
                    node.Nodes.Add(child);
                    node.Expand();
                };
                frm.ShowDialog();
            }
        }

        private void mnu_AddDevice_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                DeviceGroup group = node.Tag as DeviceGroup;
                FrmDeviceInfoDetail frm = new FrmDeviceInfoDetail();
                frm.Parent = group;
                frm.IsAdding = true;
                frm.ItemAdded += delegate(object o, ItemAddedEventArgs args)
                {
                    DeviceInfo dg = args.AddedItem as DeviceInfo;
                    TreeNode child = new TreeNode();
                    child.Tag = dg;
                    deviceTree1.FreshNode(child);
                    node.Nodes.Add(child);
                    node.Expand();
                };
                frm.ShowDialog();
            }
        }

        private void mnu_Delete_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                if (node.Tag is DeviceGroup)
                {
                    if (node.Nodes.Count == 0)
                    {
                        if (MessageBox.Show("是否要删除？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectString)).Delete(node.Tag as DeviceGroup);
                            if (ret.Result == ResultCode.Successful)
                            {
                                node.Parent.Nodes.Remove(node);
                            }
                            else
                            {
                                MessageBox.Show(ret.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("不能删除有子节点的设备组，请先删除此节点下的所有子节点再进行删除操作");
                    }
                }
                else if (node.Tag is DeviceInfo)
                {
                    if (MessageBox.Show("是否要删除？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).Delete(node.Tag as DeviceInfo);
                        if (ret.Result == ResultCode.Successful)
                        {
                            node.Parent.Nodes.Remove(node);
                        }
                        else
                        {
                            MessageBox.Show(ret.Message);
                        }
                    }
                }
            }
        }

        private void mnu_Property_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                if (node.Tag is DeviceGroup)
                {
                    FrmDeviceGroupDetail frm = new FrmDeviceGroupDetail();
                    frm.IsAdding = false;
                    frm.UpdatingItem = node.Tag;
                    frm.ItemUpdated += delegate(object o, ItemUpdatedEventArgs args)
                    {
                        deviceTree1.FreshNode(node);
                    };
                    frm.ShowDialog();
                }
                else if (node.Tag is DeviceInfo)
                {
                    FrmDeviceInfoDetail frm = new FrmDeviceInfoDetail();
                    frm.IsAdding = false;
                    frm.UpdatingItem = node.Tag;
                    frm.ItemUpdated += delegate(object o, ItemUpdatedEventArgs args)
                    {
                        deviceTree1.FreshNode(node);
                    };
                    frm.ShowDialog();
                }
            }
        }

        private void mnu_Fresh_Click(object sender, EventArgs e)
        {
            deviceTree1.Init();
        }
        #endregion 
    }
}
