﻿namespace LJH.Attendance.UI
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_AddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AddDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Property = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip2.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_AddGroup,
            this.mnu_AddDevice,
            this.mnu_Fresh,
            this.mnu_Rename,
            this.toolStripSeparator3,
            this.mnu_Delete,
            this.mnu_Property});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(137, 142);
            // 
            // mnu_AddGroup
            // 
            this.mnu_AddGroup.Name = "mnu_AddGroup";
            this.mnu_AddGroup.Size = new System.Drawing.Size(152, 22);
            this.mnu_AddGroup.Text = "增加设备组";
            this.mnu_AddGroup.Click += new System.EventHandler(this.mnu_AddGroup_Click);
            // 
            // mnu_AddDevice
            // 
            this.mnu_AddDevice.Name = "mnu_AddDevice";
            this.mnu_AddDevice.Size = new System.Drawing.Size(152, 22);
            this.mnu_AddDevice.Text = "增加设备";
            this.mnu_AddDevice.Click += new System.EventHandler(this.mnu_AddDevice_Click);
            // 
            // mnu_Fresh
            // 
            this.mnu_Fresh.Name = "mnu_Fresh";
            this.mnu_Fresh.Size = new System.Drawing.Size(152, 22);
            this.mnu_Fresh.Text = "刷新";
            this.mnu_Fresh.Click += new System.EventHandler(this.mnu_Fresh_Click);
            // 
            // mnu_Rename
            // 
            this.mnu_Rename.Name = "mnu_Rename";
            this.mnu_Rename.Size = new System.Drawing.Size(152, 22);
            this.mnu_Rename.Text = "重命名";
            this.mnu_Rename.Click += new System.EventHandler(this.mnu_Rename_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnu_Delete
            // 
            this.mnu_Delete.Name = "mnu_Delete";
            this.mnu_Delete.Size = new System.Drawing.Size(152, 22);
            this.mnu_Delete.Text = "删除";
            this.mnu_Delete.Click += new System.EventHandler(this.mnu_Delete_Click);
            // 
            // mnu_Property
            // 
            this.mnu_Property.Name = "mnu_Property";
            this.mnu_Property.Size = new System.Drawing.Size(152, 22);
            this.mnu_Property.Text = "属性";
            this.mnu_Property.Click += new System.EventHandler(this.mnu_Property_Click);
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
            this.menu.Size = new System.Drawing.Size(1100, 50);
            this.menu.TabIndex = 58;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(288, 50);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 317);
            this.splitter1.TabIndex = 63;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deviceTree1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 317);
            this.panel1.TabIndex = 62;
            // 
            // deviceTree1
            // 
            this.deviceTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceTree1.ContextMenuStrip = this.contextMenuStrip2;
            this.deviceTree1.Location = new System.Drawing.Point(4, 4);
            this.deviceTree1.Name = "deviceTree1";
            this.deviceTree1.Size = new System.Drawing.Size(281, 310);
            this.deviceTree1.TabIndex = 0;
            this.deviceTree1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.deviceTree1_AfterLabelEdit);
            this.deviceTree1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.deviceTree1_NodeMouseClick);
            // 
            // FrmDeviceInfoMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 367);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeviceInfoMaster";
            this.Text = "考勤设备";
            this.Load += new System.EventHandler(this.FrmDeviceInfoMaster_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddGroup;
        private System.Windows.Forms.ToolStripMenuItem mnu_AddDevice;
        private System.Windows.Forms.ToolStripMenuItem mnu_Delete;
        private System.Windows.Forms.ToolStripMenuItem mnu_Property;
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
        private System.Windows.Forms.ToolStripMenuItem mnu_Rename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}