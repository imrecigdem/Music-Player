using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;


/*
 Veri tabanı işlemleri için muzik_arsiviEntities objesi kullanıldı.
 
 */
namespace Music_Player
{
    public partial class AnaPanel : Form
    {
        /*
         Sisteme Giriş yapmış olan Kullanıcı bellekte tutuluyor
         */
        public Kullanici kullanici;
        public Form loginForm;
        /*
         Oynatma Listesine eklene şarkılar için kullanılan Liste tanımlıyoruz
         */
        public List<Sarki> oynatmaListesi=new List<Sarki>();
        public AnaPanel()
        {
            InitializeComponent();
        }

        /*
         Ekranı kapattan için kullanılan click event
         */
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Login login = (Login)loginForm;
            login.txtKullaniciAdi.Text = "E Posta Adresi Giriniz";
            login.txtParola.Text = "****************";
            login.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            groupAnaPanel.Text = kullanici.kullanici_ismi;
        }

        /*
         Muzik Ekleme Panelini açmak için kullanılan click Event'i
         */
        private void panel13_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuzikEkle muzikEkle = new MuzikEkle();
            muzikEkle.form = this;
            muzikEkle.loginKullanici = kullanici;
            muzikEkle.ShowDialog();
        }

        /*
         Şarkıların listelendiği panel orta panelde göstermek için kullanılan Click Event'i
         */
        private void panel12_Click(object sender, EventArgs e)
        {
            /*
             Kullanıcının eklediği şarkılar veri tabanından çekiliyor.
             Şarkılan paneline bulunan şarkılar eklenerek orta panelde açılıyor
             */
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            kullanici = db.Kullanici.Where(user => user.kullanici_id.Equals(kullanici.kullanici_id)).FirstOrDefault();
            panelOrta.Controls.Clear();
            Sarkilar_user_control sarkilarUserControl = new Sarkilar_user_control();
            sarkilarUserControl.sarkilar = kullanici.Sarki.ToList();
            sarkilarUserControl.kullanici = kullanici;
            sarkilarUserControl.anaForm = this;
            sarkilarUserControl.Dock = DockStyle.Fill;
            sarkilarUserControl.Margin = new Padding(30, 30, 30, 30);
            panelOrta.Controls.Add(sarkilarUserControl);
        }

        /*
         Kullanıcı hareketlerinin listelendiği panel orta panelde göstermek için kullanılan Click Event'i
         */
        private void panel8_Click(object sender, EventArgs e)
        {
            /*
             işlem yapan kullanıcıya göre kullanıcı hareketleri veri tabanından çekiliyor.
             Hareketler şarkılar dinleme beğenme ve ekleme olabilir.
             kullanıcı hareketleri paneline bulunan hareketler eklenerek orta panelde açılıyor
             */
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            kullanici=db.Kullanici.Where(user => user.kullanici_id.Equals(kullanici.kullanici_id)).FirstOrDefault();
            panelOrta.Controls.Clear();
            Kullanici_hareketler kullaniciHareketler = new Kullanici_hareketler();
            kullaniciHareketler.kullanici = kullanici;
            kullaniciHareketler.Dock = DockStyle.Fill;
            kullaniciHareketler.Margin = new Padding(30, 30, 30, 30);
            panelOrta.Controls.Add(kullaniciHareketler);
        }

        /*
         Şarkıların albümlerinin listelendiği panel orta panelde göstermek için kullanılan Click Event'i
         */
        private void panel11_Click(object sender, EventArgs e)
        {
            /*
             işlem yapan kullanıcın eklediği albümler veri tabanından çekiliyor.
             Albümler paneline bulunan albümler eklenerek orta panelde açılıyor
             */
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            kullanici = db.Kullanici.Where(user => user.kullanici_id.Equals(kullanici.kullanici_id)).FirstOrDefault();
            panelOrta.Controls.Clear();
            Albumler_user_control albumUserControl = new Albumler_user_control();
            albumUserControl.sarkilar = kullanici.Sarki.ToList();
            albumUserControl.kullanici = kullanici;
            albumUserControl.Dock = DockStyle.Fill;
            albumUserControl.anaForm = this;
            albumUserControl.Margin = new Padding(30, 30, 30, 30);
            panelOrta.Controls.Add(albumUserControl);
        }

        /*
         Sanatçıların listelendiği panel orta panelde göstermek için kullanılan Click Event'i
         */
        private void panel10_Click(object sender, EventArgs e)
        {
            /*
             işlem yapan kullanıcın eklediği sanatçılar veri tabanından çekiliyor.
             Sanatçılar paneline bulunan sanatçılar eklenerek orta panelde açılıyor
             */
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            kullanici = db.Kullanici.Where(user => user.kullanici_id.Equals(kullanici.kullanici_id)).FirstOrDefault();
            panelOrta.Controls.Clear();
            Sanatcilar_user_control sanatciUserControl = new Sanatcilar_user_control();
            sanatciUserControl.sarkilar = kullanici.Sarki.ToList();
            sanatciUserControl.kullanici = kullanici;
            sanatciUserControl.Dock = DockStyle.Fill;
            sanatciUserControl.anaForm = this;
            sanatciUserControl.Margin = new Padding(30, 30, 30, 30);
            panelOrta.Controls.Add(sanatciUserControl);
        }

        /*
         Oynatma listesi paneli orta panelde göstermek için kullanılan Click Event'i
         */
        private void panel9_Click(object sender, EventArgs e)
        {
            /*
            Oynatma listesi işlem yapan kullanıcıya göre veri tabanından çekiliyor.
            Oynatma listesi paneline bulunan oynatm listesi eklenerek orta panelde açılıyor
            */
            oynatmaListesi.Clear();
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            kullanici = db.Kullanici.Where(user => user.kullanici_id.Equals(kullanici.kullanici_id)).FirstOrDefault();
            decimal kullaniciId=kullanici.kullanici_id;
            panelOrta.Controls.Clear();
            List<Oynatma_Listesi> oynatmaListesiList = db.Oynatma_Listesi.ToList().Where(x => x.kullanici_id.Equals(kullaniciId)).ToList<Oynatma_Listesi>();
            foreach (Oynatma_Listesi liste in oynatmaListesiList) {
                oynatmaListesi.Add(liste.Sarki);
            }
            OynatmaListesi_user_control oynatmaListesiUserControl = new OynatmaListesi_user_control();
            oynatmaListesiUserControl.sarkilar = oynatmaListesi;
            oynatmaListesiUserControl.kullanici = kullanici;
            oynatmaListesiUserControl.anaForm = this;
            oynatmaListesiUserControl.Dock = DockStyle.Fill;
            oynatmaListesiUserControl.Margin = new Padding(30, 30, 30, 30);
            panelOrta.Controls.Add(oynatmaListesiUserControl);
        }
    }
}
