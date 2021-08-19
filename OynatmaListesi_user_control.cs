using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Music_Player
{
    public partial class OynatmaListesi_user_control : UserControl
    {
        public List<Sarki> sarkilar;
        public Kullanici kullanici;
        public Form anaForm;
        private int oynatIndex = -1;

        public OynatmaListesi_user_control()
        {
            InitializeComponent();
        }

        [DllImport("Winmm.dll", SetLastError = true)]
        static extern int mciSendString(string lpszCommand, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszReturnString, int cchReturn, IntPtr hwndCallback);

        public void playAudio(string strAudioFilename)
        {
            stopAudio();
            closeAudio();
            StringBuilder sb = new StringBuilder();
            string sAliasName = "MP3";
            int nRet = mciSendString("open \"" + strAudioFilename + "\" alias " + sAliasName, sb, 0, IntPtr.Zero);
            nRet = mciSendString("play " + sAliasName, sb, 0, IntPtr.Zero);

        }

        public void closeAudio()
        {
            StringBuilder sb = new StringBuilder();
            string sAliasName = "MP3";
            mciSendString("close " + sAliasName, sb, 0, IntPtr.Zero);
        }

        public void stopAudio()
        {
            StringBuilder sb = new StringBuilder();
            string sAliasName = "MP3";
            mciSendString("stop " + sAliasName, sb, 0, IntPtr.Zero);
        }

        private void gridOynatmaListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            muzik_arsiviEntities db = new muzik_arsiviEntities();

            foreach (DataGridViewRow row in gridOynatmaListesi.Rows)
            {
                if (e.ColumnIndex != 2)
                {
                    row.Cells["oynat"].Value = Properties.Resources.oynat;
                }
                row.Cells["sarki_ismi"].Style.ForeColor = SystemColors.InactiveBorder;
                row.Cells["sanatci"].Style.ForeColor = SystemColors.InactiveBorder;
                row.Cells["ekleyen"].Style.ForeColor = SystemColors.InactiveBorder;
                row.Cells["sarki_dakikasi"].Style.ForeColor = SystemColors.InactiveBorder;
            }

            if (oynatIndex != -1 && e.ColumnIndex != 1)
            {
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_ismi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["sanatci"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_dakikasi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["ekleyen"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["oynat"].Value = Properties.Resources.oynat2;
            }

            if (e.ColumnIndex == 2)
            {
                gridOynatmaListesi.Rows[e.RowIndex].Cells["begen"].Value = Properties.Resources.begenmis;
                Sarki_Begenme begenme = new Sarki_Begenme();
                begenme.kullanici_id = kullanici.kullanici_id;
                begenme.sarki_id = (decimal)gridOynatmaListesi.Rows[e.RowIndex].Cells["sarki_id"].Value;
                db.Sarki_Begenme.Add(begenme);

                KullaniciHareket hareket = new KullaniciHareket();
                hareket.hareket_mesaj = gridOynatmaListesi.Rows[e.RowIndex].Cells["sanatci"].Value + "'ın " + gridOynatmaListesi.Rows[e.RowIndex].Cells["sarki_ismi"].Value + " parçasını begendi";
                hareket.kullanici_id = kullanici.kullanici_id;
                hareket.yaratılma_tarihi = DateTime.Now;
                db.KullaniciHareket.Add(hareket);

                db.SaveChanges();
            }

            if (e.ColumnIndex == 1)
            {
                if (oynatIndex.Equals(e.RowIndex))
                {
                    gridOynatmaListesi.Rows[e.RowIndex].Cells["sarki_ismi"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridOynatmaListesi.Rows[e.RowIndex].Cells["sanatci"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridOynatmaListesi.Rows[e.RowIndex].Cells["ekleyen"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridOynatmaListesi.Rows[e.RowIndex].Cells["sarki_dakikasi"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridOynatmaListesi.Rows[e.RowIndex].Cells["oynat"].Value = Properties.Resources.oynat;
                    oynatIndex = -1;
                    stopAudio();
                    btnBaslat.Text = "Çalma Listesini Başlat";
                }
                else
                {
                    oynatIndex = e.RowIndex;
                    gridOynatmaListesi.Rows[e.RowIndex].Cells["oynat"].Value = Properties.Resources.oynat2;

                    KullaniciHareket hareket = new KullaniciHareket();
                    hareket.hareket_mesaj = gridOynatmaListesi.Rows[e.RowIndex].Cells["sanatci"].Value + "'ın " + gridOynatmaListesi.Rows[e.RowIndex].Cells["sarki_ismi"].Value + " parçasını dinledi";
                    hareket.kullanici_id = kullanici.kullanici_id;
                    hareket.yaratılma_tarihi = DateTime.Now;
                    db.KullaniciHareket.Add(hareket);
                    db.SaveChanges();
                    playAudio("C:\\Users\\cigde\\Desktop\\Music Player\\sarkilar\\" + gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_dosya"].Value);
                    btnBaslat.Text = "Çalma Listesini Durdur";
                }
            }
            if (oynatIndex != -1)
            {
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_ismi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["sanatci"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_dakikasi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["ekleyen"].Style.ForeColor = Color.FromArgb(30, 215, 96);
            }
        }

        private void Oynatma_listesi_Load(object sender, EventArgs e)
        {
            btnBaslat.Text = "Çalma Listesini Başlat";
            if (sarkilar != null && sarkilar.Count > 0)
            {
                foreach (Sarki sarki in sarkilar)
                {
                    var index = gridOynatmaListesi.Rows.Add();
                    gridOynatmaListesi.Rows[index].Cells["oynat"].Value = Properties.Resources.oynat;
                    gridOynatmaListesi.Rows[index].Cells["sarki_id"].Value = sarki.sarki_id;
                    gridOynatmaListesi.Rows[index].Cells["sarki_ismi"].Value = sarki.sarki_ismi;
                    gridOynatmaListesi.Rows[index].Cells["sanatci"].Value = sarki.sanatci_ismi;
                    gridOynatmaListesi.Rows[index].Cells["sarki_dakikasi"].Value = sarki.sarki_dakikasi;
                    gridOynatmaListesi.Rows[index].Cells["ekleyen"].Value = sarki.Kullanici.kullanici_ismi;
                    gridOynatmaListesi.Rows[index].Cells["begen"].Value = Properties.Resources.begen;
                    Sarki_Begenme sarkiBegeni = sarki.Sarki_Begenme.Where(begeni => begeni.kullanici_id.Equals(kullanici.kullanici_id) && begeni.sarki_id.Equals(sarki.sarki_id)).FirstOrDefault();
                    if (sarkiBegeni != null)
                    {
                        gridOynatmaListesi.Rows[index].Cells["begen"].Value = Properties.Resources.begenmis;
                    }
                    gridOynatmaListesi.Rows[index].Cells["sarki_dosya"].Value = sarki.sarki_dosya_ismi;
                }
                btnBaslat.Enabled = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            List<Oynatma_Listesi> oynatmaListesiList = db.Oynatma_Listesi.ToList().Where(x => x.kullanici_id.Equals(kullanici.kullanici_id)).ToList<Oynatma_Listesi>();
            db.Oynatma_Listesi.RemoveRange(oynatmaListesiList);
            db.SaveChanges();
            gridOynatmaListesi.Rows.Clear();
            stopAudio();
            btnBaslat.Enabled = false;
        }

        private void btnBaslat_Click(object ssender, EventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();
            if (gridOynatmaListesi.Rows!=null && gridOynatmaListesi.Rows.Count >0 && btnBaslat.Text.Equals("Çalma Listesini Başlat")) {
                oynatIndex = 0;
                gridOynatmaListesi.Rows[0].Cells["oynat"].Value = Properties.Resources.oynat2;
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_ismi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["sanatci"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_dakikasi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["ekleyen"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridOynatmaListesi.Rows[oynatIndex].Cells["oynat"].Value = Properties.Resources.oynat2;
                btnBaslat.Text = "Çalma Listesini Durdur";
                
                KullaniciHareket hareket = new KullaniciHareket();
                hareket.hareket_mesaj = gridOynatmaListesi.Rows[0].Cells["sanatci"].Value + "'ın " + gridOynatmaListesi.Rows[0].Cells["sarki_ismi"].Value + " parçasını dinledi";
                hareket.kullanici_id = kullanici.kullanici_id;
                hareket.yaratılma_tarihi = DateTime.Now;
                db.KullaniciHareket.Add(hareket);
                db.SaveChanges();
                playAudio("C:\\Users\\cigde\\Desktop\\Music Player\\sarkilar\\" + gridOynatmaListesi.Rows[0].Cells["sarki_dosya"].Value);

            }else if (gridOynatmaListesi.Rows != null && gridOynatmaListesi.Rows.Count > 0 && btnBaslat.Text.Equals("Çalma Listesini Durdur")) {
                btnBaslat.Text = "Çalma Listesini Başlat";
                btnBaslat.Enabled = true;
                stopAudio();
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_ismi"].Style.ForeColor = SystemColors.InactiveBorder;
                gridOynatmaListesi.Rows[oynatIndex].Cells["sanatci"].Style.ForeColor = SystemColors.InactiveBorder;
                gridOynatmaListesi.Rows[oynatIndex].Cells["ekleyen"].Style.ForeColor = SystemColors.InactiveBorder;
                gridOynatmaListesi.Rows[oynatIndex].Cells["sarki_dakikasi"].Style.ForeColor = SystemColors.InactiveBorder;
                gridOynatmaListesi.Rows[oynatIndex].Cells["oynat"].Value = Properties.Resources.oynat;
                oynatIndex = -1;
            }
        }
    }
}
