using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ZKFPEngXControl;

namespace LJH.Attendance.UI
{
    public partial class FrmFingerResgister : Form
    {
        public FrmFingerResgister()
        {
            InitializeComponent();
        }

        #region 私有变量
        ZKFPEngXControl.ZKFPEngX _ZKEngine = new ZKFPEngX();
        #endregion

        #region 公共属性
        public string Template { get; set; }

        public int BioSource
        {
            get
            {
                if (comBiosource.SelectedIndex >= 0)
                {
                    return comBiosource.SelectedIndex;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string Version
        {
            get
            {
                if (rdVer10.Checked) return "10.0";
                if (rdVer9.Checked) return "9.0";
                return string.Empty;
            }
        }
        #endregion

        #region 事件处理程序
        private void _ZKEngine_OnImageReceived(ref bool AImageValid)
        {
            string dir = LJH.GeneralLibrary.TempFolderManager.GetCurrentFolder();
            string path = Path.Combine(dir, Guid.NewGuid().ToString() + ".bmp");
            _ZKEngine.SaveBitmap(path);
            pictureBox1.Image = Image.FromFile(path);
        }

        private void _ZKEngine_OnFeatureInfo(int AQuality)
        {
            if (_ZKEngine.IsRegister)
            {
                label1.Text = string.Format("还需要再按 {0} 次指纹", _ZKEngine.EnrollIndex - 1);
            }
        }

        private void _ZKEngine_OnEnroll(bool ActionResult, object ATemplate)
        {
            if (ActionResult)
            {
                string ver = rdVer10.Checked ? "10" : "9";
                Template = _ZKEngine.GetTemplateAsStringEx(ver);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                _ZKEngine.CancelEnroll();
                _ZKEngine.BeginEnroll();
                label1.Text = string.Format("重新登记指纹 用户需要按 {0} 次指纹", _ZKEngine.EnrollCount);
            }
        }

        private void FrmFingerResgister_Load(object sender, EventArgs e)
        {
            this.comBiosource.SelectedIndex = 0;
            int ret = _ZKEngine.InitEngine();
            if (ret == 0)
            {
                _ZKEngine.FPEngineVersion = rdVer10.Checked ? "10" : "9";
                _ZKEngine.EnrollCount = 3;
                _ZKEngine.OnEnroll += new IZKFPEngXEvents_OnEnrollEventHandler(_ZKEngine_OnEnroll);
                _ZKEngine.OnFeatureInfo += new IZKFPEngXEvents_OnFeatureInfoEventHandler(_ZKEngine_OnFeatureInfo);
                _ZKEngine.OnImageReceived += new IZKFPEngXEvents_OnImageReceivedEventHandler(_ZKEngine_OnImageReceived);

                _ZKEngine.CancelEnroll();
                _ZKEngine.BeginEnroll();
                label1.Text = string.Format("开始登记指纹 用户需要按 {0} 次指纹", _ZKEngine.EnrollCount);
            }
            else if (ret == 1)
            {
                _ZKEngine.EndEngine();
                label1.Text = "指纹识别仪驱动程序加载失败";
                label1.ForeColor = Color.Red;
            }
            else if (ret == 2)
            {
                _ZKEngine.EndEngine();
                label1.Text = "未连接指纹识别仪";
                label1.ForeColor = Color.Red;
            }
            else if (ret == 3)
            {
                _ZKEngine.EndEngine();
                label1.Text = "属性SensorIndex指定的指纹识别仪不存在";
                label1.ForeColor = Color.Red;
            }
            else
            {
                _ZKEngine.EndEngine();
                label1.Text = "指纹识别仪初始化失败";
                label1.ForeColor = Color.Red;
            }
        }

        private void FrmFingerResgister_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ZKEngine.EndEngine();
        }
        #endregion

        private void rdVer10_CheckedChanged(object sender, EventArgs e)
        {
            if (rdVer10.Checked) _ZKEngine.FPEngineVersion = "10";
            if (rdVer9.Checked) _ZKEngine.FPEngineVersion = "9";
            _ZKEngine.EndEngine();
            _ZKEngine.InitEngine();
        }
    }
}
