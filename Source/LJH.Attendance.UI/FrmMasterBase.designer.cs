namespace LJH.Attendance.UI
{
    partial class FrmMasterBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterBase));
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Fresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Fresh,
            this.mnu_Add,
            this.mnu_Delete,
            this.mnu_Export});
            this.ContextMenu.Name = "contextMenuStrip1";
            resources.ApplyResources(this.ContextMenu, "ContextMenu");
            // 
            // mnu_Fresh
            // 
            this.mnu_Fresh.Name = "mnu_Fresh";
            resources.ApplyResources(this.mnu_Fresh, "mnu_Fresh");
            // 
            // mnu_Add
            // 
            this.mnu_Add.Name = "mnu_Add";
            resources.ApplyResources(this.mnu_Add, "mnu_Add");
            // 
            // mnu_Delete
            // 
            this.mnu_Delete.Name = "mnu_Delete";
            resources.ApplyResources(this.mnu_Delete, "mnu_Delete");
            // 
            // mnu_Export
            // 
            this.mnu_Export.Name = "mnu_Export";
            resources.ApplyResources(this.mnu_Export, "mnu_Export");
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Spring = true;
            // 
            // FrmMasterBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmMasterBase";
            this.Load += new System.EventHandler(this.FrmMasterBase_Load);
            this.ContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnu_Add;
        private System.Windows.Forms.ToolStripMenuItem mnu_Delete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        protected System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mnu_Fresh;
        private System.Windows.Forms.ToolStripMenuItem mnu_Export;

    }
}