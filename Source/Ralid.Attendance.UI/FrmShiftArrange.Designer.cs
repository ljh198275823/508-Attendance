namespace Ralid.Attendance.UI
{
    partial class FrmShiftArrange
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
            this.plnLeft = new System.Windows.Forms.Panel();
            this.departmentTreeview1 = new Ralid.Attendance.UI.DepartmentTreeview(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDateTimeInterval1 = new Ralid.Attendance.UI.UCDateTimeInterval();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_CopyToOtherDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CopyToOtherStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ApplyTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.plnLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plnLeft
            // 
            this.plnLeft.Controls.Add(this.departmentTreeview1);
            this.plnLeft.Controls.Add(this.panel2);
            this.plnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnLeft.Location = new System.Drawing.Point(0, 0);
            this.plnLeft.Name = "plnLeft";
            this.plnLeft.Size = new System.Drawing.Size(324, 335);
            this.plnLeft.TabIndex = 1;
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.CheckBoxes = true;
            this.departmentTreeview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(0, 86);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.ShowResigedStaff = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(324, 249);
            this.departmentTreeview1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFresh);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 86);
            this.panel2.TabIndex = 2;
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(244, 13);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 67);
            this.btnFresh.TabIndex = 1;
            this.btnFresh.Text = "刷新(&F)";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucDateTimeInterval1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "排班日期";
            // 
            // ucDateTimeInterval1
            // 
            this.ucDateTimeInterval1.EndDateTime = new System.DateTime(2013, 9, 10, 7, 36, 20, 189);
            this.ucDateTimeInterval1.Location = new System.Drawing.Point(9, 14);
            this.ucDateTimeInterval1.Name = "ucDateTimeInterval1";
            this.ucDateTimeInterval1.Size = new System.Drawing.Size(215, 56);
            this.ucDateTimeInterval1.StartDateTime = new System.DateTime(2013, 9, 10, 7, 36, 20, 192);
            this.ucDateTimeInterval1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(324, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 335);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(330, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(614, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(599, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "总共 0 项";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser});
            this.GridView.ContextMenuStrip = this.contextMenuStrip1;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(330, 0);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView.Size = new System.Drawing.Size(614, 313);
            this.GridView.TabIndex = 18;
            this.GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // colUser
            // 
            this.colUser.Frozen = true;
            this.colUser.HeaderText = "人员";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_CopyToOtherDate,
            this.mnu_CopyToOtherStaff,
            this.mnu_ApplyTemplate,
            this.mnu_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 114);
            // 
            // mnu_CopyToOtherDate
            // 
            this.mnu_CopyToOtherDate.Name = "mnu_CopyToOtherDate";
            this.mnu_CopyToOtherDate.Size = new System.Drawing.Size(169, 22);
            this.mnu_CopyToOtherDate.Text = "复制到其它日期...";
            this.mnu_CopyToOtherDate.Visible = false;
            this.mnu_CopyToOtherDate.Click += new System.EventHandler(this.mnu_CopyToOtherDate_Click);
            // 
            // mnu_CopyToOtherStaff
            // 
            this.mnu_CopyToOtherStaff.Name = "mnu_CopyToOtherStaff";
            this.mnu_CopyToOtherStaff.Size = new System.Drawing.Size(169, 22);
            this.mnu_CopyToOtherStaff.Text = "复制到其它人员...";
            this.mnu_CopyToOtherStaff.Click += new System.EventHandler(this.mnu_CopyToOtherStaff_Click);
            // 
            // mnu_ApplyTemplate
            // 
            this.mnu_ApplyTemplate.Name = "mnu_ApplyTemplate";
            this.mnu_ApplyTemplate.Size = new System.Drawing.Size(169, 22);
            this.mnu_ApplyTemplate.Text = "应用排班模板";
            this.mnu_ApplyTemplate.Click += new System.EventHandler(this.mnu_ApplyTemplate_Click);
            // 
            // mnu_Clear
            // 
            this.mnu_Clear.Name = "mnu_Clear";
            this.mnu_Clear.Size = new System.Drawing.Size(169, 22);
            this.mnu_Clear.Text = "清除";
            this.mnu_Clear.Click += new System.EventHandler(this.mnu_Clear_Click);
            // 
            // FrmShiftArrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 335);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.plnLeft);
            this.Name = "FrmShiftArrange";
            this.Text = "人员排班";
            this.Load += new System.EventHandler(this.FrmShiftArrange_Load);
            this.plnLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plnLeft;
        private DepartmentTreeview departmentTreeview1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFresh;
        private UCDateTimeInterval ucDateTimeInterval1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_CopyToOtherDate;
        private System.Windows.Forms.ToolStripMenuItem mnu_CopyToOtherStaff;
        private System.Windows.Forms.ToolStripMenuItem mnu_Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.ToolStripMenuItem mnu_ApplyTemplate;
    }
}