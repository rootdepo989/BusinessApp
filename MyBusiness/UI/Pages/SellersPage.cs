using MyBusiness.Core.Abstracts;
using MyBusiness.Core.Concrets;
using MyBusiness.DbOperations;
using MyBusiness.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyBusiness.UI.Pages
{
    public partial class SellersPage : Form
    {
        AppContextDb db = new AppContextDb();
        DateTime date = DateTime.Now;
        DialogResult alert;

        public SellersPage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void SallersPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SallersPage_Load(object sender, EventArgs e)
        {
            Methods.GetAllSellers(dataGridViewOfSellersPage, db);
        }

        // ClearAllInputs method...
        private void ClearAllInputs()
        {
            textBoxNAME.Text = "";
            textBox10ML.Text = "";
            textBox20ML.Text = "";
            textBox30ML.Text = "";
            textBoxLUX.Text = "";
            textBoxDELUX.Text = "";
            textBoxQr3AZN.Text = "";
        }

        // ADD OPERATIONS....

        private void buttonADD_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();


            string NAME = textBoxNAME.Text;
            string ML10 = textBox10ML.Text;
            string ML20 = textBox20ML.Text;
            string ML30 = textBox30ML.Text;
            string LUX = textBoxLUX.Text;
            string DELUX = textBoxDELUX.Text;
            string Qr3AZN = textBoxQr3AZN.Text;

            try
            {
                Methods.AddSeller(seller, NAME, ML10, ML20, ML30, LUX, DELUX, Qr3AZN, date);
                db.Sellers.Add(seller);
                db.SaveChanges();
                ClearAllInputs();
                Methods.GetAllSellers(dataGridViewOfSellersPage, db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // // UPDATE OPERATIONS....
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {


            string NAME = textBoxNAME.Text;
            string ML10 = textBox10ML.Text;
            string ML20 = textBox20ML.Text;
            string ML30 = textBox30ML.Text;
            string LUX = textBoxLUX.Text;
            string DELUX = textBoxDELUX.Text;
            string Qr3AZN = textBoxQr3AZN.Text;

            try
            {
                int sellerId = Convert.ToInt32(dataGridViewOfSellersPage.CurrentRow.Cells[0].Value.ToString());
                Methods.UpdateSeller(sellerId, db, NAME, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
                Methods.GetAllSellers(dataGridViewOfSellersPage, db);
                ClearAllInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewOfSellersPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select contact from inside from table rows...

            Seller seller = new Seller();

            try
            {
                textBoxNAME.Text = dataGridViewOfSellersPage.CurrentRow.Cells[1].Value.ToString();
                textBox10ML.Text = dataGridViewOfSellersPage.CurrentRow.Cells[2].Value.ToString();
                textBox20ML.Text = dataGridViewOfSellersPage.CurrentRow.Cells[3].Value.ToString();
                textBox30ML.Text = dataGridViewOfSellersPage.CurrentRow.Cells[4].Value.ToString();
                textBoxLUX.Text = dataGridViewOfSellersPage.CurrentRow.Cells[5].Value.ToString();
                textBoxDELUX.Text = dataGridViewOfSellersPage.CurrentRow.Cells[6].Value.ToString();
                textBoxQr3AZN.Text = dataGridViewOfSellersPage.CurrentRow.Cells[7].Value.ToString();
                seller.Toplam_Say = dataGridViewOfSellersPage.CurrentRow.Cells[8].Value.ToString();
                seller.Maya_Deyeri = Convert.ToDouble(dataGridViewOfSellersPage.CurrentRow.Cells[9].Value.ToString());
                seller.Qazancım = Convert.ToDouble(dataGridViewOfSellersPage.CurrentRow.Cells[10].Value.ToString());
                seller.Toplam_Alacagim = Convert.ToDouble(dataGridViewOfSellersPage.CurrentRow.Cells[11].Value.ToString());
                seller.Zaman = Convert.ToDateTime(dataGridViewOfSellersPage.CurrentRow.Cells[12].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // DELETE OPERATIONS....
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int sellerId = Convert.ToInt32(dataGridViewOfSellersPage.CurrentRow.Cells[0].Value.ToString());
                DeleteSeller(sellerId,dataGridViewOfSellersPage,db);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // DELETE METHOD...
        private void DeleteSeller(int sellerId, DataGridView dataGridView, AppContextDb db)
        {

            var name = dataGridView.CurrentRow.Cells[1].Value.ToString();

            Seller seller = db.Sellers.SingleOrDefault(s => s.Id == sellerId);

            alert = MessageBox.Show($"{name}    " + $"adındaki şəxsi silmək istədiyindən əminsən?", "İstifadəçi silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.Sellers.Remove(seller);
                db.SaveChanges();
            }
            Methods.GetAllSellers(dataGridViewOfSellersPage, db);
        }
    }
}
