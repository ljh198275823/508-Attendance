namespace Ralid.Attendance.UI
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
            this.txtName = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtShortName = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShiftTime = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkNextDay = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartHour = new System.Windows.Forms.NumericUpDown();
            this.txtStartMinute = new System.Windows.Forms.NumericUpDown();
            this.txtEndMinute = new System.Windows.Forms.NumericUpDown();
            this.txtEndHour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAfterEndTime = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBeforeStartTime = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtShiftTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeStartTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(225, 157);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 157);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "分钟";
            // 
            // txtShiftTime
            // 
            this.txtShiftTime.Location = new System.Drawing.Point(72, 119);
            this.txtShiftTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtShiftTime.Name = "txtShiftTime";
            this.txtShiftTime.Size = new System.Drawing.Size(77, 21);
            this.txtShiftTime.TabIndex = 18;
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
            this.label9.Location = new System.Drawing.Point(13, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "出勤计时";
            // 
            // chkNextDay
            // 
            this.chkNextDay.AutoSize = true;
            this.chkNextDay.Location = new System.Drawing.Point(192, 54);
            this.chkNextDay.Name = "chkNextDay";
            this.chkNextDay.Size = new System.Drawing.Size(60, 16);
            this.chkNextDay.TabIndex = 6;
            this.chkNextDay.Text = "第二天";
            this.chkNextDay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 46;
            this.label5.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "起止时间";
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(72, 52);
            this.txtStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(34, 21);
            this.txtStartHour.TabIndex = 53;
            // 
            // txtStartMinute
            // 
            this.txtStartMinute.Location = new System.Drawing.Point(115, 52);
            this.txtStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtStartMinute.Name = "txtStartMinute";
            this.txtStartMinute.Size = new System.Drawing.Size(34, 21);
            this.txtStartMinute.TabIndex = 54;
            // 
            // txtEndMinute
            // 
            this.txtEndMinute.Location = new System.Drawing.Point(292, 52);
            this.txtEndMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEndMinute.Name = "txtEndMinute";
            this.txtEndMinute.Size = new System.Drawing.Size(34, 21);
            this.txtEndMinute.TabIndex = 57;
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(249, 52);
            this.txtEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(34, 21);
            this.txtEndHour.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 55;
            this.label2.Text = "：";
            // 
            // txtAfterEndTime
            // 
            this.txtAfterEndTime.Location = new System.Drawing.Point(300, 84);
            this.txtAfterEndTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAfterEndTime.Name = "txtAfterEndTime";
            this.txtAfterEndTime.Size = new System.Drawing.Size(77, 21);
            this.txtAfterEndTime.TabIndex = 69;
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
            this.label31.Location = new System.Drawing.Point(241, 88);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 68;
            this.label31.Text = "延长刷卡";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(163, 88);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 67;
            this.label29.Text = "分钟";
            // 
            // txtBeforeStartTime
            // 
            this.txtBeforeStartTime.Location = new System.Drawing.Point(72, 84);
            this.txtBeforeStartTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtBeforeStartTime.Name = "txtBeforeStartTime";
            this.txtBeforeStartTime.Size = new System.Drawing.Size(77, 21);
            this.txtBeforeStartTime.TabIndex = 66;
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
            this.label30.Location = new System.Drawing.Point(12, 88);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 65;
            this.label30.Text = "提前刷卡";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 70;
            this.label3.Text = "分钟";
            // 
            // FrmShiftDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 192);
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
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.chkNextDay);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmShiftDetail";
            this.Text = "班次明细";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.chkNextDay, 0);
            this.Controls.SetChildIndex(this.txtShortName, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtShiftTime, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtStartHour, 0);
            this.Controls.SetChildIndex(this.txtStartMinute, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtEndHour, 0);
            this.Controls.SetChildIndex(this.txtEndMinute, 0);
            this.Controls.SetChildIndex(this.label30, 0);
            this.Controls.SetChildIndex(this.txtBeforeStartTime, 0);
            this.Controls.SetChildIndex(this.label29, 0);
            this.Controls.SetChildIndex(this.label31, 0);
            this.Controls.SetChildIndex(this.txtAfterEndTime, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtShiftTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeStartTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GeneralLibrary.WinformControl.DBCTextBox txtName;
        private GeneralLibrary.WinformControl.DBCTextBox txtShortName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtShiftTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkNextDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtStartHour;
        private System.Windows.Forms.NumericUpDown txtStartMinute;
        private System.Windows.Forms.NumericUpDown txtEndMinute;
        private System.Windows.Forms.NumericUpDown txtEndHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtAfterEndTime;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown txtBeforeStartTime;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label3;
    }
}