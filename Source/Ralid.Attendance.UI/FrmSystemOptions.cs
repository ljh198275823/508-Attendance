using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance.BLL;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;

namespace Ralid.Attendance.UI
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
            this.rdUseACSDept.Checked = SystemOptions.Current.UsingACSDept;
            this.rdUseMyDept.Checked = !SystemOptions.Current.UsingACSDept;
            this.btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditOptions);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SystemOptions.Current.UsingACSDept = this.rdUseACSDept.Checked;
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
    }
}
