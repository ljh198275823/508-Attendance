using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance.BLL;
using Ralid.Attendance.Model;

namespace Ralid.Attendance.UI
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
            txtStartTimeHour.IntergerValue = 9;
            txtStartTimeMinute.IntergerValue = 0;
            txtEndTimeHour.IntergerValue = 18;
            txtEndTimeMinute.IntergerValue = 0;

            if (UpdatingItem != null) SheetType = (UpdatingItem as TASheetGroup).SheetType;
            if (SheetType == "A")
            {
                List<OTType> items = (new OTTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
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
                List<VacationType> items = (new VacationTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
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
                List<TripType> items = (new TripTypeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
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
            if (dtEndDate.Value == dtStartDate.Value &&
                (txtStartTimeHour.IntergerValue * 60 + txtStartTimeMinute.IntergerValue) > (txtEndTimeHour.IntergerValue * 60 + txtEndTimeMinute.IntergerValue))
            {
                MessageBox.Show("开始时间大于结束时间");
                return false;
            }
            if (txtDuration.Value <= 0)
            {
                MessageBox.Show("计时时间不正确");
                txtDuration.Focus();
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
                txtStartTimeHour.IntergerValue = item.StartTime.Hour;
                txtStartTimeMinute.IntergerValue = item.StartTime.Minute;
                txtEndTimeHour.IntergerValue = item.EndTime.Hour;
                txtEndTimeMinute.IntergerValue = item.EndTime.Minute;
                txtDuration.Value = item.Duration;
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
                item.SheetID = Guid.NewGuid();
                item.SheetType = SheetType;
                item.CreateDate = DateTime.Now;
            }
            item.StartDate = dtStartDate.Value;
            item.EndDate = dtEndDate.Value;
            item.StartTime = new MyTime(txtStartTimeHour.IntergerValue, txtStartTimeMinute.IntergerValue, 0);
            item.EndTime = new MyTime(txtEndTimeHour.IntergerValue, txtEndTimeMinute.IntergerValue, 0);
            item.Duration =(int) txtDuration.Value;
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
            return (new TASheetBLL(AppSettings.CurrentSetting.ConnectString)).Save(addingItem as TASheetGroup);
        }

        protected override Model.Result.CommandResult UpdateItem(object updatingItem)
        {
            return (new TASheetBLL(AppSettings.CurrentSetting.ConnectString)).Save(updatingItem as TASheetGroup);
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
    }
}