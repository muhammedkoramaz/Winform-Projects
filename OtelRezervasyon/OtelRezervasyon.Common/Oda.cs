using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Common
{
    public class Oda
    {
        public string OdaIsmi { get; set; }
        public int OdaKisiSayisi { get; set; }
        public int OdaUcreti { get; set; }
        public OdaDurum OdaDurum { get; set; } = OdaDurum.Bos;
        public override string ToString()
        {
            return OdaIsmi;
        }
    }
}
