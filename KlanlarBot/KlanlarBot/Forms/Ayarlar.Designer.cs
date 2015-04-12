using System.Drawing;
using System.Windows.Forms;
namespace KlanlarBot
{
    partial class Ayarlar
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtKoy = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblKoy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.checkOtomatikGiris = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 20);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Kaydet Ve Gizle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(105, 70);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(58, 20);
            this.txtServer.TabIndex = 37;
            // 
            // txtKoy
            // 
            this.txtKoy.Location = new System.Drawing.Point(105, 102);
            this.txtKoy.Name = "txtKoy";
            this.txtKoy.Size = new System.Drawing.Size(58, 20);
            this.txtKoy.TabIndex = 38;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(62, 73);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 39;
            this.lblServer.Text = "Server";
            // 
            // lblKoy
            // 
            this.lblKoy.AutoSize = true;
            this.lblKoy.Location = new System.Drawing.Point(75, 105);
            this.lblKoy.Name = "lblKoy";
            this.lblKoy.Size = new System.Drawing.Size(25, 13);
            this.lblKoy.TabIndex = 40;
            this.lblKoy.Text = "Köy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Kullanıcı";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(105, 38);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(58, 20);
            this.txtSifre.TabIndex = 50;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(105, 6);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(58, 20);
            this.txtKullanici.TabIndex = 49;
            // 
            // checkOtomatikGiris
            // 
            this.checkOtomatikGiris.AutoSize = true;
            this.checkOtomatikGiris.Location = new System.Drawing.Point(113, 179);
            this.checkOtomatikGiris.Name = "checkOtomatikGiris";
            this.checkOtomatikGiris.Size = new System.Drawing.Size(15, 14);
            this.checkOtomatikGiris.TabIndex = 53;
            this.checkOtomatikGiris.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Otomatik Giriş Yap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Kordinat";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(105, 128);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(58, 20);
            this.txtLocation.TabIndex = 55;
            // 
            // Ayarlar
            // 
            this.ClientSize = new System.Drawing.Size(268, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkOtomatikGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblKoy);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtKoy);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnSave);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        public TextBox txtKoy;
        public TextBox txtServer;
        private Label lblServer;
        private Label lblKoy;
        private Label label1;
        private Label label2;
        public TextBox txtSifre;
        public TextBox txtKullanici;
        private CheckBox checkOtomatikGiris;
        private Label label3;
        private Label label4;
        public TextBox txtLocation;
    }
}