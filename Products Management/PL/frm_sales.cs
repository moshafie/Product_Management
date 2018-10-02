using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace Products_Management.PL
{
    public partial class frm_sales : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable dt = new DataTable();

        void Calculate_Amount()
        {
            if (txtprice.Text != string.Empty && txtqnt.Text != string.Empty)
            {


                txttotalprice.Text = ( Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqnt.Text)).ToString();
            }
        }

        void Calculate_TotalAmount()
        {
            if (txtdiscond.Text != string.Empty)
            {
                double discount = Convert.ToDouble(txtdiscond.Text);
                double Amount = Convert.ToDouble(txttotalprice.Text);
                double Total_Amount = Amount - (Amount * (discount / 100));

                txttotalamount.Text = Total_Amount.ToString();
            }
        }


        


        void CreateDataTable()
        {
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكميه");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("نسبة الخصم(%)");
            dt.Columns.Add("المبلغ الاجمالى");
            DGPRODUCTORDER.DataSource = dt;

            //Add Button column to gridview 
        /*    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "بحث";
            btn.HeaderText = "اختيار منتج";
            btn.UseColumnTextForButtonValue = true;
            DGPRODUCTORDER.Columns.Insert(0, btn); */

        }
        void ClearBoxes ()
        {
            txtproduct.Clear();
            txtproductname.Clear();
            txtprice.Clear();
            txtqnt.Clear();
            txttotalprice.Clear();
            txtdiscond.Clear();
            txttotalamount.Clear();
            BTNChooes.Focus();

        
        }
        void ClearData()
        {
            TXTCUSTOMERID.Clear();
            TXTCUSTOMERNAME.Clear();
            TXTDESCRIPTION.Clear();
            TXTFAMILYNAME.Clear();
            TXTEMAIL.Clear();
            TXTPHONE.Clear();
            TXTORDER.Clear();
            TXTDESCRIPTION.Clear();
    
            ClearBoxes();
            dt.Clear();
           
            TXTsumtotals.Clear();
            PBcoustomer.Image = null;
            BTNNEW.Enabled = true;
            BTNSAVE.Enabled = false;
            BTNPRINT.Enabled = true;
           
        }
    

        public frm_sales()
        {
            InitializeComponent();
            CreateDataTable();
            resize();
            TXTSALESMANE.Text = Program.SalesMan;
        }

        private void frm_sales_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.TXTORDER.Text= order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            BTNNEW.Enabled = false;
            BTNPRINT.Enabled = true;
            BTNSAVE.Enabled = true;
            BTNDELETE.Enabled = true;

        }

        private void TXTORDER_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frm_customer_list frm = new frm_customer_list();
                frm.ShowDialog();
                this.TXTCUSTOMERID.Text = frm.DGCustomer.CurrentRow.Cells[0].Value.ToString();
                this.TXTCUSTOMERNAME.Text = frm.DGCustomer.CurrentRow.Cells[1].Value.ToString();
                this.TXTFAMILYNAME.Text = frm.DGCustomer.CurrentRow.Cells[2].Value.ToString();
                this.TXTPHONE.Text = frm.DGCustomer.CurrentRow.Cells[3].Value.ToString();
                this.TXTEMAIL.Text = frm.DGCustomer.CurrentRow.Cells[4].Value.ToString();
                byte[] pictuer = (byte[])frm.DGCustomer.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pictuer);
                PBcoustomer.Image = Image.FromStream(ms);
            }
            catch {
                return;
            }


        }

        void resize() {

            this.DGPRODUCTORDER.RowHeadersWidth = 137;
            this.DGPRODUCTORDER.Columns[0].Width = 87;
            this.DGPRODUCTORDER.Columns[1].Width = 114;
            this.DGPRODUCTORDER.Columns[2].Width = 114;
            this.DGPRODUCTORDER.Columns[3].Width = 114;
            this.DGPRODUCTORDER.Columns[4].Width = 114;
            this.DGPRODUCTORDER.Columns[5].Width = 114;
            this.DGPRODUCTORDER.Columns[6].Width = 114;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void المنتج_Click(object sender, EventArgs e)
        {

        }

        private void BTNChooes_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();

            txtproduct.Text=frm.DGproducts.CurrentRow.Cells[0].Value.ToString();
            txtproductname.Text = frm.DGproducts.CurrentRow.Cells[1].Value.ToString();
            txtprice.Text = frm.DGproducts.CurrentRow.Cells[3].Value.ToString();
            txtqnt.Focus();
            
           
           

                
        }

        private void txtqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter && txtprice.Text != string.Empty)
            {
                TXTsumtotals.Focus();
                
            }
        }

        private void txtqnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqnt.Text != string.Empty)
            {
                txtdiscond.Focus();

            }
        }

        private void txtqnt_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate_Amount();
            Calculate_TotalAmount();
        }

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate_Amount();
            Calculate_TotalAmount();
        }

        private void txtdiscond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtdiscond_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate_TotalAmount();
        }

        private void txtdiscond_KeyDown(object sender, KeyEventArgs e)
        {
           
          
            if (e.KeyCode==Keys.Enter)
            {
                if (order.VERIFY_QNT(txtproduct.Text, Convert.ToInt32(txtqnt.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("هذه الكميه غير متاحه", "تنبيه  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0;i < DGPRODUCTORDER.Rows.Count - 1; i++)
                {

                    if (DGPRODUCTORDER.Rows[i].Cells[0].ToString()==txtproduct.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله", "تنبيه  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }             
                }


                DataRow DR = dt.NewRow();
                DR[0] = txtproduct.Text;
                DR[1] = txtproductname.Text;
                DR[2] = txtprice.Text;
                DR[3] = txtqnt.Text;             
                DR[4] = txttotalprice.Text;
                DR[5] = txtdiscond.Text;
                DR[6] = txttotalamount.Text;

                dt.Rows.Add(DR);
                DGPRODUCTORDER.DataSource = dt;
                ClearBoxes();

                TXTsumtotals.Text = (from DataGridViewRow row in DGPRODUCTORDER.Rows
                                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

            }
          
        }

        private void DGPRODUCTORDER_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtproduct.Text = this.DGPRODUCTORDER.CurrentRow.Cells[0].Value.ToString();
                txtproductname.Text = this.DGPRODUCTORDER.CurrentRow.Cells[1].Value.ToString();
                txtprice.Text = this.DGPRODUCTORDER.CurrentRow.Cells[2].Value.ToString();
                txtqnt.Text = this.DGPRODUCTORDER.CurrentRow.Cells[3].Value.ToString();
                txttotalprice.Text = this.DGPRODUCTORDER.CurrentRow.Cells[4].Value.ToString();
                txtdiscond.Text = this.DGPRODUCTORDER.CurrentRow.Cells[5].Value.ToString();
                txttotalamount.Text = this.DGPRODUCTORDER.CurrentRow.Cells[6].Value.ToString();
                DGPRODUCTORDER.Rows.RemoveAt(DGPRODUCTORDER.CurrentRow.Index);
                txtqnt.Focus();
            }
            catch
            {
                
                return;
            }
        }

        private void DGPRODUCTORDER_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TXTsumtotals.Text = (from DataGridViewRow row in DGPRODUCTORDER.Rows
                                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGPRODUCTORDER_DoubleClick(sender, e);
        }

        private void حذفالسطرالحالىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGPRODUCTORDER.Rows.RemoveAt(DGPRODUCTORDER.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            DGPRODUCTORDER.Refresh();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            if ( TXTCUSTOMERID.Text==string.Empty ||  DGPRODUCTORDER.Rows.Count <=1 )
            {
                MessageBox.Show("يجب تسجيل البينات بالكامل ", "تنبيه", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            order.ADD_ORDER(Convert.ToInt32(TXTORDER.Text), DATETIMEORDER.Value, Convert.ToInt32(TXTCUSTOMERID.Text), TXTDESCRIPTION.Text, TXTSALESMANE.Text);

            for (int i = 0; i < DGPRODUCTORDER.Rows.Count-1; i++)
            {
                order.ADD_ORDER_DETAILS(DGPRODUCTORDER.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(TXTORDER.Text),
                    Convert.ToInt32(DGPRODUCTORDER.Rows[i].Cells[3].Value),
                    DGPRODUCTORDER.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt32(DGPRODUCTORDER.Rows[i].Cells[5].Value),
                    DGPRODUCTORDER.Rows[i].Cells[4].Value.ToString(),
                    DGPRODUCTORDER.Rows[i].Cells[6].Value.ToString()
                    );
            }

           
            //RPT.CrystalReport1 OrderReport = new RPT.CrystalReport1();
            //OrderReport.SetParameterValue("@id_order", Convert.ToInt32(TXTORDER.Text));
            //RPT.FRM_RPT frm = new RPT.FRM_RPT();
            //frm.crystalReportViewer1.ReportSource = OrderReport;
            //frm.ShowDialog();
            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK);
            ClearData();
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int Order_ID =Convert.ToInt32( order.GET_LAST_ORDER_ID_For_Print().Rows[0][0]);
            RPT.CrystalReport1 OrderReport = new RPT.CrystalReport1();
            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            OrderReport.SetParameterValue("@id_order", Order_ID);           
            frm.crystalReportViewer1.ReportSource = OrderReport;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
        
    }
}
