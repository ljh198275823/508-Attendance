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
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.BLL;

namespace Ralid.Attendance.UI
{
    public partial class FrmAttendanceLogReport : FrmMasterBase 
    {
        public FrmAttendanceLogReport()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return null;
        }

        protected override List<object> GetDataSource()
        {
            List<AttendanceReader> attendanceReaders = (new AttendanceReaderBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            if (attendanceReaders == null || attendanceReaders.Count == 0)
            {
                MessageBox.Show("还没有指定考勤点，请先在 \"考勤点选择\" 上指定考勤点");
                return null;
            }
            List<string> readers = attendanceReaders.Select(it => it.ID).ToList();

            List<Staff> users = departmentTreeview1.SelectedStaff;
            if (users != null && users.Count > 0)
            {
                List<int> staff = users.Select(item => item.ID).ToList();
                AttendanceLogSearchCondition con = new AttendanceLogSearchCondition();
                con.Staff = staff;
                con.ContainManualLogs = true;
                con.Readers = readers;
                con.ReadDateTime = new DatetimeRange(ucDateTimeInterval1.StartDateTime, ucDateTimeInterval1.EndDateTime.Date.AddDays(1).AddSeconds(-1));
                List<AttendanceLog> arranges = (new AttendanceLogBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con).QueryObjects;
                return (from item in arranges
                        orderby item.StaffName ascending, item.ReadDateTime ascending
                        select (object)item).ToList();
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            AttendanceLog record = item as AttendanceLog;
            row.Tag = record;
            row.Cells["colStaff"].Value = record.StaffName;
            row.Cells["colReadDateTime"].Value = record.ReadDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            row.Cells["colReaderName"].Value = record.ReaderName;
            row.Cells["colIsManual"].Value = record.IsManual;
            row.Cells["colMemo"].Value = record.Memo;
            row.DefaultCellStyle.ForeColor = !record.IsManual ? Color.Black : Color.Red;
        }

        protected override bool DeletingItem(object item)
        {
            CommandResult ret = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).Delete(item as OTType);
            return ret.Result == ResultCode.Successful;
        }
        #endregion

        #region 事件处理程序
        private void btnFresh_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            List<object> items = GetDataSource();
            ShowItemsOnGrid(items);
        }
        #endregion
    }
}
