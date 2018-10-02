namespace Products_Management.PL
{
    partial class FRM_ADD_USER
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.combusertyp = new System.Windows.Forms.ComboBox();
            this.txtpassworedconferm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpasswored = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfulusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BTNSAVE);
            this.groupBox1.Controls.Add(this.combusertyp);
            this.groupBox1.Controls.Add(this.txtpassworedconferm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpasswored);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfulusername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بينات المستخدم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "*error";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Location = new System.Drawing.Point(180, 286);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(128, 42);
            this.BTNSAVE.TabIndex = 5;
            this.BTNSAVE.Text = "حفظ";
            this.BTNSAVE.UseVisualStyleBackColor = true;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // combusertyp
            // 
            this.combusertyp.FormattingEnabled = true;
            this.combusertyp.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.combusertyp.Location = new System.Drawing.Point(49, 207);
            this.combusertyp.Name = "combusertyp";
            this.combusertyp.Size = new System.Drawing.Size(280, 24);
            this.combusertyp.TabIndex = 4;
            // 
            // txtpassworedconferm
            // 
            this.txtpassworedconferm.Location = new System.Drawing.Point(49, 163);
            this.txtpassworedconferm.Name = "txtpassworedconferm";
            this.txtpassworedconferm.PasswordChar = '*';
            this.txtpassworedconferm.Size = new System.Drawing.Size(280, 24);
            this.txtpassworedconferm.TabIndex = 3;
            this.txtpassworedconferm.Validated += new System.EventHandler(this.txtpassworedconferm_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "كلمة السر";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpasswored
            // 
            this.txtpasswored.Location = new System.Drawing.Point(49, 133);
            this.txtpasswored.Name = "txtpasswored";
            this.txtpasswored.PasswordChar = '*';
            this.txtpasswored.Size = new System.Drawing.Size(280, 24);
            this.txtpasswored.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "الصلاحيات";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = " تأكيد كلمة السر";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtfulusername
            // 
            this.txtfulusername.Location = new System.Drawing.Point(49, 103);
            this.txtfulusername.Name = "txtfulusername";
            this.txtfulusername.Size = new System.Drawing.Size(280, 24);
            this.txtfulusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم بالكامل";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(49, 59);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(280, 24);
            this.txtusername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FRM_ADD_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 423);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_ADD_USER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button BTNSAVE;
        public System.Windows.Forms.TextBox txtusername;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox combusertyp;
        public System.Windows.Forms.TextBox txtpassworedconferm;
        public System.Windows.Forms.TextBox txtpasswored;
        public System.Windows.Forms.TextBox txtfulusername;
    }
}