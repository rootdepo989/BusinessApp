using BusinessApp.UI.SinglePages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BusinessApp.UI.Pages
{
    public partial class SalesPage : Form
    {
        public SalesPage()
        {
            InitializeComponent();
        }

        private void SalesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoRasimPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesOfRasim salesOfRasimPage = new SalesOfRasim();
            salesOfRasimPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void buttonGoXalidPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesOfXalid salesOfXalid = new SalesOfXalid();
            salesOfXalid.Show();
        }

        private void buttonGoKamilPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesOfKamil salesOfKamil = new SalesOfKamil();
            salesOfKamil.Show();
        }

        private void buttonGoSenuberPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesOfSenuber salesOfSenuber = new SalesOfSenuber();
            salesOfSenuber.Show();
        }

        private void buttonGoSebinePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesOfSebine salesOfSebine = new SalesOfSebine();
            salesOfSebine.Show();
        }
    }
}
