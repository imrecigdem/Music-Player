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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitOl kayitOl = new KayitOl();
            kayitOl.loginForm = this;
            kayitOl.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /*
         veritabanından kullanıcı ismi ve paraloya göre kullanıcıyı kontrol eden ve sisteme girişine izin veren click
         event'i
         */
        private void btnGiris_Click(object sender, EventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            Kullanici bulunanKullanici=db.Kullanici.Where(kullanici => kullanici.kullanici_eposta.Equals(txtKullaniciAdi.Text) &&
            kullanici.parola.ToString().Equals(txtParola.Text)).FirstOrDefault();
            if (bulunanKullanici != null)
            {
                AnaPanel panel = new AnaPanel();
                panel.kullanici = bulunanKullanici;
                panel.loginForm = this;
                this.Hide();
                panel.ShowDialog();
            }else {
                this.Hide();
                MessageForm form = new MessageForm();
                form.form = this;
                form.lblMessage.Text = "Kullanici adi veya parola yanlış!!!";
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
