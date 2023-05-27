﻿using BusinessApp.DbOperations;
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
    public partial class SalesOfXalid : Form
    {
        AppContextDb db = new AppContextDb();
        DialogResult alert;
        DateTime date = DateTime.Now;

        public SalesOfXalid()
        {
            InitializeComponent();
        }

        private void SalesOfXalid_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage salesPage = new SalesPage();
            salesPage.Show();
        }

        private void SalesOfXalid_Load(object sender, EventArgs e)
        {
            GetAllSales();
        }

        // GetAllSellers method...
        private void GetAllSales()
        {
            dataGridViewOfXalidPage.DataSource = db.SalesOfXalid.ToList();
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
            Xalid xalid = new Xalid();
            try
            {
                AddEntity(xalid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // add method..
        private void AddEntity(Xalid xalid)
        {

            xalid.ML_10 = textBox10ML.Text;
            xalid.ML_20 = textBox20ML.Text;
            xalid.ML_30 = textBox30ML.Text;
            xalid.LUX = textBoxLUX.Text;
            xalid.DELUX = textBoxDELUX.Text;
            xalid.Qr_3AZN = textBoxQr_3AZN.Text;
            CalcCountOfParfume(xalid);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(xalid);
            xalid.Zaman = date;
            db.SalesOfXalid.Add(xalid);
            DecreaseParfumesFromSellers();
            db.SaveChanges();
            GetAllSales();
        }

        // decrease parfumes of sellers
        private void DecreaseParfumesFromSellers()
        {
            Seller seller = db.Sellers.SingleOrDefault(x => x.Satıcının_Adı == "xalid");
            if (seller.Satıcının_Adı == "xalid")
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
        private void CalcCountOfParfume(Xalid xalid)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);
            var totalCount = ml_10 + ml_20 + ml_30 + lux + delux + qr_3azn;
            xalid.Toplam_Say = Convert.ToString(totalCount);


        }

        // cal total price of parfume...
        private void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Xalid xalid)
        {

            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);


            CalcCountOfParfume(xalid);
            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            xalid.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            xalid.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            xalid.Toplam_Aldıgım = totalMoney;

        }

        // update event....
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {

            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfXalidPage.CurrentRow.Cells[0].Value.ToString());
                UpdateEntity(entityId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewOfXalidPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select contact from inside from table rows...

            Xalid xalid = new Xalid();

            try
            {

                textBox10ML.Text = dataGridViewOfXalidPage.CurrentRow.Cells[1].Value.ToString();
                textBox20ML.Text = dataGridViewOfXalidPage.CurrentRow.Cells[2].Value.ToString();
                textBox30ML.Text = dataGridViewOfXalidPage.CurrentRow.Cells[3].Value.ToString();
                textBoxLUX.Text = dataGridViewOfXalidPage.CurrentRow.Cells[4].Value.ToString();
                textBoxDELUX.Text = dataGridViewOfXalidPage.CurrentRow.Cells[5].Value.ToString();
                textBoxQr_3AZN.Text = dataGridViewOfXalidPage.CurrentRow.Cells[6].Value.ToString();
                xalid.Toplam_Say = dataGridViewOfXalidPage.CurrentRow.Cells[7].Value.ToString();
                xalid.Maya_Deyeri = Convert.ToDouble(dataGridViewOfXalidPage.CurrentRow.Cells[8].Value.ToString());
                xalid.Qazancım = Convert.ToDouble(dataGridViewOfXalidPage.CurrentRow.Cells[9].Value.ToString());
                xalid.Toplam_Aldıgım = Convert.ToDouble(dataGridViewOfXalidPage.CurrentRow.Cells[10].Value.ToString());
                xalid.Zaman = Convert.ToDateTime(dataGridViewOfXalidPage.CurrentRow.Cells[11].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // update method...
        private void UpdateEntity(int entityId)
        {
            Xalid xalid = db.SalesOfXalid.SingleOrDefault(s => s.Id == entityId);

            xalid.ML_10 = textBox10ML.Text;
            xalid.ML_20 = textBox20ML.Text;
            xalid.ML_30 = textBox30ML.Text;
            xalid.LUX = textBoxLUX.Text;
            xalid.DELUX = textBoxDELUX.Text;
            xalid.Qr_3AZN = textBoxQr_3AZN.Text;
            // -------------------------------------------------------------------
            var ml_10 = Convert.ToInt32(textBox10ML.Text);
            var ml_20 = Convert.ToInt32(textBox20ML.Text);
            var ml_30 = Convert.ToInt32(textBox30ML.Text);
            var lux = Convert.ToInt32(textBoxLUX.Text);
            var delux = Convert.ToInt32(textBoxDELUX.Text);
            var qr_3azn = Convert.ToInt32(textBoxQr_3AZN.Text);



            double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
            xalid.Maya_Deyeri = depoPrice;
            double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 2) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
            xalid.Qazancım = myTotalGain;
            double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
            xalid.Toplam_Aldıgım = totalMoney;
            //----------------------------------------------------------------------------
            db.SaveChanges();
            GetAllSales();
        }

        // Delete event...
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int entityId = Convert.ToInt32(dataGridViewOfXalidPage.CurrentRow.Cells[0].Value.ToString());
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



            Xalid xalid = db.SalesOfXalid.SingleOrDefault(c => c.Id == entityId);

            alert = MessageBox.Show($"Satışı silmək istədiyindən əminsən?", "Satış silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.SalesOfXalid.Remove(xalid);
                db.SaveChanges();
            }
            GetAllSales();
        }
    }
}