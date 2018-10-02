namespace Products_Management.PL
{
    partial class frm_customer_list
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
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCustomer
            // 
            this.DGCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCustomer.Location = new System.Drawing.Point(0, 0);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.RowTemplate.Height = 26;
            this.DGCustomer.Size = new System.Drawing.Size(528, 373);
            this.DGCustomer.TabIndex = 0;
            this.DGCustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCustomer_CellContentDoubleClick);
            // 
            // frm_customer_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 373);
            this.Controls.Add(this.DGCustomer);
            this.Name = "frm_customer_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لائحة جميع العملاء ";
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGCustomer;

    }
}