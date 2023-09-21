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

        private void buttonGoPaylasimdizayncisiPage_MouseHover(object sender, EventArgs e)
        {
            buttonGoPaylasimdizayncisiPage.BackColor = Color.Red;
            buttonGoPaylasimdizayncisiPage.Cursor = Cursors.Hand;
        }

        private void buttonGoPaylasimdizayncisiPage_MouseLeave(object sender, EventArgs e)
        {
            buttonGoPaylasimdizayncisiPage.BackColor = Color.Black;
        }

        private void buttonGoPaylasimdizayncisiPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaylasimdizayncisiPage paylasimdizayncisiPage = new PaylasimdizayncisiPage();
            paylasimdizayncisiPage.Show();
        }

        private void buttonGoEtirDeluxPage_MouseHover(object sender, EventArgs e)
        {
            buttonGoEtirDeluxPage.BackColor = Color.Red;
        }

        private void buttonGoEtirDeluxPage_MouseLeave(object sender, EventArgs e)
        {
            buttonGoEtirDeluxPage.BackColor = Color.Black;
        }

        private void buttonGoEtirDeluxPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            EtirDeluxPage etirDeluxPage = new EtirDeluxPage();
            etirDeluxPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcuzIzleyiciAlPage ucuzIzleyiciAlPage = new UcuzIzleyiciAlPage();
            ucuzIzleyiciAlPage.Show();
        }
    }
}
