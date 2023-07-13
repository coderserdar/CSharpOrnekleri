using System;
using System.Collections;
using System.Windows.Forms;

namespace ArrayListClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
            ARRAYLIST
            
            Şuana dek gördüğümüz ilkel dizilerin(veriTipi[] olarak tanımlanan) en büyük iki özelliği;
            TİP BAĞIMLILIĞI ve ELEMAN SAYISI ZORUNLULUĞU idi..

            Ancak, ArrayList nesnesiyle birlikte bu bağımlıklar ortadan kalktı. Bir ArrayList'i meydana getirirken ne eleman sayısı vermek zorundasınız ne de bir veri tipi belirlemek zorundasız.

            Dezavantajı Nedir?
            ArrayList içeirisndeki elemanları otomatik olarak object veri tipine dönüştürüyor. Dolayısıyla bu verileri geri almak istediğiniz de mecburen bir "cast" ya da "convert" işlemine gerek duymaktasınız.. Bu da ekstra iki kat iş demektir. (object => bilinene : unboxing işlemi)

            ArrayList'i kullanıma açabilmek için namespace'lere using System.Collections; ibaresini eklemelisiniz.
        */

            //dizinin aşağıdaki gibi oluşturusanınz, eleman sayısı belirtmiş olarak oluşturmuş olursunuz.
        //ArrayList yeniDizi = new ArrayList(20);
        ArrayList yeniDizi = new ArrayList();
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            //btnEkle
            //Object tipinde değer aldığı için her şeyi bir arraylist'e atabilirsiniz.
            //yeniDizi.Add("ICTerra");
            //yeniDizi.Add(1855);
            //yeniDizi.Add(true);
            //yeniDizi.Add(new Button());
            //yeniDizi.Add(new Form());

            yeniDizi.Add("İstanbul");
            yeniDizi.Add("Ankara");
            yeniDizi.Add("İzmir");
            yeniDizi.Add("Bursa");
            yeniDizi.Add("Eskişehir");
            yeniDizi.Add("Edirne");
            yeniDizi.Add("Kuşadası");
            yeniDizi.Add("Antalya");
            yeniDizi.Add("Gaziantep");
            yeniDizi.Add("İzmir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnMetotlariGoster

            //Bir elemanı teslim alma
            this.Text = (string)yeniDizi[0];

            //Dizinin eleman sayısına ulaşma.
            this.Text = yeniDizi.Count.ToString();

            //Eleman dizide var mı yok mu kontrol etme..
            this.Text = yeniDizi.Contains("Eskişehir") ? "Bu şehir var" : "Bu şehir yok";

            //Dizideki elamanın indexini teslim alma
            this.Text = yeniDizi.IndexOf("İzmir").ToString();
            this.Text = yeniDizi.LastIndexOf("İzmir").ToString();

            //Araya eleman ekleme
            yeniDizi.Insert(3, "Malatya");

            //Verilen elamanı listeden silme
            yeniDizi.Remove("İzmir"); //İlk karşılanı siler, sonrakilere müdahale etmez

            //diziyi sıralama A - Z | 0 - 9
            yeniDizi.Sort();

            //diziyi tersine çevirme
            yeniDizi.Reverse();

            //O anki kapasiteyi, o anki eleman sayısına eşitleme..
            yeniDizi.TrimToSize();

            //Diziyi temizleme
            yeniDizi.Clear();
        }
    }
}
