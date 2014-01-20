namespace LJH.Attendance.UI
{
    partial class FrmDeviceInfoMaster
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
            this.groupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_AddGroup2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AddDevice2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rename2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Delete2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Property2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deviceTree1 = new LJH.Attendance.UI.Controls.DeviceTree(this.components);
            this.rootMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_AddGroup1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AddDevice1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Fresh1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_UploadAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Upload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_GetAttendanceLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SyncTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Fresh2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rootMenu.SuspendLayout();
            this.deviceMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMenu
            // 
            this.groupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_AddGroup2,
            this.mnu_AddDevice2,
            this.mnu_Fresh,
            this.mnu_Rename2,
            this.toolStripSeparator3,
            this.mnu_Delete2,
            this.mnu_Property2});
            this.groupMenu.Name = "contextMenuStrip2";
            this.groupMenu.Size = new System.Drawing.Size(153, 164);
            // 
            // mnu_AddGroup2
            // 
            this.mnu_AddGroup2.Name = "mnu_AddGroup2";
            this.mnu_AddGroup2.Size = new System.Drawing.Size(152, 22);
            this.mnu_AddGroup2.Text = "增加设备组";
            this.mnu_AddGroup2.Click += new System.EventHandler(this.mnu_AddGroup_Click);
            // 
            // mnu_AddDevice2
            // 
            this.mnu_AddDevice2.Name = "mnu_AddDevice2";
            this.mnu_AddDevice2.Size = new System.Drawing.Size(152, 22);
            this.mnu_AddDevice2.Text = "增加设备";
            this.mnu_AddDevice2.Click += new System.EventHandler(this.mnu_AddDevice_Click);
            // 
            // mnu_Fresh
            // 
            this.mnu_Fresh.Name = "mnu_Fresh";
            this.mnu_Fresh.Size = new System.Drawing.Size(152, 22);
            this.mnu_Fresh.Text = "刷新";
            this.mnu_Fresh.Click += new System.EventHandler(this.mnu_Fresh_Click);
            // 
            // mnu_Rename2
            // 
            this.mnu_Rename2.Name = "mnu_Rename2";
            this.mnu_Rename2.Size = new System.Drawing.Size(152, 22);
            this.mnu_Rename2.Text = "重命名";
            this.mnu_Rename2.Click += new System.EventHandler(this.mnu_Rename_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnu_Delete2
            // 
            this.mnu_Delete2.Name = "mnu_Delete2";
            this.mnu_Delete2.Size = new System.Drawing.Size(152, 22);
            this.mnu_Delete2.Text = "删除";
            this.mnu_Delete2.Click += new System.EventHandler(this.mnu_Delete_Click);
            // 
            // mnu_Property2
            // 
            this.mnu_Property2.Name = "mnu_Property2";
            this.mnu_Property2.Size = new System.Drawing.Size(152, 22);
            this.mnu_Property2.Text = "属性";
            this.mnu_Property2.Click += new System.EventHandler(this.mnu_Property_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::LJH.Attendance.UI.Properties.Resources.add;
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(62, 46);
            this.btn_Add.Text = "新建(&N)";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::LJH.Attendance.UI.Properties.Resources.delete;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(61, 46);
            this.btn_Delete.Text = "删除(&D)";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Export
            // 
            this.btn_Export.Image = global::LJH.Attendance.UI.Properties.Resources.export;
            this.btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(59, 46);
            this.btn_Export.Text = "导出(&E)";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Image = global::LJH.Attendance.UI.Properties.Resources.refresh;
            this.btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(58, 46);
            this.btn_Fresh.Text = "刷新(&F)";
            this.btn_Fresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_SelectColumns
            // 
            this.btn_SelectColumns.Image = global::LJH.Attendance.UI.Properties.Resources.columns;
            this.btn_SelectColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SelectColumns.Name = "btn_SelectColumns";
            this.btn_SelectColumns.Size = new System.Drawing.Size(70, 46);
            this.btn_SelectColumns.Text = "选择列(&L)";
            this.btn_SelectColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 46);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Delete,
            this.btn_Export,
            this.btn_Fresh,
            this.btn_SelectColumns,
            this.toolStripSeparator1,
            this.txtKeyword,
            this.toolStripSeparator2});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(797, 50);
            this.menu.TabIndex = 58;
            this.menu.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(288, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 367);
            this.splitter1.TabIndex = 63;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deviceTree1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 367);
            this.panel1.TabIndex = 62;
            // 
            // deviceTree1
            // 
            this.deviceTree1.AllowDrop = true;
            this.deviceTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceTree1.ContextMenuStrip = this.groupMenu;
            this.deviceTree1.Location = new System.Drawing.Point(4, 4);
            this.deviceTree1.Name = "deviceTree1";
            this.deviceTree1.Size = new System.Drawing.Size(281, 360);
            this.deviceTree1.TabIndex = 0;
            this.deviceTree1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.deviceTree1_AfterLabelEdit);
            this.deviceTree1.DragDrop += new System.Windows.Forms.DragEventHandler(this.deviceTree1_DragDrop);
            this.deviceTree1.DragEnter += new System.Windows.Forms.DragEventHandler(this.deviceTree1_DragEnter);
            this.deviceTree1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deviceTree1_MouseDown);
            // 
            // rootMenu
            // 
            this.rootMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_AddGroup1,
            this.mnu_AddDevice1,
            this.mnu_Fresh1});
            this.rootMenu.Name = "rootMenu";
            this.rootMenu.Size = new System.Drawing.Size(137, 70);
            // 
            // mnu_AddGroup1
            // 
            this.mnu_AddGroup1.Name = "mnu_AddGroup1";
            this.mnu_AddGroup1.Size = new System.Drawing.Size(136, 22);
            this.mnu_AddGroup1.Text = "增加设备组";
            this.mnu_AddGroup1.Click += new System.EventHandler(this.mnu_AddGroup_Click);
            // 
            // mnu_AddDevice1
            // 
            this.mnu_AddDevice1.Name = "mnu_AddDevice1";
            this.mnu_AddDevice1.Size = new System.Drawing.Size(136, 22);
            this.mnu_AddDevice1.Text = "增加设备";
            this.mnu_AddDevice1.Click += new System.EventHandler(this.mnu_AddDevice_Click);
            // 
            // mnu_Fresh1
            // 
            this.mnu_Fresh1.Name = "mnu_Fresh1";
            this.mnu_Fresh1.Size = new System.Drawing.Size(136, 22);
            this.mnu_Fresh1.Text = "刷新";
            this.mnu_Fresh1.Click += new System.EventHandler(this.mnu_Fresh_Click);
            // 
            // deviceMenu
            // 
            this.deviceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_UploadAll,
            this.mnu_Upload,
            this.mnu_GetAttendanceLog,
            this.mnu_SyncTime,
            this.toolStripSeparator4,
            this.mnu_Fresh2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.deviceMenu.Name = "contextMenuStrip2";
            this.deviceMenu.Size = new System.Drawing.Size(149, 186);
            // 
            // mnu_UploadAll
            // 
            this.mnu_UploadAll.Name = "mnu_UploadAll";
            this.mnu_UploadAll.Size = new System.Drawing.Size(152, 22);
            this.mnu_UploadAll.Text = "同步所有人员";
            this.mnu_UploadAll.Click += new System.EventHandler(this.mnu_UploadAll_Click);
            // 
            // mnu_Upload
            // 
            this.mnu_Upload.Name = "mnu_Upload";
            this.mnu_Upload.Size = new System.Drawing.Size(152, 22);
            this.mnu_Upload.Text = "下发人员信息";
            this.mnu_Upload.Click += new System.EventHandler(this.mnu_Upload_Click);
            // 
            // mnu_GetAttendanceLog
            // 
            this.mnu_GetAttendanceLog.Name = "mnu_GetAttendanceLog";
            this.mnu_GetAttendanceLog.Size = new System.Drawing.Size(152, 22);
            this.mnu_GetAttendanceLog.Text = "获取考勤记录";
            this.mnu_GetAttendanceLog.Click += new System.EventHandler(this.mnu_GetAttendanceLog_Click);
            // 
            // mnu_SyncTime
            // 
            this.mnu_SyncTime.Name = "mnu_SyncTime";
            this.mnu_SyncTime.Size = new System.Drawing.Size(152, 22);
            this.mnu_SyncTime.Text = "同步时间";
            this.mnu_SyncTime.Click += new System.EventHandler(this.mnu_SyncTime_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // mnu_Fresh2
            // 
            this.mnu_Fresh2.Name = "mnu_Fresh2";
            this.mnu_Fresh2.Size = new System.Drawing.Size(152, 22);
            this.mnu_Fresh2.Text = "刷新";
            this.mnu_Fresh2.Click += new System.EventHandler(this.mnu_Fresh_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "重命名";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.mnu_Rename_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "删除";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.mnu_Delete_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "属性";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.mnu_Property_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 175);
            this.panel2.TabIndex = 64;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(294, 175);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(503, 6);
            this.splitter2.TabIndex = 65;
            this.splitter2.TabStop = false;
            this.splitter2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(294, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 186);
            this.panel3.TabIndex = 66;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 186);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "实时考勤记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "报警信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmDeviceInfoMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(797, 367);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeviceInfoMaster";
            this.Text = "考勤设备";
            this.Load += new System.EventHandler(this.FrmDeviceInfoMaster_Load);
            this.groupMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rootMenu.ResumeLayout(false);
            this.deviceMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip groupMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddGroup2;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddDevice2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Delete2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Property2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Fresh;
        private System.Windows.Forms.ToolStripMenuItem btn_Add;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripMenuItem btn_Fresh;
        private System.Windows.Forms.ToolStripMenuItem btn_SelectColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private Controls.DeviceTree deviceTree1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Rename2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip rootMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_Fresh1;
        private System.Windows.Forms.ContextMenuStrip deviceMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnu_Fresh2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnu_UploadAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_Upload;
        private System.Windows.Forms.ToolStripMenuItem mnu_GetAttendanceLog;
        private System.Windows.Forms.ToolStripMenuItem mnu_SyncTime;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddGroup1;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddDevice1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}