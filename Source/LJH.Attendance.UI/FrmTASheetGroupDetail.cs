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
    public partial class FrmTASheetGroupDetail : FrmDetailBase
    {
        public FrmTASheetGroupDetail()
        {
            InitializeComponent();
        }

        #region 私有方法
        private string GetCategory()
        {
            foreach (Control ctrl in this.flowLayoutPanel1.Controls)
            {
                RadioButton rd = ctrl as RadioButton;
                if (rd.Checked)
                {
                    return rd.Tag.ToString();
                }
            }
            return string.Empty;
        }

        private void SetCategory(string category)
        {
            foreach (Control ctrl in this.flowLayoutPanel1.Controls)
            {
                RadioButton rd = ctrl as RadioButton;
                if (rd.Tag.ToString() == category)
                {
                    rd.Checked = true;
                    break;
                }
            }
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置单据类别(‘A’表示加班单，‘B’表示请假单，‘C’表示外出出差单
        /// </summary>
        public string SheetType { get; set; }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            DateTime dt = DateTime.Today;
            dtStartDate.Value = new DateTime(dt.Year, dt.Month, dt.Day);
            dtEndDate.Value = new DateTime(dt.Year, dt.Month, dt.Day);
           
            if (UpdatingItem != null) SheetType = (UpdatingItem as TASheetGroup).SheetType;
            if (SheetType == "A")
            {
                List<OTType> items = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
                if (items != null && items.Count > 0)
                {
                    foreach (OTType item in items)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Name = item.ID;
                        rb.Text = item.Name;
                        rb.Tag = item.ID;
                        this.flowLayoutPanel1.Controls.Add(rb);
                    }
                }
            }
            else if (SheetType == "B")
            {
                List<VacationType> items = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
                if (items != null && items.Count > 0)
                {
                    foreach (VacationType item in items)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Name = item.ID;
                        rb.Text = item.Name;
                        rb.Tag = item.ID;
                        this.flowLayoutPanel1.Controls.Add(rb);
                    }
                }
            }
            else if (SheetType == "C")
            {
                List<TripType> items = (new TripTypeBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
                if (items != null && items.Count > 0)
                {
                    foreach (TripType item in items)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Name = item.ID;
                        rb.Text = item.Name;
                        rb.Tag = item.ID;
                        this.flowLayoutPanel1.Controls.Add(rb);
                    }
                }
            }
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditTASheet);
        }

        protected override bool CheckInput()
        {
            if (treeView1.Nodes.Count == 0)
            {
                MessageBox.Show("没有选择人员");
                return false;
            }
            if (dtEndDate.Value < dtStartDate.Value)
            {
                MessageBox.Show("开始日期大于结束日期");
                return false;
            }
            if ((txtStartHour1.Value * 60 + txtStartMinute1.Value) > (txtEndHour1.Value * 60 + txtEndMinute1.Value) && !chkNextDay1.Checked)
            {
                MessageBox.Show("开始时间大于结束时间");
                return false;
            }
            if ((txtStartHour2.Value * 60 + txtStartMinute2.Value) > (txtEndHour2.Value * 60 + txtEndMinute2.Value) && !chkNextDay2.Checked)
            {
                MessageBox.Show("开始时间大于结束时间");
                return false;
            }
            if ((txtStartHour3.Value * 60 + txtStartMinute3.Value) > (txtEndHour3.Value * 60 + txtEndMinute3.Value) && !chkNextDay3.Checked)
            {
                MessageBox.Show("开始时间大于结束时间");
                return false;
            }
            if (txtDuration1.Value <= 0)
            {
                MessageBox.Show("计时时间不正确");
                txtDuration1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(GetCategory()))
            {
                MessageBox.Show("没有选择假别");
                return false;
            }

            return true;
        }

        protected override void ItemShowing()
        {
            TASheetGroup item = UpdatingItem as TASheetGroup;
            if (item != null)
            {
                dtStartDate.Value = item.StartDate;
                dtEndDate.Value = item.EndDate;
                for (int i = 0; i < item.Items.Count; i++)
                {
                    if (i == 0)
                    {
                        chkTime1.Checked = true;
                        txtStartHour1.Value = item.Items [0].StartTime.Hour;
                        txtStartMinute1.Value = item.Items[0].StartTime.Minute;
                        chkNextDay1.Checked = item.Items[0].NextDay;
                        txtEndHour1.Value = item.Items[0].EndTime.Hour;
                        txtEndMinute1.Value = item.Items[0].EndTime.Minute;
                        txtDuration1.Value = item.Items[0].Duration;
                    }
                    else if (i == 1)
                    {
                        chkTime2.Checked = true;
                        txtStartHour2.Value = item.Items[1].StartTime.Hour;
                        txtStartMinute2.Value = item.Items[1].StartTime.Minute;
                        chkNextDay2.Checked = item.Items[1].NextDay;
                        txtEndHour2.Value = item.Items[1].EndTime.Hour;
                        txtEndMinute2.Value = item.Items[1].EndTime.Minute;
                        txtDuration2.Value = item.Items[1].Duration;
                    }
                    else if (i == 2)
                    {
                        chkTime3.Checked = true;
                        txtStartHour3.Value = item.Items[2].StartTime.Hour;
                        txtStartMinute3.Value = item.Items[2].StartTime.Minute;
                        chkNextDay3.Checked = item.Items[2].NextDay;
                        txtEndHour3.Value = item.Items[2].EndTime.Hour;
                        txtEndMinute3.Value = item.Items[2].EndTime.Minute;
                        txtDuration3.Value = item.Items[2].Duration;
                    }
                }
                SetCategory(item.Category);
                txtMemo.Text = item.Memo;
                txtHeader.Text = item.Header;
                txtManager.Text = item.Manager;
                foreach (Staff staff in item.Staff)
                {
                    TreeNode node = new TreeNode(staff.Name);
                    node.Tag = staff;
                    this.treeView1.Nodes.Add(node);
                }
            }
        }

        protected override object GetItemFromInput()
        {
            TASheetGroup item = UpdatingItem as TASheetGroup;
            if (item == null)
            {
                item = new TASheetGroup();
                item.SheetType = SheetType;
                item.CreateDate = DateTime.Now;
            }
            item.StartDate = dtStartDate.Value;
            item.EndDate = dtEndDate.Value;
            if (item.Items == null) item.Items = new List<TASheetItem>();
            item.Items.Clear();
            if (chkTime1.Checked)
            {
                TASheetItem ti = new TASheetItem();
                ti.ID = Guid.NewGuid();
                ti.StartTime = new MyTime((int)txtStartHour1.Value, (int)txtStartMinute1.Value, 0);
                ti.NextDay = chkNextDay1.Checked;
                ti.EndTime = new MyTime((int)txtEndHour1.Value, (int)txtEndMinute1.Value, 0);
                ti.Duration = txtDuration1.Value;
                item.Items.Add(ti);
            }
            if (chkTime2.Checked)
            {
                TASheetItem ti = new TASheetItem();
                ti.ID = Guid.NewGuid();
                ti.StartTime = new MyTime((int)txtStartHour2.Value, (int)txtStartMinute2.Value, 0);
                ti.NextDay = chkNextDay2.Checked;
                ti.EndTime = new MyTime((int)txtEndHour2.Value, (int)txtEndMinute2.Value, 0);
                ti.Duration = txtDuration2.Value;
                item.Items.Add(ti);
            }
            if (chkTime3.Checked)
            {
                TASheetItem ti = new TASheetItem();
                ti.ID = Guid.NewGuid();
                ti.StartTime = new MyTime((int)txtStartHour3.Value, (int)txtStartMinute3.Value, 0);
                ti.NextDay = chkNextDay3.Checked;
                ti.EndTime = new MyTime((int)txtEndHour3.Value, (int)txtEndMinute3.Value, 0);
                ti.Duration = txtDuration3.Value;
                item.Items.Add(ti);
            }
            item.Category = GetCategory();
            item.Memo = txtMemo.Text;
            item.Header = txtHeader.Text;
            item.Manager = txtManager.Text;
            if (item.Staff == null) item.Staff = new List<Staff>();
            item.Staff.Clear();
            foreach (TreeNode node in treeView1.Nodes)
            {
                item.Staff.Add(node.Tag as Staff);
            }
            return item;
        }

        protected override Model.Result.CommandResult AddItem(object addingItem)
        {
            return (new TASheetBLL(AppSettings.CurrentSetting.ConnectUri)).Save(addingItem as TASheetGroup);
        }

        protected override Model.Result.CommandResult UpdateItem(object updatingItem)
        {
            return (new TASheetBLL(AppSettings.CurrentSetting.ConnectUri)).Save(updatingItem as TASheetGroup);
        }
        #endregion

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<Staff> staff = new List<Staff>();
            foreach (TreeNode node in treeView1.Nodes)
            {
                staff.Add(node.Tag as Staff);
            }

            FrmStaffSelection frm = new FrmStaffSelection();
            frm.SelectedStaff = staff;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Staff> items = frm.SelectedStaff;
                if (items != null && items.Count > 0)
                {
                    this.treeView1.Nodes.Clear();
                    foreach (Staff item in items)
                    {
                        TreeNode node = new TreeNode(item.Name);
                        node.Tag = item;
                        treeView1.Nodes.Add(node);
                    }
                }
            }
        }

        private void txtStartHour1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dt1 = today.AddHours((int)txtStartHour1.Value).AddMinutes((int)txtStartMinute1.Value);
            DateTime dt2 = today.AddHours((int)txtEndHour1.Value).AddMinutes((int)txtEndMinute1.Value);
            if (chkNextDay1.Checked) dt2 = dt2.AddDays(1);
            TimeSpan ts = new TimeSpan(dt2.Ticks - dt1.Ticks);
            txtDuration1.Value = ts.TotalMinutes > 0 ? (int)ts.TotalMinutes : 0;
        }

        private void txtStartHour2_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dt1 = today.AddHours((int)txtStartHour2.Value).AddMinutes((int)txtStartMinute2.Value);
            DateTime dt2 = today.AddHours((int)txtEndHour2.Value).AddMinutes((int)txtEndMinute2.Value);
            if (chkNextDay2.Checked) dt2 = dt2.AddDays(1);
            TimeSpan ts = new TimeSpan(dt2.Ticks - dt1.Ticks);
            txtDuration2.Value = ts.TotalMinutes > 0 ? (int)ts.TotalMinutes : 0;
        }

        private void txtStartHour3_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dt1 = today.AddHours((int)txtStartHour3.Value).AddMinutes((int)txtStartMinute3.Value);
            DateTime dt2 = today.AddHours((int)txtEndHour3.Value).AddMinutes((int)txtEndMinute3.Value);
            if (chkNextDay3.Checked) dt2 = dt2.AddDays(1);
            TimeSpan ts = new TimeSpan(dt2.Ticks - dt1.Ticks);
            txtDuration3.Value = ts.TotalMinutes > 0 ? (int)ts.TotalMinutes : 0;
        }
    }
}