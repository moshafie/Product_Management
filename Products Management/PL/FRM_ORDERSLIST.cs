using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports;

namespace Products_Management.PL
{
    public partial class FRM_ORDERSLIST : Form
    {
        BL.CLS_ORDERS ORDERS = new BL.CLS_ORDERS();
        public FRM_ORDERSLIST()
        {
            InitializeComponent();
            this.DGORDERSSEARCH.DataSource = ORDERS.SERCH_OREDERS("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int Order_ID = Convert.ToInt32(DGORDERSSEARCH.CurrentRow.Cells[0].Value);
            RPT.CrystalReport1 OrderReport = new RPT.CrystalReport1();
            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            OrderReport.SetParameterValue("@id_order", Order_ID);
            frm.crystalReportViewer1.ReportSource = OrderReport;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGORDERSSEARCH.DataSource = ORDERS.SERCH_OREDERS(textBox1.Text);
            }
            catch {
                return;
            }
        }

    }
}
