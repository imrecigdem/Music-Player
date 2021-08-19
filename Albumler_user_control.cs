using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Albumler_user_control : UserControl
    {
        public List<Sarki> sarkilar;
        public Kullanici kullanici;
        public Form anaForm;
        public Albumler_user_control()
        {
            InitializeComponent();
        }

        private void Albumler_user_control_Load(object sender, EventArgs e)
        {
            Dictionary<String, Sarki> dic = new Dictionary<String, Sarki>();

            if (sarkilar != null && sarkilar.Count > 0)
            {
                foreach (Sarki sarki in sarkilar)
                {
                    if (!dic.ContainsKey(sarki.album_ismi)) {
                        dic.Add(sarki.album_ismi,sarki);
                        var index = gridAlbumler.Rows.Add();
                        gridAlbumler.Rows[index].Cells["album_resim"].Value = Properties.Resources.album;
                        gridAlbumler.Rows[index].Cells["album_ismi"].Value = sarki.album_ismi;
                        gridAlbumler.Rows[index].Cells["sanatci"].Value = sarki.sanatci_ismi;
                        gridAlbumler.Rows[index].Cells["ekleyen"].Value = sarki.Kullanici.kullanici_ismi;

                    }
                }
            }
        }

        private void gridAlbumler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            String albumIsmi=(String)gridAlbumler.Rows[e.RowIndex].Cells["album_ismi"].Value;
            decimal kullaniciId=kullanici.kullanici_id;
            List<Sarki> sarkilar=db.Sarki.Where(s => s.album_ismi.Equals(albumIsmi)).ToList();
            sarkilar = sarkilar.Where(s => s.kullanici_id.Equals(kullaniciId)).ToList();
            kullanici = db.Kullanici.Where(user => user.kullanici_id.Equals(kullanici.kullanici_id)).FirstOrDefault();

            ((AnaPanel)anaForm).panelOrta.Controls.Clear();
            Sarkilar_user_control sarkilarUserControl = new Sarkilar_user_control();
            sarkilarUserControl.sarkilar = sarkilar;
            sarkilarUserControl.kullanici = kullanici;
            sarkilarUserControl.Dock = DockStyle.Fill;
            sarkilarUserControl.Margin = new Padding(30, 30, 30, 30);
            ((AnaPanel)anaForm).panelOrta.Controls.Add(sarkilarUserControl);
        }

        private void gridAlbumler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            if (e.ColumnIndex == 4)
            {
                String albumIsmi = (String)gridAlbumler.Rows[e.RowIndex].Cells["album_ismi"].Value;
                decimal kullaniciId = kullanici.kullanici_id;
                List<Sarki> sarkilar = db.Sarki.Where(s => s.album_ismi.Equals(albumIsmi)).ToList();
                sarkilar = sarkilar.Where(s => s.kullanici_id.Equals(kullaniciId)).ToList();
                
                Oynatma_Listesi oynatmaListesi;
                foreach (Sarki sarki in sarkilar)
                {
                    oynatmaListesi = new Oynatma_Listesi();
                    oynatmaListesi.kullanici_id = kullanici.kullanici_id;
                    oynatmaListesi.sarki_id = sarki.sarki_id;
                    db.Oynatma_Listesi.Add(oynatmaListesi);
                }

                KullaniciHareket hareket = new KullaniciHareket();
                hareket.hareket_mesaj = gridAlbumler.Rows[e.RowIndex].Cells["sanatci"].Value + "'ın"+ gridAlbumler.Rows[e.RowIndex].Cells["album_ismi"].Value + " albumündeki tüm parçalarını oynatma listesine ekledi";
                hareket.kullanici_id = kullanici.kullanici_id;
                hareket.yaratılma_tarihi = DateTime.Now;
                db.KullaniciHareket.Add(hareket);

                db.SaveChanges();
            }
        }
    }
}
