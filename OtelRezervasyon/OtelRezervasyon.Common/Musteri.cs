using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Common
{
    public class Musteri
    {
        public string MusteriAd { get; set; }
        public string MusteriTC { get; set; }
        public string Tel { get; set; }
        public override string ToString()
        {
            return MusteriAd; 
        }
    }
}
