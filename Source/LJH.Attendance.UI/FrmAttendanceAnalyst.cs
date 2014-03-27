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
    public partial class FrmAttendanceAnalyst : Form
    {
        public FrmAttendanceAnalyst()
        {
            InitializeComponent();
        }

        #region 私有方法
        private bool CreateAttendanceResults(Staff staff, DatetimeRange dr, List<string> readers)
        {
            ShiftArrangeSearchCondition con1 = new ShiftArrangeSearchCondition();
            con1.StaffID = staff.ID;
            con1.ShiftDate = dr;
            List<ShiftArrange> sas = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(con1).QueryObjects;

            TASheetSearchCondition con2 = new TASheetSearchCondition();
            con2.StaffID = staff.ID;
            List<TASheet> sheets = (new TASheetBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(con2).QueryObjects;

            AttendanceLogSearchCondition con3 = new AttendanceLogSearchCondition();
            con3.Staff = new List<int>();
            con3.Staff.Add(staff.ID);
            con3.Readers = readers;
            con3.ReadDateTime = dr;
            con3.ContainManualLogs = true;
            List<AttendanceLog> records = (new AttendanceLogBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(con3).QueryObjects;

            List<AttendanceResult> results = (new AttendanceAnalyst()).Analist(staff, sas, records, sheets, dr);
            CommandResult ret = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectUri)).Add(staff.ID, dr, results);
            return ret.Result == ResultCode.Successful;
        }
        #endregion

        #region 公共属性
        public List<Staff> Staffs
        {
            get
            {
                return departmentTreeview1.SelectedStaff;
            }
            set
            {
                departmentTreeview1.SelectedStaff = value;
            }
        }

        public DatetimeRange DateRange
        {
            get
            {
                return new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime.AddDays(1).AddSeconds(-1));
            }
            set
            {
                ucDateTimeInterval1.StartDateTime = value.Begin;
                ucDateTimeInterval1.EndDateTime = value.End;
            }
        }
        #endregion

        #region 事件处理程序
        private void FrmAttendanceAnalyst_Load(object sender, EventArgs e)
        {
            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectPreMonth();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Staff> staffs = departmentTreeview1.SelectedStaff;
            if (staffs == null || staffs.Count == 0)
            {
                MessageBox.Show("请至少选择一个人员用于生成考勤结果");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
