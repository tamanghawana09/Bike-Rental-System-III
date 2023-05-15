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
    public partial class mainUC : UserControl
    {
        public mainUC()
        {
            InitializeComponent();
            chart1.Series["Series1"].Points.AddXY("Petrol Bike", "30");
            chart1.Series["Series1"].Points.AddXY("Active Bike", "40");
            chart1.Series["Series1"].Points.AddXY("Electric Bike", "30");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 1;
            pbar.Text = pbar.Value.ToString() + "%";
            if(pbar.Value == 70)
            {
                timer1.Enabled = false;
            }
        }
    }
}
