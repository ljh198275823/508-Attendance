namespace Ralid.Attendance.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_基本资料 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Departments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_OTType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_VacationType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TripType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TASheet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Holiday = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AttendanceDoorSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AttendanceRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Shifts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ShiftTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ShiftArrange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_ManualLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AttendanceAnalyst = new System.Windows.Forms.ToolStripMenuItem();
            this.安全管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Operator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Role = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_ChangePWD = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ShiftResultStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ShiftResultStatistics2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ResultDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_AttendanceLogReport = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户手册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Aboat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new Ralid.GeneralLibrary.WinformControl.MyToolStrip(this.components);
            this.btnDepartment = new System.Windows.Forms.ToolStripButton();
            this.btnStaff = new System.Windows.Forms.ToolStripButton();
            this.btnAttendanceReader = new System.Windows.Forms.ToolStripButton();
            this.btnTASheet = new System.Windows.Forms.ToolStripButton();
            this.btnHoliday = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShift = new System.Windows.Forms.ToolStripButton();
            this.btnShiftArrange = new System.Windows.Forms.ToolStripButton();
            this.btnManualLog = new System.Windows.Forms.ToolStripButton();
            this.btnAttendanceAnalyst = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShiftResultStatistics = new System.Windows.Forms.ToolStripButton();
            this.btnShiftResultStatistics2 = new System.Windows.Forms.ToolStripButton();
            this.btnResultDetail = new System.Windows.Forms.ToolStripButton();
            this.btnAttendanceLog = new System.Windows.Forms.ToolStripButton();
            this.ucFormViewMain = new Ralid.GeneralLibrary.WinformControl.UCFormView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblOperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStation = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStartFrom = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEventServiceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCommuicationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.mnu_基本资料,
            this.考勤管理ToolStripMenuItem,
            this.安全管理ToolStripMenuItem,
            this.报表ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Logout,
            this.mnu_Exit});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            resources.ApplyResources(this.系统ToolStripMenuItem, "系统ToolStripMenuItem");
            // 
            // mnu_Logout
            // 
            this.mnu_Logout.Name = "mnu_Logout";
            resources.ApplyResources(this.mnu_Logout, "mnu_Logout");
            this.mnu_Logout.Click += new System.EventHandler(this.mnu_Logout_Click);
            // 
            // mnu_Exit
            // 
            this.mnu_Exit.Name = "mnu_Exit";
            resources.ApplyResources(this.mnu_Exit, "mnu_Exit");
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);
            // 
            // mnu_基本资料
            // 
            this.mnu_基本资料.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Departments,
            this.mnu_Staff,
            this.toolStripSeparator6,
            this.mnu_OTType,
            this.mnu_VacationType,
            this.mnu_TripType,
            this.mnu_TASheet,
            this.toolStripSeparator5,
            this.mnu_Holiday,
            this.mnu_AttendanceDoorSelection,
            this.toolStripSeparator8,
            this.mnu_Options});
            this.mnu_基本资料.Name = "mnu_基本资料";
            resources.ApplyResources(this.mnu_基本资料, "mnu_基本资料");
            // 
            // mnu_Departments
            // 
            this.mnu_Departments.Name = "mnu_Departments";
            resources.ApplyResources(this.mnu_Departments, "mnu_Departments");
            this.mnu_Departments.Click += new System.EventHandler(this.mnu_Departments_Click);
            // 
            // mnu_Staff
            // 
            this.mnu_Staff.Name = "mnu_Staff";
            resources.ApplyResources(this.mnu_Staff, "mnu_Staff");
            this.mnu_Staff.Click += new System.EventHandler(this.mnu_Staff_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // mnu_OTType
            // 
            this.mnu_OTType.Name = "mnu_OTType";
            resources.ApplyResources(this.mnu_OTType, "mnu_OTType");
            this.mnu_OTType.Click += new System.EventHandler(this.mnu_OTType_Click);
            // 
            // mnu_VacationType
            // 
            this.mnu_VacationType.Name = "mnu_VacationType";
            resources.ApplyResources(this.mnu_VacationType, "mnu_VacationType");
            this.mnu_VacationType.Click += new System.EventHandler(this.mnu_VacationType_Click);
            // 
            // mnu_TripType
            // 
            this.mnu_TripType.Name = "mnu_TripType";
            resources.ApplyResources(this.mnu_TripType, "mnu_TripType");
            this.mnu_TripType.Click += new System.EventHandler(this.mnu_TripType_Click);
            // 
            // mnu_TASheet
            // 
            this.mnu_TASheet.Name = "mnu_TASheet";
            resources.ApplyResources(this.mnu_TASheet, "mnu_TASheet");
            this.mnu_TASheet.Click += new System.EventHandler(this.mnu_TASheet_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // mnu_Holiday
            // 
            this.mnu_Holiday.Name = "mnu_Holiday";
            resources.ApplyResources(this.mnu_Holiday, "mnu_Holiday");
            this.mnu_Holiday.Click += new System.EventHandler(this.mnu_Holiday_Click);
            // 
            // mnu_AttendanceDoorSelection
            // 
            this.mnu_AttendanceDoorSelection.Name = "mnu_AttendanceDoorSelection";
            resources.ApplyResources(this.mnu_AttendanceDoorSelection, "mnu_AttendanceDoorSelection");
            this.mnu_AttendanceDoorSelection.Click += new System.EventHandler(this.mnu_AttendanceDoorSelection_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // mnu_Options
            // 
            this.mnu_Options.Name = "mnu_Options";
            resources.ApplyResources(this.mnu_Options, "mnu_Options");
            this.mnu_Options.Click += new System.EventHandler(this.mnu_Options_Click);
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_AttendanceRules,
            this.mnu_Shifts,
            this.mnu_ShiftTemplate,
            this.mnu_ShiftArrange,
            this.toolStripSeparator7,
            this.mnu_ManualLog,
            this.mnu_AttendanceAnalyst});
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            resources.ApplyResources(this.考勤管理ToolStripMenuItem, "考勤管理ToolStripMenuItem");
            // 
            // mnu_AttendanceRules
            // 
            this.mnu_AttendanceRules.Name = "mnu_AttendanceRules";
            resources.ApplyResources(this.mnu_AttendanceRules, "mnu_AttendanceRules");
            this.mnu_AttendanceRules.Click += new System.EventHandler(this.mnu_AttendanceRules_Click);
            // 
            // mnu_Shifts
            // 
            this.mnu_Shifts.Name = "mnu_Shifts";
            resources.ApplyResources(this.mnu_Shifts, "mnu_Shifts");
            this.mnu_Shifts.Click += new System.EventHandler(this.mnu_Shifts_Click);
            // 
            // mnu_ShiftTemplate
            // 
            this.mnu_ShiftTemplate.Name = "mnu_ShiftTemplate";
            resources.ApplyResources(this.mnu_ShiftTemplate, "mnu_ShiftTemplate");
            this.mnu_ShiftTemplate.Click += new System.EventHandler(this.mnu_ShiftTemplate_Click);
            // 
            // mnu_ShiftArrange
            // 
            this.mnu_ShiftArrange.Name = "mnu_ShiftArrange";
            resources.ApplyResources(this.mnu_ShiftArrange, "mnu_ShiftArrange");
            this.mnu_ShiftArrange.Click += new System.EventHandler(this.mnu_ShiftArrange_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // mnu_ManualLog
            // 
            this.mnu_ManualLog.Name = "mnu_ManualLog";
            resources.ApplyResources(this.mnu_ManualLog, "mnu_ManualLog");
            this.mnu_ManualLog.Click += new System.EventHandler(this.mnu_ManualLog_Click);
            // 
            // mnu_AttendanceAnalyst
            // 
            this.mnu_AttendanceAnalyst.Name = "mnu_AttendanceAnalyst";
            resources.ApplyResources(this.mnu_AttendanceAnalyst, "mnu_AttendanceAnalyst");
            this.mnu_AttendanceAnalyst.Click += new System.EventHandler(this.mnu_AttendanceAnalyst_Click);
            // 
            // 安全管理ToolStripMenuItem
            // 
            this.安全管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Operator,
            this.mnu_Role,
            this.toolStripSeparator2,
            this.mnu_ChangePWD});
            this.安全管理ToolStripMenuItem.Name = "安全管理ToolStripMenuItem";
            resources.ApplyResources(this.安全管理ToolStripMenuItem, "安全管理ToolStripMenuItem");
            // 
            // mnu_Operator
            // 
            this.mnu_Operator.Name = "mnu_Operator";
            resources.ApplyResources(this.mnu_Operator, "mnu_Operator");
            this.mnu_Operator.Click += new System.EventHandler(this.mnu_Operator_Click);
            // 
            // mnu_Role
            // 
            this.mnu_Role.Name = "mnu_Role";
            resources.ApplyResources(this.mnu_Role, "mnu_Role");
            this.mnu_Role.Click += new System.EventHandler(this.mnu_Role_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // mnu_ChangePWD
            // 
            this.mnu_ChangePWD.Name = "mnu_ChangePWD";
            resources.ApplyResources(this.mnu_ChangePWD, "mnu_ChangePWD");
            this.mnu_ChangePWD.Click += new System.EventHandler(this.mnu_ChangePWD_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ShiftResultStatistics,
            this.mnu_ShiftResultStatistics2,
            this.mnu_ResultDetail,
            this.toolStripSeparator3,
            this.mnu_AttendanceLogReport});
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            resources.ApplyResources(this.报表ToolStripMenuItem, "报表ToolStripMenuItem");
            // 
            // mnu_ShiftResultStatistics
            // 
            this.mnu_ShiftResultStatistics.Name = "mnu_ShiftResultStatistics";
            resources.ApplyResources(this.mnu_ShiftResultStatistics, "mnu_ShiftResultStatistics");
            this.mnu_ShiftResultStatistics.Click += new System.EventHandler(this.mnu_ShiftResultStatistics_Click);
            // 
            // mnu_ShiftResultStatistics2
            // 
            this.mnu_ShiftResultStatistics2.Name = "mnu_ShiftResultStatistics2";
            resources.ApplyResources(this.mnu_ShiftResultStatistics2, "mnu_ShiftResultStatistics2");
            this.mnu_ShiftResultStatistics2.Click += new System.EventHandler(this.mnu_ShiftResultStatistics2_Click);
            // 
            // mnu_ResultDetail
            // 
            this.mnu_ResultDetail.Name = "mnu_ResultDetail";
            resources.ApplyResources(this.mnu_ResultDetail, "mnu_ResultDetail");
            this.mnu_ResultDetail.Click += new System.EventHandler(this.mnu_ResultDetail_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // mnu_AttendanceLogReport
            // 
            this.mnu_AttendanceLogReport.Name = "mnu_AttendanceLogReport";
            resources.ApplyResources(this.mnu_AttendanceLogReport, "mnu_AttendanceLogReport");
            this.mnu_AttendanceLogReport.Click += new System.EventHandler(this.mnu_AttendanceLogReport_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户手册ToolStripMenuItem,
            this.mnu_Aboat});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            // 
            // 用户手册ToolStripMenuItem
            // 
            this.用户手册ToolStripMenuItem.Name = "用户手册ToolStripMenuItem";
            resources.ApplyResources(this.用户手册ToolStripMenuItem, "用户手册ToolStripMenuItem");
            // 
            // mnu_Aboat
            // 
            this.mnu_Aboat.Name = "mnu_Aboat";
            resources.ApplyResources(this.mnu_Aboat, "mnu_Aboat");
            this.mnu_Aboat.Click += new System.EventHandler(this.mnu_Aboat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ClickThrough = true;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDepartment,
            this.btnStaff,
            this.btnAttendanceReader,
            this.btnTASheet,
            this.btnHoliday,
            this.toolStripSeparator4,
            this.btnShift,
            this.btnShiftArrange,
            this.btnManualLog,
            this.btnAttendanceAnalyst,
            this.toolStripSeparator1,
            this.btnShiftResultStatistics,
            this.btnShiftResultStatistics2,
            this.btnResultDetail,
            this.btnAttendanceLog});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnDepartment
            // 
            this.btnDepartment.Image = global::Ralid.Attendance.UI.Properties.Resources.department;
            resources.ApplyResources(this.btnDepartment, "btnDepartment");
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Click += new System.EventHandler(this.mnu_Departments_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Image = global::Ralid.Attendance.UI.Properties.Resources.Cards;
            resources.ApplyResources(this.btnStaff, "btnStaff");
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Click += new System.EventHandler(this.mnu_Staff_Click);
            // 
            // btnAttendanceReader
            // 
            this.btnAttendanceReader.Image = global::Ralid.Attendance.UI.Properties.Resources.door;
            resources.ApplyResources(this.btnAttendanceReader, "btnAttendanceReader");
            this.btnAttendanceReader.Name = "btnAttendanceReader";
            this.btnAttendanceReader.Click += new System.EventHandler(this.mnu_AttendanceDoorSelection_Click);
            // 
            // btnTASheet
            // 
            this.btnTASheet.Image = global::Ralid.Attendance.UI.Properties.Resources.table;
            resources.ApplyResources(this.btnTASheet, "btnTASheet");
            this.btnTASheet.Name = "btnTASheet";
            this.btnTASheet.Click += new System.EventHandler(this.mnu_TASheet_Click);
            // 
            // btnHoliday
            // 
            this.btnHoliday.Image = global::Ralid.Attendance.UI.Properties.Resources.holiday;
            resources.ApplyResources(this.btnHoliday, "btnHoliday");
            this.btnHoliday.Name = "btnHoliday";
            this.btnHoliday.Click += new System.EventHandler(this.mnu_Holiday_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // btnShift
            // 
            this.btnShift.Image = global::Ralid.Attendance.UI.Properties.Resources.shift;
            resources.ApplyResources(this.btnShift, "btnShift");
            this.btnShift.Name = "btnShift";
            this.btnShift.Click += new System.EventHandler(this.mnu_Shifts_Click);
            // 
            // btnShiftArrange
            // 
            this.btnShiftArrange.Image = global::Ralid.Attendance.UI.Properties.Resources.shiftArrange;
            resources.ApplyResources(this.btnShiftArrange, "btnShiftArrange");
            this.btnShiftArrange.Name = "btnShiftArrange";
            this.btnShiftArrange.Click += new System.EventHandler(this.mnu_ShiftArrange_Click);
            // 
            // btnManualLog
            // 
            this.btnManualLog.Image = global::Ralid.Attendance.UI.Properties.Resources.add_group;
            resources.ApplyResources(this.btnManualLog, "btnManualLog");
            this.btnManualLog.Name = "btnManualLog";
            this.btnManualLog.Click += new System.EventHandler(this.mnu_ManualLog_Click);
            // 
            // btnAttendanceAnalyst
            // 
            this.btnAttendanceAnalyst.Image = global::Ralid.Attendance.UI.Properties.Resources.analysis;
            resources.ApplyResources(this.btnAttendanceAnalyst, "btnAttendanceAnalyst");
            this.btnAttendanceAnalyst.Name = "btnAttendanceAnalyst";
            this.btnAttendanceAnalyst.Click += new System.EventHandler(this.mnu_AttendanceAnalyst_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnShiftResultStatistics
            // 
            this.btnShiftResultStatistics.Image = global::Ralid.Attendance.UI.Properties.Resources.stats;
            resources.ApplyResources(this.btnShiftResultStatistics, "btnShiftResultStatistics");
            this.btnShiftResultStatistics.Name = "btnShiftResultStatistics";
            this.btnShiftResultStatistics.Click += new System.EventHandler(this.mnu_ShiftResultStatistics_Click);
            // 
            // btnShiftResultStatistics2
            // 
            this.btnShiftResultStatistics2.Image = global::Ralid.Attendance.UI.Properties.Resources.blocks_mm_device_wired;
            resources.ApplyResources(this.btnShiftResultStatistics2, "btnShiftResultStatistics2");
            this.btnShiftResultStatistics2.Name = "btnShiftResultStatistics2";
            this.btnShiftResultStatistics2.Click += new System.EventHandler(this.mnu_ShiftResultStatistics2_Click);
            // 
            // btnResultDetail
            // 
            this.btnResultDetail.Image = global::Ralid.Attendance.UI.Properties.Resources.reportDetail;
            resources.ApplyResources(this.btnResultDetail, "btnResultDetail");
            this.btnResultDetail.Name = "btnResultDetail";
            this.btnResultDetail.Click += new System.EventHandler(this.mnu_ResultDetail_Click);
            // 
            // btnAttendanceLog
            // 
            this.btnAttendanceLog.Image = global::Ralid.Attendance.UI.Properties.Resources.fingerprint_reader;
            resources.ApplyResources(this.btnAttendanceLog, "btnAttendanceLog");
            this.btnAttendanceLog.Name = "btnAttendanceLog";
            this.btnAttendanceLog.Click += new System.EventHandler(this.mnu_AttendanceLogReport_Click);
            // 
            // ucFormViewMain
            // 
            resources.ApplyResources(this.ucFormViewMain, "ucFormViewMain");
            this.ucFormViewMain.FormHeaderLength = 135;
            this.ucFormViewMain.Name = "ucFormViewMain";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblOperator,
            this.lblStation,
            this.lblStartFrom,
            this.lblEventServiceStatus,
            this.lblCommuicationStatus});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblOperator
            // 
            this.lblOperator.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblOperator.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            resources.ApplyResources(this.lblOperator, "lblOperator");
            this.lblOperator.Name = "lblOperator";
            // 
            // lblStation
            // 
            this.lblStation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStation.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            resources.ApplyResources(this.lblStation, "lblStation");
            this.lblStation.Name = "lblStation";
            // 
            // lblStartFrom
            // 
            this.lblStartFrom.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStartFrom.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            resources.ApplyResources(this.lblStartFrom, "lblStartFrom");
            this.lblStartFrom.Name = "lblStartFrom";
            // 
            // lblEventServiceStatus
            // 
            this.lblEventServiceStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblEventServiceStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            resources.ApplyResources(this.lblEventServiceStatus, "lblEventServiceStatus");
            this.lblEventServiceStatus.ForeColor = System.Drawing.Color.Black;
            this.lblEventServiceStatus.Name = "lblEventServiceStatus";
            // 
            // lblCommuicationStatus
            // 
            resources.ApplyResources(this.lblCommuicationStatus, "lblCommuicationStatus");
            this.lblCommuicationStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblCommuicationStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblCommuicationStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCommuicationStatus.Name = "lblCommuicationStatus";
            this.lblCommuicationStatus.Spring = true;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucFormViewMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private Ralid.GeneralLibrary.WinformControl.MyToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_基本资料;
        private System.Windows.Forms.ToolStripMenuItem mnu_Departments;
        private System.Windows.Forms.ToolStripMenuItem mnu_Staff;
        private System.Windows.Forms.ToolStripMenuItem mnu_AttendanceDoorSelection;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Shifts;
        private System.Windows.Forms.ToolStripMenuItem mnu_ShiftTemplate;
        private System.Windows.Forms.ToolStripMenuItem mnu_ShiftArrange;
        private System.Windows.Forms.ToolStripMenuItem mnu_AttendanceAnalyst;
        private System.Windows.Forms.ToolStripMenuItem 安全管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Role;
        private System.Windows.Forms.ToolStripMenuItem mnu_Operator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChangePWD;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_ShiftResultStatistics;
        private System.Windows.Forms.ToolStripMenuItem mnu_ResultDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户手册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Aboat;
        private System.Windows.Forms.ToolStripButton btnDepartment;
        private System.Windows.Forms.ToolStripButton btnStaff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnShift;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnu_Logout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnAttendanceReader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnShiftResultStatistics;
        private GeneralLibrary.WinformControl.UCFormView ucFormViewMain;
        private System.Windows.Forms.ToolStripMenuItem mnu_ShiftResultStatistics2;
        private System.Windows.Forms.ToolStripMenuItem mnu_ManualLog;
        private System.Windows.Forms.ToolStripButton btnShiftArrange;
        private System.Windows.Forms.ToolStripButton btnHoliday;
        private System.Windows.Forms.ToolStripButton btnShiftResultStatistics2;
        private System.Windows.Forms.ToolStripButton btnResultDetail;
        private System.Windows.Forms.ToolStripButton btnAttendanceAnalyst;
        private System.Windows.Forms.ToolStripButton btnManualLog;
        private System.Windows.Forms.ToolStripButton btnTASheet;
        private System.Windows.Forms.ToolStripMenuItem mnu_AttendanceLogReport;
        private System.Windows.Forms.ToolStripButton btnAttendanceLog;
        private System.Windows.Forms.ToolStripMenuItem mnu_Holiday;
        private System.Windows.Forms.ToolStripMenuItem mnu_OTType;
        private System.Windows.Forms.ToolStripMenuItem mnu_VacationType;
        private System.Windows.Forms.ToolStripMenuItem mnu_TripType;
        private System.Windows.Forms.ToolStripMenuItem mnu_TASheet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnu_Options;
        private System.Windows.Forms.ToolStripMenuItem mnu_AttendanceRules;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblOperator;
        private System.Windows.Forms.ToolStripStatusLabel lblStation;
        private System.Windows.Forms.ToolStripStatusLabel lblStartFrom;
        private System.Windows.Forms.ToolStripStatusLabel lblEventServiceStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCommuicationStatus;

    }
}

