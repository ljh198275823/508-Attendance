using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ralid.Attendance.UI
{
    public partial class FrmReportBase : Form
    {
        public FrmReportBase()
        {
            InitializeComponent();
        }

        #region 事件
        public event EventHandler ItemSearching;

        protected virtual void OnItemSearching(EventArgs e)
        {
            if (this.ItemSearching != null) this.ItemSearching(this, EventArgs.Empty);
        }
        #endregion

        #region 公共属性
        public DataGridView GridView
        {
            get
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is DataGridView)
                    {
                        return ctrl as DataGridView;
                    }
                }
                return null;
            }
        }
        #endregion

        #region 事件处理程序
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = this.GridView;
                if (view != null)
                {
                    saveFileDialog1.Filter = Resource1.Form_ExcelFilter;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog1.FileName;
                        if (Ralid.GeneralLibrary.WinformControl.DataGridViewExporter.Export(view, path)) MessageBox.Show(Resource1.FrmReportBase_SaveSuccess);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OnItemSearching(EventArgs.Empty);
            this.searchInfo.Text = string.Format(Resource1.FrmMasterBase_StatusBar, this.GridView.Rows.Count);
        }

        private void FrmReportBase_Load(object sender, EventArgs e)
        {
            if (GridView != null)
            {
                GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
        #endregion
    }
}
