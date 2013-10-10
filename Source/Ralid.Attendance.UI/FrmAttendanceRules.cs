﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance.BLL;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;

namespace Ralid.Attendance.UI
{
    public partial class FrmAttendanceRules : Form
    {
        public FrmAttendanceRules()
        {
            InitializeComponent();
        }

        private void ShowItem(AttendanceRules item)
        {
            chkMinLate.Checked = item.MinLate != null;
            if (item.MinLate != null)
            {
                txtMinLate.IntergerValue = item.MinLate.Value;
                txtMinLateAsAbsentMinute.IntergerValue = item.MinLateAsAbsentMinute;
            }
            chkMinLeaveEarly.Checked = item.MinLeaveEarly != null;
            if (item.MinLeaveEarly != null)
            {
                txtMinLeaveEarly.IntergerValue = item.MinLeaveEarly.Value;
                txtMinLeaveEarlyAsAbsentMinute.IntergerValue = item.MinLeaveEarlyAsAbsentMinute;
            }
            chkLateAsAbsent.Checked = item.LateAsAbsent != null;
            if (item.LateAsAbsent != null) txtLateAsAbsent.IntergerValue = item.LateAsAbsent.Value;
            chkLeaveEarlyAsAbsent.Checked = item.LeaveEarlyAsAbsent != null;
            if (item.LeaveEarlyAsAbsent != null) txtLeaveEarlyAsAbsent.IntergerValue = item.LeaveEarlyAsAbsent.Value;
            chkShiftTimeIncludeLateOrLeaveEarly.Checked = item.ShiftTimeIncludeLateOrLeaveEarly;
            chkShiftTimeIncludeWaiChu.Checked = item.ShiftTimeIncludeWaiChu;
            txtMinOTMinute.IntergerValue = item.MinOTMinute;
            txtMinShiftMinute.IntergerValue = item.MinShiftMinute;
            txtOTBeforeStartTime.Value = item.BeforeOTStartTime;
            txtOTAfterEndTime.Value = item.AfterOTEndTime;
            txtMinutesOfWorkDay.Value = item.MinutesOfWorkDay;

            comShiftUnit.SelectedUnit = item.ShiftUnit;
            txtMinShiftTime.DecimalValue = item.MinShiftTime;
            comVacationUnit.SelectedUnit = item.VacationUnit;
            txtMinVacationTime.DecimalValue = item.MinVacationTime;
            comOTUnit.SelectedUnit = item.OTUnit;
            txtMinOTTime.DecimalValue = item.MinOTTime;
            comWaichuUnit.SelectedUnit = item.WaichuUnit;
            txtMinWaichuTime.DecimalValue = item.MinWaichuTime;
            comLateLeaveEarlyUnit.SelectedUnit = item.LateLeaveEarlyUnit;
            txtMinLateLeaveEarlyTime.DecimalValue = item.MinLateLeaveEarlyTime;
        }

        private AttendanceRules GetFromInput()
        {
            AttendanceRules item = new AttendanceRules();
            if (chkMinLate.Checked)
            {
                item.MinLate =txtMinLate.IntergerValue;
                item.MinLateAsAbsentMinute = txtMinLateAsAbsentMinute.IntergerValue;

            }
            if (chkMinLeaveEarly.Checked)
            {
                item.MinLeaveEarly = txtMinLeaveEarly.IntergerValue;
                item.MinLeaveEarlyAsAbsentMinute = txtMinLeaveEarlyAsAbsentMinute.IntergerValue;
            }
            if (chkLateAsAbsent.Checked) item.LateAsAbsent = txtLateAsAbsent.IntergerValue;
            if (chkLeaveEarlyAsAbsent.Checked) item.LeaveEarlyAsAbsent = txtLeaveEarlyAsAbsent.IntergerValue;
            item.ShiftTimeIncludeLateOrLeaveEarly = chkShiftTimeIncludeLateOrLeaveEarly.Checked;
            item.ShiftTimeIncludeWaiChu = chkShiftTimeIncludeWaiChu.Checked;
            item.MinShiftMinute = txtMinShiftMinute.IntergerValue;
            item.MinOTMinute = txtMinOTMinute.IntergerValue;
            item.BeforeOTStartTime =(int) txtOTBeforeStartTime.Value;
            item.AfterOTEndTime = (int)txtOTAfterEndTime.Value;
            item.MinutesOfWorkDay = (int)txtMinutesOfWorkDay.Value;

            item.ShiftUnit = comShiftUnit.SelectedUnit;
            item.MinShiftTime = txtMinShiftTime.DecimalValue;
            item.VacationUnit = comVacationUnit.SelectedUnit;
            item.MinVacationTime = txtMinVacationTime.DecimalValue;
            item.OTUnit = comOTUnit.SelectedUnit;
            item.MinOTTime = txtMinOTTime.DecimalValue;
            item.WaichuUnit = comWaichuUnit.SelectedUnit;
            item.MinWaichuTime = txtMinWaichuTime.DecimalValue;
            item.LateLeaveEarlyUnit = comLateLeaveEarlyUnit.SelectedUnit;
            item.MinLateLeaveEarlyTime = txtMinLateLeaveEarlyTime.DecimalValue;
            return item;
        }

        private void FrmAttendanceRules_Load(object sender, EventArgs e)
        {
            comShiftUnit.Init();
            comOTUnit.Init();
            comWaichuUnit.Init();
            comVacationUnit.Init();
            comLateLeaveEarlyUnit.Init();
            ShowItem(AttendanceRules.Current);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AttendanceRules.Current = GetFromInput();
            CommandResult ret = (new ParameterBLL(AppSettings.CurrentSetting.ConnectString)).Save<AttendanceRules>(AttendanceRules.Current);
            if (ret.Result == ResultCode.Successful)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(ret.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
