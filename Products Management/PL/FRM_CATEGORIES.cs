using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace Products_Management.PL
{
    public partial class FRM_CATEGORIES : Form
       
    {
        
        SqlConnection SQLCON;

       
        
           
        

        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmbd;
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.MODE;
            if (mode == "sql")
            {
                SQLCON = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER +
                    "; Database=" + Properties.Settings.Default.DATABASE +
                    "; integrated security=false;userid=" + Properties.Settings.Default.USERID +
                    "password=" + Properties.Settings.Default.PASSWORD + "");
            }
            else
            {
                SQLCON = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER + "; Database=" + Properties.Settings.Default.DATABASE + "; integrated security=true");
            }
            da = new SqlDataAdapter("SELECT ID_CAT as'المعرف', DESCRIPTION_CAT as 'اسم الصنف' FROM CATEGORIS ", SQLCON);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtID.DataBindings.Add("text",dt, "المعرف");
            txtName.DataBindings.Add("text",dt, "اسم الصنف");
            bmb = this.BindingContext[dt];
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void FRM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void first_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void last_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblposition.Text = (bmb.Position +1) + "/" + bmb.Count;
        }

        private void prev_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void next_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnadd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text = id.ToString();
            txtName.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("added successfully", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnadd.Enabled = false;
            btnNew.Enabled = true;
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you suregg", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               bmb.RemoveAt(bmb.Position);
            cmbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("delete successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count; 
            }
            
        }

        private void btnubdat_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Edit successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblposition.Text = (bmb.Position + 1) + "/" + bmb.Count; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RPT.rpt_singl_categories rpt = new RPT.rpt_singl_categories();
            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            rpt.SetParameterValue("@ID", Convert.ToInt32(txtID.Text));
            frm.crystalReportViewer1.ReportSource = rpt;
          
            frm.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            RPT.GET_ALL_CATEGORIES rpt = new RPT.GET_ALL_CATEGORIES();
            RPT.FRM_RPT frm = new RPT.FRM_RPT();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RPT.GET_ALL_CATEGORIES myreport = new RPT.GET_ALL_CATEGORIES();
            //creat export options
            ExportOptions export = new ExportOptions();

            //creat object for destination
            DiskFileDestinationOptions Pdfoptions = new DiskFileDestinationOptions();

            PdfFormatOptions PDFformat = new PdfFormatOptions();
            //
            Pdfoptions.DiskFileName = @"D:\CATEGORIESlist.PDF";

            export = myreport.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            export.ExportFormatOptions = PDFformat;

            export.ExportDestinationOptions = Pdfoptions;
            myreport.Refresh();
            myreport.Export();

            MessageBox.Show("list exported successfully !", "export", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            RPT.rpt_singl_categories myreport2 = new RPT.rpt_singl_categories();
            //creat export options
            ExportOptions export = new ExportOptions();

            //creat object for destination
            DiskFileDestinationOptions Pdfoptions = new DiskFileDestinationOptions();

            PdfFormatOptions PDFformat = new PdfFormatOptions();
            //
            Pdfoptions.DiskFileName = @"D:\CATEGORIESlistdetales.PDF";

            export = myreport2.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            export.ExportFormatOptions = PDFformat;

            export.ExportDestinationOptions = Pdfoptions;

            myreport2.Refresh();
            myreport2.SetParameterValue("@ID", Convert.ToInt32(txtID.Text));

            myreport2.Export();

            MessageBox.Show("list exported successfully !", "export", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }


      
   

    

    

     
    }
}
