using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows .Forms ;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.BLL;

namespace Ralid.Attendance.UI
{
    public partial class RoleComboBox:ComboBox 
    {
        public RoleComboBox()
        {
            InitializeComponent();
        }

        public RoleComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Init()
        {
            RoleBll bll = new RoleBll(Ralid.Attendance.Model.AppSettings.CurrentSetting.ConnectString);
            this.DataSource = bll.GetAllRoles().QueryObjects;
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Role Role
        {
            get
            {
                if (this.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return ((Role)this.Items[SelectedIndex]);
                }
            }
            set
            {
                for (int i=0 ;i<this.Items.Count ;i++)
                {
                    Role info = (Role)this.Items[i];
                    if (info.ID == value.ID)
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
        public string SelectedRoleID
        {
            get
            {
                if (this.SelectedIndex == -1)
                {
                    return string.Empty;
                }
                else
                {
                    Role role = (Role)this.Items[SelectedIndex];
                    return role.ID;
                }
            }
            set
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    Role info = (Role)this.Items[i];
                    if (info.ID == value)
                    {
                        this.SelectedIndex = i;
                        break;
                    }
                }
            }
        }


    }
}
