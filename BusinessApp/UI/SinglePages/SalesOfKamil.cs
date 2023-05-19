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
    public partial class SalesOfKamil : Form
    {

        AppContextDb db = new AppContextDb();
        DialogResult alert;
        DateTime date = DateTime.Now;

        public SalesOfKamil()
        {
            InitializeComponent();
        }

        private void SalesOfKamil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage salesPage = new SalesPage();
            salesPage.Show();
        }

        private void SalesOfKamil_Load(object sender, EventArgs e)
        {
            GetAllSales();
        }

        // GetAllSellers method...
        private void GetAllSales()
        {
            dataGridViewOfKamilPage.DataSource = db.SalesOfKamil.ToList();
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
            Kamil kamil = new Kamil();
            try
            {
                AddEntity(kamil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        // add method..
        private void AddEntity(Kamil kamil)
        {

            kamil.ML_10 = textBox10ML.Text;
            kamil.ML_20 = textBox20ML.Text;
            kamil.ML_30 = textBox30ML.Text;
            kamil.LUX = textBoxLUX.Text;
            kamil.DELUX = textBoxDELUX.Text;
            kamil.Qr_3AZN = textBoxQr_3AZN.Text;
            CalcCountOfParfume(kamil);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(kamil);
            kamil.Zaman = date;
            db.SalesOfKamil.Add(kamil);
            DecreaseParfumesFromSellers();
            db.SaveChanges();
            GetAllSales();
        }

        // decrease parfumes of sellers
        private void DecreaseParfumesFromSellers()
        {
            Seller seller = db.Sellers.SingleOrDefault(x => x.Satıcının_Adı == "kamil");
            if (seller.Satıcının_Adı == "kamil")
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
        private void CalcCountOfParfume(Kamil kamil)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);
            var totalCount = ml_10 + ml_20 + ml_30 + lux + delux + qr_3azn;
            kamil.Toplam_Say = Convert.ToString(totalCount);


        }

        // cal total price of parfume...
        private void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Kamil kamil)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);


            CalcCountOfParfume(kamil);
            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            kamil.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            kamil.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            kamil.Toplam_Aldıgım = totalMoney;

        }

        // update event....
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfKamilPage.CurrentRow.Cells[0].Value.ToString());
                UpdateEntity(entityId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewOfKamilPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select contact from inside from table rows...

            Kamil kamil = new Kamil();

            try
            {

                textBox10ML.Text = dataGridViewOfKamilPage.CurrentRow.Cells[1].Value.ToString();
                textBox20ML.Text = dataGridViewOfKamilPage.CurrentRow.Cells[2].Value.ToString();
                textBox30ML.Text = dataGridViewOfKamilPage.CurrentRow.Cells[3].Value.ToString();
                textBoxLUX.Text = dataGridViewOfKamilPage.CurrentRow.Cells[4].Value.ToString();
                textBoxDELUX.Text = dataGridViewOfKamilPage.CurrentRow.Cells[5].Value.ToString();
                textBoxQr_3AZN.Text = dataGridViewOfKamilPage.CurrentRow.Cells[6].Value.ToString();
                kamil.Toplam_Say = dataGridViewOfKamilPage.CurrentRow.Cells[7].Value.ToString();
                kamil.Maya_Deyeri = Convert.ToDouble(dataGridViewOfKamilPage.CurrentRow.Cells[8].Value.ToString());
                kamil.Qazancım = Convert.ToDouble(dataGridViewOfKamilPage.CurrentRow.Cells[9].Value.ToString());
                kamil.Toplam_Aldıgım = Convert.ToDouble(dataGridViewOfKamilPage.CurrentRow.Cells[10].Value.ToString());
                kamil.Zaman = Convert.ToDateTime(dataGridViewOfKamilPage.CurrentRow.Cells[11].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // update method...
        private void UpdateEntity(int entityId)
        {
            Kamil kamil = db.SalesOfKamil.SingleOrDefault(s => s.Id == entityId);

            kamil.ML_10 = textBox10ML.Text;
            kamil.ML_20 = textBox20ML.Text;
            kamil.ML_30 = textBox30ML.Text;
            kamil.LUX = textBoxLUX.Text;
            kamil.DELUX = textBoxDELUX.Text;
            kamil.Qr_3AZN = textBoxQr_3AZN.Text;
            // -------------------------------------------------------------------
            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);



            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            kamil.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            kamil.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            kamil.Toplam_Aldıgım = totalMoney;
            //----------------------------------------------------------------------------
            db.SaveChanges();
            GetAllSales();
        }

        // Delete event...
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfKamilPage.CurrentRow.Cells[0].Value.ToString());
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



            Kamil kamil = db.SalesOfKamil.SingleOrDefault(c => c.Id == entityId);

            alert = MessageBox.Show($"Satışı silmək istədiyindən əminsən?", "Satış silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.SalesOfKamil.Remove(kamil);
                db.SaveChanges();
            }
            GetAllSales();
        }
    }
}
