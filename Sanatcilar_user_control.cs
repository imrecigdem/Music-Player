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
    public partial class Sanatcilar_user_control : UserControl
    {
        public List<Sarki> sarkilar;
        public Kullanici kullanici;
        public Form anaForm;
        public Sanatcilar_user_control()
        {
            InitializeComponent();
        }

        private void Sanatcilar_user_control_Load(object sender, EventArgs e)
        {
            Dictionary<String, Sarki> dic = new Dictionary<String, Sarki>();

            if (sarkilar != null && sarkilar.Count > 0)
            {
                foreach (Sarki sarki in sarkilar)
                {
                    if (!dic.ContainsKey(sarki.sanatci_ismi))
                    {
                        dic.Add(sarki.sanatci_ismi, sarki);
                        var index = gridSanatcilar.Rows.Add();
                        gridSanatcilar.Rows[index].Cells["sanatci_resim"].Value = Properties.Resources.singer;
                        gridSanatcilar.Rows[index].Cells["sanatci"].Value = sarki.sanatci_ismi;
                        gridSanatcilar.Rows[index].Cells["ekleyen"].Value = sarki.Kullanici.kullanici_ismi;
                    }
                }
            }
        }

        private void gridSanatcilar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            String sanatci = (String)gridSanatcilar.Rows[e.RowIndex].Cells["sanatci"].Value;
            decimal kullaniciId = kullanici.kullanici_id;
            List<Sarki> sarkilar = db.Sarki.Where(s => s.sanatci_ismi.Equals(sanatci)).ToList();
            sarkilar = sarkilar.Where(s => s.kullanici_id.Equals(kullaniciId)).ToList();
            kullanici = db.Kullanici.Where(user => user.kullanici_id.Equals(kullanici.kullanici_id)).FirstOrDefault();

            ((AnaPanel)anaForm).panelOrta.Controls.Clear();
            Albumler_user_control albumUserControl = new Albumler_user_control();
            albumUserControl.sarkilar = sarkilar;
            albumUserControl.kullanici = kullanici;
            albumUserControl.anaForm = anaForm;
            albumUserControl.Dock = DockStyle.Fill;
            albumUserControl.Margin = new Padding(30, 30, 30, 30);
            ((AnaPanel)anaForm).panelOrta.Controls.Add(albumUserControl);
        }

        private void gridSanatcilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            if (e.ColumnIndex == 3)
            {
                String sanatci = (String)gridSanatcilar.Rows[e.RowIndex].Cells["sanatci"].Value;
                decimal kullaniciId = kullanici.kullanici_id;
                List<Sarki> sarkilar = db.Sarki.Where(s => s.sanatci_ismi.Equals(sanatci)).ToList();
                sarkilar = sarkilar.Where(s => s.kullanici_id.Equals(kullaniciId)).ToList();

                Oynatma_Listesi oynatmaListesi;
                foreach (Sarki sarki in sarkilar) {
                    oynatmaListesi = new Oynatma_Listesi();
                    oynatmaListesi.kullanici_id = kullanici.kullanici_id;
                    oynatmaListesi.sarki_id = sarki.sarki_id;
                    db.Oynatma_Listesi.Add(oynatmaListesi);
                }

                KullaniciHareket hareket = new KullaniciHareket();
                hareket.hareket_mesaj = gridSanatcilar.Rows[e.RowIndex].Cells["sanatci"].Value + "'ın tüm parçalarını oynatma listesine ekledi";
                hareket.kullanici_id = kullanici.kullanici_id;
                hareket.yaratılma_tarihi = DateTime.Now;
                db.KullaniciHareket.Add(hareket);

                db.SaveChanges();
            }
        }
    }
}
