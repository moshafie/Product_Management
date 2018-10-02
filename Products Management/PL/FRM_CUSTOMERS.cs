using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;


namespace Products_Management.PL
{
    public partial class FRM_CUSTOMERS : Form
    {
        BL.CLS_Customer cust = new BL.CLS_Customer();
        int ID ,position ;
       
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dglist.DataSource = cust.select_customer();
            dglist.Columns[0].Visible = false;
            dglist.Columns[5].Visible = false;
            
    


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_CUSTOMERS_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try


            {
               
               byte[] bictuer;
                if (pbcustomer.Image == null)
                {
                    bictuer = new byte[0];
                    cust.ADD_NEW_CUSTOMER(TXTName.Text, txt_famely_name.Text, txt_phone.Text, txtmaile.Text, bictuer, "without_image");
                    MessageBox.Show("تمت الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.select_customer();
                }

                else
                {

                    MemoryStream ms = new MemoryStream();
                    pbcustomer.Image.Save(ms, pbcustomer.Image.RawFormat);
                    bictuer = ms.ToArray();
                    cust.ADD_NEW_CUSTOMER(TXTName.Text, txt_famely_name.Text, txt_phone.Text, txtmaile.Text, bictuer, "with_image");
                    MessageBox.Show("تمت الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.select_customer();
                }



            }
            catch
            {
                return;
            }
            finally {

                btnAdd.Enabled = false;
                btnnew.Enabled = true;
            }

            }

        private void button8_Click(object sender, EventArgs e)
        {
            
            byte[] bictuer;
            if (ID==0)
            {
                if (pbcustomer.Image == null)
                {
                    bictuer = new byte[0];
                    cust.UBDATE_CUSTOMER(ID, TXTName.Text, txt_famely_name.Text, txt_phone.Text, txtmaile.Text, bictuer, "without_image");
                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.select_customer();
                }


                else
                {

                    MemoryStream ms = new MemoryStream();
                    pbcustomer.Image.Save(ms, pbcustomer.Image.RawFormat);
                    bictuer = ms.ToArray();
                    cust.UBDATE_CUSTOMER(ID, TXTName.Text, txt_famely_name.Text, txt_phone.Text, txtmaile.Text, bictuer, "with_image");
                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dglist.DataSource = cust.select_customer();

                }

            }
            else {


                MessageBox.Show("يجب اختيار عميل محدد", "", MessageBoxButtons.OK);
            }
        
        
        }


        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TXTName.Text == dglist.CurrentRow.Cells[1].Value.ToString())
            { 
                if (MessageBox.Show("هل تريد الحذف ", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                { 
                    cust.delete_customer(ID);
                    MessageBox.Show("تم الحذف بنجاح", "", MessageBoxButtons.OK);
                    this.dglist.DataSource = cust.select_customer();
                }
           }
                else
                {

                    MessageBox.Show("يجب اختيار عميل محدد", "", MessageBoxButtons.OK);
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TXTName.Clear();
            txt_famely_name.Clear();
            txt_phone.Clear();
            txtmaile.Clear();
            pbcustomer.Image = null;
            btnAdd.Enabled = true;
            btnnew.Enabled = false;
        }

        private void pbcustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور |*.JPG; *.PNG; *GIF; *.PMB";
            if (op.ShowDialog()== DialogResult.OK)
            {
                pbcustomer.Image = Image.FromFile(op.FileName);
            }
        }

        private void dglist_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pbcustomer.Image = null;
           ID =Convert.ToInt32( dglist.CurrentRow.Cells[0].Value.ToString());
            this.TXTName.Text = dglist.CurrentRow.Cells[1].Value.ToString();
            this.txt_famely_name.Text = dglist.CurrentRow.Cells[2].Value.ToString();
            this.txt_phone.Text = dglist.CurrentRow.Cells[3].Value.ToString();
            this.txtmaile.Text = dglist.CurrentRow.Cells[4].Value.ToString();
            byte[]pictuer= (byte [])dglist.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(pictuer);
            pbcustomer.Image = Image.FromStream(ms);
            }
            catch
            {
                
                return ;
            }
          

        }
      

        private void dglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtserche_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cust.search_customer(txtserche.Text);
            this.dglist.DataSource = dt;
        }

        private void txtserche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnserch_Click(sender, e);
            }
        }

        void navigation(int endex)
        {
            try
            {
                DataRowCollection DRC = cust.select_customer().Rows;
                pbcustomer.Image = null;
                ID = Convert.ToInt32( DRC[endex][0].ToString());
                TXTName.Text = DRC[endex][1].ToString();
                txt_famely_name.Text = DRC[endex][2].ToString();
                txt_phone.Text = DRC[endex][3].ToString();
                txtmaile.Text = DRC[endex][4].ToString();
                byte[] picture = (byte[])DRC[endex][5];
                MemoryStream ms = new MemoryStream(picture);
                pbcustomer.Image = Image.FromStream(ms);
            }
            catch {

                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigation(0);
      
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            position = cust.select_customer().Rows.Count - 1;
            navigation(position);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (position == 0)
            {

                MessageBox.Show("this is frist row ");
                return;
            }
            position -= 1;
            navigation(position);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (position == cust.select_customer().Rows.Count - 1)
            {

                MessageBox.Show("this is last row ");
                return;
            }
            position += 1;
            navigation(position);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
