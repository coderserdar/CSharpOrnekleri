using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySinifiMetotlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
            Array Sınıfı(Class)
            Şu ana dek görmüş olduğumuz ilkel diziler, bize üzerinde çok fazla işlem yapma olanağı sağlamamaktadır. Eğer dizinizi yeniden boyutlandırmak, temizlemek, sıralamak, tersine çevirmek gibi temel işlemler yapmak istiyosanız, Array sınıfı size yardımcı olacaktır...
        */
        #endregion
        string[] ornekDizi = { "İstanbul", "Ankara", "İzmir", "Bursa", "Eskişehir", "Konya", "Trabzon", "Sivas", "Eskişehir" };
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //Array.Clear() => Diziden eleman silmek için kullandığımız metottur.
            Array.Clear(ornekDizi, 2, 3);
            //1. Parametre Kaynak Dizi
            //2. Parametre Başlanacak Index Değeri
            //3. Parametre Silinecek Eleman Sayısı

            // Dizinin tamamını temizleme..
            Array.Clear(ornekDizi, 0, ornekDizi.Length);
        }
        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            //Array.Copy() => Bir diziden, başka bir diziye eleman kopyalamak için kullanılır.
            string[] yeniSehirler = new string[4];
            // 1. ve 2. Overload
            //Array.Copy(ornekDizi, yeniSehirler, 4);
            //1. Parametre Kaynak Dizi
            //2. Parametre Hedef Dizi
            //3. Parametre Kaynak Diziden, Hedef diziye kaç adet eleman kopyalanacak

           
            // 2. ve 3. Overload
            Array.Copy(ornekDizi, 3, yeniSehirler, 1, 1);
            //1. Parametre Kaynak Dizi
            //2. Parametre Kaynak Dizinin Kaçıncı Index değerinden kopyalamaya başlanack
            //3. Parametre Hedef Dizi
            //4. Parametre Hedef dizinin Kaçıncı Index değerinden eklemeye başlanacak
            //5. Parametre Hedef Diziye Kaç Eleman Kopyalanacak. 

            yeniSehirler = yeniSehirler.Where(x => x != null).ToArray();
            foreach (string sehi in yeniSehirler)
                MessageBox.Show(sehi);

            //List<string> dizi = new List<string>();
            //dizi.RemoveAll(x => x == null);
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Array.IndexOf() => Dizide aradığımız elemanın index numarasını döndüren metottur. Eğer aradığınız değer dizi içerisinde mevcut değilse size -1 döndürür.. Eğer eleman birden fazla defa geçiyorsa, size ilk elemanın indexini döndürür.
            int index = Array.IndexOf(ornekDizi, txtGirisAlani.Text);
            // 1. Parametre Kaynak Dizi
            // 2. Parametre Aratılacak Nesne(object tipinde veri ister, dizinin tipi ne ise, o tipde bir değer veririniz..
            MessageBox.Show(index < 0 ? "Aradığınız eleman dizi içerisinde yer almıyor":"Aradığınız elemanın index değeri => " + index);

            index = Array.IndexOf(ornekDizi, txtGirisAlani.Text, 5, 4);
            // 1. Parametre Kaynak Dizi
            // 2. Parametre Aratılacak Nesne(object tipinde veri ister, dizinin tipi ne ise, o tipde bir değer veririniz..
            // 3. Parametre Aramaya Kaçıncı Index Değerinden Başlayayım
            // 4. Parametre Başlanılacak Index Değerinden Sonraki kaç eleman içerisinde arama yapayım.
            MessageBox.Show(index < 0 ? "Aradığınız eleman dizi içerisinde yer almıyor" : "Aradığınız elemanın index değeri => " + index);
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //Array.LastIndexOf() => Dizide aradığınız içerik birden fazla defa ge.iyorsa, size son geçtiği yerin index'ini teslim eder.. Eğer bu eleman hiç yoksa, yine -1 olarak dönüş yapar.
            int aratilanSonIndex = Array.LastIndexOf(ornekDizi, "Eskişehir");
            MessageBox.Show("Aradğınız elemanın son indexi => "+ aratilanSonIndex);

            //Bir dizide bir elemanın birden fazla olup olmadığı kontrol etme =>
            if (Array.IndexOf(ornekDizi, "Eskişehir") == Array.LastIndexOf(ornekDizi, "Eskişehir") && Array.IndexOf(ornekDizi, "Eskişehir") != -1)
                Text = "Bu dizide aradığınız eleman bir adet bulunmakdatır!";
            else
                Text = "Bu dizide aradığınız eleman birden fazla defa geçmektedir!";
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            //Array.Resize() => İlkel dizinin eleman sayısını arttırmak - azaltmak için kullandığımız metottur.

            //Birinci kullanım ile ikinci kullanım arasındaki tek fark, sizden öncelikle bir dizi tipi istemesi ve daha sonra sadece o tipteki dizileri resize edebilme kabiliyetine kavuşmasıdır. Kısaca, tip güvenliği sağlıyor.
            Array.Resize(ref ornekDizi, 23);
            Array.Resize<string>(ref ornekDizi, 23);
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //Array.Sort() => Dizinizi sıralamak için kullanacağınız metottur. Elemanların yerlerini değiştirdiği için, indeleri de değiştirecektir. Sıralama işlemi A'dan Z'ye (küçükten-büyüğe) gerçekleştirilir.
            //1. Overload
            //Array.Sort(ornekDizi);

            //5. Overload
            Array.Sort(ornekDizi, 4, 5);
            // 1. Parametre Kaynak Dizi
            // 2. Parametre Başlangıç Index Değeri
            // 3. Parametre Başlangıç Index Değerinden Sonra Kaç Eleman Sıralanacak
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //Array.Reverse() => Dizinizi tersine çevirmeye yarayan metottur. Kesinlikle sıralama yapmaz.
            Array.Reverse(ornekDizi);

            Array.Reverse(ornekDizi, 4, 5);
            // 1. Parametre Kaynak Dizi
            // 2. Parametre Başlangıç Index Değeri
            // 3. Parametre Başlangıç Index Değerinden Sonra Kaç Eleman Tersine Çevrilecek
        }
    }
}
