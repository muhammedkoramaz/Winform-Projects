using OtelRezervasyon.Common;
using OtelRezervasyon.Extentions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtelRezervasyon.UI
{
    public partial class FrmMusteriKayit : Form
    {
        public FrmMusteriKayit()
        {
            InitializeComponent();
        }

        readonly List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        Rezervasyon secilenOda = new Rezervasyon();

        Button tiklanilanButton = null;

        private void FrmMusteriKayit_Load(object sender, EventArgs e)
        {
            for (int odaKisiSayisi = 1; odaKisiSayisi < 4; odaKisiSayisi++)
            {
                // Oda kişi sayıları labellara yazdırılıyor. 
                Label odaKisiSayisiLabel = new Label
                {
                    Text = odaKisiSayisi.ToString() + " Kişilik Odalar"
                };

                flRooms.Controls.Add(odaKisiSayisiLabel);
                flRooms.SetFlowBreak(odaKisiSayisiLabel, true);

                for (int odaNumarasi = 1; odaNumarasi <= 10; odaNumarasi++)
                {
                    // Oda isimleri 101,205 vs. şekilde oluşturuluyor.
                    string odaIsmi = ((odaKisiSayisi * 100) + odaNumarasi).ToString();

                    Button btnOda = OdaButtonOluştur(odaIsmi, odaKisiSayisi, odaKisiSayisi * 50);
                    btnOda.MouseUp += OdaButton_Click;

                    flRooms.Controls.Add(btnOda);
                }
            }
            // Kral Dairesi oluşturuluyor.
            btnKral.Tag = RezervasyonOlustur("Kral Dairesi", 5, 1000);
        }
        /// <summary>
        /// Otelde bulunan odaları buton halide, özelliklerine göre oluşturan fonksiyon.
        /// </summary>
        /// <param name="odaIsmi"></param>
        /// <param name="odaKisiSayisi"></param>
        /// <param name="odaUcreti"></param>
        /// <returns></returns>
        private Button OdaButtonOluştur(string odaIsmi, int odaKisiSayisi, int odaUcreti)
        {
            Button odaButton = new Button
            {
                Text = odaIsmi,
                Width = 40,
                Height = 40,
                BackColor = Color.Green,
                Tag = RezervasyonOlustur(odaIsmi, odaKisiSayisi, odaUcreti)
            };

            odaButton.MouseUp += OdaButton_Click;

            return odaButton;
        }

        /// <summary>
        /// Her bir oda için rezervasyon oluşturma fonksiyonu.
        /// </summary>
        /// <param name="odaIsmi"></param>
        /// <param name="odaKisiSayisi"></param>
        /// <param name="odaUcreti"></param>
        /// <returns></returns>
        private Rezervasyon RezervasyonOlustur(string odaIsmi, int odaKisiSayisi, int odaUcreti)
        {
            Rezervasyon odaRezervasyon = new Rezervasyon
            {
                KalinacakOda = new Oda
                {
                    OdaIsmi = odaIsmi,
                    OdaKisiSayisi = odaKisiSayisi,
                    OdaUcreti = odaUcreti,
                    OdaDurum = OdaDurum.Bos,
                }
            };
            return odaRezervasyon;
        }
        /// <summary>
        /// Butona eğer sağ tıklanırsa temizlik-boş durumları arasında geçiş yapma ve 
        /// sol tıklanırsa tıklanılan butonun oda bilgilerini ilgili değişkene atma fonksiyonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OdaButton_Click(object sender, MouseEventArgs e)
        {   
            string odaAdi = ((Button)sender).Text == "" ? "Kral Odası" : ((Button)sender).Text.ToString();
            tiklanilanButton = sender as Button;
            secilenOda = tiklanilanButton.Tag as Rezervasyon;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    tiklanilanButton.Tag = ((Button)sender).Tag;
                    label4.Text = odaAdi + " no'lu oda seçili.";
                    gbMusteriBilgiler.Enabled = true;
                    break;
                case MouseButtons.Right:
                    OdaDurumDegistir(secilenOda.KalinacakOda.OdaDurum);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Kaydet butonuna tıklandığında eğer oda dolu ise uyarı veren ve eğer oda boş ise rezervasyon kayıt yapan fonksiyon.
        /// Rezervasyon işlemi yapıldıktan sonra o odanı durumunu ve rengini değiştirir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KaydetButton_Click(object sender, EventArgs e)
        {
            if (!(txtMusteriAd.Text.IsValidFullName()
                && txtTC.Text.IsValidTCKN()
                && txtTel.Text.IsValidPhoneNumber()))
            {
                MessageBox.Show("Doğru değil.");
                return;
            }
            var odaRezervasyon = tiklanilanButton.Tag as Rezervasyon;
            if (odaRezervasyon.KalinacakOda.OdaDurum != OdaDurum.Bos
                && odaRezervasyon.KalinacakOda.OdaDurum != OdaDurum.Temizlik)
            {
                MessageBox.Show("Oda Dolu.");
                MusteriBilgileriniTemizle();
                return;
            }

            odaRezervasyon.Musteri = new Musteri()
            {
                MusteriAd = txtMusteriAd.Text,
                MusteriTC = txtTC.Text,
                Tel = txtTel.Text,
            };
            odaRezervasyon.GirisTarihi = dtpGiris.Value;
            odaRezervasyon.KalinacakOda.OdaDurum = OdaDurum.Dolu;
            rezervasyonlar.Add(odaRezervasyon);

            tiklanilanButton.BackColor = Color.Red;

            this.Tag = rezervasyonlar;

            MusteriBilgileriniTemizle();

            MessageBox.Show("Kayıt Başarılı.");

        }
        /// <summary>
        /// Formda bulunan input componentlerini temizleme fonksiyonu.
        /// </summary>
        private void MusteriBilgileriniTemizle()
        {
            // Müşteri groupboxının içindeki textbox ve maskedtextbox elementlerinde dönüyor ve textlerini boş yapıyor.
            gbMusteriBilgiler.Controls.OfType<TextBox>()
                .Concat<Control>(gbMusteriBilgiler.Controls.OfType<MaskedTextBox>()) // Bu metot iki farklı kolleksiyonu birleştirir.
                .ToList()
                .ForEach(tb => tb.Text = "");

            dtpGiris.Value = DateTime.Now;
            tiklanilanButton = null;
            label4.Text = "Oda Seçiniz.";
            gbMusteriBilgiler.Enabled = false;
        }
        /// <summary>
        /// Odanın boş, dolu ve temizlik durumunu ayarlayan fonksiyon.
        /// </summary>
        /// <param name="odaDurum"></param>
        private void OdaDurumDegistir(OdaDurum odaDurum)
        {
            if (odaDurum == OdaDurum.Bos)
            {
                secilenOda = tiklanilanButton.Tag as Rezervasyon;
                secilenOda.KalinacakOda.OdaDurum = OdaDurum.Temizlik;
                tiklanilanButton.BackColor = Color.Cyan;
                MessageBox.Show("Oda Durumu " + OdaDurum.Temizlik.ToString() + " Olarak Değiştirildi.");
            }
            else if (odaDurum == OdaDurum.Temizlik)
            {
                secilenOda = tiklanilanButton.Tag as Rezervasyon;
                secilenOda.KalinacakOda.OdaDurum = OdaDurum.Bos;
                tiklanilanButton.BackColor = Color.Green;
                MessageBox.Show("Oda Durumu " + OdaDurum.Bos.ToString() + " Olarak Değiştirildi.");
            }
        }
    }
}
