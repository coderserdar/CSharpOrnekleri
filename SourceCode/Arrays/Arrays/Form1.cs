using System;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ARRAY - DİZİ
        // Birden fazla aynı tipteki veriyi bir arada tutmamızı sağlayan nesnelerimizdir.

         //EĞER
         //Index was outsite the bounds of the array.
         //hatası alıyorsanız, bilin ki dizinin boyutlarını aşacak şekilde eleman ekleme çabasındasınız... Hata nerde diye bakma, eleman ekleme işlemlerine git..
        private void Form1_Load(object sender, EventArgs e)
        {
            //1. Tanımlama
            //veriTipi[] diziAdi = new veriTipi[elemanSayisi];
            int[] dizi = new int[3];
            dizi[2] = 265;
            dizi[0] = 5656;
            dizi[1] = 124;
            //dizi[3] = 65464; => Dizimiz 3 elemanlı olduğu için hata verir!!

            //2. Tanımlama
            //VeriTipi[] DiziAdı = new VeriTipi[ElemanSayisi] {DiziElemanları}
            string[] sehirler = new string[4] { "izmir", "istanbul", "ankara", "eskişehir" };

            //3.Tanımlama
            //VeriTipi[] DiziAdı = {DiziElemanları};
            char[] karakterler = { 'a', 'b', 'c' };
        }
        string[] arabalar = { "Mercedes", "Bugatti", "BMW", "Ferrari", "Lamborghini" };
        private void btnSonEleman_Click(object sender, EventArgs e)
        {
            //Dizinin eleman sayısını bilmiyoruz, ancak bizden son elemanı kullanıcıya göstermek isteniyor..
            string sonEleman = arabalar[arabalar.Length - 1];
            Text = sonEleman;
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            //Rastgele olarak dizinin bir elemanını, Forum tepesine yazdıralım.
            Random rnd = new Random();
            Text = arabalar[rnd.Next(arabalar.Length)];
        }
        int[] sayilar = { 10, 20, 30, 40, 50 };
        int index = 0;
        int havuz = 0;
        private void btnListBox_Click(object sender, EventArgs e)
        {
            //Butona her basıldığında, ilk elemandan başlayarak sırası ile dizinin tüm elemanlarını listbox'a ekleyinizi.
            //Ancak, eklediğiniz her bir elemanı da bir havuzda toplayarak anlık olarak elemanların toplamını tepeye yazdırınız.
            //localScope
            if(index < sayilar.Length)
            {
                listBox1.Items.Add(sayilar[index]);
                havuz += sayilar[index];
                this.Text = "Şu ana dek toplamınız => " + havuz;
                index++;
            }else
                MessageBox.Show("Dizinin son elemanına geldik artık!");

        }
        //Global Scope
    }
}
