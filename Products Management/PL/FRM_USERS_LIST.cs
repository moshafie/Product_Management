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
    public partial class FRM_USERS_LIST : Form
    {
        BL.CLS_LOGIN USERS = new BL.CLS_LOGIN();
        public FRM_USERS_LIST()
        {
            InitializeComponent();
            this.DGUSERS.DataSource = USERS.SEARCHUSER("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.BTNSAVE.Text = "حفظ";
            FRM.ShowDialog();
            this.DGUSERS.DataSource = USERS.SEARCHUSER("");
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.txtusername.Text = DGUSERS.CurrentRow.Cells[0].Value.ToString();
            FRM.txtpasswored.Text = DGUSERS.CurrentRow.Cells[1].Value.ToString();
            FRM.txtpassworedconferm.Text = DGUSERS.CurrentRow.Cells[1].Value.ToString();
            FRM.combusertyp.Text = DGUSERS.CurrentRow.Cells[3].Value.ToString();
            FRM.txtfulusername.Text = DGUSERS.CurrentRow.Cells[2].Value.ToString();
            FRM.BTNSAVE.Text = "تعديل";
            FRM.ShowDialog();
            this.DGUSERS.DataSource = USERS.SEARCHUSER("");
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            this.DGUSERS.DataSource = USERS.SEARCHUSER(TXTSEARCH.Text);
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            string Deleteuser = DGUSERS.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("هل تريد حذف المستخدم","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                USERS.DELETEUSER(Deleteuser);
            this.DGUSERS.DataSource = USERS.SEARCHUSER("");
            }
            
        }
    }
}
