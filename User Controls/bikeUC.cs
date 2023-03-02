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
    public partial class bikeUC : UserControl
    {
        public bikeUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            petrolBike pB = new petrolBike();
            pB.ShowDialog();
            this.Show();

            //petrolUC uc = new petrolUC();
            //uc.Dock = DockStyle.Fill;
            // customerHome.Instance.PnlContainer.Controls.Add(uc);
            // customerHome.Instance.PnlContainer.Controls["petrolUC"].BringToFront();

        }

        private void bikeUC_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
