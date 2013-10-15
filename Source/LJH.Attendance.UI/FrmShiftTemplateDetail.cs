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
    public partial class FrmShiftTemplateDetail : FrmDetailBase
    {
        public FrmShiftTemplateDetail()
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
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditShiftTemplate);
        }

        protected override bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("模板名称不能为空");
                txtName.Focus();
                return false;
            }
            bool selectedOne = false;
            for (int i = 1; i <= 6; i++)
            {
                if ((this.Controls["chkShift" + i.ToString()] as CheckBox).Checked)
                {
                    selectedOne = true;
                    List<Shift> shifts= (this.Controls["txtShifts" + i.ToString()] as TextBox).Tag as List<Shift>;
                    if (shifts == null || shifts.Count == 0)
                    {
                        MessageBox.Show("模板第 " + i.ToString () + " 项没有选择班次");
                        return false;
                    }
                    int duration = (int)(this.Controls["txtDuration" + i.ToString()] as NumericUpDown).Value;
                    if (duration <= 0)
                    {
                        MessageBox.Show("模板第 " + i.ToString() + " 项没有设置持续数量");
                        return false;
                    }
                }
            }
            if (!selectedOne)
            {
                MessageBox.Show("请至少设置一个模板项");
                return false;
            }
            return true;
        }

        protected override void ItemShowing()
        {
            ShiftTemplate item = UpdatingItem as ShiftTemplate;
            if (item == null) return;
            txtName.Text = item.Name;
            chkHolidayShifted.Checked = (item.Options & TemplateOptions.HolidayShifted) == TemplateOptions.HolidayShifted;
            chkWeekendShifted.Checked = (item.Options & TemplateOptions.WeekendShifted) == TemplateOptions.WeekendShifted;
            if (item.Items != null && item.Items.Count > 0)
            {
                int i = 0;
                foreach (TemplateItem it in item.Items)
                {
                    i++;
                    if (i > 6) break;
                    (this.Controls["chkShift" + i.ToString()] as CheckBox).Checked = true;
                    (this.Controls["txtShifts" + i.ToString()] as TextBox).Text = GetShiftString(it.Shifts);
                    (this.Controls["txtShifts" + i.ToString()] as TextBox).Tag = it.Shifts;
                    (this.Controls["txtDuration" + i.ToString()] as NumericUpDown).Value = it.Duration;
                    Control panel = this.Controls["panel" + i.ToString()];
                    (panel.Controls["rdDay" + i.ToString()] as RadioButton).Checked = it.DurationUnit == 0;
                    (panel.Controls["rdTime" + i.ToString()] as RadioButton).Checked = it.DurationUnit == 1;
                    (this.Controls["txtRest" + i.ToString()] as NumericUpDown).Value = it.RestDays;
                }
            }
            txtMemo.Text = item.Memo;
        }

        protected override object GetItemFromInput()
        {
            ShiftTemplate item = UpdatingItem as ShiftTemplate;
            if (item == null)
            {
                item = new ShiftTemplate();
                item.ID = Guid.NewGuid();
            }
            item.Name = txtName.Text;
            item.Options = TemplateOptions.None;
            if (chkHolidayShifted.Checked) item.Options |= TemplateOptions.HolidayShifted;
            if (chkWeekendShifted.Checked) item.Options |= TemplateOptions.WeekendShifted;
            if (item.Items == null) item.Items = new List<TemplateItem>();
            item.Items.Clear();
            for (int i = 1; i <= 6; i++)
            {
                if ((this.Controls["chkShift" + i.ToString()] as CheckBox).Checked)
                {
                    TemplateItem it = new TemplateItem();
                    it.Shifts = (this.Controls["txtShifts" + i.ToString()] as TextBox).Tag as List<Shift>;
                    it.Duration = (int)(this.Controls["txtDuration" + i.ToString()] as NumericUpDown).Value;
                    Control panel = this.Controls["panel" + i.ToString()];
                    it.DurationUnit = (panel.Controls["rdTime" + i.ToString()] as RadioButton).Checked ? 1 : 0;
                    it.RestDays = (int)(this.Controls["txtRest" + i.ToString()] as NumericUpDown).Value;
                    item.Items.Add(it);
                }
            }
            item.Memo = txtMemo.Text;
            return item;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            return (new ShiftTemplateBLL(AppSettings.CurrentSetting.ConnectString)).Add(addingItem as ShiftTemplate);
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new ShiftTemplateBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as ShiftTemplate);
        }
        #endregion

        private void lnkShift_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (object.ReferenceEquals(this.Controls["lnkShift" + i.ToString()], sender))
                {
                    FrmShiftSelection frm = new FrmShiftSelection();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.SelectedShifts = this.Controls["txtShifts" + i.ToString()].Tag as List<Shift>;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        List<Shift> shifts = frm.SelectedShifts;
                        this.Controls["txtShifts" + i.ToString()].Tag = shifts;
                        (this.Controls["txtShifts" + i.ToString()] as TextBox).Text = GetShiftString(shifts);
                    }
                }
            }
        }

        private void chkShift_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (object.ReferenceEquals(this.Controls["chkShift" + i.ToString()], sender))
                {
                    this.Controls["lnkShift" + i.ToString()].Enabled = (this.Controls["chkShift" + i.ToString()] as CheckBox).Checked;
                }
            }
        }
    }
}
