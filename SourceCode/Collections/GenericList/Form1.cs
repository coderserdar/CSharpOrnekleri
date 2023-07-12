using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
            List<> içerisinde (<T>) verilen tipe bürünerek, o tipte bir koleksiyon oluşturmamıza olanak sağlayan dizi çeşididir. Daha önceki diziler gibi boyut arttırma işlemine gerek kalmadan üzerinde işlem yapabildiğimiz gelişmiş bir sınıftır. 
        */
        #endregion
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            //sayilar.AddRange() => çoklu ekleme işlemlerini bir arada gerçekleştirebiliriz(Tip bağımlılığına dikkat ederek)

        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");
            sehirler.Add("istanbul");
            sehirler.Add("izmir");

            foreach (string sehir in sehirler)
            {
                MessageBox.Show(sehir);
            }
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("izmir");
            sehirler.Add("istanbul");
            sehirler.Add("ankara");

            //dizinin elemanlarını küçükten büyüğe sıralama
            sehirler.Sort();

            //Linq sınıfını kullanarak List<T> içerisinde gelişmiş metotları kullanabilirsiniz.
            sehirler.ForEach(x => MessageBox.Show(x));
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("izmir");
            sehirler.Add("istanbul");
            sehirler.Add("ankara");

            MessageBox.Show(sehirler.Contains("kars") ? "Bu şehir dizide yer alıyor":"Bu şehir dizi içerisinde yer almıyor");
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            //İçeriğine sizi karar vereceğiniz bir sayısal dizi oluşturun ve bu dizinin en büyük ve enküçük elamanını mbox ile gösterelim
            int[] dizi = { 12, 23, 56, 1, 100, 80, 90 };
            Array.Sort(dizi);
            int enKucuk = dizi[0];
            int enBuyuk = dizi[dizi.Length - 1];
            MessageBox.Show($"En Küçük => {enKucuk}\nEn Büyük => {enBuyuk}");
        }
        string[] kayitlar = new string[0];
        int index = 0;
        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
            //TextBox'tan girilen veri "kayitlar" adli diziye eklensin. Her yeni kayıtta dizinin boyutu arttırılsın. Eleman eklendikten sonra ise aşağıdaki formatta kayıtlar listBox'a eklensin.
            //Format => Eleman - ElemanınIndexi

            Array.Resize(ref kayitlar, kayitlar.Length + 1);
            kayitlar[index] = textBox1.Text;
            listBox1.Items.Add(string.Format("{0}. Elaman => {1}", index + 1, kayitlar[index]));

            index++;
            textBox1.Text = "";
        }
    }
}
