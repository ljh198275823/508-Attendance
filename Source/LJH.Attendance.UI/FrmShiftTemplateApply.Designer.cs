namespace LJH.Attendance.UI
{
    partial class FrmShiftTemplateApply
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtShiftTemplate = new LJH.GeneralLibrary.WinformControl.DBCTextBox(this.components);
            this.lnkTemplate = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ucDateTimeInterval1 = new LJH.Attendance.UI.UCDateTimeInterval();
            this.departmentTreeview1 = new LJH.Attendance.UI.DepartmentTreeview(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.departmentTreeview1);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 388);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "应用到人员";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(178, 146);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(69, 146);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtShiftTemplate
            // 
            this.txtShiftTemplate.Enabled = false;
            this.txtShiftTemplate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtShiftTemplate.Location = new System.Drawing.Point(47, 19);
            this.txtShiftTemplate.Name = "txtShiftTemplate";
            this.txtShiftTemplate.Size = new System.Drawing.Size(215, 21);
            this.txtShiftTemplate.TabIndex = 23;
            // 
            // lnkTemplate
            // 
            this.lnkTemplate.AutoSize = true;
            this.lnkTemplate.Location = new System.Drawing.Point(12, 23);
            this.lnkTemplate.Name = "lnkTemplate";
            this.lnkTemplate.Size = new System.Drawing.Size(29, 12);
            this.lnkTemplate.TabIndex = 24;
            this.lnkTemplate.TabStop = true;
            this.lnkTemplate.Text = "模板";
            this.lnkTemplate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTemplate_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "排班日期";
            // 
            // ucDateTimeInterval1
            // 
            this.ucDateTimeInterval1.EndDateTime = new System.DateTime(2013, 10, 7, 23, 20, 43, 65);
            this.ucDateTimeInterval1.Location = new System.Drawing.Point(47, 74);
            this.ucDateTimeInterval1.Name = "ucDateTimeInterval1";
            this.ucDateTimeInterval1.Size = new System.Drawing.Size(215, 56);
            this.ucDateTimeInterval1.StartDateTime = new System.DateTime(2013, 10, 7, 23, 20, 43, 81);
            this.ucDateTimeInterval1.TabIndex = 25;
            // 
            // departmentTreeview1
            // 
            this.departmentTreeview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTreeview1.CheckBoxes = true;
            this.departmentTreeview1.LoadUser = false;
            this.departmentTreeview1.Location = new System.Drawing.Point(6, 22);
            this.departmentTreeview1.Name = "departmentTreeview1";
            this.departmentTreeview1.OnlyShowCurrentOperatorDepts = false;
            this.departmentTreeview1.Size = new System.Drawing.Size(278, 359);
            this.departmentTreeview1.TabIndex = 3;
            // 
            // FrmShiftTemplateApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 418);
            this.Controls.Add(this.ucDateTimeInterval1);
            this.Controls.Add(this.txtShiftTemplate);
            this.Controls.Add(this.lnkTemplate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmShiftTemplateApply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "应用排班模板";
            this.Load += new System.EventHandler(this.FrmShiftTemplateApply_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DepartmentTreeview departmentTreeview1;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnOk;
        private GeneralLibrary.WinformControl.DBCTextBox txtShiftTemplate;
        private System.Windows.Forms.LinkLabel lnkTemplate;
        private System.Windows.Forms.Label label4;
        private UCDateTimeInterval ucDateTimeInterval1;
    }
}