using System;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtGirisAlani.PasswordChar = '*';
        }
        #region Açıklamalar
        /*
            Karar Yapıları
            Uygulamanızın çalışması esnasında farklı senaryolara göre farklı yönlendirmeler yapmanız gerekebilir. Örneğin, kullanıcıdan gelen değerin aralığına göre yönlendirmeler yapabiliriz.
            3 Temel Karar Yapısı Mekanizması Karşımıza Çıkar =>
            IF-ELSE ~ Switch-Case ~ Ternary If
         */
        #endregion
        #region Karşılaştırma Operatörleri
        /*
            Karşılaştırma Operatörleri
            
            1) == (Karşılıklı iki değerin birbirine eşit olması durumu)
            2) != (Karşılıklı iki değerin birbirine eşit olmaması durumu)
            3) < (Soldaki değerin sağdaki değerden küçük olmaması durumu)
            4) > (Soldaki değerin sağdaki değerden büyük olmaması durumu)
            5) <= (Soldaki değerin sağdaki değere eşit veya küçük olmaması durumu)
            6) >= (Soldaki değerin sağdaki değere eşit veya büyük olmaması durumu)
            
         */
        #endregion
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string mesaj = string.Empty;
            //bool adminMi = txtGirisAlani.Text == "Admin";
            //adminMi ? mesaj = "Hoşgeldin Sahip!" : mesaj = "Tanıyamadım..!";
            if (txtGirisAlani.Text == "Admin")
                MessageBox.Show("Hoşgeldin Sahip!");
            else MessageBox.Show("Tanıyamadım");
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            //eğer girilen not 0'dan küçükse "0'dan küçük bir not girişi yapamzsaınız", 100'den bbüyükse "100'den büyük bir not girişi yapamazsınız.." mesajını göstersin.
            int girilenNot = int.Parse(txtGirisAlani.Text);
            if (girilenNot < 0) MessageBox.Show("0'dan küçük bir not girişi yapamzsaınız");
            else if (girilenNot > 100) MessageBox.Show("100'den büyük bir not girişi yapamazsınız");
            else MessageBox.Show("Hatasız Not girişi yaptınız");
        }

        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            basadon:
            //txtGirisAlani'ndan giirlen sayi çiftse ise "Sayı Çifttir" değilse "Sayı Tektir" mesajını kullanıcıya gösteriniz.
            try
            {
                int girilenSayi = int.Parse(txtGirisAlani.Text);
                if (girilenSayi % 2 == 0) MessageBox.Show("Sayı Çifttir");
                else MessageBox.Show("Sayı Tektir");
            }
            catch (Exception)
            {
                MessageBox.Show("Doğru formatta sayı giriniz.");
                //ç.ç.ç....
                goto basadon;
            }
        }

        private void btnDeger_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen kelimenin uzunluğu 8 karaktere eşit yada büyükse kayıt onaylandır, değilse daha uzun bir şifre girinizi..
            if (txtGirisAlani.Text.Length >= 8)
            {
                MessageBox.Show("Kayıt Onaylandı");
            }
            else
                MessageBox.Show("Daha uzun bir şifre giriniz.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
