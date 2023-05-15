using AdminRentalUI.Petrol_Bike_UC;
using AdminRentalUI.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRentalUI.Customer
{
    public partial class petrolBike : Form
    {
        public petrolBike()
        {
            InitializeComponent();

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            profileUC uc = new profileUC();
            addUserControl(uc);
            
        }

        private void userButton_Enter(object sender, EventArgs e)
        {
            userButton.BackColor = Color.White;
        }

        private void userButton_Leave(object sender, EventArgs e)
        {
            userButton.BackColor = Color.Transparent;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            mainUC uc = new mainUC();
            addUserControl(uc);
        }

        private void homeBtn_Enter(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.White;
        }

        private void homeBtn_Leave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.Transparent;
        }

        private void motorcycleBtn_Click(object sender, EventArgs e)
        {
            bikeUC uc = new bikeUC();
            addUserControl(uc);
        }

        private void motorcycleBtn_Enter(object sender, EventArgs e)
        {
            motorcycleBtn.BackColor = Color.White;
        }

        private void motorcycleBtn_Leave(object sender, EventArgs e)
        {
            motorcycleBtn.BackColor = Color.Transparent;
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            helpUC uc = new helpUC();
            addUserControl(uc);
        }

        private void helpBtn_Enter(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.White;
        }

        private void helpBtn_Leave(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.Transparent;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logoutUCcs uc = new logoutUCcs();
            addUserControl(uc);
        }

        private void logoutBtn_Enter(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Color.White;
        }

        private void logoutBtn_Leave(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Color.Transparent;
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            pBike1 pB1 = new pBike1();
            pB1.ShowDialog();
            this.Show();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            pBike2 pB2 = new pBike2();
            pB2.ShowDialog();
            this.Show();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            pBike3 pB3 = new pBike3();
            pB3.ShowDialog();
            this.Show();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            pBike4 pB4 = new pBike4();
            pB4.ShowDialog();
            this.Show();
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            pBike5 pB5 = new pBike5();
            pB5.ShowDialog();
            this.Show();
        }

        private void guna2TileButton10_Click(object sender, EventArgs e)
        {
            pBike10 pB10 = new pBike10();
            pB10.ShowDialog();
            this.Show();
        }

        private void guna2TileButton9_Click(object sender, EventArgs e)
        {
            pBike9 pB9 = new pBike9();
            pB9.ShowDialog();
            this.Show();
        }

        private void guna2TileButton8_Click(object sender, EventArgs e)
        {
            pBike8 pB8 = new pBike8();
            pB8.ShowDialog();
            this.Show();
        }

        private void guna2TileButton7_Click(object sender, EventArgs e)
        {
            pBike7 pB7 = new pBike7();
            pB7.ShowDialog();
            this.Show();
        }

        private void guna2TileButton6_Click(object sender, EventArgs e)
        {
            pBike6cs pB6 = new pBike6cs();
            pB6.ShowDialog();
            this.Show();
        }
    }
}
