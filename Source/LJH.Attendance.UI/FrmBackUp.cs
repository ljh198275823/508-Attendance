using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.GeneralLibrary.SQLHelper;

namespace LJH.Attendance.UI
{
    public partial class FrmBackUp : Form
    {
        public FrmBackUp()
        {
            InitializeComponent();
        }

        private DateTime _Begin;
        private string _BakPath;
        private string _Message;

        private SqlClient _DBClient = new SqlClient(AppSettings.CurrentSetting.GetConnectString());

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtBackUpPath.Text))
            {
                MessageBox.Show("请选择要备份的路径!");
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                processBar.Value = 0;
                timer1.Enabled = true;
                _Begin = DateTime.Now;
                _BakPath = txtBackUpPath.Text;
                btnOk.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = this.txtBackUpPath .Text;
            saveFileDialog1.DefaultExt = "bak";
            saveFileDialog1.Filter = "bak文件|*.bak";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtBackUpPath .Text = saveFileDialog1.FileName;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _DBClient.Connect();
            if (_DBClient.State == ConnectionState.Open)
            {
                _Message = _DBClient.BackupDataBase(_DBClient.DataBase, _BakPath);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                processBar.Value = (processBar.Value + 5) % processBar.Maximum;
                TimeSpan s=new TimeSpan (DateTime.Now.Ticks -_Begin .Ticks );
                lblTimeSpan.Text = string.Format("{0}分{1}秒", s.Minutes, s.Seconds);
            }
            else
            {
                processBar.Value = 0;
                timer1.Enabled = false;
                btnOk.Enabled = true;
                if (string.IsNullOrEmpty(_Message))
                {
                    MessageBox.Show("数据备份完成");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(_Message);
                }
            }
        }
    }
}
