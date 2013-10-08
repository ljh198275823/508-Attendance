namespace Ralid.Attendance.UI
{
    partial class FrmManualLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManualLog));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.txtTime2 = new System.Windows.Forms.DateTimePicker();
            this.txtTime1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemo = new Ralid.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.chkTime1 = new System.Windows.Forms.CheckBox();
            this.chkTime2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentTreeview1 = new Ralid.Attendance.UI.DepartmentTreeview(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(409, 194);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(300, 194);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "起止日期";
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.Location = new System.Drawing.Point(299, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(107, 21);
            this.dtStart.TabIndex = 11;
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.Location = new System.Drawing.Point(437, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(107, 21);
            this.dtEnd.TabIndex = 12;
            // 
            // txtTime2
            // 
            this.txtTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime2.CustomFormat = "HH:mm";
            this.txtTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTime2.Location = new System.Drawing.Point(388, 104);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(76, 21);
            this.txtTime2.TabIndex = 13;
            // 
            // txtTime1
            // 
            this.txtTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime1.CustomFormat = "HH:mm";
            this.txtTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTime1.Location = new System.Drawing.Point(388, 67);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(76, 21);
            this.txtTime1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "--";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "补签原因";
            // 
            // txtMemo
            // 
            this.txtMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMemo.Location = new System.Drawing.Point(299, 155);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(243, 21);
            this.txtMemo.TabIndex = 19;
            // 
            // chkTime1
            // 
            this.chkTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime1.AutoSize = true;
            this.chkTime1.Checked = true;
            this.chkTime1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTime1.Location = new System.Drawing.Point(299, 69);
            this.chkTime1.Name = "chkTime1";
            this.chkTime1.Size = new System.Drawing.Size(90, 16);
            this.chkTime1.TabIndex = 20;
            this.chkTime1.Text = "补签时间1：";
            this.chkTime1.UseVisualStyleBackColor = true;
            // 
            // chkTime2
            // 
            this.chkTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTime2.AutoSize = true;
            this.chkTime2.Location = new System.Drawing.Point(299, 106);
            this.chkTime2.Name = "chkTime2";
            this.chkTime2.Size = new System.Drawing.Size(90, 16);
            this.chkTime2.TabIndex = 21;
            this.chkTime2.Text = "补签时间2：";
            this.chkTime2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.departmentTreeview1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 330);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择人员";
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTreeview1.CheckBoxes = true;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(8, 17);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(264, 307);
            this.departmentTreeview1.TabIndex = 8;
            // 
            // FrmManualLog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(551, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTime2);
            this.Controls.Add(this.chkTime1);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTime1);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManualLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "补签";
            this.Load += new System.EventHandler(this.FrmManualLog_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker txtTime2;
        private System.Windows.Forms.DateTimePicker txtTime1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private GeneralLibrary.WinformControl.DBCTextBox txtMemo;
        private System.Windows.Forms.CheckBox chkTime1;
        private System.Windows.Forms.CheckBox chkTime2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DepartmentTreeview departmentTreeview1;
    }
}