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
    public partial class newLogin : Form
    {
        public newLogin()
        {
            InitializeComponent();
            signup uc= new signup();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            signin uc = new signin();
            addUserControl(uc);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            signup uc = new signup();
            addUserControl(uc);
        }
    }
}
