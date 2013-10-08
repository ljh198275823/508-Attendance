using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ralid.Attendance.UI
{
    public partial class FrmColumnSelection : Form
    {
        public FrmColumnSelection()
        {
            InitializeComponent();
        }

        #region 公共属性
        /// <summary>
        /// 获取或设置被选择列的网格控件
        /// </summary>
        public DataGridView Selectee { get; set; }
        /// <summary>
        /// 获取或设置选取的所有列
        /// </summary>
        public string[] SelectedColumns { get; set; }
        #endregion

        private void FrmColumnSelection_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();
            if (Selectee != null)
            {
                List<TreeNode> hiddenNode = new List<TreeNode>();
                foreach (DataGridViewColumn col in Selectee.Columns)
                {
                    TreeNode item = new TreeNode(col.HeaderText);
                    item.Tag = col.Name;
                    hiddenNode.Add(item);
                }
                if (SelectedColumns != null && SelectedColumns.Length > 0)
                {
                    for (int i = 0; i < SelectedColumns.Length; i++)
                    {
                        TreeNode node = hiddenNode.SingleOrDefault(item => item.Tag.ToString() == SelectedColumns[i]);
                        if (node != null)
                        {
                            treeView1.Nodes.Add(node);
                            node.Checked = true;
                            hiddenNode.Remove(node);
                        }
                    }
                }
                foreach (TreeNode node in hiddenNode)
                {
                    treeView1.Nodes.Add(node);
                }
            }
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.BackColor = Color.Blue;
                treeView1.SelectedNode.ForeColor = Color.White;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<string> cols = new List<string>();
            foreach (TreeNode item in treeView1.Nodes)
            {
                if (item.Checked)
                {
                    cols.Add(item.Tag as string);
                }
            }
            if (cols.Count > 0)
            {
                this.SelectedColumns = cols.ToArray();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("没有选择任何列,请至少选择一列");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exchange(TreeNode curNode, TreeNode node)
        {
            string curText = curNode.Text;
            object curObj = curNode.Tag;
            string preText = node.Text;
            object preObj = node.Tag;
            curNode.Text = preText;
            curNode.Tag = preObj;
            node.Text = curText;
            node.Tag = curObj;
            treeView1.SelectedNode = node;
            node.BackColor = curNode.BackColor;
            node.ForeColor = curNode.ForeColor;
            curNode.BackColor = Color.White;
            curNode.ForeColor = Color.Black;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null && node.PrevNode != null)
            {
                Exchange(node, node.PrevNode);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null && node.NextNode != null)
            {
                Exchange(node, node.NextNode);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!object.ReferenceEquals(treeView1.SelectedNode, e.Node))
            {
                if (treeView1.SelectedNode != null)
                {
                    treeView1.SelectedNode.BackColor = Color.White;
                    treeView1.SelectedNode.ForeColor = Color.Black;
                }
                treeView1.SelectedNode = e.Node;
                treeView1.SelectedNode.BackColor = Color.Blue;
                treeView1.SelectedNode.ForeColor = Color.White;
            }
        }
    }
}
