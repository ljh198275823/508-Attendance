namespace LJH.Attendance.UI
{
    partial class FrmFingerResgister
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comBiosource = new System.Windows.Forms.ComboBox();
            this.rdVer10 = new System.Windows.Forms.RadioButton();
            this.rdVer9 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // comBiosource
            // 
            this.comBiosource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBiosource.FormattingEnabled = true;
            this.comBiosource.Items.AddRange(new object[] {
            "左手拇指",
            "左手食指",
            "左手中指",
            "左手无名指",
            "左手小指",
            "右手拇指",
            "右手食指",
            "右手中指",
            "右手无名指",
            "右手小指"});
            this.comBiosource.Location = new System.Drawing.Point(12, 12);
            this.comBiosource.Name = "comBiosource";
            this.comBiosource.Size = new System.Drawing.Size(114, 20);
            this.comBiosource.TabIndex = 10;
            // 
            // rdVer10
            // 
            this.rdVer10.AutoSize = true;
            this.rdVer10.Checked = true;
            this.rdVer10.Location = new System.Drawing.Point(151, 13);
            this.rdVer10.Name = "rdVer10";
            this.rdVer10.Size = new System.Drawing.Size(47, 16);
            this.rdVer10.TabIndex = 11;
            this.rdVer10.TabStop = true;
            this.rdVer10.Text = "10.0";
            this.rdVer10.UseVisualStyleBackColor = true;
            // 
            // rdVer9
            // 
            this.rdVer9.AutoSize = true;
            this.rdVer9.Location = new System.Drawing.Point(201, 13);
            this.rdVer9.Name = "rdVer9";
            this.rdVer9.Size = new System.Drawing.Size(41, 16);
            this.rdVer9.TabIndex = 12;
            this.rdVer9.Text = "9.0";
            this.rdVer9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // FrmFingerResgister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdVer9);
            this.Controls.Add(this.rdVer10);
            this.Controls.Add(this.comBiosource);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFingerResgister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "指纹登记";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFingerResgister_FormClosed);
            this.Load += new System.EventHandler(this.FrmFingerResgister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comBiosource;
        private System.Windows.Forms.RadioButton rdVer10;
        private System.Windows.Forms.RadioButton rdVer9;
        private System.Windows.Forms.Label label1;
    }
}