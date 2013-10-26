namespace LJH.Attendance.UI
{
    partial class FrmShiftResultDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.重新生成结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看所有刷卡记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnFresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDateTimeInterval1 = new LJH.Attendance.UI.UCDateTimeInterval();
            this.plnLeft = new System.Windows.Forms.Panel();
            this.departmentTreeview1 = new LJH.Attendance.UI.DepartmentTreeview(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftOnDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftOffDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOnduty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOffDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.plnLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 重新生成结果ToolStripMenuItem
            // 
            this.重新生成结果ToolStripMenuItem.Name = "重新生成结果ToolStripMenuItem";
            this.重新生成结果ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.重新生成结果ToolStripMenuItem.Text = "重新生成结果";
            // 
            // 查看所有刷卡记录ToolStripMenuItem
            // 
            this.查看所有刷卡记录ToolStripMenuItem.Name = "查看所有刷卡记录ToolStripMenuItem";
            this.查看所有刷卡记录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看所有刷卡记录ToolStripMenuItem.Text = "查看所有刷卡记录";
            // 
            // mnu_SelectColumns
            // 
            this.mnu_SelectColumns.Name = "mnu_SelectColumns";
            this.mnu_SelectColumns.Size = new System.Drawing.Size(172, 22);
            this.mnu_SelectColumns.Text = "选择列";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_SelectColumns,
            this.查看所有刷卡记录ToolStripMenuItem,
            this.重新生成结果ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(324, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 323);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(244, 13);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 67);
            this.btnFresh.TabIndex = 1;
            this.btnFresh.Text = "刷新(&F)";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucDateTimeInterval1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "排班日期";
            // 
            // ucDateTimeInterval1
            // 
            this.ucDateTimeInterval1.EndDateTime = new System.DateTime(2013, 9, 10, 7, 36, 20, 189);
            this.ucDateTimeInterval1.Location = new System.Drawing.Point(9, 14);
            this.ucDateTimeInterval1.Name = "ucDateTimeInterval1";
            this.ucDateTimeInterval1.Size = new System.Drawing.Size(215, 56);
            this.ucDateTimeInterval1.StartDateTime = new System.DateTime(2013, 9, 10, 7, 36, 20, 192);
            this.ucDateTimeInterval1.TabIndex = 0;
            // 
            // plnLeft
            // 
            this.plnLeft.Controls.Add(this.departmentTreeview1);
            this.plnLeft.Controls.Add(this.panel2);
            this.plnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnLeft.Location = new System.Drawing.Point(0, 0);
            this.plnLeft.Name = "plnLeft";
            this.plnLeft.Size = new System.Drawing.Size(324, 323);
            this.plnLeft.TabIndex = 20;
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.CheckBoxes = true;
            this.departmentTreeview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(0, 86);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.ShowResigedStaff = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(324, 237);
            this.departmentTreeview1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFresh);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 86);
            this.panel2.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Export,
            this.btn_SelectColumns,
            this.toolStripSeparator1,
            this.txtKeyword});
            this.menu.Location = new System.Drawing.Point(330, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(856, 45);
            this.menu.TabIndex = 57;
            // 
            // btn_Export
            // 
            this.btn_Export.Image = global::LJH.Attendance.UI.Properties.Resources.export;
            this.btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(59, 41);
            this.btn_Export.Text = "导出(&E)";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_SelectColumns
            // 
            this.btn_SelectColumns.Image = global::LJH.Attendance.UI.Properties.Resources.columns;
            this.btn_SelectColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SelectColumns.Name = "btn_SelectColumns";
            this.btn_SelectColumns.Size = new System.Drawing.Size(70, 41);
            this.btn_SelectColumns.Text = "选择列(&L)";
            this.btn_SelectColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 41);
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaff,
            this.colShiftDate,
            this.colShift,
            this.colShiftOnDuty,
            this.colShiftOffDuty,
            this.colOnduty,
            this.colOffDuty,
            this.colShiftTime,
            this.colPresent,
            this.colResult,
            this.colMemo});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(330, 45);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(856, 278);
            this.GridView.TabIndex = 58;
            // 
            // colStaff
            // 
            this.colStaff.HeaderText = "人员";
            this.colStaff.Name = "colStaff";
            this.colStaff.ReadOnly = true;
            // 
            // colShiftDate
            // 
            this.colShiftDate.HeaderText = "日期";
            this.colShiftDate.Name = "colShiftDate";
            this.colShiftDate.ReadOnly = true;
            this.colShiftDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShiftDate.Width = 80;
            // 
            // colShift
            // 
            this.colShift.HeaderText = "班次";
            this.colShift.Name = "colShift";
            this.colShift.ReadOnly = true;
            this.colShift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShift.Width = 60;
            // 
            // colShiftOnDuty
            // 
            this.colShiftOnDuty.HeaderText = "应上班";
            this.colShiftOnDuty.Name = "colShiftOnDuty";
            this.colShiftOnDuty.ReadOnly = true;
            this.colShiftOnDuty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShiftOnDuty.Width = 60;
            // 
            // colShiftOffDuty
            // 
            this.colShiftOffDuty.HeaderText = "应下班";
            this.colShiftOffDuty.Name = "colShiftOffDuty";
            this.colShiftOffDuty.ReadOnly = true;
            this.colShiftOffDuty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShiftOffDuty.Width = 60;
            // 
            // colOnduty
            // 
            this.colOnduty.HeaderText = "实上班";
            this.colOnduty.Name = "colOnduty";
            this.colOnduty.ReadOnly = true;
            this.colOnduty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colOnduty.Width = 60;
            // 
            // colOffDuty
            // 
            this.colOffDuty.HeaderText = "实下班";
            this.colOffDuty.Name = "colOffDuty";
            this.colOffDuty.ReadOnly = true;
            this.colOffDuty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colOffDuty.Width = 60;
            // 
            // colShiftTime
            // 
            this.colShiftTime.HeaderText = "应出勤";
            this.colShiftTime.Name = "colShiftTime";
            this.colShiftTime.ReadOnly = true;
            this.colShiftTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShiftTime.Width = 60;
            // 
            // colPresent
            // 
            this.colPresent.HeaderText = "实出勤";
            this.colPresent.Name = "colPresent";
            this.colPresent.ReadOnly = true;
            this.colPresent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPresent.Width = 60;
            // 
            // colResult
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.colResult.DefaultCellStyle = dataGridViewCellStyle1;
            this.colResult.HeaderText = "考勤结果";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemo.HeaderText = "备注";
            this.colMemo.MinimumWidth = 100;
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            this.colMemo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmShiftResultDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 345);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.plnLeft);
            this.Name = "FrmShiftResultDetail";
            this.Text = "日考勤明细表";
            this.Controls.SetChildIndex(this.plnLeft, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.GridView, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.plnLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 重新生成结果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看所有刷卡记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_SelectColumns;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private UCDateTimeInterval ucDateTimeInterval1;
        private System.Windows.Forms.Panel plnLeft;
        private DepartmentTreeview departmentTreeview1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripMenuItem btn_SelectColumns;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftOnDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftOffDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOnduty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOffDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}