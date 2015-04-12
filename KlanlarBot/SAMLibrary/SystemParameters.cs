
namespace SAMLibrary
{
    public static class SystemParameters
    {
        #region Globals
        private static string _uygulamaYolu;
        private static string _uygulamaAdi;
        #endregion
        public static string UygulamaYolu
        {
            get
            {
                if (string.IsNullOrEmpty(_uygulamaYolu))
                    return "C:\\SAM\\";
                else
                    return _uygulamaYolu;
            }
            set { _uygulamaYolu = value; }
        }
        public static string UygulamaAdi
        {
            get
            {
                if (string.IsNullOrEmpty(_uygulamaAdi))
                    return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                else
                    return _uygulamaAdi;
            }
            set { _uygulamaAdi = value; }
        }
    }
}
