using AdminRentalUI.Petrol_Bike;
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
    public partial class customerHome : Form
    {
        public customerHome()
        {
            InitializeComponent();
            chart1.Series["Series1"].Points.AddXY("Petrol Bike", "50");
            chart1.Series["Series1"].Points.AddXY("Active Bike", "20");
            chart1.Series["Series1"].Points.AddXY("Electric Bike", "30");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT15 mt = new MT15();
            mt.ShowDialog();
            mt.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HondaCRF hf = new HondaCRF();
            hf.ShowDialog();
            hf.Show(); 
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoyalEnfield royalEnfield = new RoyalEnfield();
            royalEnfield.ShowDialog();
            royalEnfield.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KTMduke kTMduke = new KTMduke();    
            kTMduke.ShowDialog();
            kTMduke.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pro = new Profile();
            pro.ShowDialog();
            pro.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pro = new Profile();
            pro.ShowDialog();
            pro.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            about.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help();
            help.ShowDialog();
            help.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help();
            help.ShowDialog();
            help.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
            logout.ShowDialog();
            logout.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
            logout.ShowDialog();
            logout.Show();
        }
    }
}
