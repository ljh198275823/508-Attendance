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
using LJH.Attendance.BLL;

namespace LJH.Attendance.UI
{
    public partial class FrmHolidayDetail : FrmDetailBase
    {
        public FrmHolidayDetail()
        {
            InitializeComponent();
        }

        #region 重写基类方法
        protected override void ItemShowing()
        {
            Holiday info = UpdatingItem as Holiday;
            this.dtStartDate.Value = info.StartDate.Date;
            this.dtEndDate.Value = info.EndDate.Date;
            this.txtMemo.Text = info.Memo;
            if (info.WeekendToWorkDay1!=null)
            {
                checkBox1.Checked = true;
                dtWorkday1.Value = info.WeekendToWorkDay1.Value;
            }
            if (info.WeekendToWorkDay2!=null )
            {
                checkBox2.Checked = true;
                dtWorkday2.Value = info.WeekendToWorkDay2.Value;
            }
            if (info.WeekendToWorkDay3!=null )
            {
                checkBox3.Checked = true;
                dtWorkday3.Value = info.WeekendToWorkDay3.Value ;
            }
            if (info.WeekendToWorkDay4!=null )
            {
                checkBox4.Checked = true;
                dtWorkday4.Value = info.WeekendToWorkDay4.Value;
            }
            if (info.WeekendToWorkDay5!=null )
            {
                checkBox5.Checked = true;
                dtWorkday5.Value = info.WeekendToWorkDay5.Value ;
            }
            if (info.WeekendToWorkDay6!=null )
            {
                checkBox6.Checked = true;
                dtWorkday6.Value = info.WeekendToWorkDay6.Value;
            }
        }

        protected override CommandResult AddItem(object addingItem)
        {
            CommandResult ret = (new HolidayBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as Holiday);
            List<Holiday> holidays = (new HolidayBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            HolidaySetting.Current.Holidays = holidays;
            return ret;
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            CommandResult ret = (new HolidayBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as Holiday);
            List<Holiday> holidays = (new HolidayBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            HolidaySetting.Current.Holidays = holidays;
            return ret;
        }

        protected override bool CheckInput()
        {
            if (this.dtStartDate.Value.Date > this.dtEndDate.Value.Date)
            {
                MessageBox.Show(Resource1.FrmHolidayDetail_InvalidHoliday, Resource1.Form_Alert,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        protected override Object GetItemFromInput()
        {
            Holiday info;
            if (UpdatingItem == null)
            {
                info = new Holiday();
            }
            else
            {
                info = UpdatingItem as Holiday;
            }
            info.StartDate = this.dtStartDate.Value.Date;
            info.EndDate = this.dtEndDate.Value.Date;
            info.Memo = this.txtMemo.Text;
            info.WeekendToWorkDay1 = null;
            info.WeekendToWorkDay2 = null;
            info.WeekendToWorkDay3 = null;
            info.WeekendToWorkDay4 = null;
            info.WeekendToWorkDay5 = null;
            info.WeekendToWorkDay6 = null;
            if (checkBox1.Checked) info.WeekendToWorkDay1 = dtWorkday1.Value;
            if (checkBox2.Checked) info.WeekendToWorkDay2 = dtWorkday2.Value;
            if (checkBox3.Checked) info.WeekendToWorkDay3 = dtWorkday3.Value;
            if (checkBox4.Checked) info.WeekendToWorkDay4 = dtWorkday4.Value;
            if (checkBox5.Checked) info.WeekendToWorkDay5 = dtWorkday5.Value;
            if (checkBox6.Checked) info.WeekendToWorkDay6 = dtWorkday6.Value;
            return info;
        }

        protected override void InitControls()
        {
            this.dtStartDate.Value = DateTime.Today;
            this.dtEndDate.Value = DateTime.Today;
            this.dtWorkday1.Value = DateTime.Today;
            this.dtWorkday2.Value = DateTime.Today;
            this.dtWorkday3.Value = DateTime.Today;
            this.dtWorkday4.Value = DateTime.Today;
            this.dtWorkday5.Value = DateTime.Today;
            this.dtWorkday6.Value = DateTime.Today;
            this.btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditHoliday);
        }
        #endregion

        #region 事件处理程序
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, checkBox1))
            {
                dtWorkday1.Enabled = checkBox1.Checked;
            }
            else if (object.ReferenceEquals(sender, checkBox2))
            {
                dtWorkday2.Enabled = checkBox2.Checked;
            }
            else if (object.ReferenceEquals(sender, checkBox3))
            {
                dtWorkday3.Enabled = checkBox3.Checked;
            }
            else if (object.ReferenceEquals(sender, checkBox4))
            {
                dtWorkday4.Enabled = checkBox4.Checked;
            }
            else if (object.ReferenceEquals(sender, checkBox5))
            {
                dtWorkday5.Enabled = checkBox5.Checked;
            }
            else if (object.ReferenceEquals(sender, checkBox6))
            {
                dtWorkday6.Enabled = checkBox6.Checked;
            }
        }
        #endregion
    }
}
