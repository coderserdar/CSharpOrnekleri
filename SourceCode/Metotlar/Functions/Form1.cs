using System;
using System.Drawing;
using System.Windows.Forms;

namespace Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * FONKSİYONLAR (FUNCTIONS)
         * Tıpki void metotlar gibi kendine ait bir alanda işlemler gerçekleştiren ancak geriye bir değer döndürebilen yapılardır..
         */
        #region Örnek 1
        int ToplamaYap(int s1, int s2, int s3)
        {
            int toplam = s1 + s2 + s3;
            //Bir metottan çıkan sonucu dış dünyaya döndürmek için kullanıdığımız keyworddür return..
            return toplam;
        }
        private void btnToplama_Click(object sender, EventArgs e)
        {
            int sonuc = ToplamaYap(12, 35, 67);
            this.Text = ToplamaYap(22, 33, 44).ToString();

            MessageBox.Show(ToplamaYap(12,32,45).ToString());
            MessageBox.Show(Math.Pow(ToplamaYap(12,56,78),3).ToString());
        }
        #endregion

        #region Örnek 2
       
        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen değerin teklik çiftlik durumuna bakarası, çiftse -1, tekse 1, 0'a eşitse de 0 olarak geri döndüren bir fonksiyon yazınız
            MessageBox.Show(TekCiftKontrolu(Convert.ToInt32(textBox1.Text)).ToString());
        }

        int TekCiftKontrolu(int girilenDeger)
        {
            int sonuc;
            if (girilenDeger == 0) sonuc = 0;
            else if (girilenDeger % 2 == 0) sonuc = -1;
            else sonuc = 1;
            return sonuc;
        }
        #endregion
        #region Örnek 3 
        string KelimeDegistirici(string ad, string soyad)
        {
           ad = ad.Substring(0, 2).ToUpper() +  ad.Substring(2, ad.Length - 2).ToLower();
            soyad = soyad.Replace('a', 'e');
            return ad + soyad + "@ziraatteknoloji.com";
        }
        private void btnMetinselDegisiklik_Click(object sender, EventArgs e)
        {
            //dışarıdan girilen ilk kelimenin(ad) ilk iki harfi büyük, geri kalanını küçük alınız.
            // ikinci kelimenin(soyad) içeriinde geçen tüm a'lar e ile değiştiriniz.
            // ve sonuna @ziraattekoloji.com ekleyerek geri döndürünüz.
            MessageBox.Show(KelimeDegistirici(textBox1.Text, textBox2.Text));
        }
        #endregion
        #region Ornek 4
        double KarekokHesapla(int[] dizi)
        {
            double toplam = 0;
            foreach (int sayi in dizi) toplam += sayi;
            return Math.Sqrt(toplam);
        }
        private void btnDizi_Click(object sender, EventArgs e)
        {
            //Dışarıdan bir int[] dizisinin parametre olarak alan bir metot yazınızı. Metot, parametredeki dizie yer alan elemanların toplamının karekökünü döndürsün.. (Ondalıklı Gelebilir)
            MessageBox.Show(KarekokHesapla(new int[] {1, 2, 3, 4}).ToString());
        }
        #endregion
        #region Örnek 5
        Color ArkaPlanYakalayici(Control arkaPlaniYakalanacakKontrol) => arkaPlaniYakalanacakKontrol.BackColor;
        private void btnRengiYakala_Click(object sender, EventArgs e)
        {
            //Parametre olarak bir kontrol alan metot yazınız. Bu metot ilgili kontrolun arkaplan rengini (Color) geri döndürsün... Daha sonra metotdan gelen rengi formun arka plan rengi yapalım..
            this.BackColor = ArkaPlanYakalayici(btnRengiYakala);
        }
        #endregion
    }
}
