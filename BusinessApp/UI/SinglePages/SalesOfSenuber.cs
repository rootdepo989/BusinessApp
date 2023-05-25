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
    public partial class SalesOfSenuber : Form
    {
        AppContextDb db = new AppContextDb();
        DialogResult alert;
        DateTime date = DateTime.Now;

        public SalesOfSenuber()
        {
            InitializeComponent();
        }

        private void SalesOfSenuber_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage salesPage = new SalesPage();
            salesPage.Show();
        }

        private void SalesOfSenuber_Load(object sender, EventArgs e)
        {
            GetAllSales();
        }

        // GetAllSellers method...
        private void GetAllSales()
        {
            dataGridViewOfSenuberPage.DataSource = db.SalesOfSenuber.ToList();
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

            Senuber senuber = new Senuber();
            try
            {
                AddEntity(senuber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // add method..
        private void AddEntity(Senuber senuber)
        {

            senuber.ML_10 = textBox10ML.Text;
            senuber.ML_20 = textBox20ML.Text;
            senuber.ML_30 = textBox30ML.Text;
            senuber.LUX = textBoxLUX.Text;
            senuber.DELUX = textBoxDELUX.Text;
            senuber.Qr_3AZN = textBoxQr_3AZN.Text;
            CalcCountOfParfume(senuber);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(senuber);
            senuber.Zaman = date;
            db.SalesOfSenuber.Add(senuber);
            DecreaseParfumesFromSellers();
            db.SaveChanges();
            GetAllSales();
        }

        // decrease parfumes of sellers
        private void DecreaseParfumesFromSellers()
        {
            Seller seller = db.Sellers.SingleOrDefault(s => s.Satıcının_Adı == "senuber");
            if (seller.Satıcının_Adı == "senuber")
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
        private void CalcCountOfParfume(Senuber senuber)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);
            var totalCount = ml_10 + ml_20 + ml_30 + lux + delux + qr_3azn;
            senuber.Toplam_Say = Convert.ToString(totalCount);


        }

        // cal total price of parfume...
        private void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Senuber senuber)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);


            CalcCountOfParfume(senuber);
            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            senuber.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            senuber.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            senuber.Toplam_Aldıgım = totalMoney;

        }

        // Delete event...
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfSenuberPage.CurrentRow.Cells[0].Value.ToString());
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



            Senuber senuber = db.SalesOfSenuber.SingleOrDefault(c => c.Id == entityId);

            alert = MessageBox.Show($"Satışı silmək istədiyindən əminsən?", "Satış silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.SalesOfSenuber.Remove(senuber);
                db.SaveChanges();
            }
            GetAllSales();
        }
    }
}
