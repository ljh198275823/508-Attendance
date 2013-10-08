namespace Ralid.Attendance.UI
{
    partial class FrmTASheetGroupMaster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_OTSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_VacationSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TripSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartDate,
            this.colEndDate,
            this.colStartTime,
            this.colEndTime,
            this.colDuration,
            this.colCategory,
            this.colStaff,
            this.colMemo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(908, 240);
            this.dataGridView1.TabIndex = 58;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_OTSheet,
            this.btn_VacationSheet,
            this.btn_TripSheet,
            this.btn_Delete,
            this.btn_Export,
            this.btn_Fresh,
            this.btn_SelectColumns,
            this.toolStripSeparator1,
            this.txtKeyword,
            this.toolStripSeparator2});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(908, 50);
            this.menu.TabIndex = 57;
            // 
            // btn_OTSheet
            // 
            this.btn_OTSheet.Image = global::Ralid.Attendance.UI.Properties.Resources.add;
            this.btn_OTSheet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OTSheet.Name = "btn_OTSheet";
            this.btn_OTSheet.Size = new System.Drawing.Size(60, 46);
            this.btn_OTSheet.Text = "加班(&A)";
            this.btn_OTSheet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_OTSheet.Click += new System.EventHandler(this.btn_OTSheet_Click);
            // 
            // btn_VacationSheet
            // 
            this.btn_VacationSheet.Image = global::Ralid.Attendance.UI.Properties.Resources.add;
            this.btn_VacationSheet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_VacationSheet.Name = "btn_VacationSheet";
            this.btn_VacationSheet.Size = new System.Drawing.Size(60, 46);
            this.btn_VacationSheet.Text = "请假(&V)";
            this.btn_VacationSheet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_VacationSheet.Click += new System.EventHandler(this.btn_VacationSheet_Click);
            // 
            // btn_TripSheet
            // 
            this.btn_TripSheet.Image = global::Ralid.Attendance.UI.Properties.Resources.add;
            this.btn_TripSheet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_TripSheet.Name = "btn_TripSheet";
            this.btn_TripSheet.Size = new System.Drawing.Size(59, 46);
            this.btn_TripSheet.Text = "外出(&T)";
            this.btn_TripSheet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TripSheet.Click += new System.EventHandler(this.btn_TripSheet_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Ralid.Attendance.UI.Properties.Resources.delete;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(61, 46);
            this.btn_Delete.Text = "删除(&D)";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Export
            // 
            this.btn_Export.Image = global::Ralid.Attendance.UI.Properties.Resources.export;
            this.btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(59, 46);
            this.btn_Export.Text = "导出(&E)";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Image = global::Ralid.Attendance.UI.Properties.Resources.refresh;
            this.btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(58, 46);
            this.btn_Fresh.Text = "刷新(&F)";
            this.btn_Fresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_SelectColumns
            // 
            this.btn_SelectColumns.Image = global::Ralid.Attendance.UI.Properties.Resources.columns;
            this.btn_SelectColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SelectColumns.Name = "btn_SelectColumns";
            this.btn_SelectColumns.Size = new System.Drawing.Size(70, 46);
            this.btn_SelectColumns.Text = "选择列(&L)";
            this.btn_SelectColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 46);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "开始日期";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            this.colEndDate.HeaderText = "结束日期";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            // 
            // colStartTime
            // 
            this.colStartTime.HeaderText = "开始时间";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            // 
            // colEndTime
            // 
            this.colEndTime.HeaderText = "结束时间";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.ReadOnly = true;
            // 
            // colDuration
            // 
            this.colDuration.HeaderText = "计时";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "类别";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colStaff
            // 
            this.colStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaff.HeaderText = "人员";
            this.colStaff.MinimumWidth = 100;
            this.colStaff.Name = "colStaff";
            this.colStaff.ReadOnly = true;
            // 
            // colMemo
            // 
            this.colMemo.HeaderText = "事由";
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            this.colMemo.Width = 150;
            // 
            // FrmTASheetGroupMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menu);
            this.Name = "FrmTASheetGroupMaster";
            this.Text = "申请单登记";
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_OTSheet;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripMenuItem btn_Fresh;
        private System.Windows.Forms.ToolStripMenuItem btn_SelectColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btn_VacationSheet;
        private System.Windows.Forms.ToolStripMenuItem btn_TripSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}