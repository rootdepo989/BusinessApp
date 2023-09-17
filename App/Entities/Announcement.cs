using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Kateqoriya { get; set; }
        public string Ödənilən_Məbləğ { get; set; }
        public DateTime Başlama_Müddəti { get; set; }
        public DateTime Bitmə_Müddəti { get; set; }
        public string Toplam_Müddəti { get; set; }
    }
}
