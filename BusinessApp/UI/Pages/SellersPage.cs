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
    public partial class SellersPage : Form
    {
        AppContextDb db = new AppContextDb();
        DialogResult alert;
        DateTime date = DateTime.Now;

        public SellersPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void SellersPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SellersPage_Load(object sender, EventArgs e)
        {
            GetAllSellers();
        }


        // GetAllSellers method...
        private void GetAllSellers()
        {
            dataGridViewOfSellersPage.DataSource = db.Sellers.ToList();
            ClearAllInputs();
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
            textBoxQr_3AZN.Text = "";
        }

        // add event...
        private void buttonADD_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            try
            {
                AddEntity(seller);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // add method..
        private void AddEntity(Seller seller)
        {
            seller.Satıcının_Adı = textBoxNAME.Text;
            seller.ML_10 = textBox10ML.Text;
            seller.ML_20 = textBox20ML.Text;
            seller.ML_30 = textBox30ML.Text;
            seller.LUX = textBoxLUX.Text;
            seller.DELUX = textBoxDELUX.Text;
            seller.Qr_3AZN = textBoxQr_3AZN.Text;
            CalcCountOfParfume(seller);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(seller);
            seller.Zaman = date;
            db.Sellers.Add(seller);
            db.SaveChanges();
            GetAllSellers();
        }


        // calc total count of parfume...
        private void CalcCountOfParfume(Seller seller)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);
            var totalCount = ml_10 + ml_20 + ml_30 + lux + delux + qr_3azn;
            seller.Toplam_Say = Convert.ToString(totalCount);


        }


        // cal total price of parfume...
        private void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Seller seller)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);



            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            seller.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            seller.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 12) + (ml_30 * 15) + (lux * 10) + (delux * 15) + (qr_3azn * 3);
            seller.Toplam_Alacagim = totalMoney;

        }

        // update event....
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                int sellerId = Convert.ToInt32(dataGridViewOfSellersPage.CurrentRow.Cells[0].Value.ToString());
                UpdateSeller(sellerId);
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
                textBoxQr_3AZN.Text = dataGridViewOfSellersPage.CurrentRow.Cells[7].Value.ToString();
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


        // update method...
        private void UpdateSeller(int sellerId)
        {
            Seller seller = db.Sellers.SingleOrDefault(s => s.Id == sellerId);
            seller.Satıcının_Adı = textBoxNAME.Text;
            seller.ML_10 = textBox10ML.Text;
            seller.ML_20 = textBox20ML.Text;
            seller.ML_30 = textBox30ML.Text;
            seller.LUX = textBoxLUX.Text;
            seller.DELUX = textBoxDELUX.Text;
            seller.Qr_3AZN = textBoxQr_3AZN.Text;
            // -------------------------------------------------------------------
            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);


            CalcCountOfParfume(seller);
            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            seller.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            seller.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 12) + (ml_30 * 15) + (lux * 10) + (delux * 15) + (qr_3azn * 3);
            seller.Toplam_Alacagim = totalMoney;

            //----------------------------------------------------------------------------
            db.SaveChanges();
            GetAllSellers();
        }

        // Delete event...
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int sellerId = Convert.ToInt32(dataGridViewOfSellersPage.CurrentRow.Cells[0].Value.ToString());
                DeleteSeller(sellerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // delete method...

        private void DeleteSeller(int sellerId)
        {

            var name = dataGridViewOfSellersPage.CurrentRow.Cells[1].Value.ToString();

            Seller seller = db.Sellers.SingleOrDefault(s => s.Id == sellerId);

            alert = MessageBox.Show($"{name}    " + $"adındaki şəxsi silmək istədiyindən əminsən?", "İstifadəçi silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.Sellers.Remove(seller);
                db.SaveChanges();
            }
            GetAllSellers();
        }
    }
}
