namespace LJH.Attendance.UI
{
    partial class FrmShiftResultDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtCertificate = new System.Windows.Forms.TextBox();
            this.txtShiftTime = new System.Windows.Forms.TextBox();
            this.txtRealTime = new System.Windows.Forms.TextBox();
            this.cmbShiftResult = new System.Windows.Forms.ComboBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShiftDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(246, 264);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 264);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "部门";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "员工编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "应上下班时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "实上下班时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "考勤结果";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "上次修改操作员";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "备注";
            // 
            // txtDept
            // 
            this.txtDept.Enabled = false;
            this.txtDept.Location = new System.Drawing.Point(13, 29);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(191, 21);
            this.txtDept.TabIndex = 10;
            // 
            // txtCertificate
            // 
            this.txtCertificate.Enabled = false;
            this.txtCertificate.Location = new System.Drawing.Point(13, 68);
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.Size = new System.Drawing.Size(191, 21);
            this.txtCertificate.TabIndex = 12;
            // 
            // txtShiftTime
            // 
            this.txtShiftTime.Enabled = false;
            this.txtShiftTime.Location = new System.Drawing.Point(13, 148);
            this.txtShiftTime.Name = "txtShiftTime";
            this.txtShiftTime.Size = new System.Drawing.Size(191, 21);
            this.txtShiftTime.TabIndex = 13;
            // 
            // txtRealTime
            // 
            this.txtRealTime.Enabled = false;
            this.txtRealTime.Location = new System.Drawing.Point(223, 148);
            this.txtRealTime.Name = "txtRealTime";
            this.txtRealTime.Size = new System.Drawing.Size(191, 21);
            this.txtRealTime.TabIndex = 14;
            // 
            // cmbShiftResult
            // 
            this.cmbShiftResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftResult.FormattingEnabled = true;
            this.cmbShiftResult.Location = new System.Drawing.Point(13, 187);
            this.cmbShiftResult.Name = "cmbShiftResult";
            this.cmbShiftResult.Size = new System.Drawing.Size(191, 20);
            this.cmbShiftResult.TabIndex = 15;
            // 
            // txtOperator
            // 
            this.txtOperator.Enabled = false;
            this.txtOperator.Location = new System.Drawing.Point(223, 187);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(191, 21);
            this.txtOperator.TabIndex = 16;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(13, 229);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(401, 21);
            this.txtMemo.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(223, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 21);
            this.txtName.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "员工姓名";
            // 
            // txtShiftDate
            // 
            this.txtShiftDate.Enabled = false;
            this.txtShiftDate.Location = new System.Drawing.Point(14, 107);
            this.txtShiftDate.Name = "txtShiftDate";
            this.txtShiftDate.Size = new System.Drawing.Size(191, 21);
            this.txtShiftDate.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "考勤日期";
            // 
            // FrmShiftResultDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 299);
            this.Controls.Add(this.txtShiftDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.cmbShiftResult);
            this.Controls.Add(this.txtRealTime);
            this.Controls.Add(this.txtShiftTime);
            this.Controls.Add(this.txtCertificate);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmShiftResultDetail";
            this.Text = "考勤结果明细";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtDept, 0);
            this.Controls.SetChildIndex(this.txtCertificate, 0);
            this.Controls.SetChildIndex(this.txtShiftTime, 0);
            this.Controls.SetChildIndex(this.txtRealTime, 0);
            this.Controls.SetChildIndex(this.cmbShiftResult, 0);
            this.Controls.SetChildIndex(this.txtOperator, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtShiftDate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtCertificate;
        private System.Windows.Forms.TextBox txtShiftTime;
        private System.Windows.Forms.TextBox txtRealTime;
        private System.Windows.Forms.ComboBox cmbShiftResult;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShiftDate;
        private System.Windows.Forms.Label label11;
    }
}