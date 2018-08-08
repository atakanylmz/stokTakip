using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public abstract class Kişi
    {
        public string KimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        public virtual void İletişimBilgisi(string adr,string tel)
        {
            this.Tel = "05522472245";
            this.Adres = "Teknosa Festiva Salihli Manisa";

        }


    }
}
