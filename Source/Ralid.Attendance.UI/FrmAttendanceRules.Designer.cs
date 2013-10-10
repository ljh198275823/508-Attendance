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
            this.tab考勤单位 = new System.Windows.Forms.TabPage();
            this.txtMinLateLeaveEarlyTime = new Ralid.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.chkLateAsAbsent = new System.Windows.Forms.CheckBox();
            this.chkLeaveEarlyAsAbsent = new System.Windows.Forms.CheckBox();
            this.txtLateAsAbsent = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeaveEarlyAsAbsent = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chkShiftTimeIncludeWaiChu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinOTMinute = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.chkMinLate = new System.Windows.Forms.CheckBox();
            this.txtMinLate = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.chkMinLeaveEarly = new System.Windows.Forms.CheckBox();
            this.txtMinLeaveEarly = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.txtMinLateAsAbsentMinute = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.txtMinLeaveEarlyAsAbsentMinute = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMinShiftMinute = new Ralid.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtOTBeforeStartTime = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtOTAfterEndTime = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.chkShiftTimeIncludeLateOrLeaveEarly = new System.Windows.Forms.CheckBox();
            this.tab基本 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinutesOfWorkDay = new System.Windows.Forms.NumericUpDown();
            this.comVacationUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comOTUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comWaichuUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comLateLeaveEarlyUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.comShiftUnit = new Ralid.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.tabControl1.SuspendLayout();
            this.tab考勤单位.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTBeforeStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTAfterEndTime)).BeginInit();
            this.tab基本.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutesOfWorkDay)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(563, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tab考勤单位
            // 
            this.tab考勤单位.Controls.Add(this.comVacationUnit);
            this.tab考勤单位.Controls.Add(this.comOTUnit);
            this.tab考勤单位.Controls.Add(this.comWaichuUnit);
            this.tab考勤单位.Controls.Add(this.comLateLeaveEarlyUnit);
            this.tab考勤单位.Controls.Add(this.comShiftUnit);
            this.tab考勤单位.Controls.Add(this.txtMinLateLeaveEarlyTime);
            this.tab考勤单位.Controls.Add(this.label17);
            this.tab考勤单位.Controls.Add(this.label18);
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
            this.tab考勤单位.Size = new System.Drawing.Size(555, 342);
            this.tab考勤单位.TabIndex = 4;
            this.tab考勤单位.Text = "考勤单位";
            this.tab考勤单位.UseVisualStyleBackColor = true;
            // 
            // txtMinLateLeaveEarlyTime
            // 
            this.txtMinLateLeaveEarlyTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLateLeaveEarlyTime.Location = new System.Drawing.Point(223, 142);
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
            this.label17.Location = new System.Drawing.Point(176, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 49;
            this.label17.Text = "最小值";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 48;
            this.label18.Text = "迟到早退";
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
            this.label14.Location = new System.Drawing.Point(6, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 42;
            this.label14.Text = "外出/出差";
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
            this.btnClose.Location = new System.Drawing.Point(478, 386);
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
            this.btnOk.Location = new System.Drawing.Point(384, 386);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkLateAsAbsent
            // 
            this.chkLateAsAbsent.AutoSize = true;
            this.chkLateAsAbsent.Location = new System.Drawing.Point(13, 64);
            this.chkLateAsAbsent.Name = "chkLateAsAbsent";
            this.chkLateAsAbsent.Size = new System.Drawing.Size(96, 16);
            this.chkLateAsAbsent.TabIndex = 16;
            this.chkLateAsAbsent.Text = "迟到时间大于";
            this.chkLateAsAbsent.UseVisualStyleBackColor = true;
            // 
            // chkLeaveEarlyAsAbsent
            // 
            this.chkLeaveEarlyAsAbsent.AutoSize = true;
            this.chkLeaveEarlyAsAbsent.Location = new System.Drawing.Point(13, 88);
            this.chkLeaveEarlyAsAbsent.Name = "chkLeaveEarlyAsAbsent";
            this.chkLeaveEarlyAsAbsent.Size = new System.Drawing.Size(96, 16);
            this.chkLeaveEarlyAsAbsent.TabIndex = 17;
            this.chkLeaveEarlyAsAbsent.Text = "早退时间大于";
            this.chkLeaveEarlyAsAbsent.UseVisualStyleBackColor = true;
            // 
            // txtLateAsAbsent
            // 
            this.txtLateAsAbsent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLateAsAbsent.Location = new System.Drawing.Point(109, 62);
            this.txtLateAsAbsent.MaxValue = 10000;
            this.txtLateAsAbsent.MinValue = 1;
            this.txtLateAsAbsent.Name = "txtLateAsAbsent";
            this.txtLateAsAbsent.Size = new System.Drawing.Size(54, 21);
            this.txtLateAsAbsent.TabIndex = 21;
            this.txtLateAsAbsent.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "分钟 计为缺勤";
            // 
            // txtLeaveEarlyAsAbsent
            // 
            this.txtLeaveEarlyAsAbsent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLeaveEarlyAsAbsent.Location = new System.Drawing.Point(109, 86);
            this.txtLeaveEarlyAsAbsent.MaxValue = 10000;
            this.txtLeaveEarlyAsAbsent.MinValue = 1;
            this.txtLeaveEarlyAsAbsent.Name = "txtLeaveEarlyAsAbsent";
            this.txtLeaveEarlyAsAbsent.Size = new System.Drawing.Size(54, 21);
            this.txtLeaveEarlyAsAbsent.TabIndex = 23;
            this.txtLeaveEarlyAsAbsent.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "分钟 计为缺勤";
            // 
            // chkShiftTimeIncludeWaiChu
            // 
            this.chkShiftTimeIncludeWaiChu.AutoSize = true;
            this.chkShiftTimeIncludeWaiChu.Checked = true;
            this.chkShiftTimeIncludeWaiChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShiftTimeIncludeWaiChu.Location = new System.Drawing.Point(225, 116);
            this.chkShiftTimeIncludeWaiChu.Name = "chkShiftTimeIncludeWaiChu";
            this.chkShiftTimeIncludeWaiChu.Size = new System.Drawing.Size(150, 16);
            this.chkShiftTimeIncludeWaiChu.TabIndex = 25;
            this.chkShiftTimeIncludeWaiChu.Text = "外出/出差同时计为出勤";
            this.chkShiftTimeIncludeWaiChu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "加班";
            // 
            // txtMinOTMinute
            // 
            this.txtMinOTMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinOTMinute.Location = new System.Drawing.Point(49, 172);
            this.txtMinOTMinute.MaxValue = 10000;
            this.txtMinOTMinute.MinValue = 1;
            this.txtMinOTMinute.Name = "txtMinOTMinute";
            this.txtMinOTMinute.Size = new System.Drawing.Size(54, 21);
            this.txtMinOTMinute.TabIndex = 28;
            this.txtMinOTMinute.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "分钟后签退才有效";
            // 
            // chkMinLate
            // 
            this.chkMinLate.AutoSize = true;
            this.chkMinLate.Location = new System.Drawing.Point(13, 15);
            this.chkMinLate.Name = "chkMinLate";
            this.chkMinLate.Size = new System.Drawing.Size(96, 16);
            this.chkMinLate.TabIndex = 47;
            this.chkMinLate.Text = "迟到时间位于";
            this.chkMinLate.UseVisualStyleBackColor = true;
            // 
            // txtMinLate
            // 
            this.txtMinLate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLate.Location = new System.Drawing.Point(111, 13);
            this.txtMinLate.MaxValue = 10000;
            this.txtMinLate.MinValue = 1;
            this.txtMinLate.Name = "txtMinLate";
            this.txtMinLate.Size = new System.Drawing.Size(54, 21);
            this.txtMinLate.TabIndex = 48;
            this.txtMinLate.Text = "30";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(170, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 12);
            this.label23.TabIndex = 49;
            this.label23.Text = "分钟内 计为缺勤";
            // 
            // chkMinLeaveEarly
            // 
            this.chkMinLeaveEarly.AutoSize = true;
            this.chkMinLeaveEarly.Location = new System.Drawing.Point(13, 39);
            this.chkMinLeaveEarly.Name = "chkMinLeaveEarly";
            this.chkMinLeaveEarly.Size = new System.Drawing.Size(96, 16);
            this.chkMinLeaveEarly.TabIndex = 50;
            this.chkMinLeaveEarly.Text = "早退时间位于";
            this.chkMinLeaveEarly.UseVisualStyleBackColor = true;
            // 
            // txtMinLeaveEarly
            // 
            this.txtMinLeaveEarly.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLeaveEarly.Location = new System.Drawing.Point(111, 37);
            this.txtMinLeaveEarly.MaxValue = 10000;
            this.txtMinLeaveEarly.MinValue = 1;
            this.txtMinLeaveEarly.Name = "txtMinLeaveEarly";
            this.txtMinLeaveEarly.Size = new System.Drawing.Size(54, 21);
            this.txtMinLeaveEarly.TabIndex = 51;
            this.txtMinLeaveEarly.Text = "30";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(170, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 12);
            this.label24.TabIndex = 52;
            this.label24.Text = "分钟内 计为缺勤";
            // 
            // txtMinLateAsAbsentMinute
            // 
            this.txtMinLateAsAbsentMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLateAsAbsentMinute.Location = new System.Drawing.Point(265, 13);
            this.txtMinLateAsAbsentMinute.MaxValue = 10000;
            this.txtMinLateAsAbsentMinute.MinValue = 1;
            this.txtMinLateAsAbsentMinute.Name = "txtMinLateAsAbsentMinute";
            this.txtMinLateAsAbsentMinute.Size = new System.Drawing.Size(54, 21);
            this.txtMinLateAsAbsentMinute.TabIndex = 53;
            this.txtMinLateAsAbsentMinute.Text = "30";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(324, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 54;
            this.label26.Text = "分钟";
            // 
            // txtMinLeaveEarlyAsAbsentMinute
            // 
            this.txtMinLeaveEarlyAsAbsentMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLeaveEarlyAsAbsentMinute.Location = new System.Drawing.Point(265, 37);
            this.txtMinLeaveEarlyAsAbsentMinute.MaxValue = 10000;
            this.txtMinLeaveEarlyAsAbsentMinute.MinValue = 1;
            this.txtMinLeaveEarlyAsAbsentMinute.Name = "txtMinLeaveEarlyAsAbsentMinute";
            this.txtMinLeaveEarlyAsAbsentMinute.Size = new System.Drawing.Size(54, 21);
            this.txtMinLeaveEarlyAsAbsentMinute.TabIndex = 55;
            this.txtMinLeaveEarlyAsAbsentMinute.Text = "30";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(324, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 56;
            this.label25.Text = "分钟";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 148);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 57;
            this.label28.Text = "上班";
            // 
            // txtMinShiftMinute
            // 
            this.txtMinShiftMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinShiftMinute.Location = new System.Drawing.Point(49, 143);
            this.txtMinShiftMinute.MaxValue = 10000;
            this.txtMinShiftMinute.MinValue = 1;
            this.txtMinShiftMinute.Name = "txtMinShiftMinute";
            this.txtMinShiftMinute.Size = new System.Drawing.Size(54, 21);
            this.txtMinShiftMinute.TabIndex = 58;
            this.txtMinShiftMinute.Text = "30";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(109, 146);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 12);
            this.label27.TabIndex = 59;
            this.label27.Text = "分钟后签退才有效";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 207);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(89, 12);
            this.label30.TabIndex = 60;
            this.label30.Text = "加班可提前刷卡";
            // 
            // txtOTBeforeStartTime
            // 
            this.txtOTBeforeStartTime.Location = new System.Drawing.Point(107, 203);
            this.txtOTBeforeStartTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtOTBeforeStartTime.Name = "txtOTBeforeStartTime";
            this.txtOTBeforeStartTime.Size = new System.Drawing.Size(56, 21);
            this.txtOTBeforeStartTime.TabIndex = 61;
            this.txtOTBeforeStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTBeforeStartTime.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(166, 207);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 62;
            this.label29.Text = "分钟";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(209, 207);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 12);
            this.label31.TabIndex = 63;
            this.label31.Text = "加班可延后刷卡";
            // 
            // txtOTAfterEndTime
            // 
            this.txtOTAfterEndTime.Location = new System.Drawing.Point(304, 203);
            this.txtOTAfterEndTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtOTAfterEndTime.Name = "txtOTAfterEndTime";
            this.txtOTAfterEndTime.Size = new System.Drawing.Size(56, 21);
            this.txtOTAfterEndTime.TabIndex = 64;
            this.txtOTAfterEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTAfterEndTime.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(364, 207);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 12);
            this.label32.TabIndex = 65;
            this.label32.Text = "分钟";
            // 
            // chkShiftTimeIncludeLateOrLeaveEarly
            // 
            this.chkShiftTimeIncludeLateOrLeaveEarly.AutoSize = true;
            this.chkShiftTimeIncludeLateOrLeaveEarly.Checked = true;
            this.chkShiftTimeIncludeLateOrLeaveEarly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShiftTimeIncludeLateOrLeaveEarly.Location = new System.Drawing.Point(13, 116);
            this.chkShiftTimeIncludeLateOrLeaveEarly.Name = "chkShiftTimeIncludeLateOrLeaveEarly";
            this.chkShiftTimeIncludeLateOrLeaveEarly.Size = new System.Drawing.Size(180, 16);
            this.chkShiftTimeIncludeLateOrLeaveEarly.TabIndex = 66;
            this.chkShiftTimeIncludeLateOrLeaveEarly.Text = "迟到早退时间不计为缺勤时间";
            this.chkShiftTimeIncludeLateOrLeaveEarly.UseVisualStyleBackColor = true;
            // 
            // tab基本
            // 
            this.tab基本.Controls.Add(this.txtMinutesOfWorkDay);
            this.tab基本.Controls.Add(this.label5);
            this.tab基本.Controls.Add(this.label6);
            this.tab基本.Controls.Add(this.chkShiftTimeIncludeLateOrLeaveEarly);
            this.tab基本.Controls.Add(this.label32);
            this.tab基本.Controls.Add(this.txtOTAfterEndTime);
            this.tab基本.Controls.Add(this.label31);
            this.tab基本.Controls.Add(this.label29);
            this.tab基本.Controls.Add(this.txtOTBeforeStartTime);
            this.tab基本.Controls.Add(this.label30);
            this.tab基本.Controls.Add(this.label27);
            this.tab基本.Controls.Add(this.txtMinShiftMinute);
            this.tab基本.Controls.Add(this.label28);
            this.tab基本.Controls.Add(this.label25);
            this.tab基本.Controls.Add(this.txtMinLeaveEarlyAsAbsentMinute);
            this.tab基本.Controls.Add(this.label26);
            this.tab基本.Controls.Add(this.txtMinLateAsAbsentMinute);
            this.tab基本.Controls.Add(this.label24);
            this.tab基本.Controls.Add(this.txtMinLeaveEarly);
            this.tab基本.Controls.Add(this.chkMinLeaveEarly);
            this.tab基本.Controls.Add(this.label23);
            this.tab基本.Controls.Add(this.txtMinLate);
            this.tab基本.Controls.Add(this.chkMinLate);
            this.tab基本.Controls.Add(this.label4);
            this.tab基本.Controls.Add(this.txtMinOTMinute);
            this.tab基本.Controls.Add(this.label1);
            this.tab基本.Controls.Add(this.chkShiftTimeIncludeWaiChu);
            this.tab基本.Controls.Add(this.label3);
            this.tab基本.Controls.Add(this.txtLeaveEarlyAsAbsent);
            this.tab基本.Controls.Add(this.label2);
            this.tab基本.Controls.Add(this.txtLateAsAbsent);
            this.tab基本.Controls.Add(this.chkLeaveEarlyAsAbsent);
            this.tab基本.Controls.Add(this.chkLateAsAbsent);
            this.tab基本.Location = new System.Drawing.Point(4, 22);
            this.tab基本.Name = "tab基本";
            this.tab基本.Padding = new System.Windows.Forms.Padding(3);
            this.tab基本.Size = new System.Drawing.Size(555, 342);
            this.tab基本.TabIndex = 0;
            this.tab基本.Text = "基本";
            this.tab基本.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 69;
            this.label5.Text = "分钟";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "一个工作日等于";
            // 
            // txtMinutesOfWorkDay
            // 
            this.txtMinutesOfWorkDay.Location = new System.Drawing.Point(107, 238);
            this.txtMinutesOfWorkDay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtMinutesOfWorkDay.Name = "txtMinutesOfWorkDay";
            this.txtMinutesOfWorkDay.Size = new System.Drawing.Size(56, 21);
            this.txtMinutesOfWorkDay.TabIndex = 70;
            this.txtMinutesOfWorkDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinutesOfWorkDay.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
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
            // comLateLeaveEarlyUnit
            // 
            this.comLateLeaveEarlyUnit.FormattingEnabled = true;
            this.comLateLeaveEarlyUnit.Location = new System.Drawing.Point(70, 142);
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
            // FrmAttendanceRules
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(573, 421);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAttendanceRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "考勤规则";
            this.Load += new System.EventHandler(this.FrmAttendanceRules_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab考勤单位.ResumeLayout(false);
            this.tab考勤单位.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTBeforeStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTAfterEndTime)).EndInit();
            this.tab基本.ResumeLayout(false);
            this.tab基本.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutesOfWorkDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab考勤单位;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinShiftTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinLateLeaveEarlyTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
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
        private Controls.AttendanceUnitComboBox comLateLeaveEarlyUnit;
        private Controls.AttendanceUnitComboBox comShiftUnit;
        private System.Windows.Forms.TabPage tab基本;
        private System.Windows.Forms.NumericUpDown txtMinutesOfWorkDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkShiftTimeIncludeLateOrLeaveEarly;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown txtOTAfterEndTime;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown txtOTBeforeStartTime;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label27;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinShiftMinute;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinLeaveEarlyAsAbsentMinute;
        private System.Windows.Forms.Label label26;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinLateAsAbsentMinute;
        private System.Windows.Forms.Label label24;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinLeaveEarly;
        private System.Windows.Forms.CheckBox chkMinLeaveEarly;
        private System.Windows.Forms.Label label23;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinLate;
        private System.Windows.Forms.CheckBox chkMinLate;
        private System.Windows.Forms.Label label4;
        private GeneralLibrary.WinformControl.IntergerTextBox txtMinOTMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkShiftTimeIncludeWaiChu;
        private System.Windows.Forms.Label label3;
        private GeneralLibrary.WinformControl.IntergerTextBox txtLeaveEarlyAsAbsent;
        private System.Windows.Forms.Label label2;
        private GeneralLibrary.WinformControl.IntergerTextBox txtLateAsAbsent;
        private System.Windows.Forms.CheckBox chkLeaveEarlyAsAbsent;
        private System.Windows.Forms.CheckBox chkLateAsAbsent;
    }
}