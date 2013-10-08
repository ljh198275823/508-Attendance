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
    public partial class FrmProcessing : Form
    {
        public FrmProcessing()
        {
            InitializeComponent();
        }

        public void ShowProgress(string message, decimal completeRation)
        {
            try
            {
                Action action = delegate()
                {
                    this.label1.Text = message;
                    this.progressBar1.Value = (int)(completeRation * 100);
                    if (completeRation == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                };
                if (this.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action();
                }
            }
            catch
            {
            }
        }

        private void FrmProcessing_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
