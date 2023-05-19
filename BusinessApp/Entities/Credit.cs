using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Entities
{
    public class Credit
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string ML_10 { get; set; }
        public string ML_20 { get; set; }
        public string ML_30 { get; set; }
        public string LUX { get; set; }
        public string DELUX { get; set; }
        public string Qr_3AZN { get; set; }
        public string Toplam_Say { get; set; }
        public double Maya_Deyeri { get; set; }
        public double Qazancım { get; set; }
        public double Toplam_Alacagim { get; set; }
        public DateTime Zaman { get; set; }
    }
}
