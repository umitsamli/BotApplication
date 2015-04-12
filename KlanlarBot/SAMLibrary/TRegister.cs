using Microsoft.Win32;
using System;

namespace SAMLibrary
{
    public class TRegister
    {
        const string DefaultKey = "SAMLibrary";
        public static string ReadRegister(string key)
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey(DefaultKey) == null)
                {
                    WriteRegister(key, "");
                    return "";
                }
                if (Registry.CurrentUser.OpenSubKey(DefaultKey, true).OpenSubKey(SystemParameters.UygulamaAdi, true) == null)
                {
                    WriteRegister(key, "");
                    return "";
                }
                RegistryKey keys = Registry.CurrentUser.OpenSubKey(DefaultKey).OpenSubKey(SystemParameters.UygulamaAdi, true);
                string str = keys.GetValue(key, "").ToString();
                keys.Close();
                return str;
            }
            catch (Exception exc)
            {
                Log.WriteError(exc.ToString());
                return "";
            }
        }
        public static  bool WriteRegister(string key, string svalue)
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey(DefaultKey, true) == null)
                {
                    Registry.CurrentUser.CreateSubKey(DefaultKey);
                }
                if (Registry.CurrentUser.OpenSubKey(DefaultKey, true).OpenSubKey(SystemParameters.UygulamaAdi, true) == null)
                {
                    Registry.CurrentUser.OpenSubKey(DefaultKey, true).CreateSubKey(SystemParameters.UygulamaAdi);
                }
                Registry.CurrentUser.OpenSubKey(DefaultKey, true).OpenSubKey(SystemParameters.UygulamaAdi, true).SetValue(key, svalue);
                return true;
            }
            catch (Exception exc)
            {
                Log.WriteError(exc.ToString());
                return false;
            }
        }
        
    }

}
