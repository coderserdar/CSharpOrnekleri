using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParametreliMetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
            Parametreli Metotlar
            Dışarıdan gelecek olan değerlere/argümanlara göre işlem yönünü değiştirecek olan metotlardır...
            Parametredeki argümana, içeride değer atanmaz!!!
            Metot prensipleri gereği, parametrenin nereden geleceği söylenmez...
        */
        #region Örnek 1
        void ParametreliSaydir(int kacaKadarSayayim)
        {
            listBox1.Items.Clear();
            //kacaKadarSayayim = 100; / int.parse(textBox1.text) Yanlış...
            for (int i = 0; i <= kacaKadarSayayim; i++) listBox1.Items.Add(i);
        }
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            ParametreliSaydir(Convert.ToInt32(textBox1.Text));
        }
        #endregion
        #region Örnek 2
        void HesapMakinesi(double sayiBir, double sayiIki)
        {
            MessageBox.Show(Math.Pow((sayiBir + sayiIki), 3).ToString());
        }
        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen iki sayının toplamının kübünü mbox'la gösterecek metot yazınız..
            HesapMakinesi(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
        #endregion
        #region Örnek 3
        void SonUcHarfKesici(string kelime)
        {
            MessageBox.Show(kelime.Length <= 3 ? kelime : kelime.Substring(kelime.Length - 3, 3));
        }
        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen değerin son 3 harfini mbox'la gösterecek bir metot yazınız. Ancak girilen değer 3 harften azsa ya da 3 harfe eşitse direk olarak tamamını göstersin.
            SonUcHarfKesici(textBox1.Text);
        }
        #endregion
        #region Örnek 4
        void Ayristirici(string mailAdresleri)
        {
            string[] adresler = mailAdresleri.Split(';', ',', '+');
            foreach (string adres in adresler) MessageBox.Show(adres);
        }
        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen mailleri " ; , + " gördüğü yerden ayırıp listboxa dolduran bir metot yazınız
            Ayristirici(textBox1.Text);
        }
        #endregion
        #region Örnek 5
        #region 1. Yöntem
        void SesliKontrolu(string gelenMetin)
        {
            char[] karakterler = gelenMetin.ToLower().ToCharArray();
            for (int i = 0; i < karakterler.Length; i++)
            {
                switch (karakterler[i])
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'u':
                    case 'ü': listBox1.Items.Add(karakterler[i]); break;
                    default:
                        listBox2.Items.Add(karakterler[i]);
                        break;
                }
            }

            MessageBox.Show(listBox1.Items.Count == 0 ? "Sesli harf bulunmamaktadır" : $"Sesli harf sayısı {listBox1.Items.Count} ");
        }
        #endregion
        #region 2. Yöntem
        void SesliKontroluFarkli(string metin)
        {
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] karakterler = metin.ToCharArray();
            int sesliSayisi = 0;
            for (int i = 0; i < karakterler.Length; i++)
            {
                    bool sesliVarmi = false;
                for (int z = 0; z < sesliler.Length; z++)
                {
                    if (karakterler[i] == sesliler[z])
                    {
                        sesliSayisi++;
                        listBox1.Items.Add(karakterler[i]);
                        sesliVarmi = true;
                        break;
                    }
                }
                if (!sesliVarmi)
                    listBox2.Items.Add(karakterler[i]);
            }
            MessageBox.Show(sesliSayisi == 0 ? "Bu kelimede sesli harf yok" : "Bu kelimede toplam " + sesliSayisi + " tane sesli harf vardır");
        }
        #endregion
        #region 3. Yöntem
        void ContainsKelime(string metin)
        {
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] karakterler = metin.ToCharArray();
            for (int i = 0; i < karakterler.Length; i++)
            {
                if (sesliler.Contains(karakterler[i])) listBox1.Items.Add(karakterler[i]);
                else listBox2.Items.Add(karakterler[i]);
            }

            MessageBox.Show(listBox1.Items.Count == 0 ? "Bu kelimede sesli harf yok" : "Bu kelimede toplam " + listBox1.Items.Count + " tane sesli harf vardır");
        }
        #endregion
        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            // TextBox'tan gelen değerede eğer sesli bir harf varsa, o harfleri 1.litboxa atın ve kaç adet olduğunu mbox ile gösterin, eğer yoksa bu kümede sesli harf bulunmamaktadır uyarısını verinizi. Girirlen metinde sessiz harfleride lbox2'ye atınız. Kullıcı büyük küçük harf gözetmeksizin giriş yapabilir, kontrol sırasında dikkat edelim.
            //SesliKontrolu(textBox1.Text);
            //SesliKontroluFarkli(textBox1.Text);
            ContainsKelime(textBox1.Text);
        }
        #endregion
        #region Örnek 6
        void RenkDegistirici(string renkAdi)
        {
            BackColor = Color.FromName(renkAdi);
        }
        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            //ComboBox'tan seçilen rengi formun arka plan rengine atayan bir metot yazınız.
            RenkDegistirici(comboBox1.SelectedItem.ToString());
        }
        #endregion
    }
}
