using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikeRental
{
    public partial class customerHome : Form
    {
        public customerHome()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerProfile cP = new customerProfile();
            cP.ShowDialog();
            this.Show();
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHome cH = new customerHome();
            cH.ShowDialog();
            this.Show();
            this.Close();
        }

        private void motorcyceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerBikes cB = new customerBikes();
            cB.ShowDialog();
            this.Show();
            this.Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHelp cHe = new customerHelp();
            cHe.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
