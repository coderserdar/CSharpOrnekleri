using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForEachLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
            FOREACH
            1) Kesinlikle Index mantığı yoktur.
            2) Tip bağımlı döngülerdir.
            3) Çoğu zaman elimizdeki bir koleksiyonun her bir elemanını tek tek ele almak için kullanılır..
        */
        #endregion

        string[] sehirler = { "Ankara", "İzmir", "İstanbul", "Bursa", "Eskişehir", "Trabzon", "Sivas", "Malatya" };
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            //İlgili dizi içerisindeki her bir elemana geçici olarak "sehir" takma adi verilir ve döngünün ger bir adımında size dizinin her bir elemanı teslim edilir..
            foreach (string sehir in sehirler)
            {
                //sehir diye adlandırdığımız değişken, döngünün devam edebilmesi için yardımcı bir araçdır. Herhangi bir değeri yoktur!! (Foreach Iterator)
                //sehir = "Tanımsız"
                listBox1.Items.Add(sehir);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            //İkiye bölünenleri listBox1'e, bölünmeyenler listBox2'ye atın. Hem ikiye hem üçe bölünenlerin kaç tane olduğunu da mbox ile gösterelim.
            int[] dizi = { 123, 62, 32, 523, 634, 74, 73, 11, 1, 8 , 18, 36};
            int tamBolenHavuzu = 0;
            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0) listBox1.Items.Add(sayi);
                else listBox2.Items.Add(sayi);

                if (sayi % 2 == 0 && sayi % 3 == 0) tamBolenHavuzu++;
            }
            MessageBox.Show("Tam Bölünenler => " + tamBolenHavuzu);
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //listBox1'deki seçili tüm elemanlar(birden fazla seçim şansı olmalı SelectionMode=MultiSimple) listbox2'ye ekleyelim.
            foreach (string eleman in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(eleman)) listBox2.Items.Add(eleman);
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            //Formun üzerindeki tüm butonların arkaplanları ve yazi renklerini değiştirelim.
            foreach (Control control in Controls)
            {
                if(control is Button)
                {
                    control.BackColor = Color.Maroon;
                    control.ForeColor = Color.Orange;
                }
            }
        }
    }
}
