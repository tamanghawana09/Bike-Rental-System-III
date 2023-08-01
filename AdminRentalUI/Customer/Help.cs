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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
            profile.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
            profile.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
            profile.Show();
        }

        private void label13_Click(object sender, EventArgs e)
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

        private void panel4_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bike b = new bike();
            b.ShowDialog();
            b.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            Logout log = new Logout();
            log.ShowDialog();
            log.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Logout log = new Logout();
            log.ShowDialog();
            log.Show();
        }
    }
}
