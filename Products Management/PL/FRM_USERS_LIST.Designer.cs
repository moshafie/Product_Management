namespace Products_Management.PL
{
    partial class FRM_USERS_LIST
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
            this.DGUSERS = new System.Windows.Forms.DataGridView();
            this.BTNEXIT = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGUSERS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGUSERS
            // 
            this.DGUSERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUSERS.Location = new System.Drawing.Point(12, 72);
            this.DGUSERS.Name = "DGUSERS";
            this.DGUSERS.RowTemplate.Height = 26;
            this.DGUSERS.Size = new System.Drawing.Size(957, 349);
            this.DGUSERS.TabIndex = 0;
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.Location = new System.Drawing.Point(661, 451);
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(181, 30);
            this.BTNEXIT.TabIndex = 1;
            this.BTNEXIT.Text = "خروج";
            this.BTNEXIT.UseVisualStyleBackColor = true;
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Location = new System.Drawing.Point(483, 451);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(172, 30);
            this.BTNDELETE.TabIndex = 2;
            this.BTNDELETE.Text = "حذف";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Location = new System.Drawing.Point(308, 451);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(169, 30);
            this.BTNUPDATE.TabIndex = 3;
            this.BTNUPDATE.Text = "تعديل";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.Location = new System.Drawing.Point(130, 451);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(172, 30);
            this.BTNADD.TabIndex = 4;
            this.BTNADD.Text = "اضافة مستخدم جديد";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Location = new System.Drawing.Point(348, 36);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(373, 24);
            this.TXTSEARCH.TabIndex = 5;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "SEARCH :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FRM_USERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.BTNUPDATE);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNEXIT);
            this.Controls.Add(this.DGUSERS);
            this.Name = "FRM_USERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FRM_USERS_LIST";
            ((System.ComponentModel.ISupportInitialize)(this.DGUSERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGUSERS;
        private System.Windows.Forms.Button BTNEXIT;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.TextBox TXTSEARCH;
        private System.Windows.Forms.Label label1;
    }
}