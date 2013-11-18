namespace LJH.Attendance.UI
{
    partial class FrmShiftDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtShortName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogAtStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogAtEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowLateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowLeaveEarlyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeforeStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAfterEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(575, 261);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(677, 261);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "班次名称";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(72, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtShortName
            // 
            this.txtShortName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtShortName.Location = new System.Drawing.Point(373, 20);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(50, 21);
            this.txtShortName.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(340, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "简称";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartTime,
            this.colEndTime,
            this.colLogAtStart,
            this.colLogAtEnd,
            this.colAllowLateTime,
            this.colAllowLeaveEarlyTime,
            this.colBeforeStartTime,
            this.colAfterEndTime,
            this.colDuration});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(749, 196);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Add,
            this.mnu_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // mnu_Add
            // 
            this.mnu_Add.Name = "mnu_Add";
            this.mnu_Add.Size = new System.Drawing.Size(100, 22);
            this.mnu_Add.Text = "增加";
            this.mnu_Add.Click += new System.EventHandler(this.mnu_Add_Click);
            // 
            // mnu_Delete
            // 
            this.mnu_Delete.Name = "mnu_Delete";
            this.mnu_Delete.Size = new System.Drawing.Size(100, 22);
            this.mnu_Delete.Text = "删除";
            this.mnu_Delete.Click += new System.EventHandler(this.mnu_Delete_Click);
            // 
            // colStartTime
            // 
            this.colStartTime.HeaderText = "上班时间";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            this.colStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStartTime.Width = 80;
            // 
            // colEndTime
            // 
            this.colEndTime.HeaderText = "下班时间";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.ReadOnly = true;
            this.colEndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEndTime.Width = 80;
            // 
            // colLogAtStart
            // 
            this.colLogAtStart.HeaderText = "上班打卡";
            this.colLogAtStart.Name = "colLogAtStart";
            this.colLogAtStart.ReadOnly = true;
            this.colLogAtStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLogAtStart.Width = 80;
            // 
            // colLogAtEnd
            // 
            this.colLogAtEnd.HeaderText = "下班打卡";
            this.colLogAtEnd.Name = "colLogAtEnd";
            this.colLogAtEnd.ReadOnly = true;
            this.colLogAtEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLogAtEnd.Width = 80;
            // 
            // colAllowLateTime
            // 
            this.colAllowLateTime.HeaderText = "允许迟到";
            this.colAllowLateTime.Name = "colAllowLateTime";
            this.colAllowLateTime.ReadOnly = true;
            this.colAllowLateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAllowLateTime.Width = 80;
            // 
            // colAllowLeaveEarlyTime
            // 
            this.colAllowLeaveEarlyTime.HeaderText = "允许早退";
            this.colAllowLeaveEarlyTime.Name = "colAllowLeaveEarlyTime";
            this.colAllowLeaveEarlyTime.ReadOnly = true;
            this.colAllowLeaveEarlyTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAllowLeaveEarlyTime.Width = 80;
            // 
            // colBeforeStartTime
            // 
            this.colBeforeStartTime.HeaderText = "提前刷卡";
            this.colBeforeStartTime.Name = "colBeforeStartTime";
            this.colBeforeStartTime.ReadOnly = true;
            this.colBeforeStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBeforeStartTime.Width = 80;
            // 
            // colAfterEndTime
            // 
            this.colAfterEndTime.HeaderText = "延后刷卡";
            this.colAfterEndTime.Name = "colAfterEndTime";
            this.colAfterEndTime.ReadOnly = true;
            this.colAfterEndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAfterEndTime.Width = 80;
            // 
            // colDuration
            // 
            this.colDuration.HeaderText = "出勤计时(分)";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            // 
            // FrmShiftDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmShiftDetail";
            this.Text = "班次明细";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtShortName, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GeneralLibrary.WinformControl.DBCTextBox txtName;
        private GeneralLibrary.WinformControl.DBCTextBox txtShortName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Add;
        private System.Windows.Forms.ToolStripMenuItem mnu_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogAtStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogAtEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowLateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowLeaveEarlyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeforeStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAfterEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
    }
}