using BusinessApp.DbOperations;
using BusinessApp.Entities;
using BusinessApp.UI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessApp.UI.SinglePages
{
    public partial class SalesOfSebine : Form
    {
        AppContextDb db = new AppContextDb();
        DialogResult alert;
        DateTime date = DateTime.Now;

        public SalesOfSebine()
        {
            InitializeComponent();
        }

        private void SalesOfSebine_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage salesPage = new SalesPage();
            salesPage.Show();
        }

        private void SalesOfSebine_Load(object sender, EventArgs e)
        {
            GetAllSales();
        }

        // GetAllSellers method...
        private void GetAllSales()
        {
            dataGridViewOfSebinePage.DataSource = db.SalesOfSebine.ToList();
            ClearAllInputs();
        }

        // ClearAllInputs method...
        private void ClearAllInputs()
        {

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
            Sebine sebine = new Sebine();

            try
            {
                AddEntity(sebine);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // add method..
        private void AddEntity(Sebine sebine)
        {

            sebine.ML_10 = textBox10ML.Text;
            sebine.ML_20 = textBox20ML.Text;
            sebine.ML_30 = textBox30ML.Text;
            sebine.LUX = textBoxLUX.Text;
            sebine.DELUX = textBoxDELUX.Text;
            sebine.Qr_3AZN = textBoxQr_3AZN.Text;
            CalcCountOfParfume(sebine);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(sebine);
            sebine.Zaman = date;
            db.SalesOfSebine.Add(sebine);
            DecreaseParfumesFromSellers();
            db.SaveChanges();
            GetAllSales();
        }

        // decrease parfumes of sellers
        private void DecreaseParfumesFromSellers()
        {
            Seller seller = db.Sellers.SingleOrDefault(s => s.Satıcının_Adı == "sebine");
            if (seller.Satıcının_Adı == "sebine")
            {
                var result_ml10 = Convert.ToInt32(seller.ML_10) - Convert.ToInt32(textBox10ML.Text);
                seller.ML_10 = Convert.ToString(result_ml10);
                var result_ml20 = Convert.ToInt32(seller.ML_20) - Convert.ToInt32(textBox20ML.Text);
                seller.ML_20 = Convert.ToString(result_ml20);
                var result_ml30 = Convert.ToInt32(seller.ML_30) - Convert.ToInt32(textBox30ML.Text);
                seller.ML_30 = Convert.ToString(result_ml30);
                var result_lux = Convert.ToInt32(seller.LUX) - Convert.ToInt32(textBoxLUX.Text);
                seller.LUX = Convert.ToString(result_lux);
                var result_delux = Convert.ToInt32(seller.DELUX) - Convert.ToInt32(textBoxDELUX.Text);
                seller.DELUX = Convert.ToString(result_delux);
                var result_qr3azn = Convert.ToInt32(seller.Qr_3AZN) - Convert.ToInt32(textBoxQr_3AZN.Text);
                seller.Qr_3AZN = Convert.ToString(result_qr3azn);

            }
        }


        // calc total count of parfume...
        private void CalcCountOfParfume(Sebine sebine)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);
            var totalCount = ml_10 + ml_20 + ml_30 + lux + delux + qr_3azn;
            sebine.Toplam_Say = Convert.ToString(totalCount);


        }

        // cal total price of parfume...
        private void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Sebine sebine)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);


            CalcCountOfParfume(sebine);
            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            sebine.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            sebine.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            sebine.Toplam_Aldıgım = totalMoney;

        }

        // Delete event...
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfSebinePage.CurrentRow.Cells[0].Value.ToString());
                DeleteEntity(entityId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // delete method...

        private void DeleteEntity(int entityId)
        {



            Sebine sebine = db.SalesOfSebine.SingleOrDefault(c => c.Id == entityId);

            alert = MessageBox.Show($"Satışı silmək istədiyindən əminsən?", "Satış silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.SalesOfSebine.Remove(sebine);
                db.SaveChanges();
            }
            GetAllSales();
        }
    }
}
