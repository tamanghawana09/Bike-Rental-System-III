using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bikeRental.User_Controls
{
    public partial class mainUC : UserControl
    {
        /*List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();*/
        public mainUC()
        {
            InitializeComponent();


            chart6.Series["Series1"].Points.AddY("75");
            chart6.Series["Series1"].Points.AddY("25");
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 1;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 70)
            {
                timer1.Enabled = false;
            }
        }

        private void mainUC_Load(object sender, EventArgs e)
        {

        }

        private void chart6_Click(object sender, EventArgs e)
        {

        }
    }
}
