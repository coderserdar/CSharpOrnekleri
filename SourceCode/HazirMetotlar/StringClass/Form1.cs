using System;
using System.Windows.Forms;

namespace StringClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
            Sahip olduğunuz metinsel değerlerin özelliklerini değiştirmek için kullanılan metotlardır. Örneğin, kelimeleri parçalamak, eklemek, harflerin yerini değiştirmek, boşluk temizlemek, ayrıştırmak, vs.. 
        */
        string ornekMetin;
        private void button1_Click(object sender, EventArgs e)
        {
            //CompareTo => Metodu kullandığınız string değerler metoda verdiğiniz parametredeki string değeri sözlük mantığıyla karşılaştırır. Eğer sözlükte aynı lokasyondayda 0, parametredeki değer, ana değerimizden sözlükte önceyse -1, sonraysa 1 değerini döndürür.
            ornekMetin = textBox1.Text;
            int sonuc = ornekMetin.CompareTo("bilgeadam");
            string mesaj = "";
            switch (sonuc)
            {
                case -1: mesaj = "Kelime diğer kelime ile eşleşmemektedir, Eksik karakter var"; break;
                case 0: mesaj = "Tebrikler! Kelimeler eşleşmektedir"; break;
                case 1: mesaj = "Kelime diğer kelime ile eşleşmemektedir. Fazla karakter var.."; break;
            }
            MessageBox.Show(mesaj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ornekMetin = textBox1.Text;
            bool varMi = ornekMetin.Contains("adam");
            MessageBox.Show("Aradığınız değer " + (varMi ? "bulunmaktadır!":"bulunmamaktadır"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //StartsWith => Kelimenizin parametrede gönderdiğiniz değerle başlayıp başlamadığını size "bool" olarak döndürür.
            ornekMetin = textBox1.Text;
            bool sonuc = ornekMetin.StartsWith("bil");
            MessageBox.Show($"\"{ornekMetin}\" kelimesi, \"bil\" parametresi ile {(sonuc ? "başlamaktadır":"başlamamaktadır")}","Kontrol Bildirimi",MessageBoxButtons.OK, sonuc ? MessageBoxIcon.Information:MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //EndsWith() => Kelimenizi parametrede gönderdiğiniz değerle bitip bitmediğini size "bool" olarak döndürür.
            ornekMetin = textBox1.Text;
            MessageBox.Show(ornekMetin.EndsWith("dam") ? "Kelime \"dam\" ile bitmektedir.": "Kelime \"dam\" ile bitmemektedir!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //IndexOf() => Dizilerde gördüğümüz metodun aynı prensibiyle çalışır. Eğer harf varsa harfin indexini, yoksa -1 değerini , harf birden fazla var ise ilk harfin indexini döndürür.
            ornekMetin = textBox1.Text;
            int index = ornekMetin.IndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //LastIndexOf() => Dizilerde gördüğümüz metodun aynı prensibiyle çalışır. Eğer harf varsa harfin indexini, yoksa -1 değerini , harf birden fazla var ise son harfin indexini döndürür.
            ornekMetin = textBox1.Text;
            int index = ornekMetin.LastIndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //NOT => Bir string üzerinde yaptığınız değişiklikler o string'i değiştirmez, size yeni bir kopyasını teslim eder..
            //Remove (1.Kullanım) => Verdiğiniz index numarası dahil, o intexdeki ve sonraki tüm karakterleri ortadan kaldırır.
            //Remove (2.Kullanım) => Verdiğiniz index numarası dahil, o intexdeki elemandan başlayarak, ikinci parametrede gönderdiğiniz değer kadar elemanı ortadan kaldırır.
            ornekMetin = textBox1.Text;
            //ornekMetin = ornekMetin.Remove(4); => Birinci Kullanım
            ornekMetin = ornekMetin.Remove(3, 2); //=> İkinci Kullanım
            MessageBox.Show(ornekMetin);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Replace => Metniniz içeriideki bir karakteri(char) ya da bir bölümü(string) yeni bir karakter-bölüm ile değiştirmenize olanak sağları..
            ornekMetin = textBox1.Text;
            ornekMetin = ornekMetin.Replace("adam", "kadın");
            MessageBox.Show(ornekMetin);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Split => Metninizi özel bir karakter-karakterlerle birden fazla parçaya ayırmanız olanak sağlayan metottur. Aynı anda birden fazla özel karakter de verebilirsiniz..
            string mailAdresleri = textBox1.Text;
            string[] adresler = mailAdresleri.Split(';', ',');
            foreach (string mail in adresler)
                MessageBox.Show(mail);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Insert => Bir metinsel değerin herhangi bir pozisyonuna (index) yeni bir değeri iliştirmek istiyorsanız bu metodu kullanabilirsiniz. İlk parametrede kaçıncı indexten sonra ekleyeceğini, ikinci parametrede ise hangi metni ekleyeceğini söyler.
            ornekMetin = textBox1.Text;
            ornekMetin = ornekMetin.Insert(5, "cik");
            MessageBox.Show(ornekMetin);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ToLower => İlgili metnin tamamını küçük harfe çerirmenize olanak sağlar.
            //ToUpper => İlgili metnin tamamını büyük harfe çerirmenize olanak sağlar.
            ornekMetin = textBox1.Text;
            Text = ornekMetin.ToLower();
            MessageBox.Show(ornekMetin.ToUpper());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //SubString (1. Kullanım) => Metninizden, parametrede gönderdiğiniz indexten başlayarak, geri kalan kısmı çekip almanıza olanak sağlar..
            //SubString (2. Kullanım) => Metninizden, ilk parametrede verdiğiniz indexten başlayarak, ikinci parametrede verdiğini değere kadarlık kısmı çekip almanıza olanak sağlar..

            ornekMetin = textBox1.Text;
            //ornekMetin = ornekMetin.Substring(5);  => 1. Kullanım
            ornekMetin = ornekMetin.Substring(3,2); // => 2.Kullanım ge
            MessageBox.Show(ornekMetin);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //ToCharArray => Stringiniz charlarına ayırarak size char[] olarak teslim eder.
            ornekMetin = textBox1.Text;
            char[] karakterler = ornekMetin.ToCharArray();

            //Dışarıdan giirlen metindeki her bir karakterin ASCII değerleri toplamı kaçtır.
            int havuz = 0;
            for (int i = 0; i < karakterler.Length; i++)
                havuz += karakterler[i];
            MessageBox.Show(havuz.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Trim => Metninizi sağında ya da solundaki tüm boşlukları temizlemenize olanak sağlar.(TrimEnd ve TrimStart ile sadece baştan veya sondan boşluk temizlemekte mümkündür.)
            ornekMetin = textBox1.Text;
            string yeniDeger = ornekMetin.Trim();
            MessageBox.Show($"Boşluklarla hesaplanan karakter sayısı => {ornekMetin.Length}\nBoşluklar Temizlenip Hesaplanan Karakter Sayısı => {yeniDeger.Length}");
        }
    }
}
