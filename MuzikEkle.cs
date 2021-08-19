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
    public partial class MuzikEkle : Form
    {
        public Form form;
        public Kullanici loginKullanici;
        private String dosyaYolu;
        private String dosyaAdi;
        public MuzikEkle()
        {
            InitializeComponent();
        }

        private void MuzikEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        /*
         Panel girilen bilgiler ile işlem yapan kullanıcıya göre veri tabanına şarkıyı kayıt eden ve seçilen
         mp3 dosyasını sarkilar dosyası altına koyan click event'i
         */
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Mp3 Dosyası |*.mp3| Mp3 Dosyası|*.mp3";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Mp3 Dosyası Seçiniz..";
            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = file.FileName;
                dosyaAdi = file.SafeFileName;
                btnDosyaSec.Text = dosyaAdi;
            }
        }

        /*
         Panel girilen bilgiler ile işlem yapan kullanıcıya göre veri tabanına şarkıyı kayıt eden ve seçilen
         mp3 dosyasını sarkilar dosyası altına koyan click event'i
         */
        private void btnSarkiKaydet_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            System.IO.File.Copy(dosyaYolu, path + "\\sarkilar\\" + dosyaAdi);
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            Sarki sarki = new Sarki();
            sarki.sanatci_ismi = txtSanatciIsmi.Text;
            sarki.album_ismi = txtAlbumIsmi.Text;
            sarki.sarki_ismi = txtSarkiIsmi.Text;
            sarki.album_sirasi = Convert.ToInt32(txtAlbumSirasi.Text);
            sarki.sarki_dakikasi = Convert.ToDecimal(txtSarkiDakikasi.Text);
            sarki.sarki_hakkinda = txtSarkiHakkinda.Text;
            sarki.sarki_türü = txtSarkiTuru.Text;
            sarki.sarki_dosya_ismi = dosyaAdi;
            sarki.kullanici_id = loginKullanici.kullanici_id;
            db.Sarki.Add(sarki);

            KullaniciHareket hareket = new KullaniciHareket();
            hareket.hareket_mesaj = sarki.sanatci_ismi +"'ın "+ sarki.album_ismi+" albumündeki "+ sarki.sarki_ismi+" parçasını ekledi";
            hareket.kullanici_id = loginKullanici.kullanici_id;
            hareket.yaratılma_tarihi = DateTime.Now;
            db.KullaniciHareket.Add(hareket);

            db.SaveChanges();
            this.Close();
            form.Show();
        }
    }
}
