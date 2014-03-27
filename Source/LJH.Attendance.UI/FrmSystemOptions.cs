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

            this.chkAutoCreate.Checked = AppSettings.CurrentSetting.AutoGenerateResult;
            MyTime mt = AppSettings.CurrentSetting.AutoGenerateTime;
            if (mt != null)
            {
                dtAutoGenerateResultTime.Value = new DateTime(2011, 1, 1, mt.Hour, mt.Minute, mt.Second);
            }
            this.chkAutoGetAttendanceLog.Checked = AppSettings.CurrentSetting.AutoGetAttendanceLog;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AppSettings.CurrentSetting.AutoGenerateResult = chkAutoCreate.Checked;
            AppSettings.CurrentSetting.AutoGenerateTime = new MyTime(dtAutoGenerateResultTime.Value.Hour, dtAutoGenerateResultTime.Value.Minute, 0);
            AppSettings.CurrentSetting.AutoGetAttendanceLog = chkAutoGetAttendanceLog.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
