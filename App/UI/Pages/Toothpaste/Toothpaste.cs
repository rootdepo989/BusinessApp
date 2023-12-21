using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.UI.Pages.Toothpaste
{
    public partial class Toothpaste : Form
    {
        public Toothpaste()
        {
            InitializeComponent();
        }

        private void Toothpaste_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
