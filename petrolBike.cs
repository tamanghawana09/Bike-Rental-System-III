using bikeRental.Petrol_Bike;
using bikeRental.User_Controls;
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

        private void userButton_Click(object sender, EventArgs e)
        {
            profileUC uc = new profileUC();
            addUserControl(uc);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            mainUC uc = new mainUC();
            addUserControl(uc);
        }

        private void motorcyceBtn_Click(object sender, EventArgs e)
        {
            bikeUC uc = new bikeUC();
            addUserControl(uc);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            helpUC uc = new helpUC();
            addUserControl(uc);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logoutUC uc = new logoutUC();
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

        private void homeBtn_Enter(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.White;
        }

        private void homeBtn_Leave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.Transparent;
        }

        private void motorcyceBtn_Enter(object sender, EventArgs e)
        {
            motorcyceBtn.BackColor = Color.White;
        }

        private void helpBtn_Enter(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.White;
        }

        private void helpBtn_Leave(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.Transparent;
        }

        private void motorcyceBtn_Leave(object sender, EventArgs e)
        {
            motorcyceBtn.BackColor = Color.Transparent;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike1 b = new pBike1();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike2 b = new pBike2();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike3 b = new pBike3();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike4 b = new pBike4();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike5 b = new pBike5();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike6 b = new pBike6();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike7 b = new pBike7();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike8 b = new pBike8();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike9 b = new pBike9();
            b.ShowDialog();
            this.Show();
            this.Close();
        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            pBike10 b = new pBike10();
            b.ShowDialog();
            this.Show();
            this.Close();
        }
    }

}
