using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public class Müşteri:Kişi
    {
        public override void İletişimBilgisi(string adr,string tel)
        {
            this.Adres = adr;
            this.Tel = tel;
        }
    }
}
