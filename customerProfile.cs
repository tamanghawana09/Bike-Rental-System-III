namespace bikeRental
{
    public partial class customerProfile : Form
    {
        public customerProfile()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerProfile cP = new customerProfile();
            cP.ShowDialog();
            this.Show();
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHome cH = new customerHome();
            cH.ShowDialog();
            this.Show();
            this.Close();
        }

        private void motorcyceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerBikes cB = new customerBikes();
            cB.ShowDialog();
            this.Show();
            this.Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHelp cHe = new customerHelp();
            cHe.ShowDialog();
            this.Show();
            this.Close();
        }

        private void customerProfile_Load(object sender, EventArgs e)
        {

        }
    }    
}