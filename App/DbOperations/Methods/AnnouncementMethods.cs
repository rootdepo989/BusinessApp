using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace App.DbOperations.Methods
{
    public class AnnouncementMethods
    {
       

        //************************** ANNOUNCEMENT METHODS STARTED *******************************

        // GETALL ANNOUNCEMENT...
        public static void GetAllAnnouncements(DataGridView dataGridView, AppContextDb db)
        {
            Announcement announcement = new Announcement();
            CalcTotalTimeOfAnnoncement(announcement);
            dataGridView.DataSource = db.Announcements.ToList();
        }

        // ADD ANNONCEMENT....
        public static void AddAnnoncement(Announcement entity, string NAME, string CATEGORY, string PAYED,
                 DateTime TIMESTART,DateTime TIMEFINISHED)

        {
           

            entity.Adı = NAME;
            entity.Kateqoriya = CATEGORY;
            entity.Ödənilən_Məbləğ = PAYED += " AZN";
            entity.Başlama_Müddəti = TIMESTART;
            entity.Bitmə_Müddəti = TIMEFINISHED;
            CalcTotalTimeOfAnnoncement(entity);



        }

        // CALC TOTAL TIME OF ANNONCEMENT.....

        public static void CalcTotalTimeOfAnnoncement(Announcement entity)
        {
           
            var totalDayOfAnnouncement = entity.Bitmə_Müddəti - DateTime.Today;
            string totaldays = Convert.ToString(totalDayOfAnnouncement.Days);
            

            if (entity.Bitmə_Müddəti == DateTime.Today)
            {
                entity.Toplam_Müddəti = "Müddət Bitdi";
                          
            }
            else
            {
                entity.Toplam_Müddəti = totaldays += " Gün qaldı";
            }
       
        }



        // UPDATE ANNOUNCEMENT METHOD...
        public static void UpdateAnnoncement(int annoncementId, AppContextDb db, string NAME, string CATEGORY, string PAYED)
        {

            Announcement entity = db.Announcements.SingleOrDefault(a => a.Id == annoncementId);
            entity.Adı = NAME;
            entity.Kateqoriya = CATEGORY;
            entity.Ödənilən_Məbləğ = PAYED += " AZN"; 
            CalcTotalTimeOfAnnoncement(entity);
              

            db.SaveChanges();

        }


    }
}
