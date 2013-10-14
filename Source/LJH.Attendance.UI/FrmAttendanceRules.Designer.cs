namespace LJH.Attendance.UI
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
            this.comAttendanceUnit = new LJH.Attendance.UI.Controls.AttendanceUnitComboBox(this.components);
            this.txtMinAttendanceTime = new LJH.GeneralLibrary.WinformControl.DecimalTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMinutesOfWorkDay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtOTAfterEndTime = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtOTBeforeStartTime = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMinShiftMinute = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMinLeaveEarlyAsAbsentMinute = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.txtMinLateAsAbsentMinute = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.txtMinLeaveEarly = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.chkMinLeaveEarly = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMinLate = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.chkMinLate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinOTMinute = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chkShiftTimeIncludeWaiChu = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeaveEarlyAsAbsent = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtLateAsAbsent = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.chkLeaveEarlyAsAbsent = new System.Windows.Forms.CheckBox();
            this.chkLateAsAbsent = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab基本.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutesOfWorkDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTAfterEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTBeforeStartTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab基本);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tab基本
            // 
            this.tab基本.Controls.Add(this.comAttendanceUnit);
            this.tab基本.Controls.Add(this.txtMinAttendanceTime);
            this.tab基本.Controls.Add(this.label15);
            this.tab基本.Controls.Add(this.label16);
            this.tab基本.Controls.Add(this.txtMinutesOfWorkDay);
            this.tab基本.Controls.Add(this.label5);
            this.tab基本.Controls.Add(this.label6);
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
            // comAttendanceUnit
            // 
            this.comAttendanceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comAttendanceUnit.FormattingEnabled = true;
            this.comAttendanceUnit.Location = new System.Drawing.Point(119, 265);
            this.comAttendanceUnit.Name = "comAttendanceUnit";
            this.comAttendanceUnit.Size = new System.Drawing.Size(100, 20);
            this.comAttendanceUnit.TabIndex = 74;
            // 
            // txtMinAttendanceTime
            // 
            this.txtMinAttendanceTime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinAttendanceTime.Location = new System.Drawing.Point(272, 265);
            this.txtMinAttendanceTime.MaxValue = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMinAttendanceTime.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMinAttendanceTime.Name = "txtMinAttendanceTime";
            this.txtMinAttendanceTime.PointCount = 2;
            this.txtMinAttendanceTime.Size = new System.Drawing.Size(49, 21);
            this.txtMinAttendanceTime.TabIndex = 73;
            this.txtMinAttendanceTime.Text = "0.1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 72;
            this.label15.Text = "最小值";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 12);
            this.label16.TabIndex = 71;
            this.label16.Text = "考勤结果时间单位";
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
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(364, 207);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 12);
            this.label32.TabIndex = 65;
            this.label32.Text = "分钟";
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
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(209, 207);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 12);
            this.label31.TabIndex = 63;
            this.label31.Text = "加班可延后刷卡";
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
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 207);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(89, 12);
            this.label30.TabIndex = 60;
            this.label30.Text = "加班可提前刷卡";
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
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 148);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 57;
            this.label28.Text = "上班";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(347, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 56;
            this.label25.Text = "分钟";
            // 
            // txtMinLeaveEarlyAsAbsentMinute
            // 
            this.txtMinLeaveEarlyAsAbsentMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLeaveEarlyAsAbsentMinute.Location = new System.Drawing.Point(288, 37);
            this.txtMinLeaveEarlyAsAbsentMinute.MaxValue = 10000;
            this.txtMinLeaveEarlyAsAbsentMinute.MinValue = 1;
            this.txtMinLeaveEarlyAsAbsentMinute.Name = "txtMinLeaveEarlyAsAbsentMinute";
            this.txtMinLeaveEarlyAsAbsentMinute.Size = new System.Drawing.Size(54, 21);
            this.txtMinLeaveEarlyAsAbsentMinute.TabIndex = 55;
            this.txtMinLeaveEarlyAsAbsentMinute.Text = "30";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(347, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 54;
            this.label26.Text = "分钟";
            // 
            // txtMinLateAsAbsentMinute
            // 
            this.txtMinLateAsAbsentMinute.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLateAsAbsentMinute.Location = new System.Drawing.Point(288, 13);
            this.txtMinLateAsAbsentMinute.MaxValue = 10000;
            this.txtMinLateAsAbsentMinute.MinValue = 1;
            this.txtMinLateAsAbsentMinute.Name = "txtMinLateAsAbsentMinute";
            this.txtMinLateAsAbsentMinute.Size = new System.Drawing.Size(54, 21);
            this.txtMinLateAsAbsentMinute.TabIndex = 53;
            this.txtMinLateAsAbsentMinute.Text = "30";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(193, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 12);
            this.label24.TabIndex = 52;
            this.label24.Text = "分钟内 计为缺勤";
            // 
            // txtMinLeaveEarly
            // 
            this.txtMinLeaveEarly.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLeaveEarly.Location = new System.Drawing.Point(134, 37);
            this.txtMinLeaveEarly.MaxValue = 10000;
            this.txtMinLeaveEarly.MinValue = 1;
            this.txtMinLeaveEarly.Name = "txtMinLeaveEarly";
            this.txtMinLeaveEarly.Size = new System.Drawing.Size(54, 21);
            this.txtMinLeaveEarly.TabIndex = 51;
            this.txtMinLeaveEarly.Text = "30";
            // 
            // chkMinLeaveEarly
            // 
            this.chkMinLeaveEarly.AutoSize = true;
            this.chkMinLeaveEarly.Location = new System.Drawing.Point(13, 39);
            this.chkMinLeaveEarly.Name = "chkMinLeaveEarly";
            this.chkMinLeaveEarly.Size = new System.Drawing.Size(120, 16);
            this.chkMinLeaveEarly.TabIndex = 50;
            this.chkMinLeaveEarly.Text = "一次早退时间位于";
            this.chkMinLeaveEarly.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(193, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 12);
            this.label23.TabIndex = 49;
            this.label23.Text = "分钟内 计为缺勤";
            // 
            // txtMinLate
            // 
            this.txtMinLate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMinLate.Location = new System.Drawing.Point(134, 13);
            this.txtMinLate.MaxValue = 10000;
            this.txtMinLate.MinValue = 1;
            this.txtMinLate.Name = "txtMinLate";
            this.txtMinLate.Size = new System.Drawing.Size(54, 21);
            this.txtMinLate.TabIndex = 48;
            this.txtMinLate.Text = "30";
            // 
            // chkMinLate
            // 
            this.chkMinLate.AutoSize = true;
            this.chkMinLate.Location = new System.Drawing.Point(13, 15);
            this.chkMinLate.Name = "chkMinLate";
            this.chkMinLate.Size = new System.Drawing.Size(120, 16);
            this.chkMinLate.TabIndex = 47;
            this.chkMinLate.Text = "一次迟到时间位于";
            this.chkMinLate.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "加班";
            // 
            // chkShiftTimeIncludeWaiChu
            // 
            this.chkShiftTimeIncludeWaiChu.AutoSize = true;
            this.chkShiftTimeIncludeWaiChu.Checked = true;
            this.chkShiftTimeIncludeWaiChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShiftTimeIncludeWaiChu.Location = new System.Drawing.Point(13, 116);
            this.chkShiftTimeIncludeWaiChu.Name = "chkShiftTimeIncludeWaiChu";
            this.chkShiftTimeIncludeWaiChu.Size = new System.Drawing.Size(150, 16);
            this.chkShiftTimeIncludeWaiChu.TabIndex = 25;
            this.chkShiftTimeIncludeWaiChu.Text = "外出/出差同时计为出勤";
            this.chkShiftTimeIncludeWaiChu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "分钟 计为缺勤";
            // 
            // txtLeaveEarlyAsAbsent
            // 
            this.txtLeaveEarlyAsAbsent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLeaveEarlyAsAbsent.Location = new System.Drawing.Point(132, 86);
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
            this.label2.Location = new System.Drawing.Point(191, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "分钟 计为缺勤";
            // 
            // txtLateAsAbsent
            // 
            this.txtLateAsAbsent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLateAsAbsent.Location = new System.Drawing.Point(132, 62);
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
            this.chkLeaveEarlyAsAbsent.Location = new System.Drawing.Point(13, 88);
            this.chkLeaveEarlyAsAbsent.Name = "chkLeaveEarlyAsAbsent";
            this.chkLeaveEarlyAsAbsent.Size = new System.Drawing.Size(120, 16);
            this.chkLeaveEarlyAsAbsent.TabIndex = 17;
            this.chkLeaveEarlyAsAbsent.Text = "一次早退时间大于";
            this.chkLeaveEarlyAsAbsent.UseVisualStyleBackColor = true;
            // 
            // chkLateAsAbsent
            // 
            this.chkLateAsAbsent.AutoSize = true;
            this.chkLateAsAbsent.Location = new System.Drawing.Point(13, 64);
            this.chkLateAsAbsent.Name = "chkLateAsAbsent";
            this.chkLateAsAbsent.Size = new System.Drawing.Size(120, 16);
            this.chkLateAsAbsent.TabIndex = 16;
            this.chkLateAsAbsent.Text = "一次迟到时间大于";
            this.chkLateAsAbsent.UseVisualStyleBackColor = true;
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
            this.tab基本.ResumeLayout(false);
            this.tab基本.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutesOfWorkDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTAfterEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTBeforeStartTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TabPage tab基本;
        private System.Windows.Forms.NumericUpDown txtMinutesOfWorkDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private Controls.AttendanceUnitComboBox comAttendanceUnit;
        private GeneralLibrary.WinformControl.DecimalTextBox txtMinAttendanceTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}