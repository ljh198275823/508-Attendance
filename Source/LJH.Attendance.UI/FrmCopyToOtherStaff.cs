using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LJH.Attendance.BLL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;

namespace LJH.Attendance.UI
{
    public partial class FrmCopyToOtherStaff : Form
    {
        public FrmCopyToOtherStaff()
        {
            InitializeComponent();
        }

        #region 事件处理程序
        private void FrmCopyToOtherStaff_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            dtBegin.Value = new DateTime(dt.Year, dt.Month, 1);
            dtEnd.Value = dtBegin.Value.AddMonths(1).AddDays(-1);

            departmentTreeview1.LoadUser = true;
            departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            departmentTreeview1.Init();
        }

        private void label1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStaffSelection frm = new FrmStaffSelection();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Staff> items = frm.SelectedStaff;
                if (items != null && items.Count > 0)
                {
                    txtStaff.Tag = items[0];
                    txtStaff.Text = items[0].Name;
                }
            }
        }

        private bool CheckInput()
        {
            if (txtStaff.Tag == null)
            {
                MessageBox.Show("没有选择复制源人员");
                return false;
            }
            if (dtEnd.Value < dtBegin.Value)
            {
                MessageBox.Show("\"复制源\" 里面的结束时间小于开始时间");
                return false;
            }
            if (departmentTreeview1.SelectedStaff == null || departmentTreeview1.SelectedStaff.Count == 0)
            {
                MessageBox.Show("没有选择要复制到的人员");
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                ShiftArrangeBLL bll = new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectUri);
                ShiftArrangeSearchCondition con = new ShiftArrangeSearchCondition();
                con.StaffID = (txtStaff.Tag as Staff).ID;
                con.ShiftDate = new DatetimeRange(dtBegin.Value, dtEnd.Value);
                List<ShiftArrange> items = bll.GetItems(con).QueryObjects;
                List<Staff> copyees = departmentTreeview1.SelectedStaff;
                FrmProcessing frm = new FrmProcessing();

                Action action = delegate()
                {
                    decimal count = 0;
                    try
                    {
                        foreach (Staff staff in copyees)
                        {
                            List<ShiftArrange> sas = new List<ShiftArrange>();
                            if (items != null && items.Count > 0)
                            {
                                foreach (ShiftArrange sa in items)
                                {
                                    if (staff.HireDate.Date <= sa.ShiftDate.Date)
                                    {
                                        sa.StaffID = staff.ID;
                                        sas.Add(sa);
                                    }
                                }
                            }
                            count++;
                            frm.ShowProgress(string.Format("正在复制到 {0}...", staff.Name), count / copyees.Count);
                            if (sas.Count > 0)
                            {
                                CommandResult ret = bll.ShiftArrange(staff.ID, new DatetimeRange(dtBegin.Value, dtEnd.Value), sas);
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
