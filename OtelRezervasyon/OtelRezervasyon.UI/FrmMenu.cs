using OtelRezervasyon.Common;
using OtelRezervasyon.Extentions;
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
    public partial class FrmMenu : Form
    {

        FrmMusteriKayit frmMusteriKayit;
        FrmCikis frmCikis;
        FrmRapor frmRapor;
        FrmTcNo frmTcNo;

        List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
        //List<Rezervasyon> cikisiYapilanMusteriler = new List<Rezervasyon>();

        public FrmMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Müşteri Kayıt sayfasını açan fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusteriKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriKayit = new FrmMusteriKayit
            {
                MdiParent = this
            };
            frmMusteriKayit.Show();
            frmMusteriKayit.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Rapor sayfasını açan fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TumRaporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rezervasyonlar = frmCikis.Tag as List<Rezervasyon>;

            if (rezervasyonlar != null)
            {
                frmRapor = new FrmRapor(rezervasyonlar)
                {
                    MdiParent = this
                };
                frmRapor.Show();
                this.MinimizeAndShowChildForm<FrmRapor>();
            }
            else
            {
                MessageBox.Show("Raporda Görüntülenecek Veri Bulunmamaktadır.");
            }
        }

        /// <summary>
        /// Müşteri Çıkış sayfasını açan fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusteriCikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezervasyonlar = frmMusteriKayit.Tag as List<Rezervasyon>;

            if (rezervasyonlar != null)
            {
                frmCikis = new FrmCikis(rezervasyonlar)
                {
                    MdiParent = this
                };
                frmCikis.Show();

                this.MinimizeAndShowChildForm<FrmCikis>();

            }
            else
            {
                MessageBox.Show("Çıkışı Yapılacak Müşteri Bulunmamaktadır.");
            }
        }
        /// <summary>
        /// TC gönderme sayfasını açan fonksiyon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TcGonderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezervasyonlar = frmMusteriKayit.Tag as List<Rezervasyon>;
            if (rezervasyonlar != null)
            {
                frmTcNo = new FrmTcNo(rezervasyonlar)
                {
                    MdiParent = this
                };
                frmTcNo.Show();

                this.MinimizeAndShowChildForm<FrmTcNo>();
            }
            else
            {
                MessageBox.Show("T.C Kimlik Numarası Listelenecek Bir Müşteri Bulunamadı.");
            }

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
