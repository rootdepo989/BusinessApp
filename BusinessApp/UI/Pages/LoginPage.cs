using BusinessApp.DbOperations;
using BusinessApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessApp.UI.Pages
{
    public partial class LoginPage : Form
    {
        AppContextDb db = new AppContextDb();

        public LoginPage()
        {
            InitializeComponent();
        }


        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        // login event
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string AdminName = textBoxLoginName.Text;
            string AdminPassword = textBoxLoginPassword.Text;

            checkUser(AdminName, AdminPassword);
        }


        // login method

        private void checkUser(string userName, string userPassword)
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


    }
}
