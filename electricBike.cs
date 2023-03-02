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
    public partial class electricBike : Form
    {
        public electricBike()
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
            this.Hide();
            profileUC uc = new profileUC();
            addUserControl(uc);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainUC uc = new mainUC();
            addUserControl(uc);
        }

        private void motorcyceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bikeUC uc = new bikeUC();
            addUserControl(uc);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void motorcyceBtn_Leave(object sender, EventArgs e)
        {
            motorcyceBtn.BackColor = Color.Transparent;
        }

        private void helpBtn_Enter(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.White;
        }

        private void helpBtn_Leave(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.Transparent;
        }
    }
}
