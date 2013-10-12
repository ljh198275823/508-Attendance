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
    public partial class FrmShiftSelection : Form
    {
        public FrmShiftSelection()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 获取或设置所有选择的班次
        /// </summary>
        /// <returns></returns>
        public List<Shift> SelectedShifts
        {
            get
            {
                List<Shift> items = new List<Shift>();
                foreach (TreeNode node in this.treeView1.Nodes)
                {
                    if (node.Checked) items.Add(node.Tag as Shift);
                }
                return items;
            }
            set
            {
                foreach (TreeNode node in this.treeView1.Nodes)
                {
                    node.Checked = (value != null && value.Count > 0 && value.Exists(item => item.ID == (node.Tag as Shift).ID));
                }
            }
        }

        private void Init()
        {
            this.treeView1.Nodes.Clear();
            List<Shift> items = (new ShiftBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            foreach (Shift item in items)
            {
                TreeNode node = new TreeNode(string.Format("{0}({1})", item.Name, item.ShortName));
                node.Tag = item;
                this.treeView1.Nodes.Add(node);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close ();
        } 
    }
}
