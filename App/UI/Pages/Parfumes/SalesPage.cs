using App;
using App.DbOperations;
using App.Entities;
using App.UI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBusiness.UI.Pages
{
    public partial class SalesPage : Form
    {
        AppContextDb db = new AppContextDb();
        DateTime date = DateTime.Now;
        DialogResult alert;
        public SalesPage()
        {
            InitializeComponent();
        }

        private void SalesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParfumesDashboard parfumesDashboard = new ParfumesDashboard();
            parfumesDashboard.Show();
        }

        private void SalesPage_Load(object sender, EventArgs e)
        {
            Methods.GetAllSales(dataGridViewOfSalesPage, db);
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
            Sale sale = new Sale();


            string NAME = textBoxNAME.Text;
            string ML10 = textBox10ML.Text;
            string ML20 = textBox20ML.Text;
            string ML30 = textBox30ML.Text;
            string LUX = textBoxLUX.Text;
            string DELUX = textBoxDELUX.Text;
            string Qr3AZN = textBoxQr3AZN.Text;

            try
            {
                Methods.AddSale(sale, NAME, ML10, ML20, ML30, LUX, DELUX, Qr3AZN, date);
                Methods.DecreaseParfumesFromSellers(db, NAME, ML10, ML20, ML30, LUX, DELUX, Qr3AZN, date);
                db.Sales.Add(sale);
                db.SaveChanges();
                ClearAllInputs();
                Methods.GetAllSales(dataGridViewOfSalesPage, db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // UPDATE OPERATIONS....
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
                int saleId = Convert.ToInt32(dataGridViewOfSalesPage.CurrentRow.Cells[0].Value.ToString());
                Methods.UpdateSale(saleId, db, NAME, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
                Methods.GetAllSales(dataGridViewOfSalesPage, db);
                ClearAllInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewOfSalesPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select contact from inside from table rows...

            Sale sale = new Sale();

            try
            {
                textBoxNAME.Text = dataGridViewOfSalesPage.CurrentRow.Cells[1].Value.ToString();
                textBox10ML.Text = dataGridViewOfSalesPage.CurrentRow.Cells[2].Value.ToString();
                textBox20ML.Text = dataGridViewOfSalesPage.CurrentRow.Cells[3].Value.ToString();
                textBox30ML.Text = dataGridViewOfSalesPage.CurrentRow.Cells[4].Value.ToString();
                textBoxLUX.Text = dataGridViewOfSalesPage.CurrentRow.Cells[5].Value.ToString();
                textBoxDELUX.Text = dataGridViewOfSalesPage.CurrentRow.Cells[6].Value.ToString();
                textBoxQr3AZN.Text = dataGridViewOfSalesPage.CurrentRow.Cells[7].Value.ToString();
                sale.Maya_Deyeri = Convert.ToDouble(dataGridViewOfSalesPage.CurrentRow.Cells[8].Value.ToString());
                sale.Qazancım = Convert.ToDouble(dataGridViewOfSalesPage.CurrentRow.Cells[9].Value.ToString());
                sale.Toplam_Aldıgım = Convert.ToDouble(dataGridViewOfSalesPage.CurrentRow.Cells[10].Value.ToString());
                sale.Zaman = Convert.ToDateTime(dataGridViewOfSalesPage.CurrentRow.Cells[11].Value.ToString());

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
                int saleId = Convert.ToInt32(dataGridViewOfSalesPage.CurrentRow.Cells[0].Value.ToString());
                DeleteSale(saleId, dataGridViewOfSalesPage, db);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // DELETE METHOD...
        private void DeleteSale(int sellerId, DataGridView dataGridView, AppContextDb db)
        {

            var name = dataGridView.CurrentRow.Cells[1].Value.ToString();

            Sale sale = db.Sales.SingleOrDefault(s => s.Id == sellerId);

            alert = MessageBox.Show($"{name}    " + $"adındaki şəxsi silmək istədiyindən əminsən?", "İstifadəçi silinəcək!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (alert == DialogResult.Yes)
            {
                db.Sales.Remove(sale);
                db.SaveChanges();
            }
            Methods.GetAllSales(dataGridViewOfSalesPage, db);
        }


    }
}
