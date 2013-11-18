namespace LJH.Attendance.UI
{
    partial class FrmShiftItemDetail
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAfterEndTime = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBeforeStartTime = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.txtEndMinute = new System.Windows.Forms.NumericUpDown();
            this.txtEndHour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartMinute = new System.Windows.Forms.NumericUpDown();
            this.txtStartHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShiftTime = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkNextDay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllowLeaveEarlyTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAllowLateTime = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkLogAtStart = new System.Windows.Forms.CheckBox();
            this.chkLogAtEnd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShiftTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowLeaveEarlyTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowLateTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 88;
            this.label3.Text = "分钟";
            // 
            // txtAfterEndTime
            // 
            this.txtAfterEndTime.Location = new System.Drawing.Point(236, 112);
            this.txtAfterEndTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAfterEndTime.Name = "txtAfterEndTime";
            this.txtAfterEndTime.Size = new System.Drawing.Size(59, 21);
            this.txtAfterEndTime.TabIndex = 87;
            this.txtAfterEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAfterEndTime.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(182, 116);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 86;
            this.label31.Text = "延长刷卡";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(131, 116);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 85;
            this.label29.Text = "分钟";
            // 
            // txtBeforeStartTime
            // 
            this.txtBeforeStartTime.Location = new System.Drawing.Point(67, 112);
            this.txtBeforeStartTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtBeforeStartTime.Name = "txtBeforeStartTime";
            this.txtBeforeStartTime.Size = new System.Drawing.Size(59, 21);
            this.txtBeforeStartTime.TabIndex = 84;
            this.txtBeforeStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBeforeStartTime.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 116);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 83;
            this.label30.Text = "提前刷卡";
            // 
            // txtEndMinute
            // 
            this.txtEndMinute.Location = new System.Drawing.Point(279, 19);
            this.txtEndMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEndMinute.Name = "txtEndMinute";
            this.txtEndMinute.Size = new System.Drawing.Size(34, 21);
            this.txtEndMinute.TabIndex = 82;
            this.txtEndMinute.ValueChanged += new System.EventHandler(this.txtEndMinute_ValueChanged);
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(236, 19);
            this.txtEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(34, 21);
            this.txtEndHour.TabIndex = 81;
            this.txtEndHour.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.txtEndHour.ValueChanged += new System.EventHandler(this.txtEndHour_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 80;
            this.label2.Text = "：";
            // 
            // txtStartMinute
            // 
            this.txtStartMinute.Location = new System.Drawing.Point(110, 19);
            this.txtStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtStartMinute.Name = "txtStartMinute";
            this.txtStartMinute.Size = new System.Drawing.Size(34, 21);
            this.txtStartMinute.TabIndex = 79;
            this.txtStartMinute.ValueChanged += new System.EventHandler(this.txtStartMinute_ValueChanged);
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(67, 19);
            this.txtStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(34, 21);
            this.txtStartHour.TabIndex = 78;
            this.txtStartHour.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txtStartHour.ValueChanged += new System.EventHandler(this.txtStartHour_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 77;
            this.label4.Text = "：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 76;
            this.label5.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 75;
            this.label6.Text = "起止时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 74;
            this.label8.Text = "分钟";
            // 
            // txtShiftTime
            // 
            this.txtShiftTime.Location = new System.Drawing.Point(67, 147);
            this.txtShiftTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtShiftTime.Name = "txtShiftTime";
            this.txtShiftTime.Size = new System.Drawing.Size(59, 21);
            this.txtShiftTime.TabIndex = 73;
            this.txtShiftTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtShiftTime.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 72;
            this.label9.Text = "出勤计时";
            // 
            // chkNextDay
            // 
            this.chkNextDay.AutoSize = true;
            this.chkNextDay.Location = new System.Drawing.Point(178, 21);
            this.chkNextDay.Name = "chkNextDay";
            this.chkNextDay.Size = new System.Drawing.Size(60, 16);
            this.chkNextDay.TabIndex = 71;
            this.chkNextDay.Text = "第二天";
            this.chkNextDay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 94;
            this.label1.Text = "分钟";
            // 
            // txtAllowLeaveEarlyTime
            // 
            this.txtAllowLeaveEarlyTime.Location = new System.Drawing.Point(236, 75);
            this.txtAllowLeaveEarlyTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAllowLeaveEarlyTime.Name = "txtAllowLeaveEarlyTime";
            this.txtAllowLeaveEarlyTime.Size = new System.Drawing.Size(59, 21);
            this.txtAllowLeaveEarlyTime.TabIndex = 93;
            this.txtAllowLeaveEarlyTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 92;
            this.label7.Text = "允许早退";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 91;
            this.label10.Text = "分钟";
            // 
            // txtAllowLateTime
            // 
            this.txtAllowLateTime.Location = new System.Drawing.Point(67, 75);
            this.txtAllowLateTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAllowLateTime.Name = "txtAllowLateTime";
            this.txtAllowLateTime.Size = new System.Drawing.Size(59, 21);
            this.txtAllowLateTime.TabIndex = 90;
            this.txtAllowLateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 89;
            this.label11.Text = "允许迟到";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(242, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 96;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(150, 192);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 95;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkLogAtStart
            // 
            this.chkLogAtStart.AutoSize = true;
            this.chkLogAtStart.Checked = true;
            this.chkLogAtStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogAtStart.Location = new System.Drawing.Point(66, 48);
            this.chkLogAtStart.Name = "chkLogAtStart";
            this.chkLogAtStart.Size = new System.Drawing.Size(96, 16);
            this.chkLogAtStart.TabIndex = 97;
            this.chkLogAtStart.Text = "上班需要打卡";
            this.chkLogAtStart.UseVisualStyleBackColor = true;
            // 
            // chkLogAtEnd
            // 
            this.chkLogAtEnd.AutoSize = true;
            this.chkLogAtEnd.Checked = true;
            this.chkLogAtEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogAtEnd.Location = new System.Drawing.Point(236, 48);
            this.chkLogAtEnd.Name = "chkLogAtEnd";
            this.chkLogAtEnd.Size = new System.Drawing.Size(96, 16);
            this.chkLogAtEnd.TabIndex = 98;
            this.chkLogAtEnd.Text = "下班需要打卡";
            this.chkLogAtEnd.UseVisualStyleBackColor = true;
            // 
            // FrmShiftItemDetail
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(337, 227);
            this.Controls.Add(this.chkLogAtEnd);
            this.Controls.Add(this.chkLogAtStart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAllowLeaveEarlyTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAllowLateTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAfterEndTime);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtBeforeStartTime);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtEndMinute);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartMinute);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtShiftTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkNextDay);
            this.Name = "FrmShiftItemDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "班次时间段";
            this.Load += new System.EventHandler(this.FrmShiftItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShiftTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowLeaveEarlyTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllowLateTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtAfterEndTime;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown txtBeforeStartTime;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown txtEndMinute;
        private System.Windows.Forms.NumericUpDown txtEndHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtStartMinute;
        private System.Windows.Forms.NumericUpDown txtStartHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtShiftTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkNextDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtAllowLeaveEarlyTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtAllowLateTime;
        private System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkLogAtStart;
        private System.Windows.Forms.CheckBox chkLogAtEnd;
    }
}