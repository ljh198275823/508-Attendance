using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
namespace LJH.Attendance.UI.Controls
{
    public partial class AttendanceUnitComboBox : ComboBox
    {
        public AttendanceUnitComboBox()
        {
            InitializeComponent();
        }

        public AttendanceUnitComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Init()
        {
            this.Items.Clear();
            this.Items.Add(AttendanceUnitDescription.GetDescription(AttendanceUnit.Hour));
            this.Items.Add(AttendanceUnitDescription.GetDescription(AttendanceUnit.Minute));
            this.Items.Add(AttendanceUnitDescription.GetDescription(AttendanceUnit.WorkDay));
            this.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取或设置选择的单位
        /// </summary>
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AttendanceUnit SelectedUnit
        {
            get
            {
                return (AttendanceUnit)this.SelectedIndex;
            }
            set
            {
                this.SelectedIndex = (int)value;
            }
        }
    }
}
