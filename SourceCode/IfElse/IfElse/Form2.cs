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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region Mantıksal Opeatörler
        /*
            Mantıksal Operatörler
            
            Birden fazla durumun aynı anda kontrol edilmeis senaryosunda kullanılan operatörlerdir.
            && (ve) (Kontrol bloğu içerisinde yer alan tüm koşulların sağlanması durumunu işaret eder.. Koşullardan biri dahi şartı sağlamazsa bloğunuz harekete geçmez.)
            || (veya) (Kontrol bloğu içerisinde yer alan koşullardan herhangi birinin sağlanması durumuna işaret eder.. Böylece bir koşul bile sağlansa bloğuzda yazdığınız kodlar harekete geçer...)
            Yukarıdaki operatörlere "kısa devre operatörü(shortcut operatör) adı verilir. Koşulları kontrole en soldan başlar, herhangi bir uygunsuzluk durumunda diğer koşullara asla bakmaz.. Aşağıdaki operatörler ise, koşullar uysun yada uymasın hepsine bakar..
            & => ve
            | => veya
        */
        #endregion
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //admin ve 123 girildiğinde sistem açılsın..
            if (txtBirinciDeger.Text.ToLower() == "admin" && txtIkinciDeger.Text == "123")
            {
                MessageBox.Show("Tebrikler, giriş başarılı");
            }
            else
            {
                // İki koşuldan birinin sağlanmaması durumu
                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı");
            }
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 aralığı ise FF
            // 30 - 50 aralığı ise DD
            // 50-70 aralığı ise BB
            // 70 - 100 aralığı ise AA
            // mesajı karar mekanizmalarına göre dolduralım ve en sonda kullanıcıyı bilgilendirelim
                string mesaj = "Girilen not geçersizdir";
            try
            {
                int not = Convert.ToInt32(txtBirinciDeger.Text);
                if (not >= 0 && not <= 29)
                    mesaj = "Harf Notunuz : FF";
                else if (not >= 30 && not <= 49)
                    mesaj = "Harf Notunuz : DD";
                else if (not >= 50 && not <= 69)
                    mesaj = "Harf Notunuz  : BB";
                else if (not >= 70 && not <= 100)
                    mesaj = "Harf Notunuz : AA";
            }
            catch (Exception ex)
            {
                mesaj = "Geçersiz formatta not girişi yaptınız, sistemin mesajı => " + ex.Message;
            }
            MessageBox.Show(mesaj);
        }
        private void btnMarket_Click(object sender, EventArgs e)
        {
            //Dışarıdan ürün adı girilecek, kasiyer bize ürünün hangi reyonda olduğunu söylecek.
            // domates, biber, patlıcan => Sebze Reyonu
            // Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            // Cep telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            // Başka bir ürün girilirse "Bu ürün bizde yok!" uyarısı verilsin

            string urun = txtBirinciDeger.Text.ToLower();
            string mesaj = "";
            if (urun == "domates" || urun == "patlican" || urun == "biber")
                mesaj = "Sebze Reyonu sağ tarafta";
            else if (urun == "diş macunu" || urun == "parfüm" || urun == "şampuan")
                mesaj = "Kozmetik reyonu sol tarafta";
            else if (urun == "cep telefonu" || urun == "bilgisayar" || urun == "ses sistemi")
                mesaj = "Sütlerin arkasında";
            else mesaj = "Bu ürün bizde yok";
            MessageBox.Show(mesaj);
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            //Dışarıdan sipariş alınacak olan kitap miktari girilsin. Sipariş sayısı 20'den az ise toplam ücretten %5, 20 - 50 aralığında ise %10, 50-100 aralığında ise %15, 100'den fazla ise %25 inidirm yapılsın. Kitabın birim fiyatı => 5TL Amaç => Ödenecek tutarı kullanıcıya göstermek

            double birimFiyat = 5;
            double alinanSiparisMiktari = Convert.ToDouble(txtBirinciDeger.Text);
            double toplamOdenecekTutar = 0;

            if (alinanSiparisMiktari > 0 && alinanSiparisMiktari <= 20)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.95;
            }
            else if (alinanSiparisMiktari >= 21 && alinanSiparisMiktari <= 50)
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.90;
            else if (alinanSiparisMiktari >= 51 && alinanSiparisMiktari <= 100)
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.85;
            else if (alinanSiparisMiktari > 100)
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.75;

            MessageBox.Show("Bu kitaplar için ödeyeceğiniz tutar => " + toplamOdenecekTutar.ToString());
        }
    }
}
