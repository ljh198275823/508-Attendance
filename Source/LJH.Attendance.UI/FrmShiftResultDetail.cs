using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FrmShiftResultDetail : FrmDetailBase
    {
        public FrmShiftResultDetail()
        {
            InitializeComponent();
        }

        #region 公共属性
        public Staff Staff { get; set; }

        public string DeptName { get; set; }
        #endregion

        #region 重写基类方法
        protected override void InitControls()
        {
            base.InitControls();
            cmbShiftResult.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (Enum.IsDefined(typeof(AttendanceResultCode), i))
                {
                    cmbShiftResult.Items.Add(AttendanceResultDescription.GetDescription((AttendanceResultCode)i));
                }
            }
            btnOk.Enabled = Operator.CurrentOperator.Permit(Permission.EditShiftResult);
        }

        protected override bool CheckInput()
        {
            return true;
        }

        protected override void ItemShowing()
        {
            txtDept.Text = DeptName;
            if (Staff != null)
            {
                txtCertificate.Text = Staff.Certificate;
                txtName.Text = Staff.Name;
            }
            AttendanceResult ar = UpdatingItem as AttendanceResult;
            txtShiftDate.Text = ar.ShiftDate.ToLongDateString();
            txtShiftTime.Text = ar.StartTime.ToString("HH:mm") + "--" + ar.EndTime.ToString("HH:mm");
            txtRealTime.Text = (ar.OnDutyTime != null ? ar.OnDutyTime.Value.ToString("HH:mm") : new string(' ', 5)) + "--" +
                                                   (ar.OffDutyTime != null ? ar.OffDutyTime.Value.ToString("HH:mm") : new string(' ', 5));
            cmbShiftResult.SelectedIndex = (int)ar.Result;
            txtOperator.Text = ar.Modifier;
            txtMemo.Text = ar.Memo;
        }

        protected override Object GetItemFromInput()
        {
            AttendanceResult ar = UpdatingItem as AttendanceResult;
            if (IsAdding)
            {
                return null;
            }
            ar.Result = (AttendanceResultCode)cmbShiftResult.SelectedIndex;
            ar.Modifier = Operator.CurrentOperator.Name;
            ar.Memo = txtMemo.Text;
            return ar;
        }

        protected override CommandResult AddItem(object addingItem)
        {
            throw new Exception("没有实现此方法");
        }

        protected override CommandResult UpdateItem(object updatingItem)
        {
            return (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectString)).Update(updatingItem as AttendanceResult);
        }
        #endregion
    }
}
