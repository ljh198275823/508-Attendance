using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance.Model;

namespace Ralid.Attendance.UI
{
    public partial class FrmShiftItemDetail : Form
    {
        public FrmShiftItemDetail()
        {
            InitializeComponent();
        }

        #region 私有方法
        private bool CheckInput()
        {
            if ((txtStartHour.Value * 60 + txtStartMinute.Value) > (txtEndHour.Value * 60 + txtEndMinute.Value) && !chkNextDay.Checked)
            {
                MessageBox.Show("下班时间不正确，小于上班时间");
                return false;
            }
            if (txtShiftTime.Value <= 0)
            {
                MessageBox.Show("班次出勤计时不正确");
                txtShiftTime.Focus();
                return false;
            }
            return true;
        }

        private  void ItemShowing(ShiftItem shift)
        {
            txtStartHour.Value = shift.StartTime.Hour;
            txtStartMinute.Value = shift.StartTime.Minute;
            chkNextDay.Checked = shift.NextDay;
            txtEndHour.Value = shift.EndTime.Hour;
            txtEndMinute.Value = shift.EndTime.Minute;
            txtAllowLateTime.Value = shift.AllowLateTime;
            txtAllowLeaveEarlyTime.Value = shift.AllowLeaveEarlyTime;
            txtBeforeStartTime.Value = shift.BeforeStartTime;
            txtAfterEndTime.Value = shift.AfterEndTime;
            txtShiftTime.Value = shift.Duration;
        }

        private ShiftItem GetItemFromInput()
        {
            ShiftItem shift = ShiftItem as ShiftItem;
            if (shift == null) shift = new ShiftItem();
            shift.StartTime = new MyTime((int)txtStartHour.Value, (int)txtStartMinute.Value, 0);
            shift.NextDay = chkNextDay.Checked;
            shift.EndTime = new MyTime((int)txtEndHour.Value, (int)txtEndMinute.Value, 0);
            shift.AllowLateTime = txtAllowLateTime.Value;
            shift.AllowLeaveEarlyTime = txtAllowLeaveEarlyTime.Value;
            shift.BeforeStartTime = txtBeforeStartTime.Value;
            shift.AfterEndTime = txtAfterEndTime.Value;
            shift.Duration = txtShiftTime.Value;
            return shift;
        }
        #endregion

        #region 公共属性
        public ShiftItem ShiftItem { get; set; }
        #endregion

        #region 事件处理程序
        private void FrmShiftItemDetail_Load(object sender, EventArgs e)
        {
            if (ShiftItem != null)
            {
                ItemShowing(ShiftItem);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                ShiftItem = GetItemFromInput();
                this.DialogResult = DialogResult.OK;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void txtEndMinute_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dt1=today .AddHours ((int)txtStartHour.Value).AddMinutes ((int)txtStartMinute.Value);
            DateTime dt2 = today.AddHours((int)txtEndHour.Value).AddMinutes((int)txtEndMinute.Value);
            if (chkNextDay.Checked) dt2 = dt2.AddDays(1);
            TimeSpan ts = new TimeSpan(dt2.Ticks - dt1.Ticks);
            txtShiftTime.Value = ts.TotalMinutes > 0 ? (int)ts.TotalMinutes : 0;
        }

        private void txtStartMinute_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dt1 = today.AddHours((int)txtStartHour.Value).AddMinutes((int)txtStartMinute.Value);
            DateTime dt2 = today.AddHours((int)txtEndHour.Value).AddMinutes((int)txtEndMinute.Value);
            if (chkNextDay.Checked) dt2 = dt2.AddDays(1);
            TimeSpan ts = new TimeSpan(dt2.Ticks - dt1.Ticks);
            txtShiftTime.Value = ts.TotalMinutes > 0 ? (int)ts.TotalMinutes : 0;
        }

        private void txtEndHour_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dt1 = today.AddHours((int)txtStartHour.Value).AddMinutes((int)txtStartMinute.Value);
            DateTime dt2 = today.AddHours((int)txtEndHour.Value).AddMinutes((int)txtEndMinute.Value);
            if (chkNextDay.Checked) dt2 = dt2.AddDays(1);
            TimeSpan ts = new TimeSpan(dt2.Ticks - dt1.Ticks);
            txtShiftTime.Value = ts.TotalMinutes > 0 ? (int)ts.TotalMinutes : 0;
        }

        private void txtStartHour_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dt1 = today.AddHours((int)txtStartHour.Value).AddMinutes((int)txtStartMinute.Value);
            DateTime dt2 = today.AddHours((int)txtEndHour.Value).AddMinutes((int)txtEndMinute.Value);
            if (chkNextDay.Checked) dt2 = dt2.AddDays(1);
            TimeSpan ts = new TimeSpan(dt2.Ticks - dt1.Ticks);
            txtShiftTime.Value = ts.TotalMinutes > 0 ? (int)ts.TotalMinutes : 0;
        }
    }
}
