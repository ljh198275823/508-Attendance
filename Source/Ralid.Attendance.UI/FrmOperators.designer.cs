
namespace Ralid.Attendance.UI
{
    partial class FrmOperators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperators));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OperatorView = new System.Windows.Forms.DataGridView();
            this.colOperatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorView)).BeginInit();
            this.SuspendLayout();
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
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::Ralid.Attendance.UI.Properties.Resources.add;
            resources.ApplyResources(this.btn_Add, "btn_Add");
            this.btn_Add.Name = "btn_Add";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Ralid.Attendance.UI.Properties.Resources.delete;
            resources.ApplyResources(this.btn_Delete, "btn_Delete");
            this.btn_Delete.Name = "btn_Delete";
            // 
            // btn_Export
            // 
            this.btn_Export.Image = global::Ralid.Attendance.UI.Properties.Resources.export;
            resources.ApplyResources(this.btn_Export, "btn_Export");
            this.btn_Export.Name = "btn_Export";
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Image = global::Ralid.Attendance.UI.Properties.Resources.refresh;
            resources.ApplyResources(this.btn_Fresh, "btn_Fresh");
            this.btn_Fresh.Name = "btn_Fresh";
            // 
            // btn_SelectColumns
            // 
            this.btn_SelectColumns.Image = global::Ralid.Attendance.UI.Properties.Resources.columns;
            resources.ApplyResources(this.btn_SelectColumns, "btn_SelectColumns");
            this.btn_SelectColumns.Name = "btn_SelectColumns";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // txtKeyword
            // 
            this.txtKeyword.Name = "txtKeyword";
            resources.ApplyResources(this.txtKeyword, "txtKeyword");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // OperatorView
            // 
            this.OperatorView.AllowUserToAddRows = false;
            this.OperatorView.AllowUserToOrderColumns = true;
            this.OperatorView.AllowUserToResizeRows = false;
            this.OperatorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperatorView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOperatorID,
            this.colOperatorName,
            this.colRoleID,
            this.Column1});
            resources.ApplyResources(this.OperatorView, "OperatorView");
            this.OperatorView.Name = "OperatorView";
            this.OperatorView.RowHeadersVisible = false;
            this.OperatorView.RowTemplate.Height = 23;
            this.OperatorView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // colOperatorID
            // 
            this.colOperatorID.DataPropertyName = "OperatorID";
            resources.ApplyResources(this.colOperatorID, "colOperatorID");
            this.colOperatorID.Name = "colOperatorID";
            this.colOperatorID.ReadOnly = true;
            // 
            // colOperatorName
            // 
            this.colOperatorName.DataPropertyName = "OperatorName";
            resources.ApplyResources(this.colOperatorName, "colOperatorName");
            this.colOperatorName.Name = "colOperatorName";
            this.colOperatorName.ReadOnly = true;
            // 
            // colRoleID
            // 
            this.colRoleID.DataPropertyName = "RoleID";
            resources.ApplyResources(this.colRoleID, "colRoleID");
            this.colRoleID.Name = "colRoleID";
            this.colRoleID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmOperators
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OperatorView);
            this.Controls.Add(this.menu);
            this.Name = "FrmOperators";
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.OperatorView, 0);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_Add;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem btn_Export;
        private System.Windows.Forms.ToolStripMenuItem btn_Fresh;
        private System.Windows.Forms.ToolStripMenuItem btn_SelectColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView OperatorView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperatorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}