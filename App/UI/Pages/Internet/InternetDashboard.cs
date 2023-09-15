using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.UI.Pages.Internet
{
    public partial class InternetDashboard : Form
    {
        public InternetDashboard()
        {
            InitializeComponent();
        }

        private void InternetDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoElanAtlasiPage_MouseHover(object sender, EventArgs e)
        {
            buttonGoElanAtlasiPage.Cursor = Cursors.Hand;
            buttonGoElanAtlasiPage.BackColor = Color.Red;
        }

        private void buttonGoElanAtlasiPage_MouseLeave(object sender, EventArgs e)
        {
            buttonGoElanAtlasiPage.BackColor = Color.Black;
        }

        private void pictureBoxInInternetDashPage_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonGoElanAtlasiPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElanAtlasiPage elanAtlasiPage = new ElanAtlasiPage();
            elanAtlasiPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
