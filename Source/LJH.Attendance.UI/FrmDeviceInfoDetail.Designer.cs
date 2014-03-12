namespace LJH.Attendance.UI
{
    partial class FrmDeviceInfoDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpTCPIP = new System.Windows.Forms.GroupBox();
            this.txtPort = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtGateway = new LJH.GeneralLibrary.WinformControl.UCIPTextBox();
            this.txtIPMask = new LJH.GeneralLibrary.WinformControl.UCIPTextBox();
            this.txtIP = new LJH.GeneralLibrary.WinformControl.UCIPTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpRS232 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtBaud = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.txtCommport = new LJH.GeneralLibrary.WinformControl.IntergerTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.comCommunication = new System.Windows.Forms.ComboBox();
            this.comDeviceType = new System.Windows.Forms.ComboBox();
            this.txtSerial = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.chkForAttendance = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.verifyCodeComboBox1 = new LJH.Attendance.UI.Controls.VerifyCodeComboBox(this.components);
            this.gpTCPIP.SuspendLayout();
            this.gpRS232.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(361, 236);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(470, 236);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "通讯方式";
            // 
            // gpTCPIP
            // 
            this.gpTCPIP.Controls.Add(this.txtPort);
            this.gpTCPIP.Controls.Add(this.txtGateway);
            this.gpTCPIP.Controls.Add(this.txtIPMask);
            this.gpTCPIP.Controls.Add(this.txtIP);
            this.gpTCPIP.Controls.Add(this.label8);
            this.gpTCPIP.Controls.Add(this.label7);
            this.gpTCPIP.Controls.Add(this.label6);
            this.gpTCPIP.Controls.Add(this.label5);
            this.gpTCPIP.Location = new System.Drawing.Point(12, 75);
            this.gpTCPIP.Name = "gpTCPIP";
            this.gpTCPIP.Size = new System.Drawing.Size(541, 84);
            this.gpTCPIP.TabIndex = 4;
            this.gpTCPIP.TabStop = false;
            this.gpTCPIP.Text = "TCP/IP 参数";
            // 
            // txtPort
            // 
            this.txtPort.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPort.Location = new System.Drawing.Point(320, 23);
            this.txtPort.MaxValue = 65535;
            this.txtPort.MinValue = 0;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 15;
            this.txtPort.Text = "4370";
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(320, 50);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(219, 28);
            this.txtGateway.TabIndex = 14;
            // 
            // txtIPMask
            // 
            this.txtIPMask.Location = new System.Drawing.Point(40, 50);
            this.txtIPMask.Name = "txtIPMask";
            this.txtIPMask.Size = new System.Drawing.Size(219, 28);
            this.txtIPMask.TabIndex = 13;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(40, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(219, 28);
            this.txtIP.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "网关";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "掩码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "端口号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP";
            // 
            // gpRS232
            // 
            this.gpRS232.Controls.Add(this.txtAddress);
            this.gpRS232.Controls.Add(this.txtBaud);
            this.gpRS232.Controls.Add(this.txtCommport);
            this.gpRS232.Controls.Add(this.label11);
            this.gpRS232.Controls.Add(this.label10);
            this.gpRS232.Controls.Add(this.label9);
            this.gpRS232.Location = new System.Drawing.Point(12, 171);
            this.gpRS232.Name = "gpRS232";
            this.gpRS232.Size = new System.Drawing.Size(541, 50);
            this.gpRS232.TabIndex = 5;
            this.gpRS232.TabStop = false;
            this.gpRS232.Text = "RS232/485 参数";
            // 
            // txtAddress
            // 
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtAddress.Location = new System.Drawing.Point(335, 20);
            this.txtAddress.MaxValue = 2147483647;
            this.txtAddress.MinValue = 0;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(64, 21);
            this.txtAddress.TabIndex = 18;
            this.txtAddress.Text = "0";
            // 
            // txtBaud
            // 
            this.txtBaud.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtBaud.Location = new System.Drawing.Point(189, 20);
            this.txtBaud.MaxValue = 2147483647;
            this.txtBaud.MinValue = 0;
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(64, 21);
            this.txtBaud.TabIndex = 17;
            this.txtBaud.Text = "9600";
            // 
            // txtCommport
            // 
            this.txtCommport.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCommport.Location = new System.Drawing.Point(53, 20);
            this.txtCommport.MaxValue = 2147483647;
            this.txtCommport.MinValue = 0;
            this.txtCommport.Name = "txtCommport";
            this.txtCommport.Size = new System.Drawing.Size(64, 21);
            this.txtCommport.TabIndex = 16;
            this.txtCommport.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "地址";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "波特率";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "串口号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "产品类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "序列号";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(78, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 21);
            this.txtName.TabIndex = 8;
            // 
            // comCommunication
            // 
            this.comCommunication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCommunication.FormattingEnabled = true;
            this.comCommunication.Items.AddRange(new object[] {
            "TCP/IP",
            "RS232/485"});
            this.comCommunication.Location = new System.Drawing.Point(79, 39);
            this.comCommunication.Name = "comCommunication";
            this.comCommunication.Size = new System.Drawing.Size(161, 20);
            this.comCommunication.TabIndex = 9;
            this.comCommunication.SelectedIndexChanged += new System.EventHandler(this.comCommunication_SelectedIndexChanged);
            // 
            // comDeviceType
            // 
            this.comDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDeviceType.FormattingEnabled = true;
            this.comDeviceType.Items.AddRange(new object[] {
            "中控指纹门禁机"});
            this.comDeviceType.Location = new System.Drawing.Point(332, 10);
            this.comDeviceType.Name = "comDeviceType";
            this.comDeviceType.Size = new System.Drawing.Size(161, 20);
            this.comDeviceType.TabIndex = 10;
            // 
            // txtSerial
            // 
            this.txtSerial.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSerial.Location = new System.Drawing.Point(332, 39);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(162, 21);
            this.txtSerial.TabIndex = 11;
            // 
            // chkForAttendance
            // 
            this.chkForAttendance.AutoSize = true;
            this.chkForAttendance.Checked = true;
            this.chkForAttendance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForAttendance.Location = new System.Drawing.Point(12, 232);
            this.chkForAttendance.Name = "chkForAttendance";
            this.chkForAttendance.Size = new System.Drawing.Size(72, 16);
            this.chkForAttendance.TabIndex = 12;
            this.chkForAttendance.Text = "用于考勤";
            this.chkForAttendance.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "验证方式";
            // 
            // verifyCodeComboBox1
            // 
            this.verifyCodeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.verifyCodeComboBox1.FormattingEnabled = true;
            this.verifyCodeComboBox1.Location = new System.Drawing.Point(161, 230);
            this.verifyCodeComboBox1.Name = "verifyCodeComboBox1";
            this.verifyCodeComboBox1.Size = new System.Drawing.Size(121, 20);
            this.verifyCodeComboBox1.TabIndex = 14;
            // 
            // FrmDeviceInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 271);
            this.Controls.Add(this.verifyCodeComboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkForAttendance);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.comDeviceType);
            this.Controls.Add(this.comCommunication);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpRS232);
            this.Controls.Add(this.gpTCPIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeviceInfoDetail";
            this.Text = "考勤设备";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gpTCPIP, 0);
            this.Controls.SetChildIndex(this.gpRS232, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.comCommunication, 0);
            this.Controls.SetChildIndex(this.comDeviceType, 0);
            this.Controls.SetChildIndex(this.txtSerial, 0);
            this.Controls.SetChildIndex(this.chkForAttendance, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.verifyCodeComboBox1, 0);
            this.gpTCPIP.ResumeLayout(false);
            this.gpTCPIP.PerformLayout();
            this.gpRS232.ResumeLayout(false);
            this.gpRS232.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpTCPIP;
        private System.Windows.Forms.GroupBox gpRS232;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtPort;
        private LJH.GeneralLibrary.WinformControl.UCIPTextBox txtGateway;
        private LJH.GeneralLibrary.WinformControl.UCIPTextBox txtIPMask;
        private LJH.GeneralLibrary.WinformControl.UCIPTextBox txtIP;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtAddress;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtBaud;
        private LJH.GeneralLibrary.WinformControl.IntergerTextBox txtCommport;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtName;
        private System.Windows.Forms.ComboBox comCommunication;
        private System.Windows.Forms.ComboBox comDeviceType;
        private LJH.GeneralLibrary.WinformControl.DBCTextBox txtSerial;
        private System.Windows.Forms.CheckBox chkForAttendance;
        private System.Windows.Forms.Label label12;
        private Controls.VerifyCodeComboBox verifyCodeComboBox1;
    }
}