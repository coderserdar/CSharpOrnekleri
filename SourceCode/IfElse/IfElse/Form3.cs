using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form3 : Form
    {
        Random karmasikSayiUretici;
        public Form3()
        {
            InitializeComponent();
            //
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //Formun ilk açılış anında 8 haneli rastgele bir sayı lblRastgeleKarekterlere adlı label'a yazdırılacak ve kullanıcadan butona basıldığı anda textbox'taki yazıyla label'daki yazının karşılaştırılması yapılacak. Eğer karşılaştırma olumsuz ise lblKalanHakkimiz'daki değer bir azaltılacak.
            //Eğer kullanıcı 5 defa hatalı giris yaparsa button'un aktiflik özelliği kapatılacak.
            //Her hatalı girişte yeni bir rastgele sayı türetilmelidir.
            if (txtGiris.Text == lblRastgeleKarakterler.Text)
                MessageBox.Show("Doğru giriş yaptınız!!");
            else
            {
                int kalanHak = Convert.ToInt32(lblKalanHak.Text);
                kalanHak--;
                lblKalanHak.Text = kalanHak.ToString();
                if (kalanHak != 0)
                {
                    lblRastgeleKarakterler.Text = karmasikSayiUretici.Next(100000000, 1000000000).ToString();
                }
                else
                {
                    btnGirisYap.Enabled = false;
                    MessageBox.Show("Sistem bloke edildi");
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Size rastgele olarak sayı üretmekle görevli olan bir nesnemiz vardır, Bu nesnenin/sınıfın adı Random.
            karmasikSayiUretici = new Random();
            //karmasikSayiUretici.Next(minDeger, MaxDeger) => sizden iki adet parametre ister. Oluşturulacak olan sayı en az kaç olsun, en fazla kaç olsun gibi.. (sadece maxValue yazabileğiniz bir overload'u olduğunu da unutmayalım!!)
            //NOT: Her zaman verdiğiniz maksimum değerin bir eksiğine kadar rastgele değer üretebilir.
            lblRastgeleKarakterler.Text = karmasikSayiUretici.Next(100000000, 1000000000).ToString();
        }

        private void txtGiris_MouseHover(object sender, EventArgs e)
        {
            txtGiris.BackColor = Color.Aqua;
            txtGiris.ForeColor = Color.Red;
        }
    }
}
