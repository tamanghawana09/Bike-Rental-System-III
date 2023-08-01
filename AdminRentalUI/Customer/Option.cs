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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            hourPay hp = new hourPay();
            hp.ShowDialog();
            hp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.ShowDialog();
            pay.Show();
        }
    }
}
