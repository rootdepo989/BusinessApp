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
    public partial class SalesOfRasim : Form
    {

        AppContextDb db = new AppContextDb();
        DialogResult alert;
        DateTime date = DateTime.Now;

        public SalesOfRasim()
        {
            InitializeComponent();
        }

        private void SalesOfRasim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage salesPage = new SalesPage();
            salesPage.Show();
        }

        private void SalesOfRasim_Load(object sender, EventArgs e)
        {
            GetAllSales();
        }

        // GetAllSellers method...
        private void GetAllSales()
        {
            dataGridViewOfRasimPage.DataSource = db.SalesOfRasim.ToList();
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
            Rasim rasim = new Rasim();
            try
            {
                AddEntity(rasim);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // add method..
        private void AddEntity(Rasim rasim)
        {

            rasim.ML_10 = textBox10ML.Text;
            rasim.ML_20 = textBox20ML.Text;
            rasim.ML_30 = textBox30ML.Text;
            rasim.LUX = textBoxLUX.Text;
            rasim.DELUX = textBoxDELUX.Text;
            rasim.Qr_3AZN = textBoxQr_3AZN.Text;
            CalcCountOfParfume(rasim);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(rasim);
            rasim.Zaman = date;
            db.SalesOfRasim.Add(rasim);
            DecreaseParfumesFromSellers();
            db.SaveChanges();
            GetAllSales();
        }

        // decrease parfumes of sellers
        private void DecreaseParfumesFromSellers()
        {
            Seller seller = db.Sellers.SingleOrDefault(x => x.Satıcının_Adı == "rasim");
            if (seller.Satıcının_Adı == "rasim")
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
        private void CalcCountOfParfume(Rasim rasim)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);
            var totalCount = ml_10 + ml_20 + ml_30 + lux + delux + qr_3azn;
            rasim.Toplam_Say = Convert.ToString(totalCount);


        }

        // cal total price of parfume...
        private void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Rasim rasim)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);


            CalcCountOfParfume(rasim);
            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            rasim.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            rasim.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            rasim.Toplam_Aldıgım = totalMoney;

        }

        // update event....
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfRasimPage.CurrentRow.Cells[0].Value.ToString());
                UpdateEntity(entityId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewOfRasimPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select contact from inside from table rows...

            Rasim rasim = new Rasim();

            try
            {

                textBox10ML.Text = dataGridViewOfRasimPage.CurrentRow.Cells[1].Value.ToString();
                textBox20ML.Text = dataGridViewOfRasimPage.CurrentRow.Cells[2].Value.ToString();
                textBox30ML.Text = dataGridViewOfRasimPage.CurrentRow.Cells[3].Value.ToString();
                textBoxLUX.Text = dataGridViewOfRasimPage.CurrentRow.Cells[4].Value.ToString();
                textBoxDELUX.Text = dataGridViewOfRasimPage.CurrentRow.Cells[5].Value.ToString();
                textBoxQr_3AZN.Text = dataGridViewOfRasimPage.CurrentRow.Cells[6].Value.ToString();
                rasim.Toplam_Say = dataGridViewOfRasimPage.CurrentRow.Cells[7].Value.ToString();
                rasim.Maya_Deyeri = Convert.ToDouble(dataGridViewOfRasimPage.CurrentRow.Cells[8].Value.ToString());
                rasim.Qazancım = Convert.ToDouble(dataGridViewOfRasimPage.CurrentRow.Cells[9].Value.ToString());
                rasim.Toplam_Aldıgım = Convert.ToDouble(dataGridViewOfRasimPage.CurrentRow.Cells[10].Value.ToString());
                rasim.Zaman = Convert.ToDateTime(dataGridViewOfRasimPage.CurrentRow.Cells[11].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // update method...
        private void UpdateEntity(int entityId)
        {
            Rasim rasim = db.SalesOfRasim.SingleOrDefault(s => s.Id == entityId);

            rasim.ML_10 = textBox10ML.Text;
            rasim.ML_20 = textBox20ML.Text;
            rasim.ML_30 = textBox30ML.Text;
            rasim.LUX = textBoxLUX.Text;
            rasim.DELUX = textBoxDELUX.Text;
            rasim.Qr_3AZN = textBoxQr_3AZN.Text;
            // -------------------------------------------------------------------
            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);



            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            rasim.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            rasim.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            rasim.Toplam_Aldıgım = totalMoney;
            //----------------------------------------------------------------------------
            db.SaveChanges();
            GetAllSales();
        }

        // Delete event...
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfRasimPage.CurrentRow.Cells[0].Value.ToString());
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



            Rasim rasim = db.SalesOfRasim.SingleOrDefault(c => c.Id == entityId);

            alert = MessageBox.Show($"Satışı silmək istədiyindən əminsən?", "Satış silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.SalesOfRasim.Remove(rasim);
                db.SaveChanges();
            }
            GetAllSales();
        }
    }
}
