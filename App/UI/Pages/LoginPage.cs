﻿using App.DbOperations;
using App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.UI.Pages
{
    public partial class LoginPage : Form
    {
        AppContextDb db = new AppContextDb();

        public LoginPage()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            string AdminName = textBoxADMİNNAME.Text;
            string AdminPassword = textBoxADMİNPASSWORD.Text;

            CheckUser(AdminName, AdminPassword);
        }



        // *********************** LOGIN METHOD  ************************

        private void CheckUser(string userName, string userPassword)
        {


            Admin admin = db.Admins.SingleOrDefault(a => a.Name == userName || a.Password == userPassword);
            if (admin.Name != userName || admin.Password != userPassword)
            {
                MessageBox.Show("Daxil olduğunuz bilgilər yalnışdır!");
            }
            else
            {
                this.Hide();
                HomePage homePage = new HomePage();
                homePage.Show();

            }
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLOGIN_MouseHover(object sender, EventArgs e)
        {
            buttonLOGIN.Cursor = Cursors.Hand;
        }

        private void textBoxADMİNNAME_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxADMİNNAME.Text = "";
        }

        private void textBoxADMİNNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            textBoxADMİNNAME.Text = "Adınızı girin...";
            textBoxADMİNPASSWORD.Text = "Şifrənizi daxil edin";
        }

        private void textBoxADMİNPASSWORD_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxADMİNPASSWORD.Text = "";
        }
    }
}
