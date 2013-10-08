namespace Ralid.Attendance.UI
{
    partial class FrmAttendanceRules
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab基本 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinutesOfWorkDay = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinOTMinute = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chkShiftTimeContainChuChai = new System.Windows.Forms.CheckBox();
            this.chkShiftTimeContainWaiChu = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeaveEarlyAsAbsent = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtLateAsAbsent = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.chkLeaveEarlyAsAbsent = new System.Windows.Forms.CheckBox();
            this.chkLateAsAbsent = new System.Windows.Forms.CheckBox();
            this.tab考勤单位 = new System.Windows.Forms.TabPage();
            this.txtMinLateLeaveEarlyTime = new Ralid.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMinChuChaiTime = new Ralid.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMinWaichuTime = new Ralid.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMinOTTime = new Ralid.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinVacationTime = new Ralid.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinShiftTime = new Ralid.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.comVacationUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comOTUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comWaichuUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comChuchaiUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comLateLeaveEarlyUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comShiftUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.txtAllowLate = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtAllowEarly = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.intergerTextBox1 = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.intergerTextBox2 = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.intergerTextBox3 = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.intergerTextBox4 = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.intergerTextBox5 = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBeforeStartTime = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.txtAfterEndTime = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab基本.SuspendLayout();
            this.tab考勤单位.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterEndTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab基本);
            this.tabControl1.Controls.Add(this.tab考勤单位);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tab基本
            // 
            this.tab基本.Controls.Add(this.txtAfterEndTime);
            this.tab基本.Controls.Add(this.label31);
            this.tab基本.Controls.Add(this.label29);
            this.tab基本.Controls.Add(this.txtBeforeStartTime);
            this.tab基本.Controls.Add(this.label30);
            this.tab基本.Controls.Add(this.label27);
            this.tab基本.Controls.Add(this.intergerTextBox5);
            this.tab基本.Controls.Add(this.label28);
            this.tab基本.Controls.Add(this.label25);
            this.tab基本.Controls.Add(this.intergerTextBox3);
            this.tab基本.Controls.Add(this.label26);
            this.tab基本.Controls.Add(this.intergerTextBox4);
            this.tab基本.Controls.Add(this.label24);
            this.tab基本.Controls.Add(this.intergerTextBox2);
            this.tab基本.Controls.Add(this.checkBox2);
            this.tab基本.Controls.Add(this.label23);
            this.tab基本.Controls.Add(this.intergerTextBox1);
            this.tab基本.Controls.Add(this.checkBox1);
            this.tab基本.Controls.Add(this.txtAllowLate);
            this.tab基本.Controls.Add(this.txtAllowEarly);
            this.tab基本.Controls.Add(this.label21);
            this.tab基本.Controls.Add(this.label22);
            this.tab基本.Controls.Add(this.label19);
            this.tab基本.Controls.Add(this.label20);
            this.tab基本.Controls.Add(this.label5);
            this.tab基本.Controls.Add(this.txtMinutesOfWorkDay);
            this.tab基本.Controls.Add(this.label6);
            this.tab基本.Controls.Add(this.label4);
            this.tab基本.Controls.Add(this.txtMinOTMinute);
            this.tab基本.Controls.Add(this.label1);
            this.tab基本.Controls.Add(this.chkShiftTimeContainChuChai);
            this.tab基本.Controls.Add(this.chkShiftTimeContainWaiChu);
            this.tab基本.Controls.Add(this.label3);
            this.tab基本.Controls.Add(this.txtLeaveEarlyAsAbsent);
            this.tab基本.Controls.Add(this.label2);
            this.tab基本.Controls.Add(this.txtLateAsAbsent);
            this.tab基本.Controls.Add(this.chkLeaveEarlyAsAbsent);
            this.tab基本.Controls.Add(this.chkLateAsAbsent);
            this.tab基本.Location = new System.Drawing.Point(4, 22);
            this.tab基本.Name = "tab基本";
            this.tab基本.Padding = new System.Windows.Forms.Padding(3);
            this.tab基本.Size = new System.Drawing.Size(507, 342);
            this.tab基本.TabIndex = 0;
            this.tab基本.Text = "基本";
            this.tab基本.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "分钟";
            // 
            // txtMinutesOfWorkDay
            // 
            this.txtMinutesOfWorkDay.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinutesOfWorkDay.Location = new System.Drawing.Point(351, 165);
            this.txtMinutesOfWorkDay.MaxValue = 10000;
            this.txtMinutesOfWorkDay.MinValue = 1;
            this.txtMinutesOfWorkDay.Name = "txtMinutesOfWorkDay";
            this.txtMinutesOfWorkDay.Size = new System.Drawing.Size(54, 21);
            this.txtMinutesOfWorkDay.TabIndex = 34;
            this.txtMinutesOfWorkDay.Text = "480";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "一个工作日等于";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "分钟后签退才有效";
            // 
            // txtMinOTMinute
            // 
            this.txtMinOTMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinOTMinute.Location = new System.Drawing.Point(49, 189);
            this.txtMinOTMinute.MaxValue = 10000;
            this.txtMinOTMinute.MinValue = 1;
            this.txtMinOTMinute.Name = "txtMinOTMinute";
            this.txtMinOTMinute.Size = new System.Drawing.Size(54, 21);
            this.txtMinOTMinute.TabIndex = 28;
            this.txtMinOTMinute.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "加班";
            // 
            // chkShiftTimeContainChuChai
            // 
            this.chkShiftTimeContainChuChai.AutoSize = true;
            this.chkShiftTimeContainChuChai.Checked = true;
            this.chkShiftTimeContainChuChai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShiftTimeContainChuChai.Location = new System.Drawing.Point(433, 194);
            this.chkShiftTimeContainChuChai.Name = "chkShiftTimeContainChuChai";
            this.chkShiftTimeContainChuChai.Size = new System.Drawing.Size(120, 16);
            this.chkShiftTimeContainChuChai.TabIndex = 26;
            this.chkShiftTimeContainChuChai.Text = "出差同时计为出勤";
            this.chkShiftTimeContainChuChai.UseVisualStyleBackColor = true;
            // 
            // chkShiftTimeContainWaiChu
            // 
            this.chkShiftTimeContainWaiChu.AutoSize = true;
            this.chkShiftTimeContainWaiChu.Checked = true;
            this.chkShiftTimeContainWaiChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShiftTimeContainWaiChu.Location = new System.Drawing.Point(260, 194);
            this.chkShiftTimeContainWaiChu.Name = "chkShiftTimeContainWaiChu";
            this.chkShiftTimeContainWaiChu.Size = new System.Drawing.Size(120, 16);
            this.chkShiftTimeContainWaiChu.TabIndex = 25;
            this.chkShiftTimeContainWaiChu.Text = "外出同时计为出勤";
            this.chkShiftTimeContainWaiChu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "分钟 计为缺勤";
            // 
            // txtLeaveEarlyAsAbsent
            // 
            this.txtLeaveEarlyAsAbsent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLeaveEarlyAsAbsent.Location = new System.Drawing.Point(123, 134);
            this.txtLeaveEarlyAsAbsent.MaxValue = 10000;
            this.txtLeaveEarlyAsAbsent.MinValue = 1;
            this.txtLeaveEarlyAsAbsent.Name = "txtLeaveEarlyAsAbsent";
            this.txtLeaveEarlyAsAbsent.Size = new System.Drawing.Size(54, 21);
            this.txtLeaveEarlyAsAbsent.TabIndex = 23;
            this.txtLeaveEarlyAsAbsent.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "分钟 计为缺勤";
            // 
            // txtLateAsAbsent
            // 
            this.txtLateAsAbsent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLateAsAbsent.Location = new System.Drawing.Point(123, 110);
            this.txtLateAsAbsent.MaxValue = 10000;
            this.txtLateAsAbsent.MinValue = 1;
            this.txtLateAsAbsent.Name = "txtLateAsAbsent";
            this.txtLateAsAbsent.Size = new System.Drawing.Size(54, 21);
            this.txtLateAsAbsent.TabIndex = 21;
            this.txtLateAsAbsent.Text = "30";
            // 
            // chkLeaveEarlyAsAbsent
            // 
            this.chkLeaveEarlyAsAbsent.AutoSize = true;
            this.chkLeaveEarlyAsAbsent.Location = new System.Drawing.Point(13, 136);
            this.chkLeaveEarlyAsAbsent.Name = "chkLeaveEarlyAsAbsent";
            this.chkLeaveEarlyAsAbsent.Size = new System.Drawing.Size(96, 16);
            this.chkLeaveEarlyAsAbsent.TabIndex = 17;
            this.chkLeaveEarlyAsAbsent.Text = "早退时间大于";
            this.chkLeaveEarlyAsAbsent.UseVisualStyleBackColor = true;
            // 
            // chkLateAsAbsent
            // 
            this.chkLateAsAbsent.AutoSize = true;
            this.chkLateAsAbsent.Location = new System.Drawing.Point(13, 112);
            this.chkLateAsAbsent.Name = "chkLateAsAbsent";
            this.chkLateAsAbsent.Size = new System.Drawing.Size(96, 16);
            this.chkLateAsAbsent.TabIndex = 16;
            this.chkLateAsAbsent.Text = "迟到时间大于";
            this.chkLateAsAbsent.UseVisualStyleBackColor = true;
            // 
            // tab考勤单位
            // 
            this.tab考勤单位.Controls.Add(this.comVacationUnit);
            this.tab考勤单位.Controls.Add(this.comOTUnit);
            this.tab考勤单位.Controls.Add(this.comWaichuUnit);
            this.tab考勤单位.Controls.Add(this.comChuchaiUnit);
            this.tab考勤单位.Controls.Add(this.comLateLeaveEarlyUnit);
            this.tab考勤单位.Controls.Add(this.comShiftUnit);
            this.tab考勤单位.Controls.Add(this.txtMinLateLeaveEarlyTime);
            this.tab考勤单位.Controls.Add(this.label17);
            this.tab考勤单位.Controls.Add(this.label18);
            this.tab考勤单位.Controls.Add(this.txtMinChuChaiTime);
            this.tab考勤单位.Controls.Add(this.label15);
            this.tab考勤单位.Controls.Add(this.label16);
            this.tab考勤单位.Controls.Add(this.txtMinWaichuTime);
            this.tab考勤单位.Controls.Add(this.label13);
            this.tab考勤单位.Controls.Add(this.label14);
            this.tab考勤单位.Controls.Add(this.txtMinOTTime);
            this.tab考勤单位.Controls.Add(this.label11);
            this.tab考勤单位.Controls.Add(this.label12);
            this.tab考勤单位.Controls.Add(this.txtMinVacationTime);
            this.tab考勤单位.Controls.Add(this.label9);
            this.tab考勤单位.Controls.Add(this.label10);
            this.tab考勤单位.Controls.Add(this.txtMinShiftTime);
            this.tab考勤单位.Controls.Add(this.label8);
            this.tab考勤单位.Controls.Add(this.label7);
            this.tab考勤单位.Location = new System.Drawing.Point(4, 22);
            this.tab考勤单位.Name = "tab考勤单位";
            this.tab考勤单位.Padding = new System.Windows.Forms.Padding(3);
            this.tab考勤单位.Size = new System.Drawing.Size(507, 297);
            this.tab考勤单位.TabIndex = 4;
            this.tab考勤单位.Text = "考勤单位";
            this.tab考勤单位.UseVisualStyleBackColor = true;
            // 
            // txtMinLateLeaveEarlyTime
            // 
            this.txtMinLateLeaveEarlyTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLateLeaveEarlyTime.Location = new System.Drawing.Point(223, 174);
            this.txtMinLateLeaveEarlyTime.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMinLateLeaveEarlyTime.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinLateLeaveEarlyTime.Name = "txtMinLateLeaveEarlyTime";
            this.txtMinLateLeaveEarlyTime.PointCount = 2;
            this.txtMinLateLeaveEarlyTime.Size = new System.Drawing.Size(49, 21);
            this.txtMinLateLeaveEarlyTime.TabIndex = 50;
            this.txtMinLateLeaveEarlyTime.Text = "0.1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(176, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 49;
            this.label17.Text = "最小值";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 48;
            this.label18.Text = "迟到早退";
            // 
            // txtMinChuChaiTime
            // 
            this.txtMinChuChaiTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinChuChaiTime.Location = new System.Drawing.Point(223, 140);
            this.txtMinChuChaiTime.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMinChuChaiTime.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinChuChaiTime.Name = "txtMinChuChaiTime";
            this.txtMinChuChaiTime.PointCount = 2;
            this.txtMinChuChaiTime.Size = new System.Drawing.Size(49, 21);
            this.txtMinChuChaiTime.TabIndex = 47;
            this.txtMinChuChaiTime.Text = "0.1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 46;
            this.label15.Text = "最小值";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 45;
            this.label16.Text = "出差";
            // 
            // txtMinWaichuTime
            // 
            this.txtMinWaichuTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinWaichuTime.Location = new System.Drawing.Point(223, 111);
            this.txtMinWaichuTime.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMinWaichuTime.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinWaichuTime.Name = "txtMinWaichuTime";
            this.txtMinWaichuTime.PointCount = 2;
            this.txtMinWaichuTime.Size = new System.Drawing.Size(49, 21);
            this.txtMinWaichuTime.TabIndex = 44;
            this.txtMinWaichuTime.Text = "0.1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 43;
            this.label13.Text = "最小值";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 42;
            this.label14.Text = "外出";
            // 
            // txtMinOTTime
            // 
            this.txtMinOTTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinOTTime.Location = new System.Drawing.Point(223, 79);
            this.txtMinOTTime.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMinOTTime.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinOTTime.Name = "txtMinOTTime";
            this.txtMinOTTime.PointCount = 2;
            this.txtMinOTTime.Size = new System.Drawing.Size(49, 21);
            this.txtMinOTTime.TabIndex = 41;
            this.txtMinOTTime.Text = "0.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "最小值";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "加班";
            // 
            // txtMinVacationTime
            // 
            this.txtMinVacationTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinVacationTime.Location = new System.Drawing.Point(223, 47);
            this.txtMinVacationTime.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMinVacationTime.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinVacationTime.Name = "txtMinVacationTime";
            this.txtMinVacationTime.PointCount = 2;
            this.txtMinVacationTime.Size = new System.Drawing.Size(49, 21);
            this.txtMinVacationTime.TabIndex = 38;
            this.txtMinVacationTime.Text = "0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 37;
            this.label9.Text = "最小值";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "请假";
            // 
            // txtMinShiftTime
            // 
            this.txtMinShiftTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinShiftTime.Location = new System.Drawing.Point(223, 17);
            this.txtMinShiftTime.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMinShiftTime.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinShiftTime.Name = "txtMinShiftTime";
            this.txtMinShiftTime.PointCount = 2;
            this.txtMinShiftTime.Size = new System.Drawing.Size(49, 21);
            this.txtMinShiftTime.TabIndex = 35;
            this.txtMinShiftTime.Text = "0.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "最小值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "出勤";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(430, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(336, 386);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comVacationUnit
            // 
            this.comVacationUnit.FormattingEnabled = true;
            this.comVacationUnit.Location = new System.Drawing.Point(70, 47);
            this.comVacationUnit.Name = "comVacationUnit";
            this.comVacationUnit.Size = new System.Drawing.Size(100, 20);
            this.comVacationUnit.TabIndex = 56;
            // 
            // comOTUnit
            // 
            this.comOTUnit.FormattingEnabled = true;
            this.comOTUnit.Location = new System.Drawing.Point(70, 79);
            this.comOTUnit.Name = "comOTUnit";
            this.comOTUnit.Size = new System.Drawing.Size(100, 20);
            this.comOTUnit.TabIndex = 55;
            // 
            // comWaichuUnit
            // 
            this.comWaichuUnit.FormattingEnabled = true;
            this.comWaichuUnit.Location = new System.Drawing.Point(70, 111);
            this.comWaichuUnit.Name = "comWaichuUnit";
            this.comWaichuUnit.Size = new System.Drawing.Size(100, 20);
            this.comWaichuUnit.TabIndex = 54;
            // 
            // comChuchaiUnit
            // 
            this.comChuchaiUnit.FormattingEnabled = true;
            this.comChuchaiUnit.Location = new System.Drawing.Point(70, 140);
            this.comChuchaiUnit.Name = "comChuchaiUnit";
            this.comChuchaiUnit.Size = new System.Drawing.Size(100, 20);
            this.comChuchaiUnit.TabIndex = 53;
            // 
            // comLateLeaveEarlyUnit
            // 
            this.comLateLeaveEarlyUnit.FormattingEnabled = true;
            this.comLateLeaveEarlyUnit.Location = new System.Drawing.Point(70, 174);
            this.comLateLeaveEarlyUnit.Name = "comLateLeaveEarlyUnit";
            this.comLateLeaveEarlyUnit.Size = new System.Drawing.Size(100, 20);
            this.comLateLeaveEarlyUnit.TabIndex = 52;
            // 
            // comShiftUnit
            // 
            this.comShiftUnit.FormattingEnabled = true;
            this.comShiftUnit.Location = new System.Drawing.Point(70, 17);
            this.comShiftUnit.Name = "comShiftUnit";
            this.comShiftUnit.Size = new System.Drawing.Size(100, 20);
            this.comShiftUnit.TabIndex = 51;
            // 
            // txtAllowLate
            // 
            this.txtAllowLate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAllowLate.Location = new System.Drawing.Point(162, 38);
            this.txtAllowLate.MaxValue = 10000;
            this.txtAllowLate.MinValue = 0;
            this.txtAllowLate.Name = "txtAllowLate";
            this.txtAllowLate.Size = new System.Drawing.Size(54, 21);
            this.txtAllowLate.TabIndex = 46;
            this.txtAllowLate.Text = "0";
            // 
            // txtAllowEarly
            // 
            this.txtAllowEarly.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAllowEarly.Location = new System.Drawing.Point(162, 10);
            this.txtAllowEarly.MaxValue = 10000;
            this.txtAllowEarly.MinValue = 0;
            this.txtAllowEarly.Name = "txtAllowEarly";
            this.txtAllowEarly.Size = new System.Drawing.Size(54, 21);
            this.txtAllowEarly.TabIndex = 45;
            this.txtAllowEarly.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(223, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 44;
            this.label21.Text = "分钟";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(143, 12);
            this.label22.TabIndex = 43;
            this.label22.Text = "允许早退（不记录为早退)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(223, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 42;
            this.label19.Text = "分钟";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 12);
            this.label20.TabIndex = 41;
            this.label20.Text = "允许迟到（不记录为迟到)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(184, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 12);
            this.label23.TabIndex = 49;
            this.label23.Text = "分钟内 计为缺勤";
            // 
            // intergerTextBox1
            // 
            this.intergerTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.intergerTextBox1.Location = new System.Drawing.Point(125, 65);
            this.intergerTextBox1.MaxValue = 10000;
            this.intergerTextBox1.MinValue = 1;
            this.intergerTextBox1.Name = "intergerTextBox1";
            this.intergerTextBox1.Size = new System.Drawing.Size(54, 21);
            this.intergerTextBox1.TabIndex = 48;
            this.intergerTextBox1.Text = "30";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "迟到时间位于";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(184, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 12);
            this.label24.TabIndex = 52;
            this.label24.Text = "分钟内 计为缺勤";
            // 
            // intergerTextBox2
            // 
            this.intergerTextBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.intergerTextBox2.Location = new System.Drawing.Point(125, 85);
            this.intergerTextBox2.MaxValue = 10000;
            this.intergerTextBox2.MinValue = 1;
            this.intergerTextBox2.Name = "intergerTextBox2";
            this.intergerTextBox2.Size = new System.Drawing.Size(54, 21);
            this.intergerTextBox2.TabIndex = 51;
            this.intergerTextBox2.Text = "30";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 50;
            this.checkBox2.Text = "早退时间位于";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(338, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 56;
            this.label25.Text = "分钟";
            // 
            // intergerTextBox3
            // 
            this.intergerTextBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.intergerTextBox3.Location = new System.Drawing.Point(279, 85);
            this.intergerTextBox3.MaxValue = 10000;
            this.intergerTextBox3.MinValue = 1;
            this.intergerTextBox3.Name = "intergerTextBox3";
            this.intergerTextBox3.Size = new System.Drawing.Size(54, 21);
            this.intergerTextBox3.TabIndex = 55;
            this.intergerTextBox3.Text = "30";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(338, 69);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 54;
            this.label26.Text = "分钟";
            // 
            // intergerTextBox4
            // 
            this.intergerTextBox4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.intergerTextBox4.Location = new System.Drawing.Point(279, 65);
            this.intergerTextBox4.MaxValue = 10000;
            this.intergerTextBox4.MinValue = 1;
            this.intergerTextBox4.Name = "intergerTextBox4";
            this.intergerTextBox4.Size = new System.Drawing.Size(54, 21);
            this.intergerTextBox4.TabIndex = 53;
            this.intergerTextBox4.Text = "30";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(109, 163);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 12);
            this.label27.TabIndex = 59;
            this.label27.Text = "分钟后签退才有效";
            // 
            // intergerTextBox5
            // 
            this.intergerTextBox5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.intergerTextBox5.Location = new System.Drawing.Point(49, 160);
            this.intergerTextBox5.MaxValue = 10000;
            this.intergerTextBox5.MinValue = 1;
            this.intergerTextBox5.Name = "intergerTextBox5";
            this.intergerTextBox5.Size = new System.Drawing.Size(54, 21);
            this.intergerTextBox5.TabIndex = 58;
            this.intergerTextBox5.Text = "30";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 165);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 57;
            this.label28.Text = "上班";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(179, 225);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 62;
            this.label29.Text = "分钟";
            // 
            // txtBeforeStartTime
            // 
            this.txtBeforeStartTime.Location = new System.Drawing.Point(96, 221);
            this.txtBeforeStartTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtBeforeStartTime.Name = "txtBeforeStartTime";
            this.txtBeforeStartTime.Size = new System.Drawing.Size(77, 21);
            this.txtBeforeStartTime.TabIndex = 61;
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
            this.label30.Location = new System.Drawing.Point(13, 223);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 12);
            this.label30.TabIndex = 60;
            this.label30.Text = "提前刷卡时间";
            // 
            // txtAfterEndTime
            // 
            this.txtAfterEndTime.Location = new System.Drawing.Point(325, 223);
            this.txtAfterEndTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAfterEndTime.Name = "txtAfterEndTime";
            this.txtAfterEndTime.Size = new System.Drawing.Size(77, 21);
            this.txtAfterEndTime.TabIndex = 64;
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
            this.label31.Location = new System.Drawing.Point(242, 225);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 12);
            this.label31.TabIndex = 63;
            this.label31.Text = "延长刷卡时间";
            // 
            // FrmAttendanceRules
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(525, 421);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAttendanceRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "考勤规则";
            this.Load += new System.EventHandler(this.FrmAttendanceRules_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab基本.ResumeLayout(false);
            this.tab基本.PerformLayout();
            this.tab考勤单位.ResumeLayout(false);
            this.tab考勤单位.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterEndTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab基本;
        private System.Windows.Forms.TabPage tab考勤单位;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkLeaveEarlyAsAbsent;
        private System.Windows.Forms.CheckBox chkLateAsAbsent;
        private System.Windows.Forms.Label label3;
        private GeneralLibrary.WinformControl.IntergerTextBox txtLeaveEarlyAsAbsent;
        private System.Windows.Forms.Label label2;
        private GeneralLibrary.WinformControl.IntergerTextBox txtLateAsAbsent;
        private System.Windows.Forms.CheckBox chkShiftTimeContainChuChai;
        private System.Windows.Forms.CheckBox chkShiftTimeContainWaiChu;
        private System.Windows.Forms.Label label4;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinOTMinute;
        private System.Windows.Forms.Label label1;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinShiftTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinLateLeaveEarlyTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinChuChaiTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinWaichuTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinOTTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinVacationTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Controls.AttendanceUnitComboBox comVacationUnit;
        private Controls.AttendanceUnitComboBox comOTUnit;
        private Controls.AttendanceUnitComboBox comWaichuUnit;
        private Controls.AttendanceUnitComboBox comChuchaiUnit;
        private Controls.AttendanceUnitComboBox comLateLeaveEarlyUnit;
        private Controls.AttendanceUnitComboBox comShiftUnit;
        private System.Windows.Forms.Label label5;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinutesOfWorkDay;
        private System.Windows.Forms.Label label6;
        private GeneralLibrary.WinformControl.IntergerTextBox txtAllowLate;
        private GeneralLibrary.WinformControl.IntergerTextBox txtAllowEarly;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private GeneralLibrary.WinformControl.IntergerTextBox intergerTextBox3;
        private System.Windows.Forms.Label label26;
        private GeneralLibrary.WinformControl.IntergerTextBox intergerTextBox4;
        private System.Windows.Forms.Label label24;
        private GeneralLibrary.WinformControl.IntergerTextBox intergerTextBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label23;
        private GeneralLibrary.WinformControl.IntergerTextBox intergerTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label27;
        private GeneralLibrary.WinformControl.IntergerTextBox intergerTextBox5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown txtBeforeStartTime;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown txtAfterEndTime;
        private System.Windows.Forms.Label label31;
    }
}