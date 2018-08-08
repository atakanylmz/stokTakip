using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public class HesapDefteri
    {
        List<Satış> Satışlar = new List<Satış>();
        public void SatışEkle(Satış YeniSatış)
        {
            Satışlar.Add(YeniSatış);
        }
        string temp=" & ÜRÜN MİKTARI & TOPLAM TUTAR & MÜŞTERİ ADI SOYADI & MÜŞTERİ TEL & MÜŞTERİ ADRES & MÜŞTERİ TC & MÜŞTERİ ÖDENEN & MÜŞTERİ KALAN ";
        public string SatışDetayListele()
        {
            foreach (Satış S in Satışlar)
            {
                temp += "SATIŞ NO: "+S.Trmnl.SeriNo.ToString()+ " & SATIŞ TARİHİ: "+S.Tarih.ToString()+ " & ÜRÜN BARKODU: ";
            }
            
            return temp;
        }
    }
}
