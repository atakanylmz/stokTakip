using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public class Dükkan :IÜrünEkleyen
    {

        private List<Ürün> Stoktakiler = new List<Ürün>();

        public void ÜrünEkle(Ürün YeniÜrün)
        {
            

            Stoktakiler.Add(YeniÜrün);

        }

        public void StoktanÜrünEksilt(Ürün ü, int kod,int Miktar)//burada hem satılan kadar ürün sayısı azaltılıyor hem de stoktaki üründen bilgileri satılan listesindeki ürüne aktarıyoruz
        {
            foreach(Ürün ürn in Stoktakiler)
            {
                if (ürn.Ürünüm.ÜrünKodu == kod)
                {
                    ürn.Ürünüm.Adet -= Miktar;
                    ü = ürn;
                    break;
                }
            }

        }

        public string ÜrünListele()
        {
            string temp = "  ÜRÜN BARKODU       &      ÜRÜN MİKTARI  " + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            foreach (Ürün ürn in Stoktakiler)
            {
                temp += ürn.Ürünüm.ÜrünKodu.ToString() + "          &         " + ürn.Ürünüm.Adet.ToString()+ Environment.NewLine + Environment.NewLine;
            }
            return temp;
        }
    }
}
