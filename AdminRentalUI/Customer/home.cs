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
    public partial class home : Form
    {
        public home()
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
     
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void motorcycleBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.ShowDialog();
            p.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            h.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.ShowDialog();
            p.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.ShowDialog();
            p.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.ShowDialog();
            p.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            h.Show();
        }
    }
}
