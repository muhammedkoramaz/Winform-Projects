using OtelRezervasyon.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.UI
{
    public partial class FrmCikis : Form
    {
        private List<Rezervasyon> musteriOdalar;
        private List<Rezervasyon> cikisiYapilanMusteriler = new List<Rezervasyon>();
        //private Rezervasyon rezervasyon
        //private MusteriOda musteriCikisBilgi = new MusteriOda();
        Musteri musteri = new Musteri();
        Dictionary<string, int> buzdolabiIcındekiler = new Dictionary<string, int>();
        int toplamBorc = 0;

        public FrmCikis()
        {
            InitializeComponent();
        }

        public FrmCikis(List<Rezervasyon> musteriOdalar) : this()
        {
            this.musteriOdalar = musteriOdalar;
        }

        private void FrmCikis_Load(object sender, EventArgs e)
        {
            ComboBoxDoldur();
            ListBoxDoldur();
        }
        /// <summary>
        /// Müşteri isimlerinin bulunduğu combobox'a verileri yazdıran fonksiyon.
        /// </summary>
        private void ComboBoxDoldur()
        {
            foreach (var item in musteriOdalar)
            {
                cmbAdSoyad.Items.Add(item.Musteri);
            }
        }
        /// <summary>
        /// Mini Buzdolabında bulunacak itemleri listboxa yazdıracak fonksiyon.
        /// </summary>
        private void ListBoxDoldur()
        {
            buzdolabiIcındekiler.Add("Cikolata", 5);
            buzdolabiIcındekiler.Add("Su", 5);
            buzdolabiIcındekiler.Add("Kola", 10);
            buzdolabiIcındekiler.Add("Ayran", 7);
            buzdolabiIcındekiler.Add("Viski", 60);
            buzdolabiIcındekiler.Add("Sarap", 40);
            listBoxMiniDolap.Items.AddRange(buzdolabiIcındekiler.Keys.ToArray());
        }
        /// <summary>
        /// Comboboxtan seçilecek müşteri ismine göre toplam borcu hesaplayacak fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rezervasyon rezervasyonYapanMusteriBilgileri = RezervasyonBilgileriCek();

            dtpCikis.Enabled = true;
            //dtpCikis.Value = DateTime.Now;

            toplamBorc = 0;
            lblBorc.Text = "";
            listView1.Items.Clear();

            toplamBorc = rezervasyonYapanMusteriBilgileri.KalinacakOda.OdaUcreti;
        }
        /// <summary>
        /// Comboboxtan seçilecek müşterinin rezervasyon bilgilerini getiren fonksiyon.
        /// </summary>
        /// <returns></returns>
        private Rezervasyon RezervasyonBilgileriCek()
        {
            musteri = cmbAdSoyad.SelectedItem as Musteri;
            if (musteri != null)
            {
                return musteriOdalar.FirstOrDefault(a => a.Musteri.MusteriAd == musteri.MusteriAd);
            }
            return null;
        }
        /// <summary>
        /// Çıkış yap butonuna basıldığı zaman tetiklenecek fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyonYapanMusteriBilgileri = RezervasyonBilgileriCek();
            rezervasyonYapanMusteriBilgileri.CikisTarihi = dtpCikis.Value;
            rezervasyonYapanMusteriBilgileri.ToplamBorc = toplamBorc;
            rezervasyonYapanMusteriBilgileri.KalinacakOda.OdaDurum = OdaDurum.Bos;

            lblBorc.Visible = false;
            gbBuzdolabi.Enabled = false;
            listView1.Items.Clear();

            cikisiYapilanMusteriler.Add(rezervasyonYapanMusteriBilgileri);
            this.Tag = cikisiYapilanMusteriler;

            MessageBox.Show("Müşteri Çıkışı Onaylandı.");
        }
        /// <summary>
        /// Mini dolaptaki itemlere tıklandıkça alınanlar listviewine toplam tutarları ile birlikte ekleyen fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMiniDolap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBoxMiniDolap.SelectedItem.ToString();
            int borc = buzdolabiIcındekiler[selected];
            int adet = 1;

            // ListView'daki tüm öğeleri kontrol et
            foreach (ListViewItem item in listView1.Items)
            {
                // Eğer seçilen öğe zaten ListView'da varsa
                if (item.SubItems[0].Text == selected)
                {
                    adet = int.Parse(item.SubItems[2].Text) + 1;
                    item.SubItems[2].Text = adet.ToString();
                    item.SubItems[3].Text = (borc * adet).ToString();

                    // Toplam borcu güncelleme
                    toplamBorc += borc;
                    lblBorc.Text = toplamBorc.ToString() + " TL";
                    return;
                }
            }

            // Eğer seçilen öğe ListView'da yoksa, yeni bir öğe oluştur
            ListViewItem newListItem = new ListViewItem(selected);
            newListItem.SubItems.Add(borc.ToString());
            newListItem.SubItems.Add(adet.ToString());
            newListItem.SubItems.Add((borc * adet).ToString());

            // Toplam borcu güncelleme
            toplamBorc += borc;
            lblBorc.Text = toplamBorc.ToString();

            listView1.Items.Add(newListItem);
        }
        DateTime girisTarih = DateTime.Now;

        /// <summary>
        /// Datetimepicker'dan seçilen tarihlere göre fiyat hesaplayan fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            Rezervasyon rezervasyonYapanMusteriBilgileri = RezervasyonBilgileriCek();
            girisTarih = rezervasyonYapanMusteriBilgileri.GirisTarihi;

            int gunFarki = ((dtpCikis.Value.Date) - (girisTarih.Date)).Days;
            toplamBorc *= gunFarki;
            lblBorc.Text = toplamBorc.ToString();
            lblBorc.Visible = true;
            gbBuzdolabi.Enabled = true;
        }
    }
}


