namespace LJH.Attendance.UI
{
    partial class FrmStaffDetail
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtHireDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelPhoto = new System.Windows.Forms.Button();
            this.btnBrowserPhoto = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.dbcTextBox1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.rdResign = new System.Windows.Forms.RadioButton();
            this.rdUnResign = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.departmentComboBox1 = new LJH.Attendance.UI.DepartmentComboBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserPosition = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtCertificate = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(339, 327);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(448, 327);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 298);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSex);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtHireDate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnDelPhoto);
            this.tabPage1.Controls.Add(this.btnBrowserPhoto);
            this.tabPage1.Controls.Add(this.picPhoto);
            this.tabPage1.Controls.Add(this.dbcTextBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rdResign);
            this.tabPage1.Controls.Add(this.rdUnResign);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.departmentComboBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtUserPosition);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCertificate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本资料";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSex
            // 
            this.txtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSex.FormattingEnabled = true;
            this.txtSex.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.txtSex.Location = new System.Drawing.Point(48, 158);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(215, 20);
            this.txtSex.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(12, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 52;
            this.label8.Text = "性别";
            // 
            // dtHireDate
            // 
            this.dtHireDate.Location = new System.Drawing.Point(71, 189);
            this.dtHireDate.Name = "dtHireDate";
            this.dtHireDate.Size = new System.Drawing.Size(192, 21);
            this.dtHireDate.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 48;
            this.label7.Text = "入职日期";
            // 
            // btnDelPhoto
            // 
            this.btnDelPhoto.Location = new System.Drawing.Point(278, 187);
            this.btnDelPhoto.Name = "btnDelPhoto";
            this.btnDelPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnDelPhoto.TabIndex = 47;
            this.btnDelPhoto.Text = "删除相片";
            this.btnDelPhoto.UseVisualStyleBackColor = true;
            this.btnDelPhoto.Click += new System.EventHandler(this.btnDelPhoto_Click);
            // 
            // btnBrowserPhoto
            // 
            this.btnBrowserPhoto.Location = new System.Drawing.Point(359, 188);
            this.btnBrowserPhoto.Name = "btnBrowserPhoto";
            this.btnBrowserPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserPhoto.TabIndex = 46;
            this.btnBrowserPhoto.Text = "查找相片";
            this.btnBrowserPhoto.UseVisualStyleBackColor = true;
            this.btnBrowserPhoto.Click += new System.EventHandler(this.btnBrowserPhoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(278, 12);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(150, 166);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 45;
            this.picPhoto.TabStop = false;
            // 
            // dbcTextBox1
            // 
            this.dbcTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dbcTextBox1.Location = new System.Drawing.Point(48, 130);
            this.dbcTextBox1.MaxLength = 20;
            this.dbcTextBox1.Name = "dbcTextBox1";
            this.dbcTextBox1.Size = new System.Drawing.Size(215, 21);
            this.dbcTextBox1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "卡号";
            // 
            // rdResign
            // 
            this.rdResign.AutoSize = true;
            this.rdResign.Location = new System.Drawing.Point(103, 220);
            this.rdResign.Name = "rdResign";
            this.rdResign.Size = new System.Drawing.Size(47, 16);
            this.rdResign.TabIndex = 42;
            this.rdResign.Text = "离职";
            this.rdResign.UseVisualStyleBackColor = true;
            // 
            // rdUnResign
            // 
            this.rdUnResign.AutoSize = true;
            this.rdUnResign.Checked = true;
            this.rdUnResign.Location = new System.Drawing.Point(48, 220);
            this.rdUnResign.Name = "rdUnResign";
            this.rdUnResign.Size = new System.Drawing.Size(47, 16);
            this.rdUnResign.TabIndex = 41;
            this.rdUnResign.TabStop = true;
            this.rdUnResign.Text = "在职";
            this.rdUnResign.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(9, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "状态";
            // 
            // departmentComboBox1
            // 
            this.departmentComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox1.FormattingEnabled = true;
            this.departmentComboBox1.Location = new System.Drawing.Point(48, 69);
            this.departmentComboBox1.Name = "departmentComboBox1";
            this.departmentComboBox1.Size = new System.Drawing.Size(215, 20);
            this.departmentComboBox1.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "部门";
            // 
            // txtUserPosition
            // 
            this.txtUserPosition.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUserPosition.Location = new System.Drawing.Point(48, 100);
            this.txtUserPosition.MaxLength = 20;
            this.txtUserPosition.Name = "txtUserPosition";
            this.txtUserPosition.Size = new System.Drawing.Size(215, 21);
            this.txtUserPosition.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "职位";
            // 
            // txtCertificate
            // 
            this.txtCertificate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCertificate.Location = new System.Drawing.Point(48, 39);
            this.txtCertificate.MaxLength = 20;
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.Size = new System.Drawing.Size(215, 21);
            this.txtCertificate.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "编号";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(48, 11);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 21);
            this.txtName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "姓名";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "卡号及指纹";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "删除指纹";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "录制指纹";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 148);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // FrmStaffDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmStaffDetail";
            this.Text = "员工信息";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDelPhoto;
        private System.Windows.Forms.Button btnBrowserPhoto;
        private System.Windows.Forms.PictureBox picPhoto;
        private GeneralLibrary.WinformControl.DBCTextBox dbcTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdResign;
        private System.Windows.Forms.RadioButton rdUnResign;
        private System.Windows.Forms.Label label6;
        private DepartmentComboBox departmentComboBox1;
        private System.Windows.Forms.Label label5;
        private GeneralLibrary.WinformControl.DBCTextBox txtUserPosition;
        private System.Windows.Forms.Label label4;
        private GeneralLibrary.WinformControl.DBCTextBox txtCertificate;
        private System.Windows.Forms.Label label3;
        private GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtHireDate;
        private System.Windows.Forms.ComboBox txtSex;
        private System.Windows.Forms.Label label8;
    }
}