using SAMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlanlarBot
{
    public class Parameters
    {
        public static string Username
        {
            get { return TRegister.ReadRegister("Username"); }
            set { TRegister.WriteRegister("Username", value); }
        }  
        public static string Password
        {
            get { return TRegister.ReadRegister("Password"); }
            set { TRegister.WriteRegister("Password", value); }
        } 
        public static string Server
        {
            get { return TRegister.ReadRegister("Server"); }
            set { TRegister.WriteRegister("Server", value); }
        }
        public static string VillageID
        {
            get { return TRegister.ReadRegister("VillageID"); }
            set { TRegister.WriteRegister("VillageID", value); }
        } 
        public static string VillageLocation
        {
            get { return TRegister.ReadRegister("VillageLocation"); }
            set { TRegister.WriteRegister("VillageLocation", value); }
        }
        public static string AutoAtackVillages
        {
            get { return TRegister.ReadRegister("AutoAtackVillages"); }
            set { TRegister.WriteRegister("AutoAtackVillages", value); }
        }
        public static bool AutoLogin
        {
            get { return Convert.ToBoolean(TRegister.ReadRegister("AutoLogin")); }
            set { TRegister.WriteRegister("AutoLogin", value.ToString()); }
        }
         
    }
}
