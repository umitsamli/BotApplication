using System;
using System.Diagnostics;
using System.IO;

namespace SAMLibrary
{
    public static class Log
    {
        private static bool addListener = false;
        static string folder = SystemParameters.UygulamaYolu + SystemParameters.UygulamaAdi;
        static string trace = DateTime.Now.ToString("dd_MM_yy") + ".trace";
        static string filepath = folder + "\\" + trace;
        public static void AddListener()
        {
            try
            {
                bool append = true;
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                StreamWriter writer = new StreamWriter(filepath, append, System.Text.Encoding.GetEncoding("windows-1254"));
                TextWriterTraceListener listener = new TextWriterTraceListener(writer);
                Trace.Listeners.Add(listener);
                Trace.AutoFlush = true;
                addListener = true;
            }
            catch
            {
                addListener = false;
            }
        }
        private static void Logs(string message)
        {
            try
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                using (TextWriter txt = File.AppendText(filepath))
                {
                    txt.WriteLine("--> " + DateTime.Now.ToString("hh : mm : ss") + "-->  Message : " + message);
                    txt.Dispose();
                }
            }
            catch { }
        }
        private static void TraceLog(string type, string message)
        {
            try
            {
                string modul = (new StackTrace()).GetFrame(1).GetMethod().ToString();
                Trace.WriteLine("-->" + DateTime.Now.ToString("hh:mm:ss") + "--> " + type + " -->" + message + " " + modul);
            }
            catch { }
        }
        public static void WriteError(string str)
        {
            if (addListener) TraceLog("ERROR", str);
            else Logs(str);
        }
        public static void WriteInfo(string str)
        {
            if (addListener) TraceLog("INFO", str);
            else Logs(str);
        }
        public static void WriteWarning(string str)
        {
            if (addListener) TraceLog("WARNING", str);
            else Logs(str);
        }
    }
}
