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
    public partial class CreditsPage : Form
    {
        AppContextDb db = new AppContextDb();
        DialogResult alert;
        DateTime date = DateTime.Now;

        public CreditsPage()
        {
            InitializeComponent();
        }

        private void CreditsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void CreditsPage_Load(object sender, EventArgs e)
        {
            GetAllCredits();
        }

        // GetAllSellers method...
        private void GetAllCredits()
        {
            dataGridViewOfCreditsPage.DataSource = db.Credits.ToList();
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
            Credit credit = new Credit();
            try
            {
                AddEntity(credit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // add method..
        private void AddEntity(Credit credit)
        {
            credit.Adı = textBoxNAME.Text;
            credit.ML_10 = textBox10ML.Text;
            credit.ML_20 = textBox20ML.Text;
            credit.ML_30 = textBox30ML.Text;
            credit.LUX = textBoxLUX.Text;
            credit.DELUX = textBoxDELUX.Text;
            credit.Qr_3AZN = textBoxQr_3AZN.Text;
            CalcCountOfParfume(credit);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(credit);
            credit.Zaman = date;
            db.Credits.Add(credit);
            db.SaveChanges();
            GetAllCredits();
        }


        // calc total count of parfume...
        private void CalcCountOfParfume(Credit credit)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);
            var totalCount = ml_10 + ml_20 + ml_30 + lux + delux + qr_3azn;
            credit.Toplam_Say = Convert.ToString(totalCount);


        }


        // cal total price of parfume...
        private void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Credit credit)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);



            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            credit.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            credit.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 12) + (ml_30 * 15) + (lux * 10) + (delux * 15) + (qr_3azn * 3);
            credit.Toplam_Alacagim = totalMoney;

        }

        // update event....
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                int creditId = Convert.ToInt32(dataGridViewOfCreditsPage.CurrentRow.Cells[0].Value.ToString());
                UpdateSeller(creditId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewOfCreditsPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select contact from inside from table rows...

            Credit credit = new Credit();

            try
            {
                textBoxNAME.Text = dataGridViewOfCreditsPage.CurrentRow.Cells[1].Value.ToString();
                textBox10ML.Text = dataGridViewOfCreditsPage.CurrentRow.Cells[2].Value.ToString();
                textBox20ML.Text = dataGridViewOfCreditsPage.CurrentRow.Cells[3].Value.ToString();
                textBox30ML.Text = dataGridViewOfCreditsPage.CurrentRow.Cells[4].Value.ToString();
                textBoxLUX.Text = dataGridViewOfCreditsPage.CurrentRow.Cells[5].Value.ToString();
                textBoxDELUX.Text = dataGridViewOfCreditsPage.CurrentRow.Cells[6].Value.ToString();
                textBoxQr_3AZN.Text = dataGridViewOfCreditsPage.CurrentRow.Cells[7].Value.ToString();
                credit.Toplam_Say = dataGridViewOfCreditsPage.CurrentRow.Cells[8].Value.ToString();
                credit.Maya_Deyeri = Convert.ToDouble(dataGridViewOfCreditsPage.CurrentRow.Cells[9].Value.ToString());
                credit.Qazancım = Convert.ToDouble(dataGridViewOfCreditsPage.CurrentRow.Cells[10].Value.ToString());
                credit.Toplam_Alacagim = Convert.ToDouble(dataGridViewOfCreditsPage.CurrentRow.Cells[11].Value.ToString());
                credit.Zaman = Convert.ToDateTime(dataGridViewOfCreditsPage.CurrentRow.Cells[12].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // update method...
        private void UpdateSeller(int creditId)
        {
            Credit credit = db.Credits.SingleOrDefault(c => c.Id == creditId);
            credit.Adı = textBoxNAME.Text;
            credit.ML_10 = textBox10ML.Text;
            credit.ML_20 = textBox20ML.Text;
            credit.ML_30 = textBox30ML.Text;
            credit.LUX = textBoxLUX.Text;
            credit.DELUX = textBoxDELUX.Text;
            credit.Qr_3AZN = textBoxQr_3AZN.Text;
            // -------------------------------------------------------------------
            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);


            CalcCountOfParfume(credit);
            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            credit.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            credit.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 12) + (ml_30 * 15) + (lux * 10) + (delux * 15) + (qr_3azn * 3);
            credit.Toplam_Alacagim = totalMoney;

            //----------------------------------------------------------------------------
            db.SaveChanges();
            GetAllCredits();
        }

        // Delete event...
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int creditId = Convert.ToInt32(dataGridViewOfCreditsPage.CurrentRow.Cells[0].Value.ToString());
                DeleteSeller(creditId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // delete method...

        private void DeleteSeller(int creditId)
        {

            var name = dataGridViewOfCreditsPage.CurrentRow.Cells[1].Value.ToString();

            Credit credit = db.Credits.SingleOrDefault(c => c.Id == creditId);

            alert = MessageBox.Show($"{name}    " + $"adındaki şəxsi silmək istədiyindən əminsən?", "İstifadəçi silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.Credits.Remove(credit);
                db.SaveChanges();
            }
            GetAllCredits();
        }


    }
}
