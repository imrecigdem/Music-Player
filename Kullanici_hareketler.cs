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
    public partial class Kullanici_hareketler : UserControl
    {
        public Kullanici kullanici;
        public Kullanici_hareketler()
        {
            InitializeComponent();
        }

        private void Kullanici_hareketler_Load(object sender, EventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            List<KullaniciHareket> hareketListesi=kullanici.KullaniciHareket.ToList();
            List<Takipci> takipciListesi=db.Takipci.Where(takipci => takipci.takip_eden_kullanici_id.Equals(kullanici.kullanici_id)).ToList();
            foreach (Takipci takip in takipciListesi) {
                if (takip.Kullanici1!=null && takip.Kullanici1.KullaniciHareket!=null && takip.Kullanici1.KullaniciHareket.Count>0) {
                    hareketListesi.AddRange(takip.Kullanici1.KullaniciHareket);
                }
            }

            hareketListesi=hareketListesi.OrderByDescending(hareket => hareket.yaratılma_tarihi).ToList();

            if (hareketListesi != null && hareketListesi.Count > 0) {
                foreach (KullaniciHareket hareket in hareketListesi)
                {
                    var index = gridHareket.Rows.Add();
                    gridHareket.Rows[index].Cells["hareket_id"].Value = hareket.hareket_id;
                    gridHareket.Rows[index].Cells["oynat"].Value = Properties.Resources.spotify;
                    gridHareket.Rows[index].Cells["kullanici_ismi"].Value = hareket.Kullanici.kullanici_ismi;
                    gridHareket.Rows[index].Cells["mesaj"].Value = hareket.hareket_mesaj;
                    gridHareket.Rows[index].Cells["tarih"].Value = hareket.yaratılma_tarihi;
                }
            }
            
        }
    }
}
