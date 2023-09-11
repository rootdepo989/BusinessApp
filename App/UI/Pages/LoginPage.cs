using MyBusiness.DbOperations;
using MyBusiness.Entities;
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
    }
}
