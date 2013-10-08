using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance .Model ;

namespace Ralid.Attendance.UI
{
    public partial class FrmStaffSelection : Form
    {
        public FrmStaffSelection()
        {
            InitializeComponent();
            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();
        }

        /// <summary>
        /// 获取或设置选择的人员信息
        /// </summary>
        public List<Staff> SelectedStaff
        {
            get
            {
                return this.departmentTreeview1.SelectedStaff;
            }
            set
            {
                this.departmentTreeview1.SelectedStaff = value;

            }
        }

        private void FrmStaffSelection_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
