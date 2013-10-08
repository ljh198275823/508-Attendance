using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ralid.Attendance.UI
{
    public partial class frmAboat : Form
    {
        public frmAboat()
        {
            InitializeComponent();
        }

        private void frmAboat_Load(object sender, EventArgs e)
        {
            this.lbVersion.Text = Application.ProductVersion;
        }

        private void frmAboat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
