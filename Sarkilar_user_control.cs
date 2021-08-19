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
    public partial class Sarkilar_user_control : UserControl
    {
        public List<Sarki> sarkilar;
        public Kullanici kullanici;
        public Form anaForm;
        private int oynatIndex=-1;
        public Sarkilar_user_control()
        {
            InitializeComponent();
        }
        private void Sarkilar_user_control_Load(object sender, EventArgs e)
        {
            if (sarkilar != null && sarkilar.Count > 0) {
                foreach (Sarki sarki in sarkilar) {
                    var index = gridSarkilar.Rows.Add();
                    gridSarkilar.Rows[index].Cells["oynat"].Value = Properties.Resources.oynat;
                    gridSarkilar.Rows[index].Cells["sarki_id"].Value = sarki.sarki_id;
                    gridSarkilar.Rows[index].Cells["sarki_ismi"].Value = sarki.sarki_ismi;
                    gridSarkilar.Rows[index].Cells["sanatci"].Value = sarki.sanatci_ismi;
                    gridSarkilar.Rows[index].Cells["sarki_dakikasi"].Value = sarki.sarki_dakikasi;
                    gridSarkilar.Rows[index].Cells["ekleyen"].Value = sarki.Kullanici.kullanici_ismi;
                    gridSarkilar.Rows[index].Cells["begen"].Value = Properties.Resources.begen;
                    Sarki_Begenme sarkiBegeni=sarki.Sarki_Begenme.Where(begeni => begeni.kullanici_id.Equals(kullanici.kullanici_id) && begeni.sarki_id.Equals(sarki.sarki_id)).FirstOrDefault();
                    if (sarkiBegeni != null) {
                        gridSarkilar.Rows[index].Cells["begen"].Value = Properties.Resources.begenmis;
                    }
                    gridSarkilar.Rows[index].Cells["sarki_dosya"].Value = sarki.sarki_dosya_ismi;
                }
            }

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
        private void gridSarkilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            muzik_arsiviEntities db = new muzik_arsiviEntities();

            foreach (DataGridViewRow row in gridSarkilar.Rows) {
                if (e.ColumnIndex != 2){
                    row.Cells["oynat"].Value = Properties.Resources.oynat;
                }
                row.Cells["sarki_ismi"].Style.ForeColor = SystemColors.InactiveBorder;
                row.Cells["sanatci"].Style.ForeColor = SystemColors.InactiveBorder;
                row.Cells["ekleyen"].Style.ForeColor = SystemColors.InactiveBorder;
                row.Cells["sarki_dakikasi"].Style.ForeColor = SystemColors.InactiveBorder;
            }

            if (oynatIndex != -1 && e.ColumnIndex != 1) {
                gridSarkilar.Rows[oynatIndex].Cells["sarki_ismi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridSarkilar.Rows[oynatIndex].Cells["sanatci"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridSarkilar.Rows[oynatIndex].Cells["sarki_dakikasi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridSarkilar.Rows[oynatIndex].Cells["ekleyen"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridSarkilar.Rows[oynatIndex].Cells["oynat"].Value = Properties.Resources.oynat2;
            }

            if (e.ColumnIndex == 2){ 
                gridSarkilar.Rows[e.RowIndex].Cells["begen"].Value = Properties.Resources.begenmis;
                Sarki_Begenme begenme = new Sarki_Begenme();
                begenme.kullanici_id = kullanici.kullanici_id;
                begenme.sarki_id =(decimal)gridSarkilar.Rows[e.RowIndex].Cells["sarki_id"].Value;
                db.Sarki_Begenme.Add(begenme);

                KullaniciHareket hareket = new KullaniciHareket();
                hareket.hareket_mesaj = gridSarkilar.Rows[e.RowIndex].Cells["sanatci"].Value + "'ın " + gridSarkilar.Rows[e.RowIndex].Cells["sarki_ismi"].Value + " parçasını begendi";
                hareket.kullanici_id = kullanici.kullanici_id;
                hareket.yaratılma_tarihi = DateTime.Now;
                db.KullaniciHareket.Add(hareket);

                db.SaveChanges();
            }

            if (e.ColumnIndex == 7)
            {
                Oynatma_Listesi oynatmaListesi = new Oynatma_Listesi();
                oynatmaListesi.kullanici_id = kullanici.kullanici_id;
                oynatmaListesi.sarki_id = (decimal)gridSarkilar.Rows[e.RowIndex].Cells["sarki_id"].Value;
                db.Oynatma_Listesi.Add(oynatmaListesi);

                KullaniciHareket hareket = new KullaniciHareket();
                hareket.hareket_mesaj = gridSarkilar.Rows[e.RowIndex].Cells["sanatci"].Value + "'ın " + gridSarkilar.Rows[e.RowIndex].Cells["sarki_ismi"].Value + " parçasını oynatma listesine ekledi";
                hareket.kullanici_id = kullanici.kullanici_id;
                hareket.yaratılma_tarihi = DateTime.Now;
                db.KullaniciHareket.Add(hareket);

                db.SaveChanges();
            }

            if (e.ColumnIndex == 1){
                if (oynatIndex.Equals(e.RowIndex)){
                    gridSarkilar.Rows[e.RowIndex].Cells["sarki_ismi"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridSarkilar.Rows[e.RowIndex].Cells["sanatci"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridSarkilar.Rows[e.RowIndex].Cells["ekleyen"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridSarkilar.Rows[e.RowIndex].Cells["sarki_dakikasi"].Style.ForeColor = SystemColors.InactiveBorder;
                    gridSarkilar.Rows[e.RowIndex].Cells["oynat"].Value = Properties.Resources.oynat;
                    oynatIndex = -1;
                    stopAudio();
                }
                else {
                    oynatIndex = e.RowIndex;
                    gridSarkilar.Rows[e.RowIndex].Cells["oynat"].Value = Properties.Resources.oynat2;
                    playAudio("C:\\Users\\cigde\\Desktop\\Music Player\\sarkilar\\"+ gridSarkilar.Rows[oynatIndex].Cells["sarki_dosya"].Value);
                    KullaniciHareket hareket = new KullaniciHareket();
                    hareket.hareket_mesaj = gridSarkilar.Rows[e.RowIndex].Cells["sanatci"].Value + "'ın " + gridSarkilar.Rows[e.RowIndex].Cells["sarki_ismi"].Value + " parçasını dinledi";
                    hareket.kullanici_id = kullanici.kullanici_id;
                    hareket.yaratılma_tarihi = DateTime.Now;
                    db.KullaniciHareket.Add(hareket);
                    db.SaveChanges();
                }
            }
            if (oynatIndex != -1) {
                gridSarkilar.Rows[oynatIndex].Cells["sarki_ismi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridSarkilar.Rows[oynatIndex].Cells["sanatci"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridSarkilar.Rows[oynatIndex].Cells["sarki_dakikasi"].Style.ForeColor = Color.FromArgb(30, 215, 96);
                gridSarkilar.Rows[oynatIndex].Cells["ekleyen"].Style.ForeColor = Color.FromArgb(30, 215, 96);
            }
        }
    }
}
