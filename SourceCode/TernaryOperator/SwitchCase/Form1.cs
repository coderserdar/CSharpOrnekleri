using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Açıklamalar
        /*
         *  Switch ~ Case
         *  If-Else mantığıyla çalışan bir kontrol mekanizmasıdır. Aradaki fark, if-else yapısı büyüklük küçüklük gibi durumları kontrol edebilirken,
         *  switch - case yalnızca eşitlik durumlarını kontrol edebilen karar yapımızdır. Kendisine ait bir index mekanizması ile koşulları algılar,
         *  sıraya koyar ve otomatik olarak yüzlerce koşulunuz olsa bile herbirine bakmadan hangisine uyduğunu bulabilir. Bu da performansı direktman etkiler..
         *  Switch - Case bloğu içerisinde veri tipiniz ne ise, case(durum) olarak belittiğini tüm veriler de aynı veri tipinde olmalıdır!!
         *  break => Koşul sağlandı, artık karar yapısından kendini dışarı atabilirsin mesajını sisteme verir.
         */
        #endregion
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            //dışarıdan mevsim girilsin, aylar dönsün
            string mesaj = "";
            switch (txtBirinciDeger.Text)
            {
                case "Kış":
                    mesaj = "Aralık-Ocak-Şubat";
                    break;
                case "İlkbahar":
                    mesaj = "Mart-Nisan-Mayıs";
                    break;
                case "Yaz":
                    mesaj = "Haziran-Temmuz-Ağustos";
                    break;
                case "Sonbahar":
                    mesaj = "Eylül-Ekim-Kasım";
                    break;
                //Default => Öngörülen bir durum harici değerle karşılaşırsak, varsayılan olarak kara yapısı ne gibi bir işlem uygulasın cevabını verir. Tamamen opsiyoneldir. Kullanmasak da olur.
                default:
                    mesaj = "Böyle bir mevsim hiç duymadım!!";
                    break;
            }
            MessageBox.Show(mesaj);
            /*
             case "Aralık":
             case "Ocak":
             case "Şubat":
             mesaj = "kış ayı";
             break;
             */
        }

        private void btnKullaniciGirisi_Click(object sender, EventArgs e)
        {
            //Eğer ilk textbox'a
            //"Admin","Moderatör","yönetici","CEO","Başkan" değerleri girilirse "Yönetim Paneline Yönlendiriyorsunuz.."
            //"Uye" girilirse "Ana sayfaya yönlendiriliyorsunuz..
            //Harici bir durumda "Bu sayfayı görme yetkiniz yok!";
            //Bir string methodu olan ToLower, iligili metnin tamamını küçük harfe çevirmekle yükümlüdür.
            string gelenDeger = txtBirinciDeger.Text.ToLower();
            string mesaj = "";
            switch (gelenDeger)
            {
                case "admin":
                case "moderatör":
                case "yönetici":
                case "ceo":
                case "başkan":
                    mesaj = "Yönetim paneline yönlendiriliyorsunuz";
                    break;
                case "uye": mesaj = "Ana Sayfaya Yönlendiriliyorsunuz.";
                    break;
                default: mesaj = "Bu sayfayı görmeye yetkiniz yok..!";
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresinin kontrol ediniz. Eğer kullanıcı adını ve şifresini doğru girerse "Tebrikler, her ikiside doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru fakat şifreniz yanlış" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile" uyarısını kullanıcıya veriniz.
            // kullaniciAdi = "bilgeadam"
            // sifre = "1234";

            string kullaniciAdi = txtBirinciDeger.Text;
            string sifre = txtIkinciDeger.Text;
            string mesaj = "";
            switch (kullaniciAdi)
            {
                case "bilgeadam":
                    switch (sifre)
                    {
                        case "1234":
                            mesaj = "Tebrikler";
                            break;
                        default: mesaj = "Kullanıcı adı doğru fakat şifren yanlış";
                            break;
                    }
                    break;
                default:
                    mesaj = "kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile..!";
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void btnYedi_Click(object sender, EventArgs e)
        {
            // C#7 ile gelen yeni bir özellikte artık küçüklük-büyüklük, küçük eşit büyük eşit gibi durumlarıda artık kontrol edebiliyoruz.
            //NOT: Visual Studio 2017'de kullanılabiliyor, 2015 kullanılıyor ise örnek çalışmaz.
            int gelenDeger = int.Parse(txtBirinciDeger.Text);
            string mesaj = "";
            switch (gelenDeger)
            {
                case int s when (s > 100):
                    mesaj = "Sayı 100'den büyüktür";
                    break;
                case int s when (s < 100):
                    mesaj = "Sayı 100'den küçüktür";
                    break;
                default:
                    mesaj = "Sayı 100'e eşittir";
                    break;
            }
            MessageBox.Show(mesaj);
        }
    }
}
