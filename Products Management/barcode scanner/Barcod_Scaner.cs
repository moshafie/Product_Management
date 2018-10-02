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


namespace Products_Management.barcode_scanner
{
    public partial class Barcod_Scaner : Form
    {
        SqlConnection con = new SqlConnection(@"server=.; Database=Product_DB; integrated security=true");
        SqlCommand cmd = new SqlCommand();

        public Barcod_Scaner()
        {
            InitializeComponent();
        }

        private void Barcod_Scaner_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO TBL_PRD VALUES (@Barcode, @Des, @Price, @Qty, @Picture)", con);
                SqlParameter[] param = new SqlParameter[5];

                MemoryStream ms = new MemoryStream();
                pbProduct.Image.Save(ms, pbProduct.Image.RawFormat);
                byte[] image = ms.ToArray();

                param[0] = new SqlParameter("@Barcode", SqlDbType.NVarChar,50);
                param[0].Value = txtBarCode.Text;

                param[1] = new SqlParameter("@Des", SqlDbType.VarChar, 35);
                param[1].Value = txtdes.Text;

                param[2] = new SqlParameter("@Price", SqlDbType.VarChar, 35);
                param[2].Value = txtPrice.Text;

                param[3] = new SqlParameter("@Qty", SqlDbType.Int);
                param[3].Value = Convert.ToInt64(txtQty.Text);

                param[4] = new SqlParameter("@Picture", SqlDbType.Image);
                param[4].Value = image;

                con.Open();
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم اضافة المنتج", "اضافة منتج جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {

                return;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور| *.png; *.jpg; *.gif; *.bmp";
            if (op.ShowDialog()==DialogResult.OK)
            {
                pbProduct.Image = Image.FromFile(op.FileName);
            }
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                cmd = new SqlCommand("SELECT * FROM TBL_PRD WHERE Barcode= @Barcode ", con);
                cmd.Parameters.Add(new SqlParameter("@Barcode",txtBarCode.Text));
                con.Open();
                SqlDataReader reder = cmd.ExecuteReader();
                while (reder.Read())
                {
                    txtdes.Text = reder.GetString(2);
                    txtPrice.Text = reder.GetString(3);
                    txtQty.Text = Convert.ToString(reder.GetInt32(4));
                    byte[] imge = (byte[])reder[5];
                    MemoryStream ms = new MemoryStream(imge);
                    pbProduct.Image = Image.FromStream(ms);


                    
                }
                reder.Close();
                con.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
