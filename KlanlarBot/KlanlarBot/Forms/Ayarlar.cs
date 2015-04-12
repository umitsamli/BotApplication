using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlanlarBot
{
    public partial class Ayarlar : Form
    {

        public Ayarlar()
        {
            this.InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServer.Text) ||
                string.IsNullOrEmpty(txtKoy.Text))
            {
                MessageBox.Show("Lütfen Server ve Köy Bilgisini Giriniz.");
                return;
            }

            Parameters.Username = txtKullanici.Text;
            Parameters.Password = txtSifre.Text;
            Parameters.Server = txtServer.Text;
            Parameters.VillageID = txtKoy.Text;
            Parameters.VillageLocation = txtLocation.Text;
            Parameters.AutoLogin = checkOtomatikGiris.Checked;
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtServer.Text = Parameters.Server;
            txtKoy.Text = Parameters.VillageID;
            txtKullanici.Text = Parameters.Username;
            txtSifre.Text = Parameters.Password;
            txtLocation.Text = Parameters.VillageLocation;
            checkOtomatikGiris.Checked = Parameters.AutoLogin;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parameters.Username = txtKullanici.Text;
            Parameters.Password = txtSifre.Text;
            Parameters.Server = txtServer.Text;
            Parameters.VillageID = txtKoy.Text;
            Parameters.VillageLocation = txtLocation.Text;
            Parameters.AutoLogin = checkOtomatikGiris.Checked;

        }

    }
}
