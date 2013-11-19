using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmAttendanceLogReport : FrmMasterBase 
    {
        public FrmAttendanceLogReport()
        {
            InitializeComponent();
        }

        #region 私有方法
        private string GetAttendanceTime(List<AttendanceLog> items)
        {
            string temp = string.Empty;
            string lastTime = string.Empty;
            if (items != null && items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == 0)
                    {
                        temp += items[i].ReadDateTime.ToString("HH:mm") + (items[i].IsManual ? "[补签]" : string.Empty);
                    }
                    else if (!string.IsNullOrEmpty(lastTime) && lastTime != items[i].ReadDateTime.ToString("HH:mm"))
                    {
                        temp += " ," + items[i].ReadDateTime.ToString("HH:mm") + (items[i].IsManual ? "[补签]" : string.Empty);
                    }
                    lastTime = items[i].ReadDateTime.ToString("HH:mm");
                }
            }
            return temp;
        }
        #endregion

        #region 重写基类方法
        protected override void Init()
        {
            base.Init();
            this.ucDateTimeInterval1.Init();
            this.ucDateTimeInterval1.SelectThisMonth();

            this.departmentTreeview1.LoadUser = true;
            this.departmentTreeview1.ShowResigedStaff = true;
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = true;
            this.departmentTreeview1.Init();
        }

        protected override FrmDetailBase GetDetailForm()
        {
            return null;
        }

        protected override List<object> GetDataSource()
        {
            List<DeviceInfo> attendanceReaders = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).GetAttendanceReaders().QueryObjects;
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
                List<object> items = new List<object>();
                foreach (Staff s in users)
                {
                    List<AttendanceLog> rets = (from it in arranges where it.StaffID == s.ID orderby it.ReadDateTime ascending select it).ToList();
                    if (rets != null && rets.Count > 0)
                    {
                        List<IGrouping<string, AttendanceLog>> groups = rets.GroupBy(item => item.ReadDateTime.ToString("yyyy-MM-dd")).ToList();
                        List<object> sas = (from g in groups select (object)g).ToList();
                        items.AddRange(sas);
                    }
                }
                return items;
            }
            return null;
        }

        protected override void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {
            IGrouping<string, AttendanceLog> g = item as IGrouping<string, AttendanceLog>;
            List<AttendanceLog> records = g.ToList();
            row.Tag = records;
            row.Cells["colDept"].Value = departmentTreeview1.GetDepartmentName(records[0].StaffID);
            row.Cells["colStaff"].Value = records[0].StaffName;
            row.Cells["colReadDate"].Value = records[0].ReadDateTime.ToString("yyyy-MM-dd");
            row.Cells["colReadTime"].Value = GetAttendanceTime(records);
            row.DefaultCellStyle.ForeColor = records.Exists(it => it.IsManual) ? Color.Red : Color.Black;
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
