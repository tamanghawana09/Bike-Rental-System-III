using AdminRentalUI.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRentalUI.User_Control_for_Payment
{
    public partial class cashDayPayment : UserControl
    {
        public cashDayPayment()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            rulesAndRegulationcs rr = new rulesAndRegulationcs();
            rr.ShowDialog();
            this.Show();
        }
    }
}
