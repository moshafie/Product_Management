using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Products_Management.barcode_scanner
{
    public partial class BrcodeNQR : Form
    {
        public BrcodeNQR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(textBox1.Text, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrbbarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrbbarcode.Draw(textBox2.Text, 50);
        }

    }
}
