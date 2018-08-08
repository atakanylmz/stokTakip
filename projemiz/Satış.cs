using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projemiz
{
    public class Satış
    {
        public SatışKalemi Skalem = new SatışKalemi();
        public Müşteri Velinimet = new Müşteri();
        private decimal tutar;
        public decimal Tutar
        {
            get { return tutar; }
            set { tutar = Skalem.BirimSatışFiyatı*Skalem.Miktar; }
        }
        public DateTime Tarih { get; set; }
        public Terminal Trmnl=new Terminal();
        public Ödeme Para = new Ödeme();
        public Satış(string MüşteriAd,string MüşteriTc)
        {
            Velinimet.AdSoyad = MüşteriAd;
            Velinimet.KimlikNo = MüşteriTc;
            Para.KalanBorç =Tutar-Para.ÖdemeMiktarı;
        }
    

    }
}
