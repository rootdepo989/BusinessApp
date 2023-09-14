using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBusiness.UI.Pages
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoSellersPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellersPage sallersPage = new SellersPage();
            sallersPage.Show();
        }

        private void buttonGoSalesPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage salesPage = new SalesPage();
            salesPage.Show();
        }

        private void buttonGoWaitingManeyPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditsPage creditsPage = new CreditsPage();
            creditsPage.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
