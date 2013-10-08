namespace Ralid.Attendance.UI
{
    partial class FrmTASheetGroupDetail
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
            this.txtManager = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtHeader = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemo = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartTimeHour = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartTimeMinute = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtEndTimeMinute = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndTimeHour = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(469, 342);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(578, 342);
            // 
            // txtManager
            // 
            this.txtManager.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtManager.Location = new System.Drawing.Point(467, 297);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(80, 21);
            this.txtManager.TabIndex = 23;
            // 
            // txtHeader
            // 
            this.txtHeader.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtHeader.Location = new System.Drawing.Point(305, 297);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(80, 21);
            this.txtHeader.TabIndex = 21;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtEndDate.Location = new System.Drawing.Point(477, 23);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(123, 21);
            this.dtEndDate.TabIndex = 15;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtStartDate.Location = new System.Drawing.Point(314, 23);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(120, 21);
            this.dtStartDate.TabIndex = 14;
            // 
            // txtMemo
            // 
            this.txtMemo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMemo.Location = new System.Drawing.Point(252, 251);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(404, 33);
            this.txtMemo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "经理";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "部门主管";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(250, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 131);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类别";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 99);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "起止日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "起止时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "事由";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(6, 20);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(211, 296);
            this.treeView1.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 360);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "申请人";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(6, 322);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(99, 27);
            this.btnSelect.TabIndex = 31;
            this.btnSelect.Text = "选择人员";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "---";
            // 
            // txtStartTimeHour
            // 
            this.txtStartTimeHour.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStartTimeHour.Location = new System.Drawing.Point(314, 52);
            this.txtStartTimeHour.MaxValue = 23;
            this.txtStartTimeHour.MinValue = 0;
            this.txtStartTimeHour.Name = "txtStartTimeHour";
            this.txtStartTimeHour.Size = new System.Drawing.Size(34, 21);
            this.txtStartTimeHour.TabIndex = 36;
            this.txtStartTimeHour.Text = "0";
            this.txtStartTimeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "：";
            // 
            // txtStartTimeMinute
            // 
            this.txtStartTimeMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStartTimeMinute.Location = new System.Drawing.Point(357, 52);
            this.txtStartTimeMinute.MaxValue = 59;
            this.txtStartTimeMinute.MinValue = 0;
            this.txtStartTimeMinute.Name = "txtStartTimeMinute";
            this.txtStartTimeMinute.Size = new System.Drawing.Size(34, 21);
            this.txtStartTimeMinute.TabIndex = 38;
            this.txtStartTimeMinute.Text = "0";
            this.txtStartTimeMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndTimeMinute
            // 
            this.txtEndTimeMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtEndTimeMinute.Location = new System.Drawing.Point(474, 52);
            this.txtEndTimeMinute.MaxValue = 59;
            this.txtEndTimeMinute.MinValue = 0;
            this.txtEndTimeMinute.Name = "txtEndTimeMinute";
            this.txtEndTimeMinute.Size = new System.Drawing.Size(34, 21);
            this.txtEndTimeMinute.TabIndex = 41;
            this.txtEndTimeMinute.Text = "0";
            this.txtEndTimeMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "：";
            // 
            // txtEndTimeHour
            // 
            this.txtEndTimeHour.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtEndTimeHour.Location = new System.Drawing.Point(433, 52);
            this.txtEndTimeHour.MaxValue = 23;
            this.txtEndTimeHour.MinValue = 0;
            this.txtEndTimeHour.Name = "txtEndTimeHour";
            this.txtEndTimeHour.Size = new System.Drawing.Size(34, 21);
            this.txtEndTimeHour.TabIndex = 39;
            this.txtEndTimeHour.Text = "0";
            this.txtEndTimeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(616, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "分钟";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(557, 52);
            this.txtDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(53, 21);
            this.txtDuration.TabIndex = 43;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "计时";
            // 
            // FrmTASheetGroupDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 377);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEndTimeMinute);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEndTimeHour);
            this.Controls.Add(this.txtStartTimeMinute);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStartTimeHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmTASheetGroupDetail";
            this.Text = "申请单登记";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dtEndDate, 0);
            this.Controls.SetChildIndex(this.txtManager, 0);
            this.Controls.SetChildIndex(this.dtStartDate, 0);
            this.Controls.SetChildIndex(this.txtHeader, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtStartTimeHour, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtStartTimeMinute, 0);
            this.Controls.SetChildIndex(this.txtEndTimeHour, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtEndTimeMinute, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtDuration, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GeneralLibrary.WinformControl.DBCTextBox txtManager;
        private GeneralLibrary.WinformControl.DBCTextBox txtHeader;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private GeneralLibrary.WinformControl.DBCTextBox txtMemo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private GeneralLibrary.WinformControl.IntergerTextBox txtStartTimeHour;
        private System.Windows.Forms.Label label8;
        private GeneralLibrary.WinformControl.IntergerTextBox txtStartTimeMinute;
        private GeneralLibrary.WinformControl.IntergerTextBox txtEndTimeMinute;
        private System.Windows.Forms.Label label9;
        private GeneralLibrary.WinformControl.IntergerTextBox txtEndTimeHour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtDuration;
        private System.Windows.Forms.Label label11;
    }
}