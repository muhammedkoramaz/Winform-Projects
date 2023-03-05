using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu.Common
{
    public class Musteri
    {
        public string TCKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public string TelefonNo { get; set; }
        public Arac AracBilgi { get; set; }

    }
}
