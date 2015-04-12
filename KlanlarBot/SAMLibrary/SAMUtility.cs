using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Helpers;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAMLibrary
{
    public static class SAMUtility
    {
        #region Global Variables

        private static string _connectionString;
        private static Session _session;
        private static IDataLayer _datalayer;
        #endregion

        public static void ConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }
        public static Session Session
        {
            get
            {
                if (_session == null)
                {
                    string connStr = _connectionString;
                    //      string ConnStr = SQLiteConnectionProvider.GetConnectionString(Application.StartupPath + "\\DataBase.s3db");//Tools.Properties.Settings.Default.DataSource;
                    if (_datalayer == null)
                    {
                        if (string.IsNullOrEmpty(_connectionString))
                            connStr = "";
                        XPDictionary dictionary = new ReflectionDictionary();
                        XpoDefault.DataLayer = XpoDefault.GetDataLayer(connStr, AutoCreateOption.DatabaseAndSchema);
                        XpoDefault.Session = new Session(XpoDefault.DataLayer);
                        _datalayer = XpoDefault.GetDataLayer(connStr, AutoCreateOption.None);
                    }
                    _session = new DevExpress.Xpo.Session(_datalayer);
                    SessionStateStack.SuppressCrossThreadFailuresDetection = true;
                    Session.GlobalSuppressExceptionOnReferredObjectAbsentInDataStore = true;
                }
                return _session;
            }
        }
        public static IDataLayer DataLayer { get { return _datalayer; } }

    }
}
