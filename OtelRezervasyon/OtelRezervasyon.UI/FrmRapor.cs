using OtelRezervasyon.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelRezervasyon.UI
{
    public partial class FrmRapor : Form
    {
        private readonly List<Rezervasyon> rezervasyonlar;

        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<Rezervasyon> musteriOdalar) :this()
        {
            this.rezervasyonlar = musteriOdalar;
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            ListViewYazdir(rezervasyonlar);
        }
        /// <summary>
        /// Müşterileri ismine göre filtreleyen fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIsmeGoreFiltrele_Click(object sender, EventArgs e)
        {
            //TextBoxda aratırken başa sona koyduğu boşluğu temizler.
            string arananIsim = txtIsim.Text.Trim();

            var filtre = rezervasyonlar.Where(a=>a.Musteri.MusteriAd.Contains(arananIsim)).ToList();
            ListViewYazdir(filtre);
        }
        /// <summary>
        /// Müşterileri seçili tarihe göre getiren fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTariheGoreFiltrele_Click(object sender, EventArgs e)
        {
            var filtre = rezervasyonlar.Where(a => a.GirisTarihi.Date ==dtpTarih.Value.Date).ToList();
            ListViewYazdir(filtre);
        }
        /// <summary>
        /// Kaydı oluşturulan tüm müşterileri ilgili listviewe yazdırmayı sağlayan fonksiyon.
        /// </summary>
        /// <param name="rezervasyonlar"></param>
        private void ListViewYazdir(List<Rezervasyon> rezervasyonlar)
        {
            lvRezervasyonlar.Items.Clear();
            foreach (Rezervasyon rezervasyon in rezervasyonlar)
            {
                ListViewItem item = new ListViewItem(rezervasyon.Musteri.MusteriAd, 0);
                item.SubItems.Add(rezervasyon.Musteri.MusteriTC.ToString());
                item.SubItems.Add(rezervasyon.Musteri.Tel.ToString());
                item.SubItems.Add(rezervasyon.GirisTarihi.ToString());
                item.SubItems.Add(rezervasyon.CikisTarihi.ToString());
                item.SubItems.Add(rezervasyon.KalinacakOda.OdaIsmi);
                item.SubItems.Add(rezervasyon.ToplamBorc.ToString());

                lvRezervasyonlar.Items.Add(item);
            }
        }

    }
}
