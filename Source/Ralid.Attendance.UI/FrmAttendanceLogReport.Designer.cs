namespace Ralid.Attendance.UI
{
    partial class FrmAttendanceLogReport
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
            this.plnLeft = new System.Windows.Forms.Panel();
            this.departmentTreeview1 = new Ralid.Attendance.UI.DepartmentTreeview(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDateTimeInterval1 = new Ralid.Attendance.UI.UCDateTimeInterval();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReadDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsManual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.plnLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // plnLeft
            // 
            this.plnLeft.Controls.Add(this.departmentTreeview1);
            this.plnLeft.Controls.Add(this.panel2);
            this.plnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnLeft.Location = new System.Drawing.Point(0, 0);
            this.plnLeft.Name = "plnLeft";
            this.plnLeft.Size = new System.Drawing.Size(324, 321);
            this.plnLeft.TabIndex = 21;
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.CheckBoxes = true;
            this.departmentTreeview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(0, 88);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(324, 233);
            this.departmentTreeview1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFresh);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 88);
            this.panel2.TabIndex = 2;
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(244, 13);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 68);
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
            this.groupBox1.Size = new System.Drawing.Size(233, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "考勤日期";
            // 
            // ucDateTimeInterval1
            // 
            this.ucDateTimeInterval1.EndDateTime = new System.DateTime(2013, 9, 29, 16, 48, 30, 117);
            this.ucDateTimeInterval1.Location = new System.Drawing.Point(9, 17);
            this.ucDateTimeInterval1.Name = "ucDateTimeInterval1";
            this.ucDateTimeInterval1.Size = new System.Drawing.Size(215, 56);
            this.ucDateTimeInterval1.StartDateTime = new System.DateTime(2013, 9, 29, 16, 48, 30, 127);
            this.ucDateTimeInterval1.TabIndex = 0;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaff,
            this.colReadDateTime,
            this.colReaderName,
            this.colIsManual,
            this.colMemo});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(330, 45);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(556, 276);
            this.GridView.TabIndex = 61;
            // 
            // colStaff
            // 
            this.colStaff.HeaderText = "人员";
            this.colStaff.Name = "colStaff";
            this.colStaff.ReadOnly = true;
            // 
            // colReadDateTime
            // 
            this.colReadDateTime.HeaderText = "考勤时间";
            this.colReadDateTime.Name = "colReadDateTime";
            this.colReadDateTime.ReadOnly = true;
            this.colReadDateTime.Width = 130;
            // 
            // colReaderName
            // 
            this.colReaderName.HeaderText = "考勤点";
            this.colReaderName.Name = "colReaderName";
            this.colReaderName.ReadOnly = true;
            // 
            // colIsManual
            // 
            this.colIsManual.HeaderText = "补签";
            this.colIsManual.Name = "colIsManual";
            this.colIsManual.ReadOnly = true;
            this.colIsManual.Width = 40;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemo.HeaderText = "备注";
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Export,
            this.btn_SelectColumns,
            this.toolStripSeparator1,
            this.txtKeyword,
            this.toolStripSeparator2});
            this.menu.Location = new System.Drawing.Point(330, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(556, 45);
            this.menu.TabIndex = 60;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(324, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 321);
            this.splitter1.TabIndex = 59;
            this.splitter1.TabStop = false;
            // 
            // FrmAttendanceLogReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 343);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.plnLeft);
            this.Name = "FrmAttendanceLogReport";
            this.Text = "原始考勤记录";
            this.Controls.SetChildIndex(this.plnLeft, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.GridView, 0);
            this.plnLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plnLeft;
        private DepartmentTreeview departmentTreeview1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripMenuItem btn_SelectColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Splitter splitter1;
        private UCDateTimeInterval ucDateTimeInterval1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReadDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReaderName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}