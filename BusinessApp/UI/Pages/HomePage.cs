using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BusinessApp.UI.Pages
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

        private void buttonGoSellersPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellersPage sellersPage = new SellersPage();
            sellersPage.Show();
        }

        private void buttonGoSalesPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage salesPage = new SalesPage();
            salesPage.Show();
        }

        private void buttonGoCreditsPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditsPage creditsPage = new CreditsPage();
            creditsPage.Show();
        }
    }
}
