namespace Products_Management.PL
{
    partial class FRM_PRODUCT_LIST
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
            this.DGproducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DGproducts
            // 
            this.DGproducts.AllowUserToAddRows = false;
            this.DGproducts.AllowUserToDeleteRows = false;
            this.DGproducts.AllowUserToResizeColumns = false;
            this.DGproducts.AllowUserToResizeRows = false;
            this.DGproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGproducts.Location = new System.Drawing.Point(0, 0);
            this.DGproducts.MultiSelect = false;
            this.DGproducts.Name = "DGproducts";
            this.DGproducts.ReadOnly = true;
            this.DGproducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGproducts.RowTemplate.Height = 26;
            this.DGproducts.Size = new System.Drawing.Size(990, 633);
            this.DGproducts.TabIndex = 0;
            this.DGproducts.DoubleClick += new System.EventHandler(this.DGproducts_DoubleClick);
            // 
            // FRM_PRODUCT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 633);
            this.Controls.Add(this.DGproducts);
            this.Name = "FRM_PRODUCT_LIST";
            this.Text = "قائمة المنتجات ";
            ((System.ComponentModel.ISupportInitialize)(this.DGproducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGproducts;

    }
}