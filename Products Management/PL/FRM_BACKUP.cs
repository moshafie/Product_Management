using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Products_Management.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public FRM_BACKUP()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.MODE;
            if (mode == "sql")
            {
                con = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER +
                    "; Database=" + Properties.Settings.Default.DATABASE +
                    "; integrated security=false;userid=" + Properties.Settings.Default.USERID +
                    "password=" + Properties.Settings.Default.PASSWORD + "");
            }
            else
            {
                con = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER + "; Database=" + Properties.Settings.Default.DATABASE + "; integrated security=true");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncereat_Click(object sender, EventArgs e)
        {
            string FileName = txtpath.Text + "\\Product_DB" + DateTime.Now.ToShortDateString().Replace("/", "-") +"-" + DateTime.Now.ToLongTimeString().Replace(":", "-");
            string sqlquery = "Backup Database Product_DB to Disk='" + FileName + ".bak'";
            cmd = new SqlCommand(sqlquery,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء نسخه احتياطيه ", "انشاء نسخه احتياطيه", MessageBoxButtons.OK);
        }
    }
}
