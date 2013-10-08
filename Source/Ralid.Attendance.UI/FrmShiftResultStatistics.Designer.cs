namespace Ralid.Attendance.UI
{
    partial class FrmShiftResultStatistics
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
            this.查看所有刷卡记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentTreeview1 = new Ralid.Attendance.UI.DepartmentTreeview(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDateTimeInterval1 = new Ralid.Attendance.UI.UCDateTimeInterval();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看考勤结果明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新生成结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.plnLeft = new System.Windows.Forms.Panel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnOk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBelateCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBelate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveEarlyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveEarly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbsentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusinessTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.plnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // 查看所有刷卡记录ToolStripMenuItem
            // 
            this.查看所有刷卡记录ToolStripMenuItem.Name = "查看所有刷卡记录ToolStripMenuItem";
            this.查看所有刷卡记录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看所有刷卡记录ToolStripMenuItem.Text = "查看所有刷卡记录";
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.CheckBoxes = true;
            this.departmentTreeview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(0, 86);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(324, 274);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看考勤结果明细ToolStripMenuItem,
            this.查看所有刷卡记录ToolStripMenuItem,
            this.重新生成结果ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // 查看考勤结果明细ToolStripMenuItem
            // 
            this.查看考勤结果明细ToolStripMenuItem.Name = "查看考勤结果明细ToolStripMenuItem";
            this.查看考勤结果明细ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看考勤结果明细ToolStripMenuItem.Text = "查看考勤结果明细";
            // 
            // 重新生成结果ToolStripMenuItem
            // 
            this.重新生成结果ToolStripMenuItem.Name = "重新生成结果ToolStripMenuItem";
            this.重新生成结果ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.重新生成结果ToolStripMenuItem.Text = "重新生成结果";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(324, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 360);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // plnLeft
            // 
            this.plnLeft.Controls.Add(this.departmentTreeview1);
            this.plnLeft.Controls.Add(this.panel2);
            this.plnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnLeft.Location = new System.Drawing.Point(0, 0);
            this.plnLeft.Name = "plnLeft";
            this.plnLeft.Size = new System.Drawing.Size(324, 360);
            this.plnLeft.TabIndex = 7;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaff,
            this.colAttendanceDays,
            this.colTotal,
            this.colOK,
            this.colUnOk,
            this.colBelateCount,
            this.colBelate,
            this.colLeaveEarlyCount,
            this.colLeaveEarly,
            this.colAbsentCount,
            this.colAbsent,
            this.colShiftHour,
            this.colOT,
            this.colVaction,
            this.colBusinessTrip});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(330, 45);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView.Size = new System.Drawing.Size(635, 315);
            this.GridView.TabIndex = 60;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Export,
            this.btn_SelectColumns});
            this.menu.Location = new System.Drawing.Point(330, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(635, 45);
            this.menu.TabIndex = 59;
            // 
            // btn_Export
            // 
            this.btn_Export.Image = global::Ralid.Attendance.UI.Properties.Resources.export;
            this.btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(59, 41);
            this.btn_Export.Text = "导出(&E)";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_SelectColumns
            // 
            this.btn_SelectColumns.Image = global::Ralid.Attendance.UI.Properties.Resources.columns;
            this.btn_SelectColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SelectColumns.Name = "btn_SelectColumns";
            this.btn_SelectColumns.Size = new System.Drawing.Size(70, 41);
            this.btn_SelectColumns.Text = "选择列(&L)";
            this.btn_SelectColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // colStaff
            // 
            this.colStaff.HeaderText = "人员";
            this.colStaff.Name = "colStaff";
            this.colStaff.ReadOnly = true;
            // 
            // colAttendanceDays
            // 
            this.colAttendanceDays.HeaderText = "考勤天数";
            this.colAttendanceDays.Name = "colAttendanceDays";
            this.colAttendanceDays.ReadOnly = true;
            this.colAttendanceDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAttendanceDays.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "班次总数";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTotal.Width = 80;
            // 
            // colOK
            // 
            this.colOK.HeaderText = "正常班次";
            this.colOK.Name = "colOK";
            this.colOK.ReadOnly = true;
            this.colOK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colOK.Width = 80;
            // 
            // colUnOk
            // 
            this.colUnOk.HeaderText = "异常班次";
            this.colUnOk.Name = "colUnOk";
            this.colUnOk.ReadOnly = true;
            this.colUnOk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnOk.Width = 80;
            // 
            // colBelateCount
            // 
            this.colBelateCount.HeaderText = "迟到次数";
            this.colBelateCount.Name = "colBelateCount";
            this.colBelateCount.ReadOnly = true;
            this.colBelateCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBelateCount.Width = 80;
            // 
            // colBelate
            // 
            this.colBelate.HeaderText = "迟到(时)";
            this.colBelate.Name = "colBelate";
            this.colBelate.ReadOnly = true;
            this.colBelate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBelate.Width = 80;
            // 
            // colLeaveEarlyCount
            // 
            this.colLeaveEarlyCount.HeaderText = "早退次数";
            this.colLeaveEarlyCount.Name = "colLeaveEarlyCount";
            this.colLeaveEarlyCount.ReadOnly = true;
            this.colLeaveEarlyCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLeaveEarlyCount.Width = 80;
            // 
            // colLeaveEarly
            // 
            this.colLeaveEarly.HeaderText = "早退(时)";
            this.colLeaveEarly.Name = "colLeaveEarly";
            this.colLeaveEarly.ReadOnly = true;
            this.colLeaveEarly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLeaveEarly.Width = 80;
            // 
            // colAbsentCount
            // 
            this.colAbsentCount.HeaderText = "缺勤次数";
            this.colAbsentCount.Name = "colAbsentCount";
            this.colAbsentCount.ReadOnly = true;
            this.colAbsentCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAbsentCount.Width = 80;
            // 
            // colAbsent
            // 
            this.colAbsent.HeaderText = "缺勤(时)";
            this.colAbsent.Name = "colAbsent";
            this.colAbsent.ReadOnly = true;
            this.colAbsent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAbsent.Width = 80;
            // 
            // colShiftHour
            // 
            this.colShiftHour.HeaderText = "上班(时)";
            this.colShiftHour.Name = "colShiftHour";
            this.colShiftHour.ReadOnly = true;
            this.colShiftHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShiftHour.Width = 80;
            // 
            // colOT
            // 
            this.colOT.HeaderText = "加班(时)";
            this.colOT.Name = "colOT";
            this.colOT.ReadOnly = true;
            this.colOT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colOT.Width = 80;
            // 
            // colVaction
            // 
            this.colVaction.HeaderText = "请假(时)";
            this.colVaction.Name = "colVaction";
            this.colVaction.ReadOnly = true;
            // 
            // colBusinessTrip
            // 
            this.colBusinessTrip.HeaderText = "外出/出差";
            this.colBusinessTrip.Name = "colBusinessTrip";
            this.colBusinessTrip.ReadOnly = true;
            // 
            // FrmShiftResultStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 382);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.plnLeft);
            this.Name = "FrmShiftResultStatistics";
            this.Text = "月考勤统计表";
            this.Controls.SetChildIndex(this.plnLeft, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.GridView, 0);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.plnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 查看所有刷卡记录ToolStripMenuItem;
        private DepartmentTreeview departmentTreeview1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private UCDateTimeInterval ucDateTimeInterval1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看考勤结果明细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新生成结果ToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel plnLeft;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripMenuItem btn_SelectColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBelateCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBelate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveEarlyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveEarly;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusinessTrip;
    }
}