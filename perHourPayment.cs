using bikeRental.User_Control_for_payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikeRental
{
    public partial class perHourPayment : Form
    {
        public perHourPayment()
        {
            InitializeComponent();
            cashPayment uc = new cashPayment();
            addUserControl2(uc);
            happyN uc1 = new happyN();
            addUserControl1(uc1);
        }

        private void addUserControl1(UserControl userControl1)
        {
            userControl1.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl1);
            userControl1.BringToFront();
        }
        private void addUserControl2(UserControl userControl2)
        {
            userControl2.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl2);
            userControl2.BringToFront();
        }
        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            // cash payment 
            cashPayment uc = new cashPayment();
            addUserControl2(uc);

            happyN uc1 = new happyN();
            addUserControl1(uc1);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            // esewa payment
            happyE uc = new happyE();
            addUserControl2(uc);

            esewa uc1 = new esewa();
            addUserControl1(uc1);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            // lhalti payment
            happyE uc = new happyE();
            addUserControl2(uc);

            khalti uc1 = new khalti();
            addUserControl1(uc1);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
