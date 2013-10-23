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
    public partial class FrmLogin : Form
    {
        private bool _Adance = false;
        private SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void SaveConnectString()
        {
            sb.DataSource = this.txtServer.Text;
            sb.InitialCatalog = this.txtDataBase.Text;
            sb.IntegratedSecurity = rdSystem.Checked;
            sb.UserID = this.txtUserID.Text;
            sb.Password = this.txtPasswd.Text;

            sb.PersistSecurityInfo = true;
            AppSettings.CurrentSetting.ConnectString = "MSSQL:" + sb.ConnectionString;

            UpGradeDataBase(sb.ConnectionString); //升级数据库
        }

        private bool UpGradeDataBase(string connStr)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "DbUpdate.sql");
            if (System.IO.File.Exists(path))
            {
                return DatabaseUpgrader.ExeSQLFile(connStr, path);
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
            this.gpDB.Visible = false;
            this.Height = 148;

            if (!string.IsNullOrEmpty(AppSettings.CurrentSetting.ConnectString))
            {
                try
                {
                    string connStr = AppSettings.CurrentSetting.ConnectString;
                    if (!string.IsNullOrEmpty(connStr))
                    {
                        int p = connStr.IndexOf(':');
                        if (p > 0)
                        {
                            string sqlType = connStr.Substring(0, p);
                            if (sqlType.ToUpper() == "MSSQL")
                            {
                                sb = new SqlConnectionStringBuilder(connStr.Substring(p + 1));
                                txtServer.Text = sb.DataSource;
                                txtDataBase.Text = sb.InitialCatalog;
                                if (sb.IntegratedSecurity)
                                {
                                    this.rdSystem.Checked = true;
                                }
                                else
                                {
                                    this.rdUser.Checked = true;
                                    this.txtUserID.Text = sb.UserID;
                                    this.txtPasswd.Text = sb.Password;
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }

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
            if (string.IsNullOrEmpty(txtServer.Text))
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmLogin_InvalidServer);
                this.txtServer.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDataBase.Text))
            {
                MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmLogin_InvalidDataBase);
                this.txtDataBase.Focus();
                return;
            }

            SaveConnectString();
           

            OperatorBll authen = new OperatorBll(AppSettings.CurrentSetting.ConnectString);
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

        private void rdSystem_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUserID.Enabled = !rdSystem.Checked;
            this.txtPasswd.Enabled = !rdSystem.Checked;
        }

        private void rdUser_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUserID.Enabled = rdUser.Checked;
            this.txtPasswd.Enabled = rdUser.Checked;
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            _Adance = !_Adance;
            if (_Adance)
            {
                this.gpDB.Visible = _Adance;
                this.Height = 248;
            }
            else
            {
                this.gpDB.Visible = false;
                this.Height = 148;
            }
        }
    }
}
