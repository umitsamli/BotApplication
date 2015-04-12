using SAMLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KlanlarBot
{
    public enum WebBrowserProcess
    {

        OtomatikSaldiri = 0,
        SaldiriOnay = 1,

        Normal = 2,
        Giris = 3,
        OtomatikSaldiriHazirla = 4
    }
    public static class Utility
    {
        private static List<BarbarianVillage> _barbarianVillages;

        public static WebBrowser WebBrowser { get; set; }
        public static WebBrowserProcess WebBrowserProcess { get; set; }
        public static List<BarbarianVillage> BarbarianVillages
        {
            get
            {
                if (_barbarianVillages == null)
                    _barbarianVillages = new List<BarbarianVillage>();
                return _barbarianVillages;
            }
            set { _barbarianVillages = value; }
        }

        public static string TümKoyler = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=overview_villages";
        public static string Harita = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=map";
        public static string Raporlar = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=report";
        public static string Mesajlar = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=mail";
        public static string Siralama = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=ranking";
        public static string Klan = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=ally";
        public static string Profil = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=info_player";
        public static string Premium = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=premium";
        public static string Ayarlar = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=settings";
        public static string Market = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=market";
        public static string İctimaMeydani = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=place";
        public static string Demirci = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=smith";
        public static string Akademi = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=snob";
        public static string Atolye = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=garage";
        public static string Ahır = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=stable";
        public static string Kisla = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=barracks";
        public static string AnaBina = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=main";
        public static string Koy = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&screen=overview";
        public static string AskerTopla = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&mode=train&screen=train";
        public static string AcigaAlma = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&mode=decommission&screen=train";
        public static string TopluAskerToplama = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&mode=mass&screen=train";
        public static string TopluAcigaAlma = Parameters.Server + ".klanlar.org/game.php?village=" + Parameters.VillageID + "&mode=mass_decommission&screen=train";
    }
}

