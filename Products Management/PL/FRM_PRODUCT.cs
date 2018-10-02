using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace Products_Management.PL
{
    public partial class FRM_PRODUCT : Form
    {
        private static FRM_PRODUCT frm;
        static void frm_formclosd(object sender, FormClosedEventArgs e)
        {

            frm = null;
        }
        public static FRM_PRODUCT getmainform
        {

            get
            {

                if (frm == null)
                {
                    frm = new FRM_PRODUCT();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosd);

                }
                return frm;


            }

        }



        BL.cls_product prd = new BL.cls_product();
        public FRM_PRODUCT()
        {
           
            InitializeComponent();
            if (frm == null)
                frm=this;
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_addproduct frm = new frm_addproduct();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.search_PRODUCT(shearchtxt.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج المحدد", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation ) == DialogResult.OK)
            {
                prd.Delete_Product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم حزف المنتج المحدد","", MessageBoxButtons.OK);
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
           
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "الغاء", MessageBoxButtons.OK);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_addproduct frm = new frm_addproduct();
            frm.txtref.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtdes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtpric.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbcategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtref.ReadOnly = true;
            frm.state = "ubdate";
            frm.Text = "تحديث المنتج" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnsave.Text = "تحديث";
            byte[]image=(byte[])prd.Get_Imag(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);

            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_Preview frm = new FRM_Preview();
            byte[] image = (byte[])prd.Get_Imag(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void FRM_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.rpt_product_singl MYREPORT = new RPT.rpt_product_singl();
            MYREPORT.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            frm.crystalReportViewer1.ReportSource = MYREPORT;
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_product MYREPORT = new RPT.rpt_all_product();
            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            frm.crystalReportViewer1.ReportSource = MYREPORT;
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_product myreport = new RPT.rpt_all_product();
            //creat export options
            ExportOptions export = new ExportOptions();
            
            //creat object for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            ExcelFormatOptions excelformat = new ExcelFormatOptions();
            //set the path of desyination
          
            dfoptions.DiskFileName = @"D:\producrslist.xls";

            export = myreport.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;
            
            export.ExportFormatType = ExportFormatType.Excel;

            export.ExportFormatOptions = excelformat;

            export.ExportDestinationOptions = dfoptions;

            myreport.Export();

            MessageBox.Show("list exported successfully !", "export", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

          
        }
    }
}
