using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI.Controls
{
    public partial class DeviceTree :TreeView
    {
        #region 构造函数
        public DeviceTree()
        {
            InitializeComponent();
        }

        public DeviceTree(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region 私有变量
        List<DeviceGroup> _Groups = null;
        List<DeviceInfo> _Devices = null;
        List<TreeNode> _AllDeviceNodes = new List<TreeNode>();
        List<TreeNode> _AllGroupNodes = new List<TreeNode>();
        #endregion

        #region 私有方法
        private void Node_Checked(object sender, TreeViewEventArgs e)
        {
            this.AfterCheck -= Node_Checked;
            CheckChildren(e.Node);
            CheckParent(e.Node);
            this.AfterCheck += Node_Checked;
        }

        private void CheckChildren(TreeNode curNode)
        {
            foreach (TreeNode nod in curNode.Nodes)
            {
                nod.Checked = curNode.Checked;
                CheckChildren(nod);
            }
        }

        private void CheckParent(TreeNode curNode)
        {
            TreeNode parent = curNode.Parent;
            if (parent != null)
            {
                bool allChecked = true;
                foreach (TreeNode n in parent.Nodes)
                {
                    if (n.Checked == false)
                    {
                        allChecked = false;
                        break;
                    }
                }
                parent.Checked = allChecked;
                CheckParent(parent);
            }
        }

        private TreeNode AddDeviceGroupNode(DeviceGroup group)
        {
            TreeNode node = new TreeNode();
            node.Tag = group;

            List<DeviceGroup> children = _Groups.Where(item => item.ParentID == group.ID).ToList();
            if (children != null && children.Count > 0)
            {
                foreach (DeviceGroup child in children)
                {
                    TreeNode dnode = AddDeviceGroupNode(child);
                    FreshNode(dnode);
                    node.Nodes.Add(dnode);
                    _AllGroupNodes.Add(dnode);
                }
            }
            if (_Devices != null && _Devices.Count > 0)
            {
                foreach (DeviceInfo device in _Devices)
                {
                    if (device.GroupID == group.ID)
                    {
                        TreeNode unode = new TreeNode(device.Name);
                        unode.Tag = device;
                        FreshNode(unode);
                        node.Nodes.Add(unode);
                        _AllDeviceNodes.Add(unode);
                    }
                }
            }
            return node;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置选择的人员
        /// </summary>
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<DeviceInfo> SelectedDevices
        {
            get
            {
                List<DeviceInfo> items = new List<DeviceInfo>();
                foreach (TreeNode node in _AllDeviceNodes)
                {
                    if (node.Checked)
                    {
                        items.Add(node.Tag as DeviceInfo);
                    }
                }
                return items;
            }
            set
            {
                this.AfterCheck -= Node_Checked;
                foreach (TreeNode node in _AllDeviceNodes)
                {
                    bool check = false;
                    check = value != null && value.Count > 0 && value.Exists(item => (node.Tag as DeviceInfo).ID == item.ID);
                    node.Checked = check;
                    CheckChildren(node);
                    CheckParent(node);
                }
                this.AfterCheck += Node_Checked;
            }
        }
        
        /// <summary>
        /// 获取或设置选择的部门
        /// </summary>
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<DeviceGroup> SelectedGroups
        {
            get
            {
                List<DeviceGroup> items = new List<DeviceGroup>();
                foreach (TreeNode node in _AllGroupNodes)
                {
                    if (node.Checked)
                    {
                        items.Add(node.Tag as DeviceGroup);
                    }
                }
                return items;
            }
            set
            {
                this.AfterCheck -= Node_Checked;
                foreach (TreeNode node in _AllGroupNodes)
                {
                    bool check = false;
                    check = value != null && value.Count > 0 && value.Exists(item => (node.Tag as DeviceGroup).ID == item.ID);
                    node.Checked = check;
                    CheckChildren(node);
                    CheckParent(node);
                }
                this.AfterCheck += Node_Checked;
            }
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 初始化树
        /// </summary>
        public void Init()
        {
            _AllDeviceNodes.Clear();
            _AllGroupNodes.Clear();
            _Groups = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            _Devices = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
            if (_Groups != null && _Groups.Count > 0)
            {
                _Groups = (from dept in _Groups orderby dept.ID ascending select dept).ToList();
            }
            this.Nodes.Clear();
            this.ImageList = images;
            TreeNode root = new TreeNode();
            FreshNode(root);
            this.Nodes.Add(root);

            if (_Groups != null && _Groups.Count > 0)
            {
                foreach (DeviceGroup group in _Groups)
                {
                    if (string.IsNullOrEmpty(group.ParentID))
                    {
                        TreeNode dnode = AddDeviceGroupNode(group);
                        FreshNode(dnode);
                        root.Nodes.Add(dnode);
                        _AllGroupNodes.Add(dnode);
                    }
                }
            }
            if (_Devices != null && _Devices.Count > 0)
            {
                foreach (DeviceInfo device in _Devices)
                {
                    if (string.IsNullOrEmpty(device.GroupID))
                    {
                        TreeNode unode = new TreeNode();
                        unode.Tag = device;
                        FreshNode(unode);
                        root.Nodes.Add(unode);
                        _AllDeviceNodes.Add(unode);
                    }
                }
            }
            this.ExpandAll();
            this.AfterCheck -= Node_Checked;
            this.AfterCheck += Node_Checked;
        }
        /// <summary>
        /// 根据组ID选择组
        /// </summary>
        /// <param name="groups"></param>
        public void SelectGroups(List<string> groups)
        {
            this.AfterCheck -= Node_Checked;
            foreach (TreeNode node in _AllGroupNodes)
            {
                bool check = false;
                check = groups.Exists(item => (node.Tag as DeviceGroup).ID == item);
                node.Checked = check;
                CheckChildren(node);
                CheckParent(node);
            }
            this.AfterCheck += Node_Checked;
        }
        /// <summary>
        /// 选择所有组
        /// </summary>
        public void SelectAll()
        {
            this.AfterCheck -= Node_Checked;
            foreach (TreeNode node in _AllGroupNodes)
            {
                node.Checked = true;
            }
            foreach (TreeNode node in this.Nodes)
            {
                node.Checked = true;
            }
            this.AfterCheck += Node_Checked;
        }

        public void FreshNode(TreeNode node)
        {
            if (node.Tag == null)
            {
                node.Text = "所有设备";
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }
            else if (node.Tag is DeviceGroup)
            {
                DeviceGroup group = node.Tag as DeviceGroup;
                node.Text = string.Format("[{0}] {1}", group.ID, group.Name);
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
            else if (node.Tag is DeviceInfo)
            {
                DeviceInfo device = node.Tag as DeviceInfo;
                node.Text = device.Name;
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
        }
        #endregion
    }
}
