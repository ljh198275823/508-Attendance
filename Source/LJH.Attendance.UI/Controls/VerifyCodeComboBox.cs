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
    public partial class VerifyCodeComboBox : ComboBox
    {
        public VerifyCodeComboBox()
        {
            InitializeComponent();
        }

        public VerifyCodeComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region 公共属性和方法
        public void Init()
        {
            this.Items.Clear();
            TextValueItem<VerifyCode>[] items = new TextValueItem<VerifyCode>[]{
            new TextValueItem<VerifyCode>(VerifyCode.None , string.Empty ),
            new TextValueItem <VerifyCode>(VerifyCode.FP_AND_PW ,"指纹加密码"),
            new TextValueItem<VerifyCode>(VerifyCode.PIN_AND_FP,"指纹加卡"),
            new TextValueItem<VerifyCode>(VerifyCode.FP_AND_PW_AND_PIN, "指纹加卡加密码"),
            };
            this.DataSource = items;
            this.DisplayMember = "Text";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取或设置选择的单位
        /// </summary>
        [Browsable(false)]
        [Localizable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VerifyCode SelectedVerifyCode
        {
            get
            {
                VerifyCode mode = VerifyCode.None;
                if (this.SelectedItem != null)
                {
                    TextValueItem<VerifyCode> item = SelectedItem as TextValueItem<VerifyCode>;
                    if (item != null)
                    {
                        mode = item.Value;
                    }
                }
                return mode;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    TextValueItem<VerifyCode> item = Items[i] as TextValueItem<VerifyCode>;
                    if (item != null && item.Value == value)
                    {
                        SelectedIndex = i;
                    }
                }
            }
        }
        #endregion
    }
}
