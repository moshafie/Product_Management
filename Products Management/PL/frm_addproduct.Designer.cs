namespace Products_Management.PL
{
    partial class frm_addproduct
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
            this.cmbcategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtpric = new System.Windows.Forms.TextBox();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.txtref = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "الصنف : ";
            // 
            // cmbcategories
            // 
            this.cmbcategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategories.FormattingEnabled = true;
            this.cmbcategories.Location = new System.Drawing.Point(86, 34);
            this.cmbcategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbcategories.Name = "cmbcategories";
            this.cmbcategories.Size = new System.Drawing.Size(230, 24);
            this.cmbcategories.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnexite);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtdes);
            this.groupBox1.Controls.Add(this.txtpric);
            this.groupBox1.Controls.Add(this.txtqte);
            this.groupBox1.Controls.Add(this.txtref);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbcategories);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(614, 673);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بينات المنتج";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(215, 613);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 49);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnexite
            // 
            this.btnexite.Location = new System.Drawing.Point(38, 613);
            this.btnexite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnexite.Name = "btnexite";
            this.btnexite.Size = new System.Drawing.Size(103, 49);
            this.btnexite.TabIndex = 8;
            this.btnexite.Text = "الغاء";
            this.btnexite.UseVisualStyleBackColor = true;
            this.btnexite.Click += new System.EventHandler(this.btnexite_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(86, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "تحديث ملف الصوره";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 384);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(86, 154);
            this.txtdes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(230, 86);
            this.txtdes.TabIndex = 3;
            // 
            // txtpric
            // 
            this.txtpric.Location = new System.Drawing.Point(86, 321);
            this.txtpric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpric.Name = "txtpric";
            this.txtpric.Size = new System.Drawing.Size(230, 24);
            this.txtpric.TabIndex = 5;
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(86, 267);
            this.txtqte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(230, 24);
            this.txtqte.TabIndex = 4;
            // 
            // txtref
            // 
            this.txtref.Location = new System.Drawing.Point(86, 90);
            this.txtref.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(230, 24);
            this.txtref.TabIndex = 1;
            this.txtref.Validated += new System.EventHandler(this.txtref_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "صورة المنتج";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ثمن المنتج";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "الكميه المخزنه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "وصف المنتج :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "معرف المنتج :";
            // 
            // frm_addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_addproduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة منتج جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbcategories;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtdes;
        public System.Windows.Forms.TextBox txtpric;
        public System.Windows.Forms.TextBox txtqte;
        public System.Windows.Forms.TextBox txtref;
    }
}