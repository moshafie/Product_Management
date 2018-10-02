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
    public partial class frm_main : Form
    {
        //single instand to handler 
        private static frm_main frm;
        static void frm_formclosd(object sender, FormClosedEventArgs e)
        {

            frm = null;
        }
        public static frm_main getmainform 
        {

            get {

                if (frm == null)
                {
                    frm = new frm_main();
                    frm.FormClosed+= new FormClosedEventHandler(frm_formclosd);
                
                }
                return frm;
            
            
            }
        
        }

        public frm_main()
        {
            InitializeComponent();


            if (frm == null)
                frm = this;

            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحطيToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled= false;
            this.انشاءنسخهاحطيToolStripMenuItem.Enabled = false;
            this.استعادةنسخهمحفوظهToolStripMenuItem.Enabled = false;

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGEN frm = new FRM_LOGEN();
            frm.Show();
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addproduct frm = new frm_addproduct();
            frm.Show();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ادارةالمنتجاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT frm = new FRM_PRODUCT();
            frm.Show();

        }

        private void ادارةالصنفالجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES FRM = new FRM_CATEGORIES();
            FRM.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void اضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS FRM = new FRM_CUSTOMERS();
            FRM.ShowDialog();
        }

        private void اضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sales frm = new frm_sales();
            frm.Show();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERSLIST  FRM = new FRM_ORDERSLIST();
            FRM.ShowDialog();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USERS_LIST FRM = new FRM_USERS_LIST();
            FRM.ShowDialog();
        }

        private void انشاءنسخهاحطيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS FRM = new FRM_CUSTOMERS();
            FRM.ShowDialog();
        }

        private void استعادةنسخهمحفوظهToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRM_Restor FRM = new FRM_Restor();
            FRM.ShowDialog();
        }

        private void اعداداتالاتصالبالسيرفيرToolStripMenuItem_Click(object sender, EventArgs e)
        {

           FRM_CONFIG FRM = new FRM_CONFIG();
            FRM.ShowDialog();
        }

      
    }
}
