using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Configuration ;
using System.Windows.Forms;
using System.Data.SqlClient;
using LJH.Attendance .Model;
using LJH.Attendance.BLL;
using LJH.GeneralLibrary;

namespace LJH.Attendance.UI
{
    public partial class FrmLoginDemo : Form
    {
        private SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();

        public FrmLoginDemo()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void SaveConnectString()
        {
            string p = "Data Source=" + Path.Combine(Application.StartupPath, "Attendance.db");
            AppSettings.CurrentSetting.ConnectUri = "SQLITE:" + p;
        }

        private bool UpGradeDataBase()
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "DbUpdate.sql");
            if (System.IO.File.Exists(path))
            {
                return DatabaseUpgrader.ExeSQLFile(AppSettings.CurrentSetting.ConnectUri, path);
            }
            return false;
        }

        private List<string> GetHistoryOperators()
        {
            List<string> items = null;
            string file = Path.Combine(Application.StartupPath, "HistoryOperators.txt");
            if (File.Exists(file))
            {
                try
                {
                    using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            items= new List<string>();
                            while (!reader.EndOfStream)
                            {
                                items.Add(reader.ReadLine());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                }
            }
            return items;
        }

        private void SaveHistoryOperators()
        {
            List<string> items = new List<string>();
            if (txtLogName.AutoCompleteCustomSource != null && txtLogName.AutoCompleteCustomSource.Count > 0)
            {
                string[] history = new string[txtLogName.AutoCompleteCustomSource.Count];
                txtLogName.AutoCompleteCustomSource.CopyTo(history, 0);
                items.AddRange(history);

            }
            if (!items.Contains(txtLogName.Text)) items.Add(txtLogName.Text);
            try
            {
                string file = Path.Combine(Application.StartupPath, "HistoryOperators.txt");
                using (FileStream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        foreach (string item in items)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
        }
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CommandLineArgs.UserName))
            {
                this.txtLogName.Text = CommandLineArgs.UserName;
                this.txtPassword.Text = CommandLineArgs.Password;
                CommandLineArgs.UserName = string.Empty;
                CommandLineArgs.Password = string.Empty;
                this.btnLogin_Click(this.btnLogin, EventArgs.Empty);
                return;
            }

            this.chkRememberLogid.Checked = AppSettings.CurrentSetting.RememberLogID;
            if (AppSettings.CurrentSetting.RememberLogID)
            {
                List<string> history = GetHistoryOperators();
                if (history != null && history.Count > 0)
                {
                    this.txtLogName.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                    foreach (string item in history)
                    {
                        this.txtLogName.AutoCompleteCustomSource.Add(item);
                        this.txtLogName.Items.Add(item);
                    }
                }
            }
        }

        private void chkRememberLogid_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.CurrentSetting.RememberLogID = chkRememberLogid.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string logName = this.txtLogName.Text.Trim();
            string pwd = this.txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(logName))
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmLogin_InvalidUserName);
                return;
            }

            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmLogin_InvalidPwd);
                return;
            }
            SaveConnectString();

            OperatorBll authen = new OperatorBll(AppSettings.CurrentSetting.ConnectUri);
            if (authen.Authentication(logName, pwd))
            {
                this.DialogResult = DialogResult.OK;
                if (AppSettings.CurrentSetting.RememberLogID) SaveHistoryOperators();
                this.Close();
            }
            else
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmLogin_AuthenFail);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
