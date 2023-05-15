using AdminRentalUI.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace AdminRentalUI.Customer
{
    public partial class customerHome : Form
    {
        public customerHome()
        {
            InitializeComponent();
            mainUC uc = new mainUC();
            addUserControl(uc);
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
    }
}
