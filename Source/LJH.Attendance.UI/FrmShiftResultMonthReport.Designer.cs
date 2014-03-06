namespace LJH.Attendance.UI
{
    partial class FrmShiftResultMonthReport
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
            this.btnFresh = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ucDateTimeInterval1 = new LJH.Attendance.UI.UCDateTimeInterval();
            this.plnLeft = new System.Windows.Forms.Panel();
            this.departmentTreeview1 = new LJH.Attendance.UI.DepartmentTreeview(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看考勤结果明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看所有刷卡记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新生成结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.colDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay07 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay08 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay09 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBelateCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveEarlyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForgetCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plnLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
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
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(324, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 308);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
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
            this.plnLeft.Size = new System.Drawing.Size(324, 308);
            this.plnLeft.TabIndex = 4;
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
            this.departmentTreeview1.Size = new System.Drawing.Size(324, 222);
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看考勤结果明细ToolStripMenuItem,
            this.查看所有刷卡记录ToolStripMenuItem,
            this.重新生成结果ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(167, 70);
            // 
            // 查看考勤结果明细ToolStripMenuItem
            // 
            this.查看考勤结果明细ToolStripMenuItem.Name = "查看考勤结果明细ToolStripMenuItem";
            this.查看考勤结果明细ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.查看考勤结果明细ToolStripMenuItem.Text = "查看考勤结果明细";
            // 
            // 查看所有刷卡记录ToolStripMenuItem
            // 
            this.查看所有刷卡记录ToolStripMenuItem.Name = "查看所有刷卡记录ToolStripMenuItem";
            this.查看所有刷卡记录ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.查看所有刷卡记录ToolStripMenuItem.Text = "查看所有刷卡记录";
            // 
            // 重新生成结果ToolStripMenuItem
            // 
            this.重新生成结果ToolStripMenuItem.Name = "重新生成结果ToolStripMenuItem";
            this.重新生成结果ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.重新生成结果ToolStripMenuItem.Text = "重新生成结果";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Export,
            this.toolStripSeparator1,
            this.txtKeyword});
            this.menu.Location = new System.Drawing.Point(330, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(848, 45);
            this.menu.TabIndex = 60;
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
            this.colDept,
            this.colStaff,
            this.colDay01,
            this.colDay02,
            this.colDay03,
            this.colDay04,
            this.colDay05,
            this.colDay06,
            this.colDay07,
            this.colDay08,
            this.colDay09,
            this.colDay10,
            this.colDay11,
            this.colDay12,
            this.colDay13,
            this.colDay14,
            this.colDay15,
            this.colDay16,
            this.colDay17,
            this.colDay18,
            this.colDay19,
            this.colDay20,
            this.colDay21,
            this.colDay22,
            this.colDay23,
            this.colDay24,
            this.colDay25,
            this.colDay26,
            this.colDay27,
            this.colDay28,
            this.colDay29,
            this.colDay30,
            this.colDay31,
            this.colShiftTime,
            this.colPresent,
            this.colBelateCount,
            this.colLeaveEarlyCount,
            this.colForgetCount});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(330, 45);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(848, 263);
            this.GridView.TabIndex = 61;
            // 
            // colDept
            // 
            this.colDept.HeaderText = "部门";
            this.colDept.Name = "colDept";
            this.colDept.ReadOnly = true;
            // 
            // colStaff
            // 
            this.colStaff.HeaderText = "人员";
            this.colStaff.Name = "colStaff";
            this.colStaff.ReadOnly = true;
            // 
            // colDay01
            // 
            this.colDay01.HeaderText = "01";
            this.colDay01.Name = "colDay01";
            this.colDay01.ReadOnly = true;
            this.colDay01.Width = 20;
            // 
            // colDay02
            // 
            this.colDay02.HeaderText = "02";
            this.colDay02.Name = "colDay02";
            this.colDay02.ReadOnly = true;
            this.colDay02.Width = 20;
            // 
            // colDay03
            // 
            this.colDay03.HeaderText = "03";
            this.colDay03.Name = "colDay03";
            this.colDay03.ReadOnly = true;
            this.colDay03.Width = 20;
            // 
            // colDay04
            // 
            this.colDay04.HeaderText = "04";
            this.colDay04.Name = "colDay04";
            this.colDay04.ReadOnly = true;
            this.colDay04.Width = 20;
            // 
            // colDay05
            // 
            this.colDay05.HeaderText = "05";
            this.colDay05.Name = "colDay05";
            this.colDay05.ReadOnly = true;
            this.colDay05.Width = 20;
            // 
            // colDay06
            // 
            this.colDay06.HeaderText = "06";
            this.colDay06.Name = "colDay06";
            this.colDay06.ReadOnly = true;
            this.colDay06.Width = 20;
            // 
            // colDay07
            // 
            this.colDay07.HeaderText = "07";
            this.colDay07.Name = "colDay07";
            this.colDay07.ReadOnly = true;
            this.colDay07.Width = 20;
            // 
            // colDay08
            // 
            this.colDay08.HeaderText = "08";
            this.colDay08.Name = "colDay08";
            this.colDay08.ReadOnly = true;
            this.colDay08.Width = 20;
            // 
            // colDay09
            // 
            this.colDay09.HeaderText = "09";
            this.colDay09.Name = "colDay09";
            this.colDay09.ReadOnly = true;
            this.colDay09.Width = 20;
            // 
            // colDay10
            // 
            this.colDay10.HeaderText = "10";
            this.colDay10.Name = "colDay10";
            this.colDay10.ReadOnly = true;
            this.colDay10.Width = 20;
            // 
            // colDay11
            // 
            this.colDay11.HeaderText = "11";
            this.colDay11.Name = "colDay11";
            this.colDay11.ReadOnly = true;
            this.colDay11.Width = 20;
            // 
            // colDay12
            // 
            this.colDay12.HeaderText = "12";
            this.colDay12.Name = "colDay12";
            this.colDay12.ReadOnly = true;
            this.colDay12.Width = 20;
            // 
            // colDay13
            // 
            this.colDay13.HeaderText = "13";
            this.colDay13.Name = "colDay13";
            this.colDay13.ReadOnly = true;
            this.colDay13.Width = 20;
            // 
            // colDay14
            // 
            this.colDay14.HeaderText = "14";
            this.colDay14.Name = "colDay14";
            this.colDay14.ReadOnly = true;
            this.colDay14.Width = 20;
            // 
            // colDay15
            // 
            this.colDay15.HeaderText = "15";
            this.colDay15.Name = "colDay15";
            this.colDay15.ReadOnly = true;
            this.colDay15.Width = 20;
            // 
            // colDay16
            // 
            this.colDay16.HeaderText = "16";
            this.colDay16.Name = "colDay16";
            this.colDay16.ReadOnly = true;
            this.colDay16.Width = 20;
            // 
            // colDay17
            // 
            this.colDay17.HeaderText = "17";
            this.colDay17.Name = "colDay17";
            this.colDay17.ReadOnly = true;
            this.colDay17.Width = 20;
            // 
            // colDay18
            // 
            this.colDay18.HeaderText = "18";
            this.colDay18.Name = "colDay18";
            this.colDay18.ReadOnly = true;
            this.colDay18.Width = 20;
            // 
            // colDay19
            // 
            this.colDay19.HeaderText = "19";
            this.colDay19.Name = "colDay19";
            this.colDay19.ReadOnly = true;
            this.colDay19.Width = 20;
            // 
            // colDay20
            // 
            this.colDay20.HeaderText = "20";
            this.colDay20.Name = "colDay20";
            this.colDay20.ReadOnly = true;
            this.colDay20.Width = 20;
            // 
            // colDay21
            // 
            this.colDay21.HeaderText = "21";
            this.colDay21.Name = "colDay21";
            this.colDay21.ReadOnly = true;
            this.colDay21.Width = 20;
            // 
            // colDay22
            // 
            this.colDay22.HeaderText = "22";
            this.colDay22.Name = "colDay22";
            this.colDay22.ReadOnly = true;
            this.colDay22.Width = 20;
            // 
            // colDay23
            // 
            this.colDay23.HeaderText = "23";
            this.colDay23.Name = "colDay23";
            this.colDay23.ReadOnly = true;
            this.colDay23.Width = 20;
            // 
            // colDay24
            // 
            this.colDay24.HeaderText = "24";
            this.colDay24.Name = "colDay24";
            this.colDay24.ReadOnly = true;
            this.colDay24.Width = 20;
            // 
            // colDay25
            // 
            this.colDay25.HeaderText = "25";
            this.colDay25.Name = "colDay25";
            this.colDay25.ReadOnly = true;
            this.colDay25.Width = 20;
            // 
            // colDay26
            // 
            this.colDay26.HeaderText = "26";
            this.colDay26.Name = "colDay26";
            this.colDay26.ReadOnly = true;
            this.colDay26.Width = 20;
            // 
            // colDay27
            // 
            this.colDay27.HeaderText = "27";
            this.colDay27.Name = "colDay27";
            this.colDay27.ReadOnly = true;
            this.colDay27.Width = 20;
            // 
            // colDay28
            // 
            this.colDay28.HeaderText = "28";
            this.colDay28.Name = "colDay28";
            this.colDay28.ReadOnly = true;
            this.colDay28.Width = 20;
            // 
            // colDay29
            // 
            this.colDay29.HeaderText = "29";
            this.colDay29.Name = "colDay29";
            this.colDay29.ReadOnly = true;
            this.colDay29.Width = 20;
            // 
            // colDay30
            // 
            this.colDay30.HeaderText = "30";
            this.colDay30.Name = "colDay30";
            this.colDay30.ReadOnly = true;
            this.colDay30.Width = 20;
            // 
            // colDay31
            // 
            this.colDay31.HeaderText = "31";
            this.colDay31.Name = "colDay31";
            this.colDay31.ReadOnly = true;
            this.colDay31.Width = 20;
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
            // colBelateCount
            // 
            this.colBelateCount.HeaderText = "迟到(次)";
            this.colBelateCount.Name = "colBelateCount";
            this.colBelateCount.ReadOnly = true;
            this.colBelateCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBelateCount.Width = 40;
            // 
            // colLeaveEarlyCount
            // 
            this.colLeaveEarlyCount.HeaderText = "早退(次)";
            this.colLeaveEarlyCount.Name = "colLeaveEarlyCount";
            this.colLeaveEarlyCount.ReadOnly = true;
            this.colLeaveEarlyCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLeaveEarlyCount.Width = 40;
            // 
            // colForgetCount
            // 
            this.colForgetCount.HeaderText = "漏打卡(次)";
            this.colForgetCount.Name = "colForgetCount";
            this.colForgetCount.ReadOnly = true;
            this.colForgetCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colForgetCount.Width = 50;
            // 
            // FrmShiftResultMonthDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 330);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.plnLeft);
            this.Name = "FrmShiftResultMonthDetail";
            this.Text = "月考勤明细表";
            this.Controls.SetChildIndex(this.plnLeft, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.GridView, 0);
            this.plnLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.Splitter splitter1;
        private UCDateTimeInterval ucDateTimeInterval1;
        private System.Windows.Forms.Panel plnLeft;
        private DepartmentTreeview departmentTreeview1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 查看考勤结果明细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看所有刷卡记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新生成结果ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay01;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay02;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay03;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay04;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay05;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay06;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay07;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay08;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay09;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay14;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay15;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay16;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay17;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay18;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay19;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay20;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay21;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay22;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay23;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay24;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay25;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay26;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay27;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay28;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay29;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay30;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay31;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBelateCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveEarlyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForgetCount;
    }
}