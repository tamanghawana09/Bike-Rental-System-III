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
    public partial class Bikes : Form
    {
        public Bikes()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            h.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            h.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            h.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            Bikes b = new Bikes();
            b.ShowDialog();
            b.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bikes b = new Bikes();
            b.ShowDialog();
            b.Show();
        }

        private void motorcycleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bikes b = new Bikes();
            b.ShowDialog();
            b.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.ShowDialog();
            p.Show();
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
    }
}
