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
    }
}
