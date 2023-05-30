using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AdminRentalUI
{
    public partial class QRCodeGenerator : Form
    {
        
        public QRCodeGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQR.Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic.Image = code.GetGraphic(10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQR.Text))
            {
                MessageBox.Show("Please enter some text first");
                return;
            }

            SaveQRCode();
           
        }
        public void SaveQRCode()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG files (*.png) | *.png|All files (*.*)|*.*";
            sfd.FileName = "QRCode.png";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                pic.Image.Save(sfd.FileName, ImageFormat.Png);
                MessageBox.Show("QR Code saved successfully!");
                this.Close();
            }
        }


        }
    }
