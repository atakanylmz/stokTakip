using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public class Terminal
    {
        public KasaGörevlisi KGörevli = new KasaGörevlisi();
        public Terminal()
        {
            KGörevli.KimlikNo = GirişEkranı.Tc;
            KGörevli.AdSoyad = GirişEkranı.AdSoyad;
        }
        
       
        public int SeriNo { get; set; }
    }
}
