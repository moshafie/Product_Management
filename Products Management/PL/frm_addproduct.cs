using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Products_Management.PL
{
    public partial class frm_addproduct : Form
    {
      

        public string state = "add";
        BL.cls_product prd = new BL.cls_product();
        public frm_addproduct()
        {
            InitializeComponent();
           
            

            cmbcategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbcategories.DisplayMember = "DESCRIPTION_CAT";
            cmbcategories.ValueMember = "ID_CAT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG; *PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (btnsave.Text == "حفظ")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimg = ms.ToArray();
                prd.ADD_PRODUCT(Convert.ToInt32(cmbcategories.SelectedValue), txtdes.Text, txtref.Text, Convert.ToInt32(txtqte.Text), txtpric.Text, byteimg);
                MessageBox.Show("تمت الاضافه بنجاح", "عملية الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_PRODUCT.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }
            else if (btnsave.Text == ("تحديث"))
            {
                MemoryStream ms1 = new MemoryStream();
                pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                byte[] byteimg1 = ms1.ToArray();
                prd.UbDate_PRODUCT(Convert.ToInt32(cmbcategories.SelectedValue), txtdes.Text, txtref.Text, Convert.ToInt32(txtqte.Text), txtpric.Text, byteimg1);
                MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_PRODUCT.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();


            }
        }

        private void btnexite_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            this.Close();
        }

        private void txtref_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = prd.VERIVY_IDPRODUCT(txtref.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtref.Focus();
                    txtref.SelectionStart = 0;
                    txtref.SelectionLength = txtref.TextLength;
                }
            }
        }

      
    }
}
