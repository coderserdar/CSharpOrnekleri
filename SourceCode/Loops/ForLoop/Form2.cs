using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForLoop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //Aşağıdaki dizide yer alan her bir elemanı, listbox içerisine ekleyelim.
            string[] takimlar = { "Fenerbahçe", "Beşiktaş", "Galatasaray", "Trabzonspor", "Karagümrük" };
            for (int i = 0; i < takimlar.Length; i++)
            {
                listBox1.Items.Add(takimlar[i]);
            }
        }

        private void btnOrnekıki_Click(object sender, EventArgs e)
        {
            //Sayısal bir dizi tanımlayın ve Array sınıfını kullanmadan o dizinin en büyük elemanını gösterin..
            int[] sayisal = { 12, 45, 64, 23, 64, 23, 99, 2132, 27 };
            int enBuyukEleman = 0;
            for (int i = 0; i < sayisal.Length; i++)
            {
                if (enBuyukEleman < sayisal[i])
                    enBuyukEleman = sayisal[i];
            }

            MessageBox.Show("En Büyük Eleman => " + enBuyukEleman);
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //aşağıdaki dizide kaç tane çift kaç tane tek sayı vardır kullanıcıyı bilgilendirelim.
            int[] sayisal = { 12, 45, 64, 23, 64, 23, 99, 2132, 27 };
            int tekSayilar = 0;
            int ciftSayilar = 0;
            for (int i = 0; i < sayisal.Length; i++)
            {
                if (sayisal[i] % 2 == 0)
                    ciftSayilar++;
                else tekSayilar++;
            }
            MessageBox.Show("Bu dizideki tek sayıların adeti => "+ tekSayilar + "\nÇift sayıların adeti => " + ciftSayilar);
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //NOT => String'ler aynı zamanda birer char dizisidir.
            string adim = txtGirisAlani.Text;
            string tersAd = "";
            for (int i = adim.Length - 1; i >= 0; i--)
            {
                tersAd += adim[i];
            }
            MessageBox.Show(tersAd);
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            //Karmaşık 10 adet sayıyı listboxa ekleyelim
            listBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(101));
            }
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //Form üzerinde yer alan tüm butonların arkaplan renklerini lacivert, yazı rengini de sarı yapalım.
            //eğer içerisinde bulunduğunuz formu/class işaret etmek isterseniz kullanağınız keyword "this"'dir.

            for (int i = 0; i < this.Controls.Count; i++)
            {
                //Eğer karar yapılarınızda bir tip kontrolü yapıyorsanız, ==, != gibi oparatörler size cevap vermez. Yapmanız gereken, bu operatörlerin yerine "is" keywordünü kullanmak..
                if (Controls[i] is Button)
                {
                    Controls[i].BackColor = Color.DarkBlue;
                    Controls[i].ForeColor = Color.Yellow;
                }
                else if (Controls[i] is ListBox)
                {
                    Controls[i].BackColor = Color.DarkBlue;
                    Controls[i].ForeColor = Color.Yellow;
                    listBox1.Font = new Font("Tahoma", 13);
                }
            }
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen sayısal ifadenin rakam değerlerinin toplamını gösteriniz. => 123 girilirse 1+2+3=6 sonucu dönmelidir.

            string degerler = "";
            int toplamHavuzu = 0;
            for (int i = 0; i < txtGirisAlani.Text.Length; i++)
            {
                //Char'ı int'e çevirdiğimiz zaman bize ASCII değerini vereceği için, öncelikle onu string'e çevirip daha sonra int'e çevirmek daha doğru olacaktır.
                if (txtGirisAlani.Text.Length - 1 == i )
                {
                    degerler += txtGirisAlani.Text[i] + " = ";
                }
                else
                {
                    degerler += txtGirisAlani.Text[i] + " + ";
                }
                int cevrilenDeger = Convert.ToInt32(txtGirisAlani.Text[i].ToString());
                toplamHavuzu += cevrilenDeger;
            }
            MessageBox.Show($"Girilen Değerler => {degerler} {toplamHavuzu}");
        }
    }
}
