namespace LJH.Attendance.UI
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
            this.txtManager = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtHeader = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemo = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDuration1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndMinute1 = new System.Windows.Forms.NumericUpDown();
            this.txtEndHour1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartMinute1 = new System.Windows.Forms.NumericUpDown();
            this.txtStartHour1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkNextDay1 = new System.Windows.Forms.CheckBox();
            this.chkTime1 = new System.Windows.Forms.CheckBox();
            this.chkTime2 = new System.Windows.Forms.CheckBox();
            this.txtEndMinute2 = new System.Windows.Forms.NumericUpDown();
            this.txtEndHour2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartMinute2 = new System.Windows.Forms.NumericUpDown();
            this.txtStartHour2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkNextDay2 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDuration2 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.chkTime3 = new System.Windows.Forms.CheckBox();
            this.txtEndMinute3 = new System.Windows.Forms.NumericUpDown();
            this.txtEndHour3 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStartMinute3 = new System.Windows.Forms.NumericUpDown();
            this.txtStartHour3 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.chkNextDay3 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDuration3 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(492, 390);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(601, 390);
            // 
            // txtManager
            // 
            this.txtManager.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtManager.Location = new System.Drawing.Point(467, 351);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(80, 21);
            this.txtManager.TabIndex = 23;
            // 
            // txtHeader
            // 
            this.txtHeader.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtHeader.Location = new System.Drawing.Point(305, 351);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(80, 21);
            this.txtHeader.TabIndex = 21;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtEndDate.Location = new System.Drawing.Point(487, 23);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(123, 21);
            this.dtEndDate.TabIndex = 15;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtStartDate.Location = new System.Drawing.Point(324, 23);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(120, 21);
            this.dtStartDate.TabIndex = 14;
            // 
            // txtMemo
            // 
            this.txtMemo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMemo.Location = new System.Drawing.Point(252, 305);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(440, 33);
            this.txtMemo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "经理";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "部门主管";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(250, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 131);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 99);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "起止日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 282);
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
            this.label1.Location = new System.Drawing.Point(456, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(671, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "分钟";
            // 
            // txtDuration1
            // 
            this.txtDuration1.Location = new System.Drawing.Point(612, 52);
            this.txtDuration1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDuration1.Name = "txtDuration1";
            this.txtDuration1.Size = new System.Drawing.Size(53, 21);
            this.txtDuration1.TabIndex = 43;
            this.txtDuration1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(579, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "计时";
            // 
            // txtEndMinute1
            // 
            this.txtEndMinute1.Location = new System.Drawing.Point(536, 52);
            this.txtEndMinute1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEndMinute1.Name = "txtEndMinute1";
            this.txtEndMinute1.Size = new System.Drawing.Size(34, 21);
            this.txtEndMinute1.TabIndex = 91;
            this.txtEndMinute1.ValueChanged += new System.EventHandler(this.txtStartHour1_ValueChanged);
            // 
            // txtEndHour1
            // 
            this.txtEndHour1.Location = new System.Drawing.Point(493, 52);
            this.txtEndHour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEndHour1.Name = "txtEndHour1";
            this.txtEndHour1.Size = new System.Drawing.Size(34, 21);
            this.txtEndHour1.TabIndex = 90;
            this.txtEndHour1.ValueChanged += new System.EventHandler(this.txtStartHour1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 89;
            this.label3.Text = "：";
            // 
            // txtStartMinute1
            // 
            this.txtStartMinute1.Location = new System.Drawing.Point(367, 52);
            this.txtStartMinute1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtStartMinute1.Name = "txtStartMinute1";
            this.txtStartMinute1.Size = new System.Drawing.Size(34, 21);
            this.txtStartMinute1.TabIndex = 88;
            this.txtStartMinute1.ValueChanged += new System.EventHandler(this.txtStartHour1_ValueChanged);
            // 
            // txtStartHour1
            // 
            this.txtStartHour1.Location = new System.Drawing.Point(324, 52);
            this.txtStartHour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtStartHour1.Name = "txtStartHour1";
            this.txtStartHour1.Size = new System.Drawing.Size(34, 21);
            this.txtStartHour1.TabIndex = 87;
            this.txtStartHour1.ValueChanged += new System.EventHandler(this.txtStartHour1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 86;
            this.label5.Text = "：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 85;
            this.label8.Text = "---";
            // 
            // chkNextDay1
            // 
            this.chkNextDay1.AutoSize = true;
            this.chkNextDay1.Location = new System.Drawing.Point(435, 54);
            this.chkNextDay1.Name = "chkNextDay1";
            this.chkNextDay1.Size = new System.Drawing.Size(60, 16);
            this.chkNextDay1.TabIndex = 83;
            this.chkNextDay1.Text = "第二天";
            this.chkNextDay1.UseVisualStyleBackColor = true;
            // 
            // chkTime1
            // 
            this.chkTime1.AutoSize = true;
            this.chkTime1.Location = new System.Drawing.Point(250, 54);
            this.chkTime1.Name = "chkTime1";
            this.chkTime1.Size = new System.Drawing.Size(72, 16);
            this.chkTime1.TabIndex = 92;
            this.chkTime1.Text = "起止时间";
            this.chkTime1.UseVisualStyleBackColor = true;
            // 
            // chkTime2
            // 
            this.chkTime2.AutoSize = true;
            this.chkTime2.Location = new System.Drawing.Point(250, 81);
            this.chkTime2.Name = "chkTime2";
            this.chkTime2.Size = new System.Drawing.Size(72, 16);
            this.chkTime2.TabIndex = 104;
            this.chkTime2.Text = "起止时间";
            this.chkTime2.UseVisualStyleBackColor = true;
            // 
            // txtEndMinute2
            // 
            this.txtEndMinute2.Location = new System.Drawing.Point(536, 79);
            this.txtEndMinute2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEndMinute2.Name = "txtEndMinute2";
            this.txtEndMinute2.Size = new System.Drawing.Size(34, 21);
            this.txtEndMinute2.TabIndex = 103;
            this.txtEndMinute2.ValueChanged += new System.EventHandler(this.txtStartHour2_ValueChanged);
            // 
            // txtEndHour2
            // 
            this.txtEndHour2.Location = new System.Drawing.Point(493, 79);
            this.txtEndHour2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEndHour2.Name = "txtEndHour2";
            this.txtEndHour2.Size = new System.Drawing.Size(34, 21);
            this.txtEndHour2.TabIndex = 102;
            this.txtEndHour2.ValueChanged += new System.EventHandler(this.txtStartHour2_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 101;
            this.label9.Text = "：";
            // 
            // txtStartMinute2
            // 
            this.txtStartMinute2.Location = new System.Drawing.Point(367, 79);
            this.txtStartMinute2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtStartMinute2.Name = "txtStartMinute2";
            this.txtStartMinute2.Size = new System.Drawing.Size(34, 21);
            this.txtStartMinute2.TabIndex = 100;
            this.txtStartMinute2.ValueChanged += new System.EventHandler(this.txtStartHour2_ValueChanged);
            // 
            // txtStartHour2
            // 
            this.txtStartHour2.Location = new System.Drawing.Point(324, 79);
            this.txtStartHour2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtStartHour2.Name = "txtStartHour2";
            this.txtStartHour2.Size = new System.Drawing.Size(34, 21);
            this.txtStartHour2.TabIndex = 99;
            this.txtStartHour2.ValueChanged += new System.EventHandler(this.txtStartHour2_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(358, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 98;
            this.label12.Text = "：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 97;
            this.label13.Text = "---";
            // 
            // chkNextDay2
            // 
            this.chkNextDay2.AutoSize = true;
            this.chkNextDay2.Location = new System.Drawing.Point(435, 81);
            this.chkNextDay2.Name = "chkNextDay2";
            this.chkNextDay2.Size = new System.Drawing.Size(60, 16);
            this.chkNextDay2.TabIndex = 96;
            this.chkNextDay2.Text = "第二天";
            this.chkNextDay2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(671, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 95;
            this.label14.Text = "分钟";
            // 
            // txtDuration2
            // 
            this.txtDuration2.Location = new System.Drawing.Point(612, 79);
            this.txtDuration2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDuration2.Name = "txtDuration2";
            this.txtDuration2.Size = new System.Drawing.Size(53, 21);
            this.txtDuration2.TabIndex = 94;
            this.txtDuration2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(579, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 93;
            this.label15.Text = "计时";
            // 
            // chkTime3
            // 
            this.chkTime3.AutoSize = true;
            this.chkTime3.Location = new System.Drawing.Point(251, 106);
            this.chkTime3.Name = "chkTime3";
            this.chkTime3.Size = new System.Drawing.Size(72, 16);
            this.chkTime3.TabIndex = 116;
            this.chkTime3.Text = "起止时间";
            this.chkTime3.UseVisualStyleBackColor = true;
            // 
            // txtEndMinute3
            // 
            this.txtEndMinute3.Location = new System.Drawing.Point(537, 104);
            this.txtEndMinute3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEndMinute3.Name = "txtEndMinute3";
            this.txtEndMinute3.Size = new System.Drawing.Size(34, 21);
            this.txtEndMinute3.TabIndex = 115;
            this.txtEndMinute3.ValueChanged += new System.EventHandler(this.txtStartHour3_ValueChanged);
            // 
            // txtEndHour3
            // 
            this.txtEndHour3.Location = new System.Drawing.Point(494, 104);
            this.txtEndHour3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEndHour3.Name = "txtEndHour3";
            this.txtEndHour3.Size = new System.Drawing.Size(34, 21);
            this.txtEndHour3.TabIndex = 114;
            this.txtEndHour3.ValueChanged += new System.EventHandler(this.txtStartHour3_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(528, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 113;
            this.label16.Text = "：";
            // 
            // txtStartMinute3
            // 
            this.txtStartMinute3.Location = new System.Drawing.Point(368, 104);
            this.txtStartMinute3.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtStartMinute3.Name = "txtStartMinute3";
            this.txtStartMinute3.Size = new System.Drawing.Size(34, 21);
            this.txtStartMinute3.TabIndex = 112;
            this.txtStartMinute3.ValueChanged += new System.EventHandler(this.txtStartHour3_ValueChanged);
            // 
            // txtStartHour3
            // 
            this.txtStartHour3.Location = new System.Drawing.Point(325, 104);
            this.txtStartHour3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtStartHour3.Name = "txtStartHour3";
            this.txtStartHour3.Size = new System.Drawing.Size(34, 21);
            this.txtStartHour3.TabIndex = 111;
            this.txtStartHour3.ValueChanged += new System.EventHandler(this.txtStartHour3_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 110;
            this.label17.Text = "：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(408, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 12);
            this.label18.TabIndex = 109;
            this.label18.Text = "---";
            // 
            // chkNextDay3
            // 
            this.chkNextDay3.AutoSize = true;
            this.chkNextDay3.Location = new System.Drawing.Point(436, 106);
            this.chkNextDay3.Name = "chkNextDay3";
            this.chkNextDay3.Size = new System.Drawing.Size(60, 16);
            this.chkNextDay3.TabIndex = 108;
            this.chkNextDay3.Text = "第二天";
            this.chkNextDay3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(672, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 107;
            this.label19.Text = "分钟";
            // 
            // txtDuration3
            // 
            this.txtDuration3.Location = new System.Drawing.Point(613, 104);
            this.txtDuration3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDuration3.Name = "txtDuration3";
            this.txtDuration3.Size = new System.Drawing.Size(53, 21);
            this.txtDuration3.TabIndex = 106;
            this.txtDuration3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(580, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 105;
            this.label20.Text = "计时";
            // 
            // FrmTASheetGroupDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 425);
            this.Controls.Add(this.chkTime3);
            this.Controls.Add(this.txtEndMinute3);
            this.Controls.Add(this.txtEndHour3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtStartMinute3);
            this.Controls.Add(this.txtStartHour3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.chkNextDay3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDuration3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.chkTime2);
            this.Controls.Add(this.txtEndMinute2);
            this.Controls.Add(this.txtEndHour2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStartMinute2);
            this.Controls.Add(this.txtStartHour2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkNextDay2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDuration2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chkTime1);
            this.Controls.Add(this.txtEndMinute1);
            this.Controls.Add(this.txtEndHour1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStartMinute1);
            this.Controls.Add(this.txtStartHour1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkNextDay1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDuration1);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.label2);
            this.Name = "FrmTASheetGroupDetail";
            this.Text = "申请单登记";
            this.Controls.SetChildIndex(this.label2, 0);
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
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtDuration1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.chkNextDay1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtStartHour1, 0);
            this.Controls.SetChildIndex(this.txtStartMinute1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtEndHour1, 0);
            this.Controls.SetChildIndex(this.txtEndMinute1, 0);
            this.Controls.SetChildIndex(this.chkTime1, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtDuration2, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.chkNextDay2, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtStartHour2, 0);
            this.Controls.SetChildIndex(this.txtStartMinute2, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtEndHour2, 0);
            this.Controls.SetChildIndex(this.txtEndMinute2, 0);
            this.Controls.SetChildIndex(this.chkTime2, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.txtDuration3, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.chkNextDay3, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txtStartHour3, 0);
            this.Controls.SetChildIndex(this.txtStartMinute3, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtEndHour3, 0);
            this.Controls.SetChildIndex(this.txtEndMinute3, 0);
            this.Controls.SetChildIndex(this.chkTime3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuration3)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtDuration1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtEndMinute1;
        private System.Windows.Forms.NumericUpDown txtEndHour1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtStartMinute1;
        private System.Windows.Forms.NumericUpDown txtStartHour1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkNextDay1;
        private System.Windows.Forms.CheckBox chkTime1;
        private System.Windows.Forms.CheckBox chkTime2;
        private System.Windows.Forms.NumericUpDown txtEndMinute2;
        private System.Windows.Forms.NumericUpDown txtEndHour2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtStartMinute2;
        private System.Windows.Forms.NumericUpDown txtStartHour2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkNextDay2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtDuration2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkTime3;
        private System.Windows.Forms.NumericUpDown txtEndMinute3;
        private System.Windows.Forms.NumericUpDown txtEndHour3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown txtStartMinute3;
        private System.Windows.Forms.NumericUpDown txtStartHour3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkNextDay3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown txtDuration3;
        private System.Windows.Forms.Label label20;
    }
}