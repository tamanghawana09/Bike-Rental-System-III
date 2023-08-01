using AdminRentalUI.Electric_Bike;
using AdminRentalUI.Petrol_Bike;
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
    public partial class bike : Form
    {
        public bike()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MT15 mt = new MT15();
            mt.ShowDialog();
            mt.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ns200 ns = new Ns200();
            ns.ShowDialog();
            ns.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            RoyalEnfield re = new RoyalEnfield();
            re.ShowDialog();
            re.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            RoyalEnfield re = new RoyalEnfield();
            re.ShowDialog();
            re.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HJ250 hj = new HJ250();
            hj.ShowDialog();
            hj.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            KTMduke ktm = new KTMduke();
            ktm.ShowDialog();
            ktm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            HondaCRF crf = new HondaCRF();
            crf.ShowDialog();
            crf.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            NIU niu = new NIU();
            niu.ShowDialog();
            niu.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            SS ss = new SS();
            ss.ShowDialog();
            ss.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Yatri y = new Yatri();
            y.ShowDialog();
            y.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Yadea ya = new Yadea(); 
            ya.ShowDialog();
            ya.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SSCPX cpx = new SSCPX();
            cpx.ShowDialog();
            cpx.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            bella be = new bella();
            be.ShowDialog();
            be.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pro = new Profile();
            pro.ShowDialog();
            pro.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerHome ch = new customerHome();
            ch.ShowDialog();
            ch.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MT15 mt = new MT15();
            mt.ShowDialog();
            mt.Show();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            Ns200 ns = new Ns200();
            ns.ShowDialog();
            ns.Show();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            RoyalEnfield re = new RoyalEnfield();  
            re.ShowDialog();
            re.Show();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            HJ250 hJ250 = new HJ250();
            hJ250.ShowDialog();
            hJ250.Show();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            KTMduke ktm = new KTMduke();
            ktm.ShowDialog();
            ktm.Show();
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            HondaCRF crf = new HondaCRF();
            crf.ShowDialog();
            crf.Show();
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            NIU niu = new NIU();
            niu.ShowDialog();
            niu.Show();
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            SS ss = new SS();
            ss.ShowDialog();
            ss.Show();
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            Yatri yatri = new Yatri();
            yatri.ShowDialog();
            yatri.Show();
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            Yadea ya = new Yadea();
            ya.ShowDialog();
            ya.Show();
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            SSCPX sSCPX = new SSCPX();
            sSCPX.ShowDialog();
            sSCPX.Show();
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            bella be = new bella();
            be.ShowDialog();
            be.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
