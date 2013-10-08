using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ralid.Attendance .Model ;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.BLL;

namespace Ralid.Attendance.UI
{
    public partial class FrmCopyToDate : Form
    {
        public FrmCopyToDate()
        {
            InitializeComponent();
        }

        #region 私有方法
        private string GetShiftString(List<Shift> items)
        {
            if (items == null || items.Count == 0) return string.Empty;
            string ret = string.Empty;
            int count = 0;
            foreach (Shift item in items)
            {
                if (count > 0) ret += ",";
                ret += !string.IsNullOrEmpty(item.ShortName) ? item.ShortName : item.Name;
                count++;
            }
            return ret;
        }

        private List<ShiftArrange> GetShiftArranges()
        {
            List<ShiftArrange> items = new List<ShiftArrange>();
            DateTime dt = dtBegin.Value;
            while (dt <= dtEnd.Value)
            {
                if (HolidaySetting.Current != null && HolidaySetting.Current.IsHoliday(dt) && chkNoShiftOnHoliday.Checked) //节假日不排班
                {
                    continue;
                }
                if ((dt.DayOfWeek == DayOfWeek.Monday && chkMonday.Checked) ||
                    (dt.DayOfWeek == DayOfWeek.Tuesday && chkTuesday.Checked) ||
                    (dt.DayOfWeek == DayOfWeek.Wednesday && chkWednesday.Checked) ||
                    (dt.DayOfWeek == DayOfWeek.Thursday && chkThursday.Checked) ||
                    (dt.DayOfWeek == DayOfWeek.Friday && chkFriday.Checked) ||
                    (dt.DayOfWeek == DayOfWeek.Saturday && chkSaturday.Checked) ||
                    (dt.DayOfWeek == DayOfWeek.Sunday && chkSunday.Checked) ||
                    ((dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday) && chkWeekendToWorkdayNeedShift.Checked && !HolidaySetting.Current.IsWeekend(dt)) //
                    )
                {
                    if (SourceShifts != null && SourceShifts.Count > 0)
                    {
                        foreach (Shift s in SourceShifts)
                        {
                            ShiftArrange sa = new ShiftArrange()
                            {
                                StaffID = Staff.ID,
                                ShiftDate = dt,
                                ShiftID = s.ID,
                                Shift = s
                            };
                            items.Add(sa);
                        }
                    }
                }
                dt = dt.AddDays(1);
            }
            return items;
        }
        #endregion

        #region 公共属性
        public Staff Staff { get; set; }

        public DateTime SourceDate { get; set; }

        public List<Shift> SourceShifts { get; set; }

        public List<ShiftArrange> ShiftArranges { get; set; }
        #endregion

        #region 事件处理函数
        private void FrmCopyToDate_Load(object sender, EventArgs e)
        {
            dtSource.Value = SourceDate;
            txtSourceShifts.Text = GetShiftString(SourceShifts);

            dtBegin.Value = SourceDate.Date.AddDays(1); //增加一天
            dtEnd.Value = (new DateTime(SourceDate.Year, SourceDate.Month, 1)).AddMonths(1).AddDays(-1); //月底最后一天
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtEnd.Value < dtBegin.Value)
            {
                MessageBox.Show("\"复制到\" 里面的结束时间小于开始时间");
                return;
            }
            DatetimeRange dr = new DatetimeRange(dtBegin.Value, dtEnd.Value);
            List<ShiftArrange> items = GetShiftArranges();
            CommandResult ret = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectString)).ShiftArrange(Staff.ID, dr, items);
            if (ret.Result == ResultCode.Successful)
            {
                ShiftArranges = items;
                this.DialogResult = DialogResult.OK;
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
        #endregion
    }
}
