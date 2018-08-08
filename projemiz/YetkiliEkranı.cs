using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projemiz
{
    public partial class YetkiliEkranı : Form
    {
        public YetkiliEkranı()
        {       

            InitializeComponent();

        }
        private void YetkiliEkranı_Load(object sender, EventArgs e)
        {

        }
        public ÜrünKataloğu ÜKatalog = new ÜrünKataloğu();
        
            
       
        SatışKalemi SKalemi = new SatışKalemi();
        
            Dükkan Dkkn = new Dükkan();
        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            Ürün YeniÜrün=new Ürün();
            YeniÜrün.Ürünüm.ÜrünKodu = Convert.ToInt32(txtStokÜrünBarkodu.Text);
            int Miktar = Convert.ToInt32(txtStokÜrünMiktarı.Text);
            ÜKatalog.Karşılaştır(YeniÜrün, YeniÜrün.Ürünüm.ÜrünKodu);
            YeniÜrün.Ürünüm.Adet = Miktar;
            Dkkn.ÜrünEkle(YeniÜrün);
            txtÜrünStokListesi.Text = Dkkn.ÜrünListele();
            

        }

        private void btnKatalogaÜrünEkle_Click(object sender, EventArgs e)
        {

            Ürün YeniÜrün=new Ürün();
            YeniÜrün.Ürünüm.Tanım = txtKatalogdaTanım.Text;
            YeniÜrün.Ürünüm.Maliyet = Convert.ToDecimal(txtKatalogdaFiyat.Text);
            YeniÜrün.Ürünüm.ÜrünKodu = Convert.ToInt32(txtKatalogdaBarkod.Text);
            ÜKatalog.ÜrünEkle(YeniÜrün);
            txtÜrünKataloğuListesi.Text = ÜKatalog.ÜrünListele();

        }

        

        private void btnKatalogdanÜrünSil_Click(object sender, EventArgs e)
        {
            ÜKatalog.KarşılaştırSil(Convert.ToInt32(txtKatalogdaBarkod.Text));
            txtÜrünKataloğuListesi.Text = ÜKatalog.ÜrünListele();
            
        }
        private void btnÜrünSat_Click(object sender, EventArgs e)
        {
            Müşteri M=new Müşteri();
            M.İletişimBilgisi(txtMüşteriAdres.Text, txtMüşteriTel.Text);
            Satış SatışDetay=new Satış(txtMüşteriAdSoyad.Text.ToString(),txtSatışMüşteriTC.Text.ToString()) {Velinimet=M };

            Dkkn.StoktanÜrünEksilt(SatışDetay.Skalem.SatılanÜrün, Convert.ToInt32(txtSatışBarkod.Text), Convert.ToInt32(txtSatışMiktar.Text));
            SatışDetay.Tarih = Convert.ToDateTime(txtSatışTarih.Text);
            lblSatışNo.Text = (Convert.ToInt32(lblSatışNo.Text) + 1).ToString();
            SatışDetay.Trmnl.SeriNo = Convert.ToInt32(lblSatışNo.Text);
            SatışDetay.Para.ÖdemeMiktarı = Convert.ToDecimal(txtÖdeme.Text);

        }

        
    }
}
