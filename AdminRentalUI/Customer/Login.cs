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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
           customerHome cuh = new customerHome();
           cuh.ShowDialog();
           cuh.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
