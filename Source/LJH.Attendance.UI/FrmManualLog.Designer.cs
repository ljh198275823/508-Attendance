namespace LJH.Attendance.UI
{
    partial class FrmManualLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManualLog));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemo = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.chkTime1 = new System.Windows.Forms.CheckBox();
            this.chkTime2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentTreeview1 = new LJH.Attendance.UI.DepartmentTreeview(this.components);
            this.txtMinute1 = new System.Windows.Forms.NumericUpDown();
            this.txtHour1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinute2 = new System.Windows.Forms.NumericUpDown();
            this.txtHour2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinute3 = new System.Windows.Forms.NumericUpDown();
            this.txtHour3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTime3 = new System.Windows.Forms.CheckBox();
            this.txtMinute4 = new System.Windows.Forms.NumericUpDown();
            this.txtHour4 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTime4 = new System.Windows.Forms.CheckBox();
            this.txtMinute5 = new System.Windows.Forms.NumericUpDown();
            this.txtHour5 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.chkTime5 = new System.Windows.Forms.CheckBox();
            this.txtMinute6 = new System.Windows.Forms.NumericUpDown();
            this.txtHour6 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkTime6 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(409, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(300, 303);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "起止日期";
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.Location = new System.Drawing.Point(299, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(107, 21);
            this.dtStart.TabIndex = 11;
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.Location = new System.Drawing.Point(437, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(107, 21);
            this.dtEnd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "--";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "补签原因";
            // 
            // txtMemo
            // 
            this.txtMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMemo.Location = new System.Drawing.Point(299, 264);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(243, 21);
            this.txtMemo.TabIndex = 19;
            // 
            // chkTime1
            // 
            this.chkTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime1.AutoSize = true;
            this.chkTime1.Checked = true;
            this.chkTime1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTime1.Location = new System.Drawing.Point(299, 70);
            this.chkTime1.Name = "chkTime1";
            this.chkTime1.Size = new System.Drawing.Size(90, 16);
            this.chkTime1.TabIndex = 20;
            this.chkTime1.Text = "补签时间1：";
            this.chkTime1.UseVisualStyleBackColor = true;
            // 
            // chkTime2
            // 
            this.chkTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime2.AutoSize = true;
            this.chkTime2.Location = new System.Drawing.Point(299, 100);
            this.chkTime2.Name = "chkTime2";
            this.chkTime2.Size = new System.Drawing.Size(90, 16);
            this.chkTime2.TabIndex = 21;
            this.chkTime2.Text = "补签时间2：";
            this.chkTime2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.departmentTreeview1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 330);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择人员";
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTreeview1.CheckBoxes = true;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(8, 17);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(264, 307);
            this.departmentTreeview1.TabIndex = 8;
            // 
            // txtMinute1
            // 
            this.txtMinute1.Location = new System.Drawing.Point(424, 68);
            this.txtMinute1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMinute1.Name = "txtMinute1";
            this.txtMinute1.Size = new System.Drawing.Size(34, 21);
            this.txtMinute1.TabIndex = 57;
            // 
            // txtHour1
            // 
            this.txtHour1.Location = new System.Drawing.Point(381, 68);
            this.txtHour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour1.Name = "txtHour1";
            this.txtHour1.Size = new System.Drawing.Size(34, 21);
            this.txtHour1.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "：";
            // 
            // txtMinute2
            // 
            this.txtMinute2.Location = new System.Drawing.Point(424, 98);
            this.txtMinute2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMinute2.Name = "txtMinute2";
            this.txtMinute2.Size = new System.Drawing.Size(34, 21);
            this.txtMinute2.TabIndex = 60;
            // 
            // txtHour2
            // 
            this.txtHour2.Location = new System.Drawing.Point(381, 98);
            this.txtHour2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour2.Name = "txtHour2";
            this.txtHour2.Size = new System.Drawing.Size(34, 21);
            this.txtHour2.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 58;
            this.label3.Text = "：";
            // 
            // txtMinute3
            // 
            this.txtMinute3.Location = new System.Drawing.Point(424, 126);
            this.txtMinute3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMinute3.Name = "txtMinute3";
            this.txtMinute3.Size = new System.Drawing.Size(34, 21);
            this.txtMinute3.TabIndex = 64;
            // 
            // txtHour3
            // 
            this.txtHour3.Location = new System.Drawing.Point(381, 126);
            this.txtHour3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour3.Name = "txtHour3";
            this.txtHour3.Size = new System.Drawing.Size(34, 21);
            this.txtHour3.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 62;
            this.label6.Text = "：";
            // 
            // chkTime3
            // 
            this.chkTime3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime3.AutoSize = true;
            this.chkTime3.Location = new System.Drawing.Point(299, 128);
            this.chkTime3.Name = "chkTime3";
            this.chkTime3.Size = new System.Drawing.Size(90, 16);
            this.chkTime3.TabIndex = 61;
            this.chkTime3.Text = "补签时间3：";
            this.chkTime3.UseVisualStyleBackColor = true;
            // 
            // txtMinute4
            // 
            this.txtMinute4.Location = new System.Drawing.Point(424, 153);
            this.txtMinute4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMinute4.Name = "txtMinute4";
            this.txtMinute4.Size = new System.Drawing.Size(34, 21);
            this.txtMinute4.TabIndex = 68;
            // 
            // txtHour4
            // 
            this.txtHour4.Location = new System.Drawing.Point(381, 153);
            this.txtHour4.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour4.Name = "txtHour4";
            this.txtHour4.Size = new System.Drawing.Size(34, 21);
            this.txtHour4.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 66;
            this.label7.Text = "：";
            // 
            // chkTime4
            // 
            this.chkTime4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime4.AutoSize = true;
            this.chkTime4.Location = new System.Drawing.Point(299, 155);
            this.chkTime4.Name = "chkTime4";
            this.chkTime4.Size = new System.Drawing.Size(90, 16);
            this.chkTime4.TabIndex = 65;
            this.chkTime4.Text = "补签时间4：";
            this.chkTime4.UseVisualStyleBackColor = true;
            // 
            // txtMinute5
            // 
            this.txtMinute5.Location = new System.Drawing.Point(424, 180);
            this.txtMinute5.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMinute5.Name = "txtMinute5";
            this.txtMinute5.Size = new System.Drawing.Size(34, 21);
            this.txtMinute5.TabIndex = 72;
            // 
            // txtHour5
            // 
            this.txtHour5.Location = new System.Drawing.Point(381, 180);
            this.txtHour5.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour5.Name = "txtHour5";
            this.txtHour5.Size = new System.Drawing.Size(34, 21);
            this.txtHour5.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 70;
            this.label8.Text = "：";
            // 
            // chkTime5
            // 
            this.chkTime5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime5.AutoSize = true;
            this.chkTime5.Location = new System.Drawing.Point(299, 182);
            this.chkTime5.Name = "chkTime5";
            this.chkTime5.Size = new System.Drawing.Size(90, 16);
            this.chkTime5.TabIndex = 69;
            this.chkTime5.Text = "补签时间5：";
            this.chkTime5.UseVisualStyleBackColor = true;
            // 
            // txtMinute6
            // 
            this.txtMinute6.Location = new System.Drawing.Point(424, 209);
            this.txtMinute6.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMinute6.Name = "txtMinute6";
            this.txtMinute6.Size = new System.Drawing.Size(34, 21);
            this.txtMinute6.TabIndex = 76;
            // 
            // txtHour6
            // 
            this.txtHour6.Location = new System.Drawing.Point(381, 209);
            this.txtHour6.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour6.Name = "txtHour6";
            this.txtHour6.Size = new System.Drawing.Size(34, 21);
            this.txtHour6.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 74;
            this.label9.Text = "：";
            // 
            // chkTime6
            // 
            this.chkTime6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime6.AutoSize = true;
            this.chkTime6.Location = new System.Drawing.Point(299, 211);
            this.chkTime6.Name = "chkTime6";
            this.chkTime6.Size = new System.Drawing.Size(90, 16);
            this.chkTime6.TabIndex = 73;
            this.chkTime6.Text = "补签时间6：";
            this.chkTime6.UseVisualStyleBackColor = true;
            // 
            // FrmManualLog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(551, 345);
            this.Controls.Add(this.txtMinute6);
            this.Controls.Add(this.txtHour6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkTime6);
            this.Controls.Add(this.txtMinute5);
            this.Controls.Add(this.txtHour5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkTime5);
            this.Controls.Add(this.txtMinute4);
            this.Controls.Add(this.txtHour4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkTime4);
            this.Controls.Add(this.txtMinute3);
            this.Controls.Add(this.txtHour3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkTime3);
            this.Controls.Add(this.txtMinute2);
            this.Controls.Add(this.txtHour2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinute1);
            this.Controls.Add(this.txtHour1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTime2);
            this.Controls.Add(this.chkTime1);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManualLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "补签";
            this.Load += new System.EventHandler(this.FrmManualLog_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinute6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private GeneralLibrary.WinformControl.DBCTextBox txtMemo;
        private System.Windows.Forms.CheckBox chkTime1;
        private System.Windows.Forms.CheckBox chkTime2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DepartmentTreeview departmentTreeview1;
        private System.Windows.Forms.NumericUpDown txtMinute1;
        private System.Windows.Forms.NumericUpDown txtHour1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtMinute2;
        private System.Windows.Forms.NumericUpDown txtHour2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtMinute3;
        private System.Windows.Forms.NumericUpDown txtHour3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTime3;
        private System.Windows.Forms.NumericUpDown txtMinute4;
        private System.Windows.Forms.NumericUpDown txtHour4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkTime4;
        private System.Windows.Forms.NumericUpDown txtMinute5;
        private System.Windows.Forms.NumericUpDown txtHour5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkTime5;
        private System.Windows.Forms.NumericUpDown txtMinute6;
        private System.Windows.Forms.NumericUpDown txtHour6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTime6;
    }
}