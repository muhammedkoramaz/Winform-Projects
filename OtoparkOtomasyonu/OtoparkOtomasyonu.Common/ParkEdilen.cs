using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu.Common
{
    public class ParkEdilen
    {
        public Musteri Musteri { get; set; }
        public ParkYeri ParkYeri { get; set; } = new ParkYeri();
        public DateTime GirisTarihi { get; set; } = DateTime.Now;    
        public DateTime CikisTarihi { get; set; } = DateTime.Now;
        public double ToplamBorc { get; set; }
    }
}
