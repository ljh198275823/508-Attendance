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
            this.txtCertificate = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserPosition = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.departmentComboBox1 = new LJH.Attendance.UI.DepartmentComboBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.rdUnResign = new System.Windows.Forms.RadioButton();
            this.rdResign = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dbcTextBox1 = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(416, 222);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(525, 222);
            // 
            // txtCertificate
            // 
            this.txtCertificate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCertificate.Location = new System.Drawing.Point(60, 44);
            this.txtCertificate.MaxLength = 20;
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.Size = new System.Drawing.Size(215, 21);
            this.txtCertificate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(24, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "编号";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(60, 16);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 21);
            this.txtName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "姓名";
            // 
            // txtUserPosition
            // 
            this.txtUserPosition.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUserPosition.Location = new System.Drawing.Point(60, 108);
            this.txtUserPosition.MaxLength = 20;
            this.txtUserPosition.Name = "txtUserPosition";
            this.txtUserPosition.Size = new System.Drawing.Size(215, 21);
            this.txtUserPosition.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "职位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(24, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "部门";
            // 
            // departmentComboBox1
            // 
            this.departmentComboBox1.FormattingEnabled = true;
            this.departmentComboBox1.Location = new System.Drawing.Point(60, 77);
            this.departmentComboBox1.Name = "departmentComboBox1";
            this.departmentComboBox1.Size = new System.Drawing.Size(215, 20);
            this.departmentComboBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(24, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "状态";
            // 
            // rdUnResign
            // 
            this.rdUnResign.AutoSize = true;
            this.rdUnResign.Checked = true;
            this.rdUnResign.Location = new System.Drawing.Point(60, 175);
            this.rdUnResign.Name = "rdUnResign";
            this.rdUnResign.Size = new System.Drawing.Size(47, 16);
            this.rdUnResign.TabIndex = 25;
            this.rdUnResign.TabStop = true;
            this.rdUnResign.Text = "在职";
            this.rdUnResign.UseVisualStyleBackColor = true;
            // 
            // rdResign
            // 
            this.rdResign.AutoSize = true;
            this.rdResign.Location = new System.Drawing.Point(115, 175);
            this.rdResign.Name = "rdResign";
            this.rdResign.Size = new System.Drawing.Size(47, 16);
            this.rdResign.TabIndex = 26;
            this.rdResign.Text = "离职";
            this.rdResign.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(294, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 148);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(294, 170);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 28;
            this.btnBrowser.Text = "增加相片";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "删除相片";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dbcTextBox1
            // 
            this.dbcTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dbcTextBox1.Location = new System.Drawing.Point(60, 138);
            this.dbcTextBox1.MaxLength = 20;
            this.dbcTextBox1.Name = "dbcTextBox1";
            this.dbcTextBox1.Size = new System.Drawing.Size(215, 21);
            this.dbcTextBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "卡号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "删除指纹";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "录制指纹";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(458, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 148);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // FrmStaffDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dbcTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdResign);
            this.Controls.Add(this.rdUnResign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.departmentComboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCertificate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmStaffDetail";
            this.Text = "员工信息";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCertificate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtUserPosition, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.departmentComboBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.rdUnResign, 0);
            this.Controls.SetChildIndex(this.rdResign, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnBrowser, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dbcTextBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GeneralLibrary.WinformControl.DBCTextBox txtCertificate;
        private System.Windows.Forms.Label label3;
        private GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.Label label1;
        private GeneralLibrary.WinformControl.DBCTextBox txtUserPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DepartmentComboBox departmentComboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdUnResign;
        private System.Windows.Forms.RadioButton rdResign;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button button2;
        private GeneralLibrary.WinformControl.DBCTextBox dbcTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}