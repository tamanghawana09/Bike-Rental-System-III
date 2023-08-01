using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRentalUI.Customer
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //exit button
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHome ch = new customerHome();
            ch.ShowDialog();
            ch.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            customerHome ch = new customerHome();
            ch.ShowDialog();
            ch.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHome ch = new customerHome();
            ch.ShowDialog();
            ch.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHome ch = new customerHome();
            ch.ShowDialog();
            ch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
