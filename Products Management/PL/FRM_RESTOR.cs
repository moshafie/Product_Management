﻿using System;
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
    public partial class FRM_Restor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public FRM_Restor()
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = openFileDialog1.FileName;
            }
        }

        private void btncereat_Click(object sender, EventArgs e)
        {
            string StrQuery = "Alter Database Product_DB Set Offline With RollBack immediate; Restore Database Product_DB From Disk='" + txtpath.Text + "' WITH REPLACE;";
            cmd = new SqlCommand(StrQuery,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخه الاحتياطيه ", "استعادة النسخه الاحتياطيه ", MessageBoxButtons.OK);
        }

        

    }
}
