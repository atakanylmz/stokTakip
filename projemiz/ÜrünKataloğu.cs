using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public class ÜrünKataloğu:IÜrünEkleyen
    {
        public List<Ürün> Kataloğum = new List<Ürün>();

        public void ÜrünEkle(Ürün YeniÜrün)
        {
            Kataloğum.Add(YeniÜrün);
            
        }
        
        public void ÜrünSil(Ürün EskiÜrün, int tane)
        {
            Kataloğum.Remove(EskiÜrün);
        }
        public void KarşılaştırSil(int SilinecekÜrününBarkodu)
        {
            foreach (Ürün ü in Kataloğum)
            {
                if (ü.Ürünüm.ÜrünKodu == Convert.ToInt32(SilinecekÜrününBarkodu))
                {
                    ÜrünSil(ü, 1);
                    break;
                }

            }
        }
        public void Karşılaştır(Ürün ürn,int kod)
        {
            foreach (Ürün ü in Kataloğum)
            {
                if (ü.Ürünüm.ÜrünKodu ==kod)
                {
                    ürn.Ürünüm = ü.Ürünüm;
                    
                    break;
                    
                }

            }
           
            

        }

        public string ÜrünListele()
        {
            string temp = "ÜRÜN BARKODU      &      ÜRÜN TANIMI      &      ÜRÜN MALİYET" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            foreach (Ürün ürn in Kataloğum)
            {
                temp += ürn.Ürünüm.ÜrünKodu.ToString() + "          &         " + ürn.Ürünüm.Tanım.ToString() + "           &         " + ürn.Ürünüm.Maliyet.ToString() + Environment.NewLine + Environment.NewLine;
            }
            return temp;
        }
    }
}
