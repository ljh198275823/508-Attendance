using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.BLL;

namespace Ralid.Attendance.UI
{
    public partial class FrmShiftDetail : FrmDetailBase
    {
        public FrmShiftDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditShift);
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("班次名称不能为空");
                txtName.Focus();
                return false;
            }
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

        protected override void ItemShowing()
        {
            Shift shift = UpdatingItem as Shift;
            if (shift == null) return;
            txtName.Text = shift.Name;
            txtShortName.Text = shift.ShortName;
            txtStartHour.Value = shift.StartTime.Hour;
            txtStartMinute.Value = shift.StartTime.Minute;
            chkNextDay.Checked = shift.NextDay;
            txtEndHour.Value = shift.EndTime.Hour;
            txtEndMinute.Value = shift.EndTime.Minute;
            txtBeforeStartTime.Value = shift.BeforeStartTime;
            txtAfterEndTime.Value = shift.AfterEndTime;
            txtShiftTime.Value = shift.ShiftDuration;
        }

        protected override object GetItemFromInput()
        {
            Shift shift = UpdatingItem as Shift;
            if (shift == null)
            {
                shift = new Shift();
            }
            shift.Name = txtName.Text;
            shift.ShortName = txtShortName.Text;
            shift.StartTime = new MyTime((int)txtStartHour.Value, (int)txtStartMinute.Value, 0);
            shift.NextDay = chkNextDay.Checked;
            shift.EndTime = new MyTime((int)txtEndHour.Value, (int)txtEndMinute.Value, 0);
            shift.BeforeStartTime = (int)txtBeforeStartTime.Value;
            shift.AfterEndTime = (int)txtAfterEndTime.Value;
            shift.ShiftDuration = (int)txtShiftTime.Value;
            return shift;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new ShiftBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as Shift);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new ShiftBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as Shift);
        }
        #endregion
    }
}
