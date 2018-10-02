namespace Products_Management.PL
{
    partial class FRM_CONFIG
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
            this.TXTSERVERNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTDATABASENAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RBWINDOWS = new System.Windows.Forms.RadioButton();
            this.RBSQLSERVER = new System.Windows.Forms.RadioButton();
            this.TXTUSERID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.BTNCLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTSERVERNAME
            // 
            this.TXTSERVERNAME.Location = new System.Drawing.Point(159, 28);
            this.TXTSERVERNAME.Name = "TXTSERVERNAME";
            this.TXTSERVERNAME.Size = new System.Drawing.Size(226, 24);
            this.TXTSERVERNAME.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم السيرفر";
            // 
            // TXTDATABASENAME
            // 
            this.TXTDATABASENAME.Location = new System.Drawing.Point(159, 66);
            this.TXTDATABASENAME.Name = "TXTDATABASENAME";
            this.TXTDATABASENAME.Size = new System.Drawing.Size(226, 24);
            this.TXTDATABASENAME.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "قاعدة البينات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "طريقة الدخول للسيرفر";
            // 
            // RBWINDOWS
            // 
            this.RBWINDOWS.AutoSize = true;
            this.RBWINDOWS.Location = new System.Drawing.Point(172, 157);
            this.RBWINDOWS.Name = "RBWINDOWS";
            this.RBWINDOWS.Size = new System.Drawing.Size(213, 21);
            this.RBWINDOWS.TabIndex = 2;
            this.RBWINDOWS.Text = "WINDOWS AUTHENTICATION";
            this.RBWINDOWS.UseVisualStyleBackColor = true;
            this.RBWINDOWS.CheckedChanged += new System.EventHandler(this.RBWINDOWS_CheckedChanged);
            // 
            // RBSQLSERVER
            // 
            this.RBSQLSERVER.AutoSize = true;
            this.RBSQLSERVER.Checked = true;
            this.RBSQLSERVER.Location = new System.Drawing.Point(172, 184);
            this.RBSQLSERVER.Name = "RBSQLSERVER";
            this.RBSQLSERVER.Size = new System.Drawing.Size(231, 21);
            this.RBSQLSERVER.TabIndex = 2;
            this.RBSQLSERVER.TabStop = true;
            this.RBSQLSERVER.Text = "SQL SERVERE AUTHENTICATION";
            this.RBSQLSERVER.UseVisualStyleBackColor = true;
            this.RBSQLSERVER.CheckedChanged += new System.EventHandler(this.RBSQLSERVER_CheckedChanged);
            // 
            // TXTUSERID
            // 
            this.TXTUSERID.Location = new System.Drawing.Point(159, 242);
            this.TXTUSERID.Name = "TXTUSERID";
            this.TXTUSERID.ReadOnly = true;
            this.TXTUSERID.Size = new System.Drawing.Size(226, 24);
            this.TXTUSERID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "اسم الامستخدم ";
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.Location = new System.Drawing.Point(159, 280);
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.PasswordChar = '*';
            this.TXTPASSWORD.ReadOnly = true;
            this.TXTPASSWORD.Size = new System.Drawing.Size(226, 24);
            this.TXTPASSWORD.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "كلمة المرور";
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Location = new System.Drawing.Point(159, 383);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(107, 26);
            this.BTNSAVE.TabIndex = 3;
            this.BTNSAVE.Text = "حفظ الاعدادات";
            this.BTNSAVE.UseVisualStyleBackColor = true;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // BTNCLOSE
            // 
            this.BTNCLOSE.Location = new System.Drawing.Point(292, 383);
            this.BTNCLOSE.Name = "BTNCLOSE";
            this.BTNCLOSE.Size = new System.Drawing.Size(107, 26);
            this.BTNCLOSE.TabIndex = 3;
            this.BTNCLOSE.Text = "خروج";
            this.BTNCLOSE.UseVisualStyleBackColor = true;
            this.BTNCLOSE.Click += new System.EventHandler(this.BTNCLOSE_Click);
            // 
            // FRM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 441);
            this.Controls.Add(this.BTNCLOSE);
            this.Controls.Add(this.BTNSAVE);
            this.Controls.Add(this.RBSQLSERVER);
            this.Controls.Add(this.RBWINDOWS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.TXTDATABASENAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTUSERID);
            this.Controls.Add(this.TXTSERVERNAME);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CONFIG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادت السيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTSERVERNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTDATABASENAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RBWINDOWS;
        private System.Windows.Forms.RadioButton RBSQLSERVER;
        private System.Windows.Forms.TextBox TXTUSERID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.Button BTNCLOSE;
    }
}