using System;
using System.Windows.Forms;

namespace ForLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Dongüler - Loops
        /*
            Bir başlangıç değeri olan, belirli bir koşul gerçekleşene dek süren ve bu süreç içerisinde bir takım işlemleri tekrarlı olarak gerçekleştiren nesnereler "dongu" adını vermeyteyiz.

            FOR - FOREACH - WHILE - DO WHILE
         */
        #endregion
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Dongüye ilk giriş anında derleyici başlangıç değerine bakar ve bir daha asla bu bloğa uğramaz.
            //Bundan sonraki işlemler önce arttır, daha sonra koşula bak, koşul uygunsa döngünün kod bloğunu harekete geçir, uygun değilse döngüden çık.

            //for(baslangicDegeri; bitisKosulu; artis-azalisMiktari)
            for (int deger = 1; deger <= 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }
        }

        private void btnOrnekıki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int deger = 1000; deger >= 1; deger--)
            {
                listBox1.Items.Add(deger);
            }
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 2; i <= 1000; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Char'lar arkaplanda ASCII değerler barındırırlar..  Char'ları Int32'ye çevirirseniz size ASCII değerlerini teslim ederler.
            // A - 65
            // B - 66
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add($"{c} - {Convert.ToInt32(c)}");
            }
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            // 1 - 100 arasındaki toplamını ekrana yazdıralım.
            int toplam = 0;
            for (int i = 0; i < 101; i++)
            {
                toplam += i;
            }
            MessageBox.Show("Toplam => " + toplam);
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki çift sayıların toplamı ile, tek sayıların toplamının farklarının karesi kaçtır?
            int ciftlerinToplami = 0;
            int teklerinToplami = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) ciftlerinToplami += i;
                else teklerinToplami += i;
            }

            int sonuc = (ciftlerinToplami + teklerinToplami) * (ciftlerinToplami + teklerinToplami);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //1945 - günümüz yılı arasındaki yılları ListBox'a eklensin ancak 1990 ve 1992 yılları eklenmesin.

            for (int i = 1945; i <= DateTime.Now.Year; i++)
            {
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }
            }

        }
    }
}
