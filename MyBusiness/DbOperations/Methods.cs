using MyBusiness.Core.Abstracts;
using MyBusiness.Core.Concrets;
using MyBusiness.Entities;
using MyBusiness.UI.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyBusiness.DbOperations
{
    public class Methods 
    {
        //************************** SELLER METHODS STARTED *******************************

        // GETALL SELLERS...
        public static void GetAllSellers(DataGridView dataGridView, AppContextDb db)
        {
            dataGridView.DataSource = db.Sellers.ToList();
        }

        // ADD SELLER....
        public static void AddSeller(Seller entity,string NAME,string ML10,string ML20,
            string ML30,string LUX,string DELUX,string Qr3AZN, DateTime date)

        {
            
            entity.Satıcının_Adı = NAME;
            entity.ML_10 = ML10;
            entity.ML_20 = ML20;
            entity.ML_30 = ML30;
            entity.LUX = LUX;
            entity.DELUX = DELUX;
            entity.Qr_3AZN = Qr3AZN;
            CalcCountOfParfumes(entity, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(entity, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
            entity.Zaman = date;       
            
        }


        // CALC TOTAL COUNT OF PARFUMES...
        public static void CalcCountOfParfumes(Seller entity, string ML10, string ML20,
            string ML30, string LUX, string DELUX, string Qr3AZN)
        {
            var ml10 = Convert.ToInt32(ML10);
            var ml20 = Convert.ToInt32(ML20);
            var ml30 = Convert.ToInt32( ML30);
            var lux = Convert.ToInt32(LUX);
            var delux = Convert.ToInt32(DELUX);
            var qr3azn = Convert.ToInt32(Qr3AZN);
            var totalCount = ml10 + ml20 + ml30 + lux + delux + qr3azn;
            entity.Toplam_Say = Convert.ToString(totalCount);

            entity.ML_10 = ML10;
            entity.ML_20 = ML20;
            entity.ML_30 = ML30;
            entity.LUX = LUX;
            entity.DELUX = DELUX;
            entity.Qr_3AZN = Qr3AZN;
            
        }

        // CALC DEPO PRICE OF PARFUMES AND MYGAIN AND TOTAL MONEY 0F SELLERS....
        public static void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(Seller entity, string ML10, string ML20,
            string ML30, string LUX, string DELUX, string Qr3AZN)
        {

            var ml_10 = Convert.ToInt32(ML10);
            var ml_20 = Convert.ToInt32(ML20);
            var ml_30 = Convert.ToInt32(ML30);
            var lux = Convert.ToInt32(LUX);
            var delux = Convert.ToInt32(DELUX);
            var qr_3azn = Convert.ToInt32(Qr3AZN);



           if(entity.Satıcının_Adı == "kamil")
            {
                double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
                entity.Maya_Deyeri = depoPrice;
                double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 1) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
                entity.Qazancım = myTotalGain;
                double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 11) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
                entity.Toplam_Alacagim = totalMoney;
            }
            else
            {
                double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
                entity.Maya_Deyeri = depoPrice;
                double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 1) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
                entity.Qazancım = myTotalGain;
                double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
                entity.Toplam_Alacagim = totalMoney;
            }

        }

        // DECREASE PARFUMES FROM SELLER..
        public static void DecreaseParfumesFromSellers(AppContextDb db, string NAME, string ML10, string ML20,
            string ML30, string LUX, string DELUX, string Qr3AZN)
        {
            Seller seller = db.Sellers.SingleOrDefault(x => x.Satıcının_Adı == NAME);
            if (seller.Satıcının_Adı == NAME)
            {
                var result_ml10 = Convert.ToInt32(seller.ML_10) - Convert.ToInt32(ML10);
                seller.ML_10 = Convert.ToString(result_ml10);
                var result_ml20 = Convert.ToInt32(seller.ML_20) - Convert.ToInt32(ML20);
                seller.ML_20 = Convert.ToString(result_ml20);
                var result_ml30 = Convert.ToInt32(seller.ML_30) - Convert.ToInt32(ML30);
                seller.ML_30 = Convert.ToString(result_ml30);
                var result_lux = Convert.ToInt32(seller.LUX) - Convert.ToInt32(LUX);
                seller.LUX = Convert.ToString(result_lux);
                var result_delux = Convert.ToInt32(seller.DELUX) - Convert.ToInt32(DELUX);
                seller.DELUX = Convert.ToString(result_delux);
                var result_qr3azn = Convert.ToInt32(seller.Qr_3AZN) - Convert.ToInt32(Qr3AZN);
                seller.Qr_3AZN = Convert.ToString(result_qr3azn);

            }
        }

        // UPDATE SELLER...
        public static void UpdateSeller(int sellerId, AppContextDb db, string NAME, string ML10, string ML20,
            string ML30, string LUX, string DELUX, string Qr3AZN)
        {

            Seller entity = db.Sellers.SingleOrDefault(s => s.Id == sellerId);
            entity.Satıcının_Adı = NAME;
            entity.ML_10 = ML10;
            entity.ML_20 = ML20;
            entity.ML_30 = ML30;
            entity.LUX = LUX;
            entity.DELUX = DELUX;
            entity.Qr_3AZN = Qr3AZN;
            // -------------------------------------------------------------------
            var ml_10 = Convert.ToInt32(ML10);
            var ml_20 = Convert.ToInt32(ML20);
            var ml_30 = Convert.ToInt32(ML30);
            var lux = Convert.ToInt32(LUX);
            var delux = Convert.ToInt32(DELUX);
            var qr_3azn = Convert.ToInt32(Qr3AZN);


            CalcCountOfParfumes(entity, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney(entity, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
            
            db.SaveChanges();
            
        }
        //************************** SALE METHODS STARTED *******************************






        //************************** SALE METHODS STARTED *******************************

        // GETALL SALES...
        public static void GetAllSales(DataGridView dataGridView, AppContextDb db)
        {
            dataGridView.DataSource = db.Sales.ToList();
        }


        // ADD SALE....
        public static void AddSale(Sale entity, string NAME, string ML10, string ML20,
            string ML30, string LUX, string DELUX, string Qr3AZN, DateTime date)

        {

            entity.Satıcının_Adı = NAME;
            entity.ML_10 = ML10;
            entity.ML_20 = ML20;
            entity.ML_30 = ML30;
            entity.LUX = LUX;
            entity.DELUX = DELUX;
            entity.Qr_3AZN = Qr3AZN;
            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney2(entity, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
            entity.Zaman = date;


        }

        // CALC DEPO PRICE OF PARFUMES AND MYGAIN AND TOTAL MONEY OF SALES....
        public static void CalcDepoPriceOfParfumesAndMyGainAndTotalMoney2(Sale entity, string ML10, string ML20,
            string ML30, string LUX, string DELUX, string Qr3AZN)
        {

            var ml_10 = Convert.ToInt32(ML10);
            var ml_20 = Convert.ToInt32(ML20);
            var ml_30 = Convert.ToInt32(ML30);
            var lux = Convert.ToInt32(LUX);
            var delux = Convert.ToInt32(DELUX);
            var qr_3azn = Convert.ToInt32(Qr3AZN);



            if (entity.Satıcının_Adı == "kamil")
            {
                double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
                entity.Maya_Deyeri = depoPrice;
                double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 1) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
                entity.Qazancım = myTotalGain;
                double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 11) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
                entity.Toplam_Aldıgım = totalMoney;
            }
            else
            {
                double depoPrice = (ml_10 * 2.50) + (ml_20 * 6) + (ml_30 * 10) + (lux * 5) + (delux * 9) + (qr_3azn * 1.80);
                entity.Maya_Deyeri = depoPrice;
                double myTotalGain = (ml_10 * 0.50) + (ml_20 * 2) + (ml_30 * 1) + (lux * 1) + (delux * 2) + (qr_3azn * 0.60);
                entity.Qazancım = myTotalGain;
                double totalMoney = (ml_10 * 3) + (ml_20 * 8) + (ml_30 * 12) + (lux * 6) + (delux * 11) + (qr_3azn * 2.40);
                entity.Toplam_Aldıgım = totalMoney;
            }

        }

        // UPDATE SELLER...
        public static void UpdateSale(int saleId, AppContextDb db, string NAME, string ML10, string ML20,
            string ML30, string LUX, string DELUX, string Qr3AZN)
        {

            Sale entity = db.Sales.SingleOrDefault(s => s.Id == saleId);
            entity.Satıcının_Adı = NAME;
            entity.ML_10 = ML10;
            entity.ML_20 = ML20;
            entity.ML_30 = ML30;
            entity.LUX = LUX;
            entity.DELUX = DELUX;
            entity.Qr_3AZN = Qr3AZN;
            // -------------------------------------------------------------------
            var ml_10 = Convert.ToInt32(ML10);
            var ml_20 = Convert.ToInt32(ML20);
            var ml_30 = Convert.ToInt32(ML30);
            var lux = Convert.ToInt32(LUX);
            var delux = Convert.ToInt32(DELUX);
            var qr_3azn = Convert.ToInt32(Qr3AZN);


            CalcDepoPriceOfParfumesAndMyGainAndTotalMoney2(entity, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
            Methods.DecreaseParfumesFromSellers(db, NAME, ML10, ML20, ML30, LUX, DELUX, Qr3AZN);
            db.SaveChanges();

        }


        //************************** END OF SALE METHODS *******************************


    }
}
