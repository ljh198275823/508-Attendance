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

        ZKFPEngXControl.ZKFPEngX _ZKEngine = new ZKFPEngX();

        private void _ZKEngine_OnImageReceived(ref bool AImageValid)
        {
            string dir = LJH.GeneralLibrary.TempFolderManager.GetCurrentFolder();
            string path = Path.Combine(dir, Guid.NewGuid().ToString() + ".bmp");
            _ZKEngine.SaveBitmap(path);
            pictureBox1.Image = Image.FromFile(path);
        }

        private  void _ZKEngine_OnFeatureInfo(int AQuality)
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
                label1.Text = "登记指纹成功";
                string template = _ZKEngine.GetTemplateAsString();
            }
            else
            {
                _ZKEngine.CancelEnroll();
                _ZKEngine.BeginEnroll();
                label1.Text = string.Format("开始登记指纹 用户需要按 {0} 次指纹", _ZKEngine.EnrollCount);
            }
        }

        private void FrmFingerResgister_Load(object sender, EventArgs e)
        {
            int ret = _ZKEngine.InitEngine();
            if (ret == 0)
            {
                _ZKEngine.FPEngineVersion = "10";
                _ZKEngine.EnrollCount = 3;
                _ZKEngine.OnEnroll += new IZKFPEngXEvents_OnEnrollEventHandler(_ZKEngine_OnEnroll);
                _ZKEngine.OnFeatureInfo += new IZKFPEngXEvents_OnFeatureInfoEventHandler(_ZKEngine_OnFeatureInfo);
                _ZKEngine.OnImageReceived += new IZKFPEngXEvents_OnImageReceivedEventHandler(_ZKEngine_OnImageReceived);

                _ZKEngine.CancelEnroll();
                _ZKEngine.BeginEnroll();
                label1.Text = string.Format("开始登记指纹 用户需要按 {0} 次指纹", _ZKEngine.EnrollCount);
            }
            else
            {
                _ZKEngine.EndEngine();
                label1.Text = "初始化失败";
            }
        }

        private void FrmFingerResgister_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ZKEngine.EndEngine();
        }
    }
}
