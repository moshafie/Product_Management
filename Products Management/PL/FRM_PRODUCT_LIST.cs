using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.cls_product prd = new BL.cls_product();
        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.DGproducts.DataSource = prd.GET_ALL_PRODUCTS();

        }

        private void DGproducts_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
