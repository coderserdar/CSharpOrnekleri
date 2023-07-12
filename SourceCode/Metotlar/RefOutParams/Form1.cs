using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefOutParams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Out Açıklama
        /*
            Out Keyword
            Bir metot içerisinden birden fazla değer döndürmek isterseniz, "return" keywordü fonksiyonlarda size yetmeyecektir. Void metotlar zaten geriye değer döndürmez. Bu bilinenleri yıkabilmek için kullandığımız keyword "out" keywordüdür.
        */
        #region Out Bir
        void GeriyeDegerDonduren(int sayi, out double firlatilanSonuc)
        {
            firlatilanSonuc = Math.Pow(sayi, 2);
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            double yakalananSonuc;
            GeriyeDegerDonduren(12, out yakalananSonuc);
            MessageBox.Show(yakalananSonuc.ToString());
        }
        #endregion
        #region Out İki
        void ListBoxunElemanlariniTemizle(ListBox listBox, out int kacElemanSildim)
        {
            kacElemanSildim = listBox.Items.Count;
            listBox.Items.Clear();
        }
        private void btnOutIki_Click(object sender, EventArgs e)
        {
            int silinenElemanSayisi;
            ListBoxunElemanlariniTemizle(listBox1, out silinenElemanSayisi);
            MessageBox.Show("ListBox'tan toplam "+ silinenElemanSayisi + " eleman silinmiştir");
        }
        #endregion
        #region Örnek 3
        void Hesapla(int sayiBir, int sayiIki, out int toplam, out int fark, out long carpim, out double bolum, out byte mod)
        {
            toplam = sayiBir + sayiIki;
            fark = sayiBir - sayiIki;
            carpim = sayiIki * sayiBir;
            bolum = sayiBir / sayiIki;
            mod = (byte)(sayiBir % sayiIki);
        }
        private void btnOut3_Click(object sender, EventArgs e)
        {
            //Geriye değer döndürmeyen metotla, dışarıdan girilen iki sayısının toplamı, farkı, çarpımı, bolümü, modunu kullanıcıya gösterecek bir metot yazınız.
            Hesapla(9, 4, out int toplam, out int fark, out long carpim, out double bolum, out byte mod);
            MessageBox.Show($"Toplama işlemi sonucu => {toplam}\nFark işlemi sonucu => {fark}\nÇarpma işlemi sonucu => {carpim}\nBolme işlemi sonucu => {bolum}\nMod işlemi sonucu => {mod}\n");
        }
        #endregion
        #endregion
        #region Params
        /*
            Params Keyword
            Dışaradan metoda kaç parametre geleceği bilmememktedir. Ancak gelecek olan tüm parametrelerle de bir takım işlemler yapmak zorundasını.
            Bu sayısız parametreyi tek bir çatı altında toplamanın yolu "params" keywordünden geçer.. Dikkat: Params sizden dizi isteyecektir.
            * Params keywordu kullanın parametre metot imzalarında her zaman en sonda olmalır ve params keywordunu bir parametrede kullandıysan o metot özelinde bir daha kullanamayacaksınız demektir.
        */
        double FiyatlariHesapla(params double[] fiyatlar)
        {
            double toplamFiyat = 0;
            foreach (double fiyat in fiyatlar) toplamFiyat += fiyat;
            return toplamFiyat;
        }
        private void btnParams_Click(object sender, EventArgs e)
        {
            //double[] secililer = { 199.90, 299.90, 9.99 };
            //FiyatlariHesapla(secililer);
            double odenecekTutar = FiyatlariHesapla(199.90, 299.90, 9.99);
            MessageBox.Show(odenecekTutar.ToString() + " TL");
        }
        #endregion
        #region Ref
        /*
            Ref Keyword
            ref parametere niteleyicisi C#'ın "değer olarak çağrı" yerine "referans olarak çağrı" oluşturmasını sağlar. ref kullanarak, void tipli metotlardan değer alabilirsiniz. Üstelik bu değeri alabilmek için yeni bir değişken atamanıza bile gerek kalmaz. ref, methoda parametre olarak soktuğunz, elinizdeki varolan değişkeni değiştirebilir.
        */
        void MailListeleyici(ref string[] hangiDiziyeEklensin, string mailAdresleri)
        {
            //; gördüğümüz yerden değerleri bölüp, diziye ekleyelim.
            string[] gelenDegerler = mailAdresleri.Split(';');
            for (int i = 0; i < gelenDegerler.Length; i++)
            {
                Array.Resize(ref hangiDiziyeEklensin, hangiDiziyeEklensin.Length + 1);
                hangiDiziyeEklensin[i] = gelenDegerler[i];
            }
        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            string[] elemanlar = new string[0];
            MailListeleyici(ref elemanlar, txtMailAdresleri.Text);

            foreach (string eleman in elemanlar) listBox1.Items.Add(eleman);
        }
        #endregion
    }
}
