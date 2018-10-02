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
    public partial class FRM_ADD_USER : Form
    {
        BL.CLS_LOGIN user = new BL.CLS_LOGIN();
        
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == string.Empty || txtpasswored.Text == string.Empty || txtpassworedconferm.Text == string.Empty)
            {

               
                MessageBox.Show("يجب ادخال بينات المستخدم بشكل صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            if (txtpasswored.Text != txtpassworedconferm.Text)
            {
                MessageBox.Show("برجاء ادخال كلمة السر بشكل صحيح ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label6.Visible = true;
            }

            if (BTNSAVE.Text=="حفظ")
            {
                 user.ADD_NEW_USER(txtusername.Text, txtpasswored.Text, combusertyp.Text, txtfulusername.Text);
                MessageBox.Show("تم اضافة مستخدم جديد ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfulusername.Clear();
                txtpasswored.Clear();
                txtusername.Clear();
                txtpassworedconferm.Clear();
                txtusername.Focus();
                label6.Visible = false;

            }
            else if (BTNSAVE.Text=="تعديل")
            {
                 user.UPDATE_USER(txtusername.Text, txtpasswored.Text, combusertyp.Text, txtfulusername.Text);
                 MessageBox.Show("تم التعديل ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
            }
               
            
        }

        private void txtpassworedconferm_Validated(object sender, EventArgs e)
        {
            if (txtpasswored.Text != txtpassworedconferm.Text)
            {
                MessageBox.Show("برجاء ادخال كلمة السر بشكل صحيح ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label6.Visible = true;
            }

        }
    }
}
