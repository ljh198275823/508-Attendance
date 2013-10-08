using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ralid.Attendance.UI
{
    public partial class UCDateTimeInterval : UserControl
    {
        public UCDateTimeInterval()
        {
            InitializeComponent();
        }

        public event EventHandler DateRangeChanged;

        #region 公共方法
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
        }
        /// <summary>
        /// 获取或设置开始时间
        /// </summary>
        public DateTime StartDateTime
        {
            get
            {
                return this.dtStart.Value;
            }
            set
            {
                this.dtStart.Value = value;
            }
        }
        /// <summary>
        /// 获取或设置结束时间
        /// </summary>
        public DateTime EndDateTime
        {
            get
            {
                return this.dtEnd.Value;
            }
            set
            {
                this.dtEnd.Value = value;
            }
        }
        /// <summary>
        /// 选择本月
        /// </summary>
        public void SelectThisMonth()
        {
            DateTime dt = DateTime.Today;
            this.dtStart.Value = new DateTime(dt.Year, dt.Month, 1);
            this.dtEnd.Value = this.dtStart.Value.AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// 选择本月
        /// </summary>
        public void SelectPreMonth()
        {
            DateTime dt = DateTime.Today.AddMonths(-1);
            this.dtStart.Value = new DateTime(dt.Year, dt.Month, 1);
            this.dtEnd.Value = this.dtStart.Value.AddMonths(1).AddDays(-1);
        }
        #endregion

        #region 事件处理程序
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dtEnd.Value < dtStart.Value)
            {
                dtEnd.Value = dtStart.Value;
            }
        }
        #endregion

        private void btnPreMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = this.dtStart.Value.AddMonths(-1);
            this.dtStart.Value = new DateTime(dt.Year, dt.Month, 1);
            this.dtEnd.Value = this.dtStart.Value.AddMonths(1).AddDays(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = this.dtStart.Value.AddMonths(1);
            this.dtStart.Value = new DateTime(dt.Year, dt.Month, 1);
            this.dtEnd.Value = this.dtStart.Value.AddMonths(1).AddDays(-1);
        }
    }
}
