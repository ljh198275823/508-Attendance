using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ralid.Attendance.BLL;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;

namespace Ralid.Attendance.UI
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
            con1.UserID = staff.ID;
            con1.ShiftDate = dr;
            List<ShiftArrange> sas = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con1).QueryObjects;

            TASheetSearchCondition con2 = new TASheetSearchCondition();
            con2.StaffID = staff.ID;
            List<TASheet> sheets = (new TASheetBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con2).QueryObjects;

            AttendanceLogSearchCondition con3 = new AttendanceLogSearchCondition();
            con3.Staff = new List<int>();
            con3.Staff.Add(staff.ID);
            con3.Readers = readers;
            con3.ReadDateTime = dr;
            con3.ContainManualLogs = true;
            List<AttendanceLog> records = (new AttendanceLogBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con3).QueryObjects;

            List<AttendanceResult> results = (new AttendanceAnalyst()).Analist(staff, sas, records, sheets,dr);
            CommandResult ret = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectString)).Add(staff.ID, dr, results);
            return ret.Result == ResultCode.Successful;
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
            FrmProcessing frm = new FrmProcessing();
            DatetimeRange dr = new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime.AddDays(1).AddSeconds(-1));
            List<AttendanceReader> attendanceReaders = (new AttendanceReaderBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (attendanceReaders == null || attendanceReaders.Count == 0)
            {
                MessageBox.Show("还没有指定考勤点，请先在 \"考勤点选择\" 上指定考勤点");
                return;
            }
            List<string> readers = attendanceReaders.Select(it => it.ID).ToList();

            Action action = delegate()
            {
                decimal count = 0;
                try
                {
                    foreach (Staff staff in staffs)
                    {
                        try
                        {
                            frm.ShowProgress(string.Format("正在生成考勤结果 {0}...", staff.Name), count / staffs.Count);
                            count++;
                            bool ret = CreateAttendanceResults(staff, dr, readers);
                            if (ret)
                            {
                                frm.ShowProgress(string.Format("生成考勤结果成功 {0}", staff.Name), count / staffs.Count);
                            }
                            else
                            {
                                frm.ShowProgress(string.Format("生成考勤结果失败 {0}", staff.Name), count / staffs.Count);
                            }
                        }
                        catch (Exception ex)
                        {
                            Ralid.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
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
        #endregion
    }
}
