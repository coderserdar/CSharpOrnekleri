using System;
using System.Windows.Forms;

namespace MathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
            MATH CLASSI
            Hazır olarak onlarca matematiksel fonskiyonu bize sunan temel sınıftır. Yuvarlama işlemleri, PI bilgisi, karekök, kuvvet vs..
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Text = Math.PI.ToString();
            string deger = Math.PI.ToString();
            deger = deger.Substring(0, 4);
            this.Text = deger;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mutlakDeger = Math.Abs(-45);
            this.Text = mutlakDeger.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Floor => Verilen ondalıklı değeri, bir alt tam değere tamamalr.
            double deger = Math.Floor(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Ceiling => Verilen ondalıklı değeri, bir üst tam değere tamamlar.
            double deger = Math.Ceiling(11.01);
            MessageBox.Show(deger.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Round => Sayının yarısından fazlasını bir üste, yarısından azını ise bir alttaki tam değere yuvarlar.
            //Not: .'dan önceki sayı çiftse bir alt değere, tek ise bir üst değere tamamlar. (Not: .'dan sonraki değer 50 ise)
            double deger = Math.Round(12.50);
            MessageBox.Show(deger.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Truncate => Sayının ondalıklı kısmına bakmaz, yalnızca tam kısmını teslim eder...
            double deger = Math.Truncate(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Max
            int max = Math.Max(45, 65);
            MessageBox.Show(max.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Min
            int min = Math.Min(45, 65);
            MessageBox.Show(min.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Pow => Kuvvet alma işlemlerini gerçekleştirir. Ilk parametredeki hangi sayının kuvveti alınacak, ikinci parametrede ise o sayının kaçıncı kuvverti alınacak diye sorar.
            double kuvvet = Math.Pow(3, 4);
            MessageBox.Show(kuvvet.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Sqrt => Bir sayının karekökünü hesaplamak için kullanılır.
            double deger = Math.Sqrt(15);
            MessageBox.Show(deger.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Sign => Bir sayının negatif, pozitif ya da 0'a eşit olup olmadığıyla ilgili bildirim döner..
            // eğer sayı negatifse -1, pozitifse +1, 0 ise size 0 değerini döner..
            int sonuc = Math.Sign(-25);
            MessageBox.Show(sonuc.ToString()); //-1

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen 3 sayıdan en küçüğünü tek satorda gösteriniz, if kullanmayınız
            int birinciDeger = Convert.ToInt32(textBox1.Text);
            int ikinciDeger = Convert.ToInt32(textBox2.Text);
            int ucuncuDeger = Convert.ToInt32(textBox3.Text);

            int minDeger = Math.Min(Math.Min(birinciDeger, ikinciDeger), ucuncuDeger);

            Text = $"En küçük değer {minDeger}";
        }

       
    }
}
