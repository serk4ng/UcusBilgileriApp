using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusBilgileriApp.MODELS
{
    public class Ucus
    {
        public string Ucus_Numarasi { get; set; }
        public string Id_Havayolu { get; set; }
        public string Kalkis_Yeri_Id { get; set; }
        public string Varis_Yeri_Id { get; set; }
        public DateTime Kalkis_Tarih { get; set; }
        public TimeSpan Kalkis_Saat { get; set; }
        public DateTime Varis_Tarih { get; set; }
        public TimeSpan Varis_Saat { get; set; }
        public TimeSpan Tahmini_Sure { get; set; }
        public string Id_Ucak { get; set; }
    }
}
