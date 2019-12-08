using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusBilgileriApp.MODELS
{
    public class Ucak
    {
        public string Id_Ucak { get; set; }
        public string Ucak_Adi { get; set; }
        public int Yolcu_Sayisi { get; set; }
        public string Id_Havayolu { get; set; }
        public int Adet { get; set; }
    }
}
