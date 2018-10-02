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
   
    public partial class FRM_LOGEN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGEN()
        {
            InitializeComponent();
        }

        private void FRM_LOGEN_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtname.Text, txtpwd.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString()=="admin")
                {
                       frm_main.getmainform.استعادةنسخهمحفوظهToolStripMenuItem.Enabled = true;
                frm_main.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                frm_main.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
                frm_main.getmainform.انشاءنسخهاحطيToolStripMenuItem.Enabled = true;
                frm_main.getmainform.العملاءToolStripMenuItem.Enabled = true;
                frm_main.getmainform.المنتجاتToolStripMenuItem.Visible = true;
                Program.SalesMan = dt.Rows[0]["USERNAME"].ToString();
                this.Close();
                }
                else if (dt.Rows[0][2].ToString()=="user")
                {
                       frm_main.getmainform.استعادةنسخهمحفوظهToolStripMenuItem.Enabled = true;
                frm_main.getmainform.المستخدمونToolStripMenuItem.Enabled = false;
                frm_main.getmainform.المنتجاتToolStripMenuItem.Visible = false;
                frm_main.getmainform.انشاءنسخهاحطيToolStripMenuItem.Enabled = true;
                frm_main.getmainform.العملاءToolStripMenuItem.Enabled = true;
                Program.SalesMan = dt.Rows[0]["USERNAME"].ToString();
                this.Close();
                }

            }
            else {
                MessageBox.Show("login faild!");
                 }
        }

    

     
    }
}
