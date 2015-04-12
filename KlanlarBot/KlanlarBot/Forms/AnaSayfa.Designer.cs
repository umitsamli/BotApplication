using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace KlanlarBot
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelOtomatikInsaat = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOtomatikSaldiri = new System.Windows.Forms.Panel();
            this.btnDetayliGorunum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKalanZaman = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listSaldirilacakKoyler = new System.Windows.Forms.ListBox();
            this.lblIlkBiten = new System.Windows.Forms.Label();
            this.btnSaldiriDurdur = new System.Windows.Forms.Button();
            this.btnSaldiriBaslat = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMizrak = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.txtOkcuAtli = new System.Windows.Forms.TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.txtOkcu = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtAgirAtli = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtHafifAtli = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtCasus = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txtBalta = new System.Windows.Forms.TextBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.txtKilic = new System.Windows.Forms.TextBox();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.timerSonsuzSaldiri = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tumKoylerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelBakisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otomatikSaldiriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otomatikInsaatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtError = new System.Windows.Forms.TextBox();
            this.timerErrorShow = new System.Windows.Forms.Timer(this.components);
            this.panelIslemler.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelOtomatikInsaat.SuspendLayout();
            this.panelOtomatikSaldiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIslemler
            // 
            this.panelIslemler.Controls.Add(this.webBrowser1);
            this.panelIslemler.Controls.Add(this.panelLeft);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIslemler.Location = new System.Drawing.Point(0, 27);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(1168, 515);
            this.panelIslemler.TabIndex = 35;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(210, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(958, 515);
            this.webBrowser1.TabIndex = 37;
            this.webBrowser1.Url = new System.Uri("http://klanlar.org", System.UriKind.Absolute);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelOtomatikInsaat);
            this.panelLeft.Controls.Add(this.panelOtomatikSaldiri);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(210, 515);
            this.panelLeft.TabIndex = 40;
            // 
            // panelOtomatikInsaat
            // 
            this.panelOtomatikInsaat.Controls.Add(this.label2);
            this.panelOtomatikInsaat.Location = new System.Drawing.Point(0, 0);
            this.panelOtomatikInsaat.Name = "panelOtomatikInsaat";
            this.panelOtomatikInsaat.Size = new System.Drawing.Size(16, 11);
            this.panelOtomatikInsaat.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "label2";
            // 
            // panelOtomatikSaldiri
            // 
            this.panelOtomatikSaldiri.Controls.Add(this.btnDetayliGorunum);
            this.panelOtomatikSaldiri.Controls.Add(this.label3);
            this.panelOtomatikSaldiri.Controls.Add(this.labelKalanZaman);
            this.panelOtomatikSaldiri.Controls.Add(this.label1);
            this.panelOtomatikSaldiri.Controls.Add(this.listSaldirilacakKoyler);
            this.panelOtomatikSaldiri.Controls.Add(this.lblIlkBiten);
            this.panelOtomatikSaldiri.Controls.Add(this.btnSaldiriDurdur);
            this.panelOtomatikSaldiri.Controls.Add(this.btnSaldiriBaslat);
            this.panelOtomatikSaldiri.Controls.Add(this.PictureBox1);
            this.panelOtomatikSaldiri.Controls.Add(this.txtMizrak);
            this.panelOtomatikSaldiri.Controls.Add(this.pictureBox10);
            this.panelOtomatikSaldiri.Controls.Add(this.txtOkcuAtli);
            this.panelOtomatikSaldiri.Controls.Add(this.pictureBox11);
            this.panelOtomatikSaldiri.Controls.Add(this.txtOkcu);
            this.panelOtomatikSaldiri.Controls.Add(this.pictureBox4);
            this.panelOtomatikSaldiri.Controls.Add(this.txtAgirAtli);
            this.panelOtomatikSaldiri.Controls.Add(this.pictureBox7);
            this.panelOtomatikSaldiri.Controls.Add(this.txtHafifAtli);
            this.panelOtomatikSaldiri.Controls.Add(this.pictureBox8);
            this.panelOtomatikSaldiri.Controls.Add(this.txtCasus);
            this.panelOtomatikSaldiri.Controls.Add(this.pictureBox9);
            this.panelOtomatikSaldiri.Controls.Add(this.txtBalta);
            this.panelOtomatikSaldiri.Controls.Add(this.pictureBox12);
            this.panelOtomatikSaldiri.Controls.Add(this.txtKilic);
            this.panelOtomatikSaldiri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOtomatikSaldiri.Location = new System.Drawing.Point(0, 0);
            this.panelOtomatikSaldiri.Name = "panelOtomatikSaldiri";
            this.panelOtomatikSaldiri.Size = new System.Drawing.Size(210, 515);
            this.panelOtomatikSaldiri.TabIndex = 39;
            // 
            // btnDetayliGorunum
            // 
            this.btnDetayliGorunum.Location = new System.Drawing.Point(73, 171);
            this.btnDetayliGorunum.Name = "btnDetayliGorunum";
            this.btnDetayliGorunum.Size = new System.Drawing.Size(132, 23);
            this.btnDetayliGorunum.TabIndex = 67;
            this.btnDetayliGorunum.Text = "Detaylı Görünüm";
            this.btnDetayliGorunum.UseVisualStyleBackColor = true;
            this.btnDetayliGorunum.Click += new System.EventHandler(this.btnDetayliGorunum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "Kalan Zaman";
            // 
            // labelKalanZaman
            // 
            this.labelKalanZaman.AutoSize = true;
            this.labelKalanZaman.Location = new System.Drawing.Point(78, 256);
            this.labelKalanZaman.Name = "labelKalanZaman";
            this.labelKalanZaman.Size = new System.Drawing.Size(0, 13);
            this.labelKalanZaman.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Sonraki Saldırı";
            // 
            // listSaldirilacakKoyler
            // 
            this.listSaldirilacakKoyler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listSaldirilacakKoyler.FormattingEnabled = true;
            this.listSaldirilacakKoyler.Items.AddRange(new object[] {
            "649|408",
            "650|407",
            "649|409",
            "650|406",
            "652|408",
            "648|407",
            "651|410",
            "651|406"});
            this.listSaldirilacakKoyler.Location = new System.Drawing.Point(3, 108);
            this.listSaldirilacakKoyler.Name = "listSaldirilacakKoyler";
            this.listSaldirilacakKoyler.Size = new System.Drawing.Size(64, 173);
            this.listSaldirilacakKoyler.TabIndex = 62;
            // 
            // lblIlkBiten
            // 
            this.lblIlkBiten.AutoSize = true;
            this.lblIlkBiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlkBiten.Location = new System.Drawing.Point(80, 215);
            this.lblIlkBiten.Name = "lblIlkBiten";
            this.lblIlkBiten.Size = new System.Drawing.Size(0, 15);
            this.lblIlkBiten.TabIndex = 61;
            // 
            // btnSaldiriDurdur
            // 
            this.btnSaldiriDurdur.Enabled = false;
            this.btnSaldiriDurdur.Location = new System.Drawing.Point(73, 137);
            this.btnSaldiriDurdur.Name = "btnSaldiriDurdur";
            this.btnSaldiriDurdur.Size = new System.Drawing.Size(133, 23);
            this.btnSaldiriDurdur.TabIndex = 59;
            this.btnSaldiriDurdur.Text = "Saldırı Durdur";
            this.btnSaldiriDurdur.UseVisualStyleBackColor = true;
            this.btnSaldiriDurdur.Click += new System.EventHandler(this.btnSaldiriDurdur_Click);
            // 
            // btnSaldiriBaslat
            // 
            this.btnSaldiriBaslat.Location = new System.Drawing.Point(73, 108);
            this.btnSaldiriBaslat.Name = "btnSaldiriBaslat";
            this.btnSaldiriBaslat.Size = new System.Drawing.Size(133, 23);
            this.btnSaldiriBaslat.TabIndex = 58;
            this.btnSaldiriBaslat.Text = "Saldırı Başlat";
            this.btnSaldiriBaslat.UseVisualStyleBackColor = true;
            this.btnSaldiriBaslat.Click += new System.EventHandler(this.btnSaldiriBaslat_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Image = global::KlanlarBot.Properties.Resources.spear;
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // txtMizrak
            // 
            this.txtMizrak.Location = new System.Drawing.Point(29, 3);
            this.txtMizrak.Name = "txtMizrak";
            this.txtMizrak.Size = new System.Drawing.Size(46, 20);
            this.txtMizrak.TabIndex = 41;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Image = global::KlanlarBot.Properties.Resources.marcher;
            this.pictureBox10.Location = new System.Drawing.Point(95, 81);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 56;
            this.pictureBox10.TabStop = false;
            // 
            // txtOkcuAtli
            // 
            this.txtOkcuAtli.Location = new System.Drawing.Point(121, 80);
            this.txtOkcuAtli.Name = "txtOkcuAtli";
            this.txtOkcuAtli.Size = new System.Drawing.Size(46, 20);
            this.txtOkcuAtli.TabIndex = 55;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Image = global::KlanlarBot.Properties.Resources.archer;
            this.pictureBox11.Location = new System.Drawing.Point(3, 81);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 54;
            this.pictureBox11.TabStop = false;
            // 
            // txtOkcu
            // 
            this.txtOkcu.Location = new System.Drawing.Point(29, 82);
            this.txtOkcu.Name = "txtOkcu";
            this.txtOkcu.Size = new System.Drawing.Size(46, 20);
            this.txtOkcu.TabIndex = 53;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::KlanlarBot.Properties.Resources.heavy;
            this.pictureBox4.Location = new System.Drawing.Point(95, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // txtAgirAtli
            // 
            this.txtAgirAtli.Location = new System.Drawing.Point(121, 56);
            this.txtAgirAtli.Name = "txtAgirAtli";
            this.txtAgirAtli.Size = new System.Drawing.Size(46, 20);
            this.txtAgirAtli.TabIndex = 51;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Image = global::KlanlarBot.Properties.Resources.light;
            this.pictureBox7.Location = new System.Drawing.Point(95, 31);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // txtHafifAtli
            // 
            this.txtHafifAtli.Location = new System.Drawing.Point(121, 31);
            this.txtHafifAtli.Name = "txtHafifAtli";
            this.txtHafifAtli.Size = new System.Drawing.Size(46, 20);
            this.txtHafifAtli.TabIndex = 49;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Image = global::KlanlarBot.Properties.Resources.spy;
            this.pictureBox8.Location = new System.Drawing.Point(95, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 48;
            this.pictureBox8.TabStop = false;
            // 
            // txtCasus
            // 
            this.txtCasus.Location = new System.Drawing.Point(121, 3);
            this.txtCasus.Name = "txtCasus";
            this.txtCasus.Size = new System.Drawing.Size(46, 20);
            this.txtCasus.TabIndex = 47;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Image = global::KlanlarBot.Properties.Resources.axe;
            this.pictureBox9.Location = new System.Drawing.Point(3, 55);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.TabIndex = 46;
            this.pictureBox9.TabStop = false;
            // 
            // txtBalta
            // 
            this.txtBalta.Location = new System.Drawing.Point(29, 55);
            this.txtBalta.Name = "txtBalta";
            this.txtBalta.Size = new System.Drawing.Size(46, 20);
            this.txtBalta.TabIndex = 45;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Image = global::KlanlarBot.Properties.Resources.sword;
            this.pictureBox12.Location = new System.Drawing.Point(3, 29);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 44;
            this.pictureBox12.TabStop = false;
            // 
            // txtKilic
            // 
            this.txtKilic.Location = new System.Drawing.Point(29, 28);
            this.txtKilic.Name = "txtKilic";
            this.txtKilic.Size = new System.Drawing.Size(46, 20);
            this.txtKilic.TabIndex = 43;
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // timerSonsuzSaldiri
            // 
            this.timerSonsuzSaldiri.Interval = 5000;
            this.timerSonsuzSaldiri.Tick += new System.EventHandler(this.timerSonsuzSaldiri_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.tumKoylerToolStripMenuItem,
            this.genelBakisToolStripMenuItem,
            this.otomatikSaldiriToolStripMenuItem,
            this.otomatikInsaatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 27);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // tumKoylerToolStripMenuItem
            // 
            this.tumKoylerToolStripMenuItem.Name = "tumKoylerToolStripMenuItem";
            this.tumKoylerToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.tumKoylerToolStripMenuItem.Text = "Tüm Köyler";
            this.tumKoylerToolStripMenuItem.Click += new System.EventHandler(this.tumKoylerToolStripMenuItem_Click);
            // 
            // genelBakisToolStripMenuItem
            // 
            this.genelBakisToolStripMenuItem.Name = "genelBakisToolStripMenuItem";
            this.genelBakisToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.genelBakisToolStripMenuItem.Text = "Genel Bakış";
            this.genelBakisToolStripMenuItem.Click += new System.EventHandler(this.genelBakisToolStripMenuItem_Click);
            // 
            // otomatikSaldiriToolStripMenuItem
            // 
            this.otomatikSaldiriToolStripMenuItem.Name = "otomatikSaldiriToolStripMenuItem";
            this.otomatikSaldiriToolStripMenuItem.Size = new System.Drawing.Size(131, 23);
            this.otomatikSaldiriToolStripMenuItem.Text = "Otomatik Saldırı";
            this.otomatikSaldiriToolStripMenuItem.Click += new System.EventHandler(this.otomatikSaldiriToolStripMenuItem_Click);
            // 
            // otomatikInsaatToolStripMenuItem
            // 
            this.otomatikInsaatToolStripMenuItem.Name = "otomatikInsaatToolStripMenuItem";
            this.otomatikInsaatToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
            this.otomatikInsaatToolStripMenuItem.Text = "Otomatik İnşaat";
            this.otomatikInsaatToolStripMenuItem.Click += new System.EventHandler(this.otomatikInsaatToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // txtError
            // 
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtError.Location = new System.Drawing.Point(0, 542);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(1168, 14);
            this.txtError.TabIndex = 39;
            this.txtError.Text = "Error Bar";
            this.txtError.DoubleClick += new System.EventHandler(this.txtError_DoubleClick);
            // 
            // timerErrorShow
            // 
            this.timerErrorShow.Enabled = true;
            this.timerErrorShow.Interval = 1000;
            this.timerErrorShow.Tick += new System.EventHandler(this.timerErrorShow_Tick);
            // 
            // AnaSayfa
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 556);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KlanlarBot";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.Resize += new System.EventHandler(this.AnaSayfa_Resize);
            this.panelIslemler.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelOtomatikInsaat.ResumeLayout(false);
            this.panelOtomatikInsaat.PerformLayout();
            this.panelOtomatikSaldiri.ResumeLayout(false);
            this.panelOtomatikSaldiri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelIslemler;
        private Timer timerSaat;
        private Timer timerSonsuzSaldiri;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem tumKoylerToolStripMenuItem;
        private ToolStripMenuItem genelBakisToolStripMenuItem;
        private ToolStripMenuItem otomatikSaldiriToolStripMenuItem;
        private NotifyIcon notifyIcon;
        private WebBrowser webBrowser1;
        private ToolStripMenuItem otomatikInsaatToolStripMenuItem;
        private Panel panelOtomatikSaldiri;
        private Button btnDetayliGorunum;
        private Label label3;
        private Label labelKalanZaman;
        private Label label1;
        private ListBox listSaldirilacakKoyler;
        private Label lblIlkBiten;
        private Button btnSaldiriDurdur;
        private Button btnSaldiriBaslat;
        private PictureBox PictureBox1;
        private TextBox txtMizrak;
        private PictureBox pictureBox10;
        private TextBox txtOkcuAtli;
        private PictureBox pictureBox11;
        private TextBox txtOkcu;
        private PictureBox pictureBox4;
        private TextBox txtAgirAtli;
        private PictureBox pictureBox7;
        private TextBox txtHafifAtli;
        private PictureBox pictureBox8;
        private TextBox txtCasus;
        private PictureBox pictureBox9;
        private TextBox txtBalta;
        private PictureBox pictureBox12;
        private TextBox txtKilic;
        private Panel panelLeft;
        private Panel panelOtomatikInsaat;
        private Label label2;
        private TextBox txtError;
        private Timer timerErrorShow;
    }
}

