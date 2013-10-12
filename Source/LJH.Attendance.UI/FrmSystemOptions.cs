using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.BLL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;

namespace LJH.Attendance.UI
{
    public partial class FrmSystemOptions : Form
    {
        public FrmSystemOptions()
        {
            InitializeComponent();
        }

        #region 事件处理程序
        private void SystemOptions_Load(object sender, EventArgs e)
        {
            this.btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditOptions);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CommandResult ret = (new ParameterBLL(AppSettings.CurrentSetting.ConnectString)).Save<SystemOptions>(SystemOptions.Current);
            if (ret.Result != ResultCode.Successful)
            {
                MessageBox.Show(ret.Message);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                    }
    }
}
