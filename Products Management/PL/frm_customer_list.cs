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
    public partial class frm_customer_list : Form
    {
        BL.CLS_Customer cust = new BL.CLS_Customer();
        public frm_customer_list()
        {
            InitializeComponent();
            this.DGCustomer.DataSource = cust.select_customer();
            this.DGCustomer.Columns[0].Visible = false;
            this.DGCustomer.Columns[5].Visible = false;

        }

        private void DGCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
