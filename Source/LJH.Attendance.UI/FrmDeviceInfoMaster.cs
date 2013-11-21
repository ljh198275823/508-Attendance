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
    public partial class FrmDeviceInfoMaster : Form
    {
        public FrmDeviceInfoMaster()
        {
            InitializeComponent();
        }

        #region 事件处理程序
        private void FrmDeviceInfoMaster_Load(object sender, EventArgs e)
        {
            deviceTree1.Init();
        }

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
            mnu_Rename.Enabled = e.Node.Tag != null;
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

        private void mnu_Rename_Click(object sender, EventArgs e)
        {
            TreeNode node = this.deviceTree1.SelectedNode;
            deviceTree1.LabelEdit = true;
            if (node.Tag is DeviceGroup)
            {
                node.Text = (node.Tag as DeviceGroup).Name;
            }
            else if (node.Tag is DeviceInfo)
            {
                node.Text = (node.Tag as DeviceInfo).Name;
            }
            node.BeginEdit();
        }

        private void deviceTree1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label))
            {
                TreeNode node = e.Node;
                if (node.Tag is DeviceGroup)
                {
                    DeviceGroup group = node.Tag as DeviceGroup;
                    group.Name = e.Label;
                    CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectString)).Update(group);
                }
                else if (node.Tag is DeviceInfo)
                {
                    DeviceInfo device = node.Tag as DeviceInfo;
                    device.Name = e.Label;
                    CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).Update(device);
                }
                deviceTree1.FreshNode(node);
                e.CancelEdit = true; //这一行不能省
                deviceTree1.LabelEdit = false;
            }
            else
            {
                e.CancelEdit = true;
            }
        }
    }
}
