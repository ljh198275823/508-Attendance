namespace LJH.Attendance.UI
{
    partial class FrmSystemOptions
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutoCreate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtAutoGenerateResultTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoGetAttendanceLog = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(271, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(177, 158);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAutoCreate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtAutoGenerateResultTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 61);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动生成考勤报表";
            // 
            // chkAutoCreate
            // 
            this.chkAutoCreate.AutoSize = true;
            this.chkAutoCreate.Location = new System.Drawing.Point(18, 30);
            this.chkAutoCreate.Name = "chkAutoCreate";
            this.chkAutoCreate.Size = new System.Drawing.Size(15, 14);
            this.chkAutoCreate.TabIndex = 3;
            this.chkAutoCreate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "自动生成前一天的考勤结果";
            // 
            // dtAutoGenerateResultTime
            // 
            this.dtAutoGenerateResultTime.CustomFormat = "HH:mm";
            this.dtAutoGenerateResultTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAutoGenerateResultTime.Location = new System.Drawing.Point(68, 27);
            this.dtAutoGenerateResultTime.Name = "dtAutoGenerateResultTime";
            this.dtAutoGenerateResultTime.Size = new System.Drawing.Size(70, 21);
            this.dtAutoGenerateResultTime.TabIndex = 1;
            this.dtAutoGenerateResultTime.Value = new System.DateTime(2014, 3, 6, 2, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "每天";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoGetAttendanceLog);
            this.groupBox1.Location = new System.Drawing.Point(4, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "考勤设备选项";
            // 
            // chkAutoGetAttendanceLog
            // 
            this.chkAutoGetAttendanceLog.AutoSize = true;
            this.chkAutoGetAttendanceLog.Location = new System.Drawing.Point(14, 29);
            this.chkAutoGetAttendanceLog.Name = "chkAutoGetAttendanceLog";
            this.chkAutoGetAttendanceLog.Size = new System.Drawing.Size(192, 16);
            this.chkAutoGetAttendanceLog.TabIndex = 3;
            this.chkAutoGetAttendanceLog.Text = "自动从考勤设备中获取考勤记录";
            this.chkAutoGetAttendanceLog.UseVisualStyleBackColor = true;
            // 
            // FrmSystemOptions
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(366, 193);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSystemOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统选项";
            this.Load += new System.EventHandler(this.SystemOptions_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAutoCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtAutoGenerateResultTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAutoGetAttendanceLog;
    }
}