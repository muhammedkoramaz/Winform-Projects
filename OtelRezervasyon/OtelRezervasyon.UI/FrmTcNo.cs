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

namespace OtelRezervasyon.UI
{
    public partial class FrmTcNo : Form
    {
        private readonly List<Rezervasyon> rezervasyonlar;

        public FrmTcNo()
        {
            InitializeComponent();
        }
        public FrmTcNo(List<Rezervasyon> rez) :this()
        {
            this.rezervasyonlar = rez;
        }
        private void FrmTcNo_Load(object sender, EventArgs e)
        {
            ListViewYazdir();
        }
        /// <summary>
        /// Tc kimlik numaraları ve müşteri ad soyad bilgileri listviewe yazdırılır.
        /// </summary>
        private void ListViewYazdir()
        {
            foreach (Rezervasyon rezervasyon in rezervasyonlar)
            {
                ListViewItem item = new ListViewItem(rezervasyon.Musteri.MusteriTC.ToString());
                item.SubItems.Add(rezervasyon.Musteri.MusteriAd.ToString());

                lvTcKimlikListesi.Items.Add(item);
            }
        }
        /// <summary>
        /// Gönder butonuna basıldığında tüm tc kimlik numaraları polise gönderilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGonder_Click(object sender, EventArgs e)
        {
            lvTcKimlikListesi.Items.Clear();
        }
    }
}
