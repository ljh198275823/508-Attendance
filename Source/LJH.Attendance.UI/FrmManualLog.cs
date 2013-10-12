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

namespace LJH.Attendance.UI
{
    public partial class FrmManualLog : Form
    {
        public FrmManualLog()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            List<Staff> staff = departmentTreeview1.SelectedStaff;
            if (staff == null || staff.Count == 0)
            {
                MessageBox.Show("没有选择人员");
                return false;
            }
            if (dtStart.Value > dtEnd.Value)
            {
                MessageBox.Show("开始日期大于结束日期");
                return false;
            }
            if (!this.chkTime1.Checked && !this.chkTime2.Checked)
            {
                MessageBox.Show("没有指定答卡时间");
                return false;
            }
            return true;
        }

        #region 事件处理程序
        private void FrmManualLog_Load(object sender, EventArgs e)
        {
            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();

            dtStart.Value = DateTime.Today.Date;
            dtEnd.Value = DateTime.Today.Date;
            txtHour1.Value = 9;
            txtHour2.Value = 18;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                AttendanceLogBLL bll = new AttendanceLogBLL(AppSettings.CurrentSetting.ConnectString);
                List<Staff> items = departmentTreeview1.SelectedStaff;
                foreach (Staff staff in items)
                {
                    DateTime dt1 = dtStart.Value;
                    DateTime dt2 = dtEnd.Value;
                    while (dt1 <= dt2)
                    {
                        for (int i = 1; i <= 6; i++)
                        {
                            if ((this.Controls["chkTime" + i.ToString()] as CheckBox).Checked)
                            {
                                int hour = (int)((this.Controls["txtHour" + i.ToString()] as NumericUpDown).Value);
                                int minute=(int)((this.Controls["txtMinute" +i.ToString ()] as NumericUpDown ).Value);
                                AttendanceLog record = new AttendanceLog()
                                {
                                    StaffID = staff.ID,
                                    StaffName = staff.Name,
                                    ReaderID = string.Empty,
                                    ReadDateTime = dt1.AddHours(hour).AddMinutes(minute),
                                    IsManual = true,
                                    Memo = txtMemo.Text
                                };
                                bll.Add(record);
                            }
                        }
                        dt1 = dt1.AddDays(1);
                    }
                }
            }
            this.departmentTreeview1.SelectedStaff = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
