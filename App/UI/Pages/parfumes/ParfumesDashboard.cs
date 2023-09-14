using App.UI.Pages;
using MyBusiness.UI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.UI.Pages
{
    public partial class ParfumesDashboard : Form
    {
        public ParfumesDashboard()
        {
            InitializeComponent();
        }

        private void ParfumesDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoSalesPage_MouseHover(object sender, EventArgs e)
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

        private void buttonGoHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
