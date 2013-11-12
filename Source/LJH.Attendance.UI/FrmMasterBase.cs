using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.SearchCondition;

namespace LJH.Attendance.UI
{
    public partial class FrmMasterBase : Form
    {
        public FrmMasterBase()
        {
            InitializeComponent();
        }


        #region 私有变量
        private DataGridView _gridView;

        private DataGridView GridView
        {
            get
            {
                if (_gridView == null)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is DataGridView)
                        {
                            _gridView = ctrl as DataGridView;
                        }
                    }
                }
                return _gridView;
            }
        }

        private Panel _PnlLeft;

        private Panel PnlLeft
        {
            get
            {
                if (_PnlLeft == null)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is Panel && ctrl.Name == "pnlLeft")
                        {
                            _PnlLeft = ctrl as Panel;
                            break;
                        }
                    }
                }
                return _PnlLeft;
            }
        }
        #endregion

        #region 私有方法
        private void InitToolbar()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ToolStrip && ctrl.Name == "menu")  //初始化子窗体的菜单，如果有的话
                {
                    MenuStrip menu = ctrl as MenuStrip;
                    if (menu.Items["btn_Add"] != null) menu.Items["btn_Add"].Click += btnAdd_Click;
                    if (menu.Items["btn_Delete"] != null) menu.Items["btn_Delete"].Click += btnDelete_Click;
                    if (menu.Items["btn_Export"] != null) menu.Items["btn_Export"].Click += btnExport_Click;
                    if (menu.Items["btn_Fresh"] != null) menu.Items["btn_Fresh"].Click += btnFresh_Click;
                    if (menu.Items["btn_SelectColumns"] != null) menu.Items["btn_SelectColumns"].Click += btn_SelectColumns_Click;
                    if (menu.Items["btnSearch"] != null) menu.Items["btnSearch"].Click += btnSearch_Click;
                    if (menu.Items["btnClear"] != null) menu.Items["btnClear"].Click += btnClear_Click;
                    if (menu.Items["txtKeyword"] != null && menu.Items["txtKeyword"] is ToolStripTextBox)
                    {
                        (menu.Items["txtKeyword"] as ToolStripTextBox).TextChanged += txtKeyword_TextChanged;
                    }
                    break;
                }
            }
        }

        private void InitGridView()
        {
            if (GridView != null)
            {
                if (ForSelect)
                {
                    GridView.CellDoubleClick += GridView_DoubleClick1;
                }
                else
                {
                    GridView.CellDoubleClick += GridView_DoubleClick;
                }
                GridView.CellMouseDown += GridView_CellMouseDown;
                GridView.Sorted += new EventHandler(GridView_Sorted);
            }
        }

        private void ShowVisableColumns()
        {
            DataGridView grid = this.GridView;
            if (grid == null) return;
            string temp = AppSettings.CurrentSetting.GetConfigContent(string.Format("{0}_Columns", this.GetType().Name));
            if (string.IsNullOrEmpty(temp)) return;
            List<string> cols = temp.Split(',').ToList();

            foreach (DataGridViewColumn c in grid.Columns)
            {
                int index = cols.IndexOf(c.Name);
                c.Visible = index >= 0;
                if (index >= 0)
                {
                    c.DisplayIndex = index;
                }
            }
        }

        protected DataGridViewRow Add_A_Row(object item, bool forNewItem)
        {
            int row = GridView.Rows.Add();
            ShowItemInGridViewRow(GridView.Rows[row], item);
            GridView.Rows[row].Tag = item;
            if (forNewItem)
            {
                if (this.GridView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow r in GridView.SelectedRows)
                    {
                        r.Selected = false;
                    }
                }
                GridView.Rows[row].Selected = true;
                if (row > GridView.DisplayedColumnCount(false))
                {
                    GridView.FirstDisplayedScrollingRowIndex = row - GridView.DisplayedColumnCount(false) + 1;
                }
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", GridView.Rows.Count);
            return GridView.Rows[row];
        }

        private void Update_A_Row(object item)
        {
            foreach (DataGridViewRow row in GridView.Rows)
            {
                object pre = row.Tag;
                if (pre != null && pre == item)
                {
                    ShowItemInGridViewRow(row, item);
                }
            }
        }

        private string[] GetAllVisiableColumns()
        {
            if (GridView != null)
            {
                List<DataGridViewColumn> cols = new List<DataGridViewColumn>();
                foreach (DataGridViewColumn col in GridView.Columns)
                {
                    if (col.Visible) cols.Add(col);
                }
                return (from col in cols
                        orderby col.DisplayIndex ascending
                        select col.Name).ToArray();
            }
            return null;
        }

        private Button GetActiveButtonOnLeftPanel()
        {
            Button b = null;
            if (PnlLeft != null)
            {
                foreach (Control ctrl in PnlLeft.Controls)
                {
                    if (ctrl is Button)
                    {
                        if (b == null) b = ctrl as Button; //先将第一个按钮设置成活动按钮
                        if ((ctrl as Button).BackColor == SystemColors.ControlDark)
                        {
                            b = ctrl as Button;
                            break;
                        }
                    }
                }
            }
            return b;
        }

        private void btnLeftPanelButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                foreach (Control ctrl in PnlLeft.Controls)
                {
                    if (ctrl is Button)
                    {
                        (ctrl as Button).BackColor = SystemColors.Control;
                    }
                }
                Button b = sender as Button;
                b.BackColor = SystemColors.ControlDark;
                ShowItemsOnGrid(b.Tag as List<object>);
            }
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置窗体是否是用来做选择用的,(此属性需要在窗体显示之前指定)
        /// </summary>
        public bool ForSelect { get; set; }
        /// <summary>
        /// 获取或设置窗体在选择模式下的选择项
        /// </summary>
        public object SelectedItem { get; set; }
        #endregion

        #region 子类要重写的方法
        protected virtual void Init()
        {
            InitToolbar();
            InitGridView();
            ShowVisableColumns();
        }

        protected virtual FrmDetailBase GetDetailForm()
        {
            return null;
        }

        protected virtual List<object> GetDataSource()
        {
            return null;
        }

        protected virtual void ShowItemInGridViewRow(DataGridViewRow row, object item)
        {

        }

        protected virtual bool DeletingItem(object item)
        {
            return false;
        }
        #endregion

        #region 公共方法
        protected void ShowItemsOnGrid(List<object> items)
        {
            GridView.Rows.Clear();

            if (items != null && items.Count > 0)
            {
                foreach (object item in items)
                {
                    DataGridViewRow row = Add_A_Row(item, false);
                }
            }
            ShowRowBackColor();
            if (this.GridView.Rows.Count > 0)
            {
                this.GridView.Rows[0].Selected = false;
                this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", GridView.Rows.Count);
            }
        }

        protected virtual void ShowRowBackColor()
        {
            int count = 0;
            foreach (DataGridViewRow row in this.GridView.Rows)
            {
                if (row.Visible)
                {
                    count++;
                    row.DefaultCellStyle.BackColor = (count % 2 == 1) ? Color.FromArgb(230, 230, 230) : Color.White;
                }
            }
        }

        public virtual void Fresh(SearchCondition search)
        {
            btnFresh_Click(null, EventArgs.Empty);
        }
        #endregion

        #region 事件处理
        private void FrmMasterBase_Load(object sender, EventArgs e)
        {
            Init();
            if (PnlLeft != null)
            {
                foreach (Control ctrl in PnlLeft.Controls)
                {
                    if (ctrl is Button)
                    {
                        (ctrl as Button).Click += btnLeftPanelButton_Click;
                    }
                }
            }
            if (GridView != null)
            {
                btnFresh_Click(null, null);
            }
        }

        private void GridView_Sorted(object sender, EventArgs e)
        {
            ShowRowBackColor();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDetailBase detailForm = GetDetailForm();
                if (detailForm != null)
                {
                    detailForm.IsAdding = true;
                    DataGridViewRow row = null;
                    detailForm.ItemAdded += delegate(object obj, ItemAddedEventArgs args)
                    {
                        row = Add_A_Row(args.AddedItem, true);
                    };
                    detailForm.ItemUpdated += delegate(object obj, ItemUpdatedEventArgs args)
                    {
                        ShowItemInGridViewRow(row, args.UpdatedItem);
                    };
                    detailForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GridView.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> deletingRows = new List<DataGridViewRow>();

                    DialogResult result = MessageBox.Show("确实要删除所选项吗?", "确定", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = GridView.Rows.Count - 1; i > -1; i--)
                        {
                            DataGridViewRow row = GridView.Rows[i];
                            if (row.Selected)
                            {
                                object deletingItem = row.Tag;
                                if (DeletingItem(deletingItem))
                                {
                                    deletingRows.Add(row);
                                }
                            }
                        }
                        foreach (DataGridViewRow row in deletingRows)
                        {
                            GridView.Rows.Remove(row);
                        }
                        this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", GridView.Rows.Count);
                    }
                }
                else
                {
                    MessageBox.Show("没有选择项!", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            List<object> datasource = GetDataSource();
            ShowItemsOnGrid(datasource);
            foreach (Control ctrl in this.Controls)
            {
                MenuStrip menu = ctrl as MenuStrip;
                if (ctrl is ToolStrip && ctrl.Name == "menu")  //初始化子窗体的菜单，如果有的话
                {
                    if (menu.Items["txtKeyword"] != null && menu.Items["txtKeyword"] is ToolStripTextBox)
                    {
                        txtKeyword_TextChanged(menu.Items["txtKeyword"], EventArgs.Empty);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = this.GridView;
                if (view != null)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel文档|*.xls|所有文件(*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog1.FileName;
                        if (LJH.GeneralLibrary.WinformControl.DataGridViewExporter.Export(view, path, false))
                        {
                            MessageBox.Show("导出成功");
                        }
                        else
                        {
                            MessageBox.Show("保存到电子表格时出现错误!");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("保存到电子表格时出现错误!");
            }
        }

        private void btn_SelectColumns_Click(object sender, EventArgs e)
        {
            FrmColumnSelection frm = new FrmColumnSelection();
            frm.Selectee = this.GridView;
            frm.SelectedColumns = GetAllVisiableColumns();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string[] cols = frm.SelectedColumns;
                if (cols != null && cols.Length > 0)
                {
                    string temp = string.Join(",", cols);
                    AppSettings.CurrentSetting.SaveConfig(string.Format("{0}_Columns", this.GetType().Name), temp);
                    ShowVisableColumns();
                }
            }
        }

        private void GridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object pre = this.GridView.Rows[e.RowIndex].Tag;
                if (pre != null)
                {
                    FrmDetailBase detailForm = GetDetailForm();
                    if (detailForm != null)
                    {
                        detailForm.IsAdding = false;
                        detailForm.UpdatingItem = pre;

                        detailForm.ItemUpdated += delegate(object obj, ItemUpdatedEventArgs args)
                        {
                            ShowItemInGridViewRow(this.GridView.Rows[e.RowIndex], args.UpdatedItem);
                        };
                        detailForm.ShowDialog();
                    }
                }
            }
        }

        private void GridView_DoubleClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.SelectedItem = this.GridView.Rows[e.RowIndex].Tag;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void GridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    if (!GridView.Rows[e.RowIndex].Selected)
                    {
                        foreach (DataGridViewRow row in GridView.Rows)
                        {
                            row.Selected = false;
                        }
                        GridView.Rows[e.RowIndex].Selected = true;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (GridView == null) return;
            string keyword = string.Empty;
            ToolStrip parent = null;
            if (sender is ToolStripMenuItem)
            {
                parent = (sender as ToolStripMenuItem).GetCurrentParent();
            }
            if (parent == null) return;
            foreach (ToolStripItem ctrl in parent.Items)
            {
                if (ctrl is ToolStripTextBox && ctrl.Name == "txtKeyword")
                {
                    keyword = (ctrl as ToolStripTextBox).Text;
                    break;
                }
            }
            int count = 0;
            DataGridView grid = this.GridView;
            foreach (DataGridViewRow row in grid.Rows)
            {
                bool visible = false;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (
                        string.IsNullOrEmpty(keyword) ||
                        ((row.Cells[col.Index] is DataGridViewTextBoxCell) && row.Cells[col.Index].Value != null && row.Cells[col.Index].Value.ToString().Contains(keyword))
                        )
                    {
                        visible = true;
                        count++;
                        break;
                    }
                }
                row.Visible = visible;
            }
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", count);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ToolStrip parent = null;
            if (sender is ToolStripMenuItem)
            {
                parent = (sender as ToolStripMenuItem).GetCurrentParent();
            }
            if (parent == null) return;
            foreach (ToolStripItem ctrl in parent.Items)
            {
                if (ctrl is ToolStripTextBox && ctrl.Name == "txtKeyword")
                {
                    (ctrl as ToolStripTextBox).Text = string.Empty;
                    break;
                }
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (GridView == null) return;
            string keyword = string.Empty;
            if (sender is ToolStripTextBox)
            {
                keyword = (sender as ToolStripTextBox).Text;
            }
            int count = 0;
            DataGridView grid = this.GridView;
            foreach (DataGridViewRow row in grid.Rows)
            {
                bool visible = false;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (
                        string.IsNullOrEmpty(keyword) ||
                        ((row.Cells[col.Index] is DataGridViewTextBoxCell) && row.Cells[col.Index].Value != null && row.Cells[col.Index].Value.ToString().Contains(keyword))
                        )
                    {
                        visible = true;
                        count++;
                        break;
                    }
                }
                row.Visible = visible;
            }
            ShowRowBackColor();
            this.toolStripStatusLabel1.Text = string.Format("总共 {0} 项", count);
        }
        #endregion
    }
}
