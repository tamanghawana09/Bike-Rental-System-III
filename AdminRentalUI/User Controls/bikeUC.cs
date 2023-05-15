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

namespace AdminRentalUI.User_Controls
{
    public partial class bikeUC : UserControl
    {
        public bikeUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            petrolBike pB = new petrolBike();
            pB.ShowDialog();
            this.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            electricBike eB = new electricBike();
            eB.ShowDialog();
            this.Show();
            this.Hide();
        }
    }
}
