namespace Ralid.Attendance.UI
{
    partial class FrmStaff
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.plnLeft = new System.Windows.Forms.Panel();
            this.departmentTreeview1 = new Ralid.Attendance.UI.DepartmentTreeview(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Resign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CancelResign = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtKeyWord = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserPosition1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResigned1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plnLeft.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter1.Location = new System.Drawing.Point(324, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 400);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // plnLeft
            // 
            this.plnLeft.Controls.Add(this.departmentTreeview1);
            this.plnLeft.Controls.Add(this.panel2);
            this.plnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnLeft.Location = new System.Drawing.Point(0, 0);
            this.plnLeft.Name = "plnLeft";
            this.plnLeft.Size = new System.Drawing.Size(324, 400);
            this.plnLeft.TabIndex = 4;
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(0, 34);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.ShowResigedStaff = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(324, 366);
            this.departmentTreeview1.TabIndex = 3;
            this.departmentTreeview1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.departmentTreeview1_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 34);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Remove,
            this.mnu_Resign,
            this.mnu_CancelResign});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 92);
            // 
            // mnu_Remove
            // 
            this.mnu_Remove.Name = "mnu_Remove";
            this.mnu_Remove.Size = new System.Drawing.Size(160, 22);
            this.mnu_Remove.Text = "从所属部门删除";
            this.mnu_Remove.Click += new System.EventHandler(this.mnu_Remove_Click);
            // 
            // mnu_Resign
            // 
            this.mnu_Resign.Name = "mnu_Resign";
            this.mnu_Resign.Size = new System.Drawing.Size(160, 22);
            this.mnu_Resign.Text = "离职";
            this.mnu_Resign.Click += new System.EventHandler(this.mnu_Resign_Click);
            // 
            // mnu_CancelResign
            // 
            this.mnu_CancelResign.Name = "mnu_CancelResign";
            this.mnu_CancelResign.Size = new System.Drawing.Size(160, 22);
            this.mnu_CancelResign.Text = "取消离职";
            this.mnu_CancelResign.Click += new System.EventHandler(this.mnu_CancelResign_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(330, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 191);
            this.panel3.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "未归组人员";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID1,
            this.colName1,
            this.colUserPosition1,
            this.colResigned1,
            this.colMemo1});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(584, 121);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView_CellMouseDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Add});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 26);
            // 
            // mnu_Add
            // 
            this.mnu_Add.Name = "mnu_Add";
            this.mnu_Add.Size = new System.Drawing.Size(160, 22);
            this.mnu_Add.Text = "添加到所选部门";
            this.mnu_Add.Click += new System.EventHandler(this.mnu_Add_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtKeyWord);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 35);
            this.panel4.TabIndex = 31;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtKeyWord.Location = new System.Drawing.Point(3, 3);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(575, 21);
            this.txtKeyWord.TabIndex = 29;
            this.txtKeyWord.TextChanged += new System.EventHandler(this.txtKeyWord_TextChanged);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(330, 203);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(596, 6);
            this.splitter2.TabIndex = 14;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridView);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 203);
            this.panel1.TabIndex = 30;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colUserPosition,
            this.colResigned,
            this.colMemo});
            this.GridView.ContextMenuStrip = this.contextMenuStrip1;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(596, 181);
            this.GridView.TabIndex = 27;
            this.GridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView_CellMouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 181);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(596, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(581, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "总共 0 项";
            // 
            // colID
            // 
            this.colID.HeaderText = "编号";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.MinimumWidth = 100;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colUserPosition
            // 
            this.colUserPosition.HeaderText = "职位";
            this.colUserPosition.MinimumWidth = 100;
            this.colUserPosition.Name = "colUserPosition";
            this.colUserPosition.ReadOnly = true;
            // 
            // colResigned
            // 
            this.colResigned.HeaderText = "状态";
            this.colResigned.Name = "colResigned";
            this.colResigned.ReadOnly = true;
            // 
            // colMemo
            // 
            this.colMemo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemo.HeaderText = "门禁部门";
            this.colMemo.Name = "colMemo";
            this.colMemo.ReadOnly = true;
            this.colMemo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colID1
            // 
            this.colID1.HeaderText = "编号";
            this.colID1.Name = "colID1";
            this.colID1.ReadOnly = true;
            // 
            // colName1
            // 
            this.colName1.HeaderText = "姓名";
            this.colName1.MinimumWidth = 100;
            this.colName1.Name = "colName1";
            this.colName1.ReadOnly = true;
            this.colName1.Width = 150;
            // 
            // colUserPosition1
            // 
            this.colUserPosition1.HeaderText = "职位";
            this.colUserPosition1.MinimumWidth = 100;
            this.colUserPosition1.Name = "colUserPosition1";
            this.colUserPosition1.ReadOnly = true;
            // 
            // colResigned1
            // 
            this.colResigned1.HeaderText = "状态";
            this.colResigned1.Name = "colResigned1";
            this.colResigned1.ReadOnly = true;
            // 
            // colMemo1
            // 
            this.colMemo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemo1.HeaderText = "门禁部门";
            this.colMemo1.Name = "colMemo1";
            this.colMemo1.ReadOnly = true;
            this.colMemo1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.plnLeft);
            this.Name = "FrmStaff";
            this.Text = "人员管理";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.plnLeft.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel plnLeft;
        private DepartmentTreeview departmentTreeview1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Remove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private GeneralLibrary.WinformControl.DBCTextBox txtKeyWord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Resign;
        private System.Windows.Forms.ToolStripMenuItem mnu_CancelResign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserPosition1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResigned1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}