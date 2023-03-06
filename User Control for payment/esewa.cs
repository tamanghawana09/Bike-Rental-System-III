using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikeRental.User_Control_for_payment
{
    public partial class esewa : UserControl
    {
        public esewa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rulesAndRegulation rr = new rulesAndRegulation();
            rr.ShowDialog();
            this.Show();
        }
    }
}
