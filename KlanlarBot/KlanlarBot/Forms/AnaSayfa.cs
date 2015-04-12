using SAMLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlanlarBot
{
    public partial class AnaSayfa : Form
    {
        int count = 0;
        string strMizrak = "";
        string strKilic = "";
        string strBalta = "";
        string strCasus = "";
        string strHafifAtli = "";
        string strAgirAtli = "";
        string strSahmerdan = "";
        string strMancinik = "";
        string strMisyoner = "";
        int sureMizrak = 25;
        int sureKilic = 22;
        int sureBalta = 18;
        int sureCasus = 9;
        int sureHafifAtli = 10;
        int sureAgirAtli = 11;
        int sureSahmerdan = 0;
        int sureMancinik = 0;
        int sureMisyoner = 0;

        int maxSure = 0;

        public AnaSayfa()
        {

            InitializeComponent();
            Utility.WebBrowser = webBrowser1;
            Utility.WebBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            panelLeft.Visible = panelOtomatikSaldiri.Visible = panelOtomatikInsaat.Visible = false;

            if (Parameters.AutoLogin)
                Utility.WebBrowserProcess = WebBrowserProcess.Giris;
            if (string.IsNullOrEmpty(Parameters.Server) ||
                string.IsNullOrEmpty(Parameters.VillageID) ||
                string.IsNullOrEmpty(Parameters.VillageLocation))
            {
                ayarlarToolStripMenuItem_Click(null, null);
            }

        }
        private void DocumentComplete()
        {
            while (Utility.WebBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
                Trace.WriteLine("Sayfa Bekleniyor...");
            }
            Trace.WriteLine("Sayfa Tamamlandı...");
        }
        public bool GirisKontrol()
        {
            if (Utility.WebBrowser.Url.ToString().IndexOf("overview_villages") > 0)
            {
                Utility.WebBrowser.Navigate(Utility.Koy);
                DocumentComplete();
            }

            return (Utility.WebBrowser.DocumentText.IndexOf("game_data") > 0 && Utility.WebBrowser.DocumentText.IndexOf("\"id\":" + Parameters.VillageID) > 0);
        }

        private void AnaSayfa_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.Text = "NotifyIcon Denemesi";
                notifyIcon.BalloonTipTitle = "Program Çalışıyor";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(30000);
            }

        }

        private double UzaklikHesap(string kordinat)
        {
            int mx = Convert.ToInt32(Parameters.VillageLocation.Split('|')[0]);
            int my = Convert.ToInt32(Parameters.VillageLocation.Split('|')[1]);
            int vx = Convert.ToInt32(kordinat.Split('|')[0]);
            int vy = Convert.ToInt32(kordinat.Split('|')[1]);

            return Math.Sqrt(Math.Pow((vx - mx), 2) + Math.Pow((vy - my), 2));

        }

        private void btnSaldiriBaslat_Click(object sender, EventArgs e)
        {
            strMizrak = this.txtMizrak.Text;
            strKilic = this.txtKilic.Text;
            strBalta = this.txtBalta.Text;
            strCasus = this.txtCasus.Text;
            strHafifAtli = this.txtHafifAtli.Text;
            strAgirAtli = this.txtAgirAtli.Text;

            Utility.BarbarianVillages.Clear();
            foreach (var item in listSaldirilacakKoyler.Items)
            {
                try { Utility.BarbarianVillages.Add(new BarbarianVillage() { Kordinat = item.ToString(), ToplamSaldiriSayisi = 0, Uzaklik = UzaklikHesap(item.ToString()) }); }
                catch (Exception exc) { Log.WriteError(exc.ToString()); }
            }
             
            timerSonsuzSaldiri.Interval = 1000;
            timerSonsuzSaldiri.Enabled = true;
            timerSonsuzSaldiri.Start();
        }

        private void btnSaldiriDurdur_Click(object sender, EventArgs e)
        {
            timerSonsuzSaldiri.Enabled = false;
            timerSonsuzSaldiri.Stop();
            listSaldirilacakKoyler.Visible = false;
        }
        private void btnDetayliGorunum_Click(object sender, EventArgs e)
        {
            new DetayliSaldiriGorunum().ShowDialog();
        }

        private void timerSonsuzSaldiri_Tick(object sender, EventArgs e)
        {
            timerSonsuzSaldiri.Enabled = false;    
            OtomatikSaldiri();
        }
        private void OtomatikSaldiri()
        {
            #region  İçtima Meydanı Kontrolü
            if (Utility.WebBrowser.Url.ToString() != Utility.İctimaMeydani)
            {
                Utility.WebBrowser.Navigate(Utility.İctimaMeydani);
                DocumentComplete();
            }
            #endregion

            #region Listeye Saldır
            Utility.BarbarianVillages.OrderBy(a => a.Uzaklik);
            for (int i = 0; i < Utility.BarbarianVillages.Count; i++)
            {
                listSaldirilacakKoyler.SelectedIndex = i;
                Saldir(Utility.BarbarianVillages[i].Kordinat);
            }
            #endregion
            #region Tekrar Saldırı Planla

            Utility.BarbarianVillages.OrderBy(i => i.SonSaldiriDonus);
            timerSonsuzSaldiri.Interval = Convert.ToInt32((Utility.BarbarianVillages[0].SonSaldiriDonus - DateTime.Now).TotalMilliseconds + 5000);
            timerSonsuzSaldiri.Enabled = true;
            #endregion
        }
        private void Saldir(string p)
        {
            SaldiriHazirla(p);
            DocumentComplete();
            SaldiriOnayla();
            DocumentComplete();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            this.labelKalanZaman.Text = sonraki_saldiri < DateTime.Now ? "" : (sonraki_saldiri - DateTime.Now).ToString();
            this.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss.FFF", CultureInfo.InvariantCulture);
        }

        DateTime sonraki_saldiri = DateTime.Now;
        void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (Utility.WebBrowserProcess == WebBrowserProcess.Giris)
                {
                    HtmlElement user = Utility.WebBrowser.Document.GetElementById("user");
                    HtmlElement password = Utility.WebBrowser.Document.GetElementById("password");

                    if (user != null && password != null)
                    {
                        try
                        {
                            if (Utility.WebBrowser.DocumentText.IndexOf("$('#login_submit_button').click()") > 0)
                            {
                                user.SetAttribute("Value", Parameters.Username);
                                password.SetAttribute("Value", Parameters.Password);

                                Utility.WebBrowser.Navigate("javascript:$('#login_submit_button').click()");
                            }
                        }
                        catch (Exception exc)
                        {
                            Log.WriteError(exc.ToString());
                            MessageBox.Show(exc.ToString());
                        }
                    }


                    if (Utility.WebBrowser.DocumentText.IndexOf("$('#world_selection').toggle()") > 0)
                    {
                        Utility.WebBrowser.Navigate("javascript:$('#world_selection').toggle()");
                    }


                    if (Utility.WebBrowser.DocumentText.IndexOf("Index.submit_login('server_tr27')") > 0)
                    {
                        Utility.WebBrowser.Navigate("javascript:Index.submit_login('server_tr27');");

                    }

                    if (Utility.WebBrowser.DocumentText.IndexOf("game_data") > 0 && Utility.WebBrowser.DocumentText.IndexOf("\"id\":" + Parameters.VillageID) > 0)
                        Utility.WebBrowserProcess = WebBrowserProcess.Normal;

                }
            }
            catch (Exception exc)
            {
                Log.WriteError(exc.ToString());
                txtError.Text = exc.ToString();
            }

        }

        public void SaldiriHazirla(string kordinat)
        {
            HtmlElement e = Utility.WebBrowser.Document.GetElementById("target_attack");
            if (e != null)
            {
                Utility.WebBrowser.Document.GetElementById("unit_input_spear").SetAttribute("Value", strMizrak);
                Utility.WebBrowser.Document.GetElementById("unit_input_sword").SetAttribute("Value", strKilic);
                Utility.WebBrowser.Document.GetElementById("unit_input_axe").SetAttribute("Value", strBalta);
                Utility.WebBrowser.Document.GetElementById("unit_input_spy").SetAttribute("Value", strCasus);
                Utility.WebBrowser.Document.GetElementById("unit_input_light").SetAttribute("Value", strHafifAtli);
                Utility.WebBrowser.Document.GetElementById("unit_input_heavy").SetAttribute("Value", strAgirAtli);
                Utility.WebBrowser.Document.GetElementById("unit_input_ram").SetAttribute("Value", strSahmerdan);
                Utility.WebBrowser.Document.GetElementById("unit_input_catapult").SetAttribute("Value", strMancinik);
                Utility.WebBrowser.Document.GetElementById("unit_input_snob").SetAttribute("Value", strMisyoner);
                Utility.WebBrowser.Document.GetElementById("input").SetAttribute("Value", kordinat);

                e.InvokeMember("Click");

                if (!string.IsNullOrEmpty(strMizrak)) if (maxSure < sureMizrak) maxSure = sureMizrak;
                if (!string.IsNullOrEmpty(strKilic)) if (maxSure < sureKilic) maxSure = sureKilic;
                if (!string.IsNullOrEmpty(strBalta)) if (maxSure < sureBalta) maxSure = sureBalta;
                if (!string.IsNullOrEmpty(strCasus)) if (maxSure < sureCasus) maxSure = sureCasus;
                if (!string.IsNullOrEmpty(strHafifAtli)) if (maxSure < sureHafifAtli) maxSure = sureHafifAtli;
                if (!string.IsNullOrEmpty(strAgirAtli)) if (maxSure < sureAgirAtli) maxSure = sureAgirAtli;
                if (!string.IsNullOrEmpty(strSahmerdan)) if (maxSure < sureSahmerdan) maxSure = sureSahmerdan;
                if (!string.IsNullOrEmpty(strMancinik)) if (maxSure < sureMancinik) maxSure = sureMancinik;
                if (!string.IsNullOrEmpty(strMisyoner)) if (maxSure < sureMisyoner) maxSure = sureMisyoner;

            }
        }
        public void SaldiriOnayla()
        {
            HtmlElement e = Utility.WebBrowser.Document.GetElementById("troop_confirm_go");
            if (e != null)
            {
                e.InvokeMember("Click");
            }
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
        }
        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ayarlar() { Location = this.Location }.ShowDialog();
        }
        private void tumKoylerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.WebBrowser.Navigate(Utility.TümKoyler);
        }
        private void genelBakisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.WebBrowser.Navigate(Utility.Koy);
        }
        private void otomatikSaldiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GirisKontrol())
            { 
                panelLeft.Visible = panelOtomatikSaldiri.Visible = !panelOtomatikSaldiri.Visible;
                if (panelOtomatikSaldiri.Visible)
                {
                    panelOtomatikSaldiri.Dock = DockStyle.Fill;
                    panelOtomatikInsaat.Dock = DockStyle.None;
                    panelOtomatikInsaat.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Yapınız.");
            }
        }
        private void otomatikInsaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GirisKontrol())
            { 
                panelLeft.Visible = panelOtomatikInsaat.Visible = !panelOtomatikInsaat.Visible;
                if (panelOtomatikSaldiri.Visible)
                {
                    panelOtomatikInsaat.Dock = DockStyle.Fill;
                    panelOtomatikSaldiri.Dock = DockStyle.None;
                    panelOtomatikSaldiri.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Lütfen Giriş Yapınız.");
            }

        }

        private void txtError_DoubleClick(object sender, EventArgs e)
        {
            if (txtError.Text.Length < 100)
            {
                MessageBox.Show(txtError.Text);
            }
        }

        DateTime errorShow;
        bool haveMessage = false;
        private void timerErrorShow_Tick(object sender, EventArgs e)
        {

            if (txtError.Text.Length > 100 && !haveMessage)
            {
                errorShow = DateTime.Now;
                haveMessage = true;
            }
            if (haveMessage)
            {
                if ((DateTime.Now - errorShow).TotalMilliseconds > 60000)
                {
                    txtError.Text = "";
                }
            }

        }





    }
}
