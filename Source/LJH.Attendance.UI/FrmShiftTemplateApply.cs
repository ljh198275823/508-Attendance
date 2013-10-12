using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmShiftTemplateApply : Form
    {
        public FrmShiftTemplateApply()
        {
            InitializeComponent();
        }

        #region 公共属性
        /// <summary>
        /// 获取或设置排班模板
        /// </summary>
        public ShiftTemplate Template { get; set; }
        #endregion

        #region 事件处理程序
        private void FrmShiftTemplateApply_Load(object sender, EventArgs e)
        {
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();
            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();

            if (Template != null)
            {
                txtShiftTemplate.Tag = Template;
                txtShiftTemplate.Text = Template.Name;
            }
        }

        private void lnkTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShiftTemplateMaster frm = new FrmShiftTemplateMaster();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ForSelect = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShiftTemplate template = frm.SelectedItem as ShiftTemplate;
                txtShiftTemplate.Text = template.Name;
                txtShiftTemplate.Tag = template;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtShiftTemplate.Tag == null)
            {
                MessageBox.Show("没有选择模板");
                return;
            }
            if (this.ucDateTimeInterval1.StartDateTime > this.ucDateTimeInterval1.EndDateTime)
            {
                MessageBox.Show("应用的日期不正确,开始时间大于结束时间");
                return;
            }
            if (this.departmentTreeview1.SelectedStaff == null || this.departmentTreeview1.SelectedStaff.Count == 0)
            {
                MessageBox.Show("没有选择人员");
                return;
            }
            FrmProcessing frm = new FrmProcessing();
            DatetimeRange dr = new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime);
            List<Staff> staffs = this.departmentTreeview1.SelectedStaff;
            ShiftTemplate template = txtShiftTemplate.Tag as ShiftTemplate;
            Action action = delegate()
            {
                decimal count = 0;
                try
                {
                    foreach (Staff staff in staffs)
                    {
                        try
                        {
                            frm.ShowProgress(string.Format("正在应用模板 {0}...", staff.Name), count / staffs.Count);
                            count++;
                            List<ShiftArrange> items = template.ApplyTemplateTo(staff, dr);
                            CommandResult ret = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectString)).ShiftArrange(staff.ID, dr, items);
                            if (ret.Result == ResultCode.Successful)
                            {
                                frm.ShowProgress(string.Format("应用模板成功 {0}", staff.Name), count / staffs.Count);
                            }
                            else
                            {
                                frm.ShowProgress(string.Format("应用模板失败 {0}", staff.Name), count / staffs.Count);
                            }
                        }
                        catch (Exception ex)
                        {
                            LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
            };

            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                t.Abort();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
