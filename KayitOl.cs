using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class KayitOl : Form
    {
        public Form loginForm;
        public KayitOl()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
            this.Close();
        }

        /*
         Ekrandan girilen Kullanıcı adı, şifre ve kullanıcı ismine göre veritabanında sisteme
         kullanıcı kayıt eden click event'i
         */
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.kullanici_eposta = txtKullaniciEposta.Text;
            kullanici.kullanici_ismi = txtKullaniciIsmi.Text;
            kullanici.parola = Convert.ToInt32(txtParola.Text);
               
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            db.Kullanici.Add(kullanici);
            db.SaveChanges();
            this.Close();
            ((Login)loginForm).txtKullaniciAdi.Text = kullanici.kullanici_eposta;
            loginForm.Show();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
