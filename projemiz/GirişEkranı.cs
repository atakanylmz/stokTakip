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
    public partial class GirişEkranı : Form
    {
        public GirişEkranı()
        {
            InitializeComponent();
        }
        public static string Tc { get; private set; }
        public static string AdSoyad { get; set; }
        string a, b;

        private void GirişEkranı_Load(object sender, EventArgs e)
        {
            MessageBox.Show("tc ve şifreyi aynı ayarladım hocam. 1,2,3 veya 4 den birini seçin. Kasada 4 personel çalışıyor.");

        }

        private void BtnYetkiliGiriş_Click(object sender, EventArgs e)
        {
            a = txtYetkiliTC.Text.ToString();
            b = txtYetkiliŞifre.Text.ToString();
            if ((a == "1" && b == "1")||(a=="2"&&b=="2") || (a == "3" && b == "3") || (a == "4" && b == "4"))
            {if (a == "1") AdSoyad = "Atakan Yılmaz"; if (a == "2") AdSoyad = "Kaan Yılmaz"; if (a == "3") AdSoyad = "Orkun"; if (a == "1") AdSoyad = "Deniz";
                Tc = a;
               YetkiliEkranı YEkran = new YetkiliEkranı();
                
               // YEkran.trm.Görevli.AdSoyad = this.AdSoyad; 
               // YEkran.Görevli.KimlikNo = this.Tc;
            YEkran.Show();
            BtnYetkiliGiriş.Visible = false;
            }
        }

       
    }
}
