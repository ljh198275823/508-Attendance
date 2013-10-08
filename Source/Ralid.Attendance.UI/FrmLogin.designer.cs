namespace Ralid.Attendance.UI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogName = new System.Windows.Forms.ComboBox();
            this.txtPassword = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.gpDB = new System.Windows.Forms.GroupBox();
            this.txtPasswd = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtUserID = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtDataBase = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.txtServer = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdUser = new System.Windows.Forms.RadioButton();
            this.rdSystem = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRememberLogid = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.gpDB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogName
            // 
            this.txtLogName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtLogName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.txtLogName, "txtLogName");
            this.txtLogName.Name = "txtLogName";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // gpDB
            // 
            resources.ApplyResources(this.gpDB, "gpDB");
            this.gpDB.Controls.Add(this.txtPasswd);
            this.gpDB.Controls.Add(this.txtUserID);
            this.gpDB.Controls.Add(this.txtDataBase);
            this.gpDB.Controls.Add(this.txtServer);
            this.gpDB.Controls.Add(this.label6);
            this.gpDB.Controls.Add(this.label5);
            this.gpDB.Controls.Add(this.label4);
            this.gpDB.Controls.Add(this.label3);
            this.gpDB.Controls.Add(this.rdUser);
            this.gpDB.Controls.Add(this.rdSystem);
            this.gpDB.Name = "gpDB";
            this.gpDB.TabStop = false;
            // 
            // txtPasswd
            // 
            resources.ApplyResources(this.txtPasswd, "txtPasswd");
            this.txtPasswd.Name = "txtPasswd";
            // 
            // txtUserID
            // 
            resources.ApplyResources(this.txtUserID, "txtUserID");
            this.txtUserID.Name = "txtUserID";
            // 
            // txtDataBase
            // 
            resources.ApplyResources(this.txtDataBase, "txtDataBase");
            this.txtDataBase.Name = "txtDataBase";
            // 
            // txtServer
            // 
            resources.ApplyResources(this.txtServer, "txtServer");
            this.txtServer.Name = "txtServer";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rdUser
            // 
            resources.ApplyResources(this.rdUser, "rdUser");
            this.rdUser.Name = "rdUser";
            this.rdUser.UseVisualStyleBackColor = true;
            this.rdUser.CheckedChanged += new System.EventHandler(this.rdUser_CheckedChanged);
            // 
            // rdSystem
            // 
            resources.ApplyResources(this.rdSystem, "rdSystem");
            this.rdSystem.Checked = true;
            this.rdSystem.Name = "rdSystem";
            this.rdSystem.TabStop = true;
            this.rdSystem.UseVisualStyleBackColor = true;
            this.rdSystem.CheckedChanged += new System.EventHandler(this.rdSystem_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkRememberLogid);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtLogName);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // chkRememberLogid
            // 
            resources.ApplyResources(this.chkRememberLogid, "chkRememberLogid");
            this.chkRememberLogid.Name = "chkRememberLogid";
            this.chkRememberLogid.UseVisualStyleBackColor = true;
            this.chkRememberLogid.CheckedChanged += new System.EventHandler(this.chkRememberLogid_CheckedChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnAdvance
            // 
            resources.ApplyResources(this.btnAdvance, "btnAdvance");
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpDB);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Login_Load);
            this.gpDB.ResumeLayout(false);
            this.gpDB.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.ComboBox txtLogName;
        public Ralid.GeneralLibrary.WinformControl.DBCTextBox txtPassword;
        private System.Windows.Forms.GroupBox gpDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdUser;
        private System.Windows.Forms.RadioButton rdSystem;
        private Ralid.GeneralLibrary.WinformControl.DBCTextBox txtPasswd;
        private Ralid.GeneralLibrary.WinformControl.DBCTextBox txtUserID;
        private Ralid.GeneralLibrary.WinformControl.DBCTextBox txtDataBase;
        private Ralid.GeneralLibrary.WinformControl.DBCTextBox txtServer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.CheckBox chkRememberLogid;
    }
}