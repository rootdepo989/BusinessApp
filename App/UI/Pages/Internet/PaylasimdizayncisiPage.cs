using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.UI.Pages.Internet
{
    public partial class PaylasimdizayncisiPage : Form
    {
        public PaylasimdizayncisiPage()
        {
            InitializeComponent();
        }

        private void PaylasimdizayncisiPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
