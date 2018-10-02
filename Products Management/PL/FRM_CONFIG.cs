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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            TXTSERVERNAME.Text = Properties.Settings.Default.SERVER;
            TXTDATABASENAME.Text = Properties.Settings.Default.DATABASE;
           
            if (  Properties.Settings.Default.MODE=="SQL")
            {
                RBSQLSERVER.Checked = true;
                TXTUSERID.Text = Properties.Settings.Default.USERID;
                TXTPASSWORD.Text = Properties.Settings.Default.PASSWORD;
            }
            else
            {
                RBWINDOWS.Checked = true;
                 TXTPASSWORD.Clear();
                 TXTUSERID.Clear();
                 TXTUSERID.ReadOnly = true;
                 TXTPASSWORD.ReadOnly = true;
            }
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SERVER = TXTSERVERNAME.Text;
            Properties.Settings.Default.DATABASE = TXTDATABASENAME.Text;
            Properties.Settings.Default.MODE = RBSQLSERVER.Checked == true ? "SQL" : "WINDOWS";
            Properties.Settings.Default.USERID = TXTUSERID.Text;
            Properties.Settings.Default.PASSWORD = TXTPASSWORD.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات الجديده بنجاح", "اعدادت السيرفر", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RBSQLSERVER_CheckedChanged(object sender, EventArgs e)
        {
            TXTSERVERNAME.ReadOnly = false;
            TXTPASSWORD.ReadOnly = false;
            TXTUSERID.ReadOnly = false;
        }

        private void RBWINDOWS_CheckedChanged(object sender, EventArgs e)
        {
            TXTSERVERNAME.ReadOnly = true;
            TXTPASSWORD.ReadOnly = true;
            TXTUSERID.ReadOnly = true;
        }

        private void BTNCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
