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

namespace LJH.Attendance.UI
{
    public partial class DepartmentTreeview : TreeView
    {
        #region 构造函数
        public DepartmentTreeview()
        {
            InitializeComponent();
        }

        public DepartmentTreeview(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        #endregion

        #region 私有变量
        List<Department> _Depts = null;
        List<Staff> _Users = null;
        List<TreeNode> _AllUserNodes = new List<TreeNode>();
        List<TreeNode> _AllDeptNodes = new List<TreeNode>();
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

        private TreeNode AddDepartmentNode(Department dept, out int userCount)
        {
            int count = 0;
            List<Staff> users = null;
            if (LoadUser)
            {
                users = _Users.Where(item => item.DepartmentID == dept.ID).ToList();
            }

            TreeNode parent = new TreeNode();
            parent.Text = string.Format("[{0}] {1}", dept.ID, dept.Name);
            parent.Tag = dept;

            List<Department> children = _Depts.Where(item => item.ParentID == dept.ID).ToList();
            if (children != null && children.Count > 0)
            {
                foreach (Department child in children)
                {
                    if (OnlyShowCurrentOperatorDepts  && !Operator.CurrentOperator.Depts.Exists(item => item == child.ID))
                    {
                    }
                    else
                    {
                        int uc = 0;
                        TreeNode dnode = AddDepartmentNode(child, out uc);
                        dnode.ImageIndex = 0;
                        dnode.SelectedImageIndex = 0;
                        parent.Nodes.Add(dnode);
                        _AllDeptNodes.Add(dnode);
                        count += uc;
                    }
                }
            }
            if (LoadUser)
            {
                foreach (Staff user in users)
                {
                    if (user.Resigned && !ShowResigedStaff)
                    {
                    }
                    else
                    {
                        TreeNode unode = new TreeNode(user.Name);
                        unode.Tag = user;
                        unode.ImageIndex = 1;
                        unode.SelectedImageIndex = 1;
                        parent.Nodes.Add(unode);
                        _AllUserNodes.Add(unode);
                        count++;
                    }
                }
            }
            if (LoadUser) parent.Text = string.Format("[{0}] {1} ({2}人)", dept.ID, dept.Name, count);
            userCount = count;
            return parent;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置是否加载用户信息，此属性需要要初始化前指定，或者指定后需再调用一次Init
        /// </summary>
        public bool LoadUser { get; set; }
        /// <summary>
        /// 获取或设置是否显示离职人员
        /// </summary>
        public bool ShowResigedStaff { get; set; }
        /// <summary>
        /// 获取或设置是否只显示当前操作的部门信息，否表示全部显示,此属性需要要初始化前指定，或者指定后需再调用一次Init
        /// </summary>
        public bool OnlyShowCurrentOperatorDepts { get; set; }
        /// <summary>
        /// 获取或设置选择的人员
        /// </summary>
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Staff> SelectedStaff
        {
            get
            {
                List<Staff> items = new List<Staff>();
                foreach (TreeNode node in _AllUserNodes)
                {
                    if (node.Checked)
                    {
                        items.Add(node.Tag as Staff);
                    }
                }
                return items;
            }
            set
            {
                this.AfterCheck -= Node_Checked;
                foreach (TreeNode node in _AllUserNodes)
                {
                    bool check = false;
                    check = value != null && value.Count > 0 && value.Exists(item => (node.Tag as Staff).ID == item.ID);
                    node.Checked = check;
                    CheckChildren(node);
                    CheckParent(node);
                }
                this.AfterCheck += Node_Checked;
            }
        }

        /// <summary>
        /// 获取或设置选择的人员
        /// </summary>
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<int> SelectedStaffIDs
        {
            get
            {
                List<int> items = new List<int>();
                foreach (TreeNode node in _AllUserNodes)
                {
                    if (node.Checked)
                    {
                        items.Add((node.Tag as Staff).ID);
                    }
                }
                return items;
            }
            set
            {
                this.AfterCheck -= Node_Checked;
                foreach (TreeNode node in _AllUserNodes)
                {
                    bool check = false;
                    check = value != null && value.Count > 0 && value.Exists(item => (node.Tag as Staff).ID == item);
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
        public List<Department> SelectedDepartments
        {
            get
            {
                List<Department> items = new List<Department>();
                foreach (TreeNode node in _AllDeptNodes)
                {
                    if (node.Checked)
                    {
                        items.Add(node.Tag as Department);
                    }
                }
                return items;
            }
            set
            {
                this.AfterCheck -= Node_Checked;
                foreach (TreeNode node in _AllDeptNodes)
                {
                    bool check = false;
                    check = value != null && value.Count > 0 && value.Exists(item => (node.Tag as Department).ID == item.ID);
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
            _AllUserNodes.Clear();
            _AllDeptNodes.Clear();
            _Depts = (new DepartmentBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (_Depts != null && _Depts.Count > 0)
            {
                _Depts = (from dept in _Depts orderby dept.ID ascending select dept).ToList();
            }
            if (LoadUser)
            {
                _Users = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
                if(_Users !=null && _Users .Count >0) _Users = (from staff in _Users orderby staff.Name ascending select staff).ToList();
            }

            this.Nodes.Clear();
            this.ImageList = images;
            TreeNode root = new TreeNode("所有部门");
            root.ImageIndex = 2;
            root.SelectedImageIndex = 2;
            this.Nodes.Add(root);

            int count = 0;
            if (_Depts != null && _Depts.Count > 0)
            {
                foreach (Department dept in _Depts)
                {
                    if (string.IsNullOrEmpty(dept.ParentID))
                    {
                        if (OnlyShowCurrentOperatorDepts  && !Operator.CurrentOperator.Depts.Exists(item => item == dept.ID))
                        {
                        }
                        else
                        {
                            int userCount = 0;
                            TreeNode dnode = AddDepartmentNode(dept, out userCount);
                            dnode.ImageIndex = 0;
                            dnode.SelectedImageIndex = 0;
                            root.Nodes.Add(dnode);
                            _AllDeptNodes.Add(dnode);
                            count += userCount;
                        }
                    }
                }
            }
            if (LoadUser)
            {
                root.Expand();
                if (LoadUser) root.Text = string.Format("{0} ({1}人)", "所有部门", count);
            }
            else
            {
                this.ExpandAll();
            }
            this.AfterCheck -= Node_Checked;
            this.AfterCheck += Node_Checked;
        }
        /// <summary>
        /// 根据部门ID选择部门
        /// </summary>
        /// <param name="depts"></param>
        public void SelectDepts(List<string> depts)
        {
            this.AfterCheck -= Node_Checked;
            foreach (TreeNode node in _AllDeptNodes)
            {
                bool check = false;
                check = depts.Exists(item => (node.Tag as Department).ID == item);
                node.Checked = check;
                CheckChildren(node);
                CheckParent(node);
            }
            this.AfterCheck += Node_Checked;
        }
        /// <summary>
        /// 选择所有部门
        /// </summary>
        public void SelectAllDepts()
        {
            this.AfterCheck -= Node_Checked;
            foreach (TreeNode node in _AllDeptNodes)
            {
                node.Checked = true;
            }
            foreach (TreeNode node in this.Nodes)
            {
                node.Checked = true;
            }
            this.AfterCheck += Node_Checked;
        }
        /// <summary>
        /// 通过员工ID获取部门名称
        /// </summary>
        /// <param name="staffID"></param>
        /// <returns></returns>
        public string GetDepartmentName(int staffID)
        {
            if (_AllUserNodes != null && _AllUserNodes.Count > 0)
            {
                foreach (TreeNode node in _AllUserNodes)
                {
                    Staff s = node.Tag as Staff;
                    if (s.ID == staffID)
                    {
                        TreeNode dept = node.Parent;
                        if (dept != null && dept.Tag != null)
                        {
                            Department d = dept.Tag as Department;
                            if (d != null) return d.Name;
                        }
                    }
                }
            }
            return string.Empty;
        }
        #endregion
    }
}
