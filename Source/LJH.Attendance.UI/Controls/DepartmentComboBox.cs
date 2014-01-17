using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.BLL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;

namespace LJH.Attendance.UI
{
    public partial class DepartmentComboBox :ComboBox 
    {
        public DepartmentComboBox()
        {
            InitializeComponent();
        }

        public DepartmentComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 公共方法
        public void Init()
        {
            DepartmentBLL bll = new DepartmentBLL(AppSettings.CurrentSetting.ConnectString);
            List<Department> items = bll.GetItems(null).QueryObjects;
            this.Items.Clear();
            this.Items.Add("");
            foreach (var item in items)
            {
                this.Items.Add(item);
            }
            this.DisplayMember = "Name";
            this.SelectedIndex = 0;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DepartmentID
        {
            get
            {
                if (this.SelectedIndex <= 0)
                {
                    return string.Empty;
                }
                else
                {
                    Department info = this.Items[SelectedIndex] as Department;
                    return info.ID;
                }
            }
            set
            {
                this.SelectedIndex = -1;
                for (int i = 0; i < this.Items.Count; i++)
                {
                    Department info = this.Items[i] as Department;
                    if (info != null && info.ID == value)
                    {
                        this.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Department SelectecDepartment
        {
            get
            {
                if (this.SelectedIndex == -1)
                {
                    return null;
                }
                return this.Items[SelectedIndex] as Department;
            }
        }
        #endregion
    }
}
