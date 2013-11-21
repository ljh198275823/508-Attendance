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

        #region 私有变量

        #endregion

        #region 事件处理程序
        private void FrmDeviceInfoMaster_Load(object sender, EventArgs e)
        {
            deviceTree1.Init();
        }

        private void deviceTree1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = deviceTree1.GetNodeAt(e.Location);
            if (node != null) deviceTree1.SelectedNode = node;
            if (e.Button == MouseButtons.Right)
            {
                mnu_AddGroup.Enabled = (node != null && (node.Tag == null || node.Tag is DeviceGroup));
                mnu_AddDevice.Enabled = (node != null && (node.Tag == null || node.Tag is DeviceGroup));
                mnu_Property.Enabled = (node != null && node.Tag != null);
                mnu_Rename.Enabled = (node != null && node.Tag != null);
                mnu_Delete.Enabled = (node != null && node.Tag != null);
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (node != null && node.Tag is DeviceInfo)
                {
                    deviceTree1.DoDragDrop(node, DragDropEffects.Copy | DragDropEffects.Move);
                }
            }
        }

        private void deviceTree1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect != DragDropEffects.None) e.Effect = DragDropEffects.Copy;
        }

        private void deviceTree1_DragDrop(object sender, DragEventArgs e)
        {
            Point p = deviceTree1.PointToClient(new Point(e.X, e.Y));
            TreeNode node = deviceTree1.GetNodeAt(p);
            if (node != null && (node.Tag == null || node.Tag is DeviceGroup))
            {
                string[] s = e.Data.GetFormats();
                if (s.Length > 0)
                {
                    object o = e.Data.GetData(s[0]);
                    if (o is TreeNode)
                    {
                        TreeNode copy = o as TreeNode;
                        if (object.ReferenceEquals(copy.Parent, node)) return; //如果只是拖到同一个父节点下，则不用做什么操作
                        if (copy.Tag is DeviceInfo)
                        {
                            DeviceInfo device = copy.Tag as DeviceInfo;
                            DeviceGroup group = node.Tag as DeviceGroup;
                            device.GroupID = group != null ? group.ID : null;
                            CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).Update(device);
                            if (ret.Result == ResultCode.Successful)
                            {
                                copy.Parent.Nodes.Remove(copy);
                                node.Nodes.Add(copy);
                            }
                        }
                        else if (copy.Tag is DeviceGroup)
                        {
                            DeviceGroup cg = copy.Tag as DeviceGroup;
                            DeviceGroup group = node.Tag as DeviceGroup;
                            cg.ParentID = group != null ? group.ID : null;
                            CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectString)).Update(cg);
                            if (ret.Result == ResultCode.Successful)
                            {
                                copy.Parent.Nodes.Remove(copy);
                                node.Nodes.Add(copy);
                            }
                        }
                    }
                }
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
