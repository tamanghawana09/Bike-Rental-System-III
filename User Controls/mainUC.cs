using bikeRental.Petrol_Bike;
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


            chart6.Series["Series1"].Points.AddXY("Petrol Bike", "75");
            chart6.Series["Series1"].Points.AddXY("Electric Bike", "25");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBike10 b = new pBike10();
            b.ShowDialog();
            this.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBike2 b = new pBike2();
            b.ShowDialog();
            this.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBike7 b = new pBike7();
            b.ShowDialog();
            this.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBike6 b = new pBike6();
            b.ShowDialog();
            this.Show();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            petrolBike pB = new petrolBike();
            pB.ShowDialog();
            this.Show();

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            electricBike eB = new electricBike();
            eB.ShowDialog();
            this.Show();

        }
    }
}
