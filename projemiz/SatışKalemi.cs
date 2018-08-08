using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public class SatışKalemi
    {
        public Ürün SatılanÜrün = new Ürün();
        public int Miktar { get; set; }
        public decimal BirimSatışFiyatı { get; set; }
    }

}
