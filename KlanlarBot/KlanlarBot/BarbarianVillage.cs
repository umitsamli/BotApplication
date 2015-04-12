using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlanlarBot
{
    public class BarbarianVillage 
    {
        public string Kordinat { get; set; }
        public double Uzaklik { get; set; }
        public int ToplamSaldiriSayisi { get; set; }
        public DateTime SonSaldiri { get; set; }
        public DateTime SonSaldiriVaris { get; set; }
        public DateTime SonSaldiriDonus { get; set; } 
         
    }
}
