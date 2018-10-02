namespace Products_Management.PL
{
    partial class FRM_Restor
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
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btncereat = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "حفظ النسخه الاحتياطيه";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(225, 65);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(339, 24);
            this.txtpath.TabIndex = 6;
            // 
            // btncereat
            // 
            this.btncereat.Location = new System.Drawing.Point(395, 147);
            this.btncereat.Name = "btncereat";
            this.btncereat.Size = new System.Drawing.Size(197, 23);
            this.btncereat.TabIndex = 3;
            this.btncereat.Text = "انشاء نسخه احتياطيه";
            this.btncereat.UseVisualStyleBackColor = true;
            this.btncereat.Click += new System.EventHandler(this.btncereat_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(598, 147);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(116, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "الغاء";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(570, 66);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(116, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FRM_Restor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btncereat);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Restor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استعادة النسخه الاحتياطيه ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btncereat;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}