using App.UI.Pages;
using App.UI.Pages.Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void buttonGoParfumeBusinessPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParfumesDashboard parfumesDashboard = new ParfumesDashboard();
            parfumesDashboard.Show();
        }

        private void buttonGoWebBusinessPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            InternetDashboard internetDashboard = new InternetDashboard();
            internetDashboard.Show();
        }

        private void buttonGoParfumeBusinessPage_MouseHover(object sender, EventArgs e)
        {
            buttonGoParfumeBusinessPage.Cursor = Cursors.Hand;
        }

        private void buttonGoWebBusinessPage_MouseHover(object sender, EventArgs e)
        {
            buttonGoWebBusinessPage.Cursor = Cursors.Hand;
        }
    }
}
