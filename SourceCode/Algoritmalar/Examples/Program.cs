using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            //Dışarıdan alınan iki sayının toplamıyla farkının birbirine bölümünden kalanın sonucu kaçtır?(Farkın toplama bölümünden kalan kaçtır?
            //Console.WriteLine("1. Sayıyı Giriniz : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı Giriniz : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = sayi1 + sayi2;
            //int fark = sayi1 - sayi2;

            //int bolumundenKalan = toplam % fark;

            //Console.WriteLine("İşlemin Sonucu => " + bolumundenKalan);
            #endregion
            #region Örnek 2
            //Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2ye bölümünden kalanın karesi kaçtır?
            //Console.WriteLine("Lütfen bir sayı giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sonuc = (sayi - 10 + 20) % 2;
            //int karesi = sonuc * sonuc;
            //Console.WriteLine("İşlem Sonucu => " + karesi);
            #endregion
            #region Örnek 3
            //Dışarıdan girilen iki sayının karelerinin toplamı ile karelerinin farkı toplamı kaçtır?
            //Console.WriteLine("Lütfen birinci sayı giriniz : ");
            //double sayi1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayı giriniz : ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //double birinciKare = sayi1 * sayi1;
            //double ikinciKare = sayi2 * sayi2;

            //double fark = birinciKare - ikinciKare;
            //double toplam = ikinciKare + birinciKare;

            //double sonuc = toplam + fark;
            //Console.WriteLine(sonuc);

            #endregion
            #region Örnek 4
            //Vize notunun %30'u, Final notunun %70'ini alıp öğrencinin not ortalamasını çıkartan bir uygulama(sonuç ondalıklı olabilir!!)
            //Console.WriteLine("Vize notu => ");
            //double vize = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Final notu => ");
            //double final = double.Parse(Console.ReadLine());

            //double sonuc = (vize * 0.30) + (final * 0.70);

            //Console.WriteLine($"Ortalama notunuz => {sonuc}" );
            #endregion
            #region Örnek 5
            //Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alınız ve adi.soyadi@ziraatteknoloji.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.
            Console.WriteLine("isim => ");
            string isim = Console.ReadLine();
            Console.WriteLine("soyisim => ");
            string soyIsim = Console.ReadLine();
            string mail = isim + "." + soyIsim + "@ziraatteknoloji.com";
            Console.WriteLine(mail);

            Console.WriteLine($"{isim}.{soyIsim}@ziraatteknoloji.com");
            Console.WriteLine(string.Format("{0}.{1}@ziraatteknoloji.com",isim,soyIsim));
            
            #endregion
            /*
                Bir veri tipindeki değişkeni, diğer bir veri tipine çevirmek için ihtiyacımız olan yardımcı bir sınıf vardır. Bu sınıf "Convert" sınıfıdır.
                Burada bir istisnadan bahsetmekte fayda var, Dış dünyaya gösterilecek olan ne varsa, bu değerler mutlak suretle metinsel - string veri tipi - olmalıdır. Dolayısıyla bir değeri stringe çevirmekinin .NET bize kolaylık sunmuştur => ToString()
                unutulmamsı gerek bir husus, veriyi string'e çevirdiğimiz anda, üzerindeki matematiksel fonksiyonları kaybeder!!!

                byte cevrilecekBir = Convert.ToByte(cevrilecekDeger)
                short cevrilecekBir = Convert.ToInt16(cevrilecekDeger)
                long cevrilecekBir = Convert.ToInt64(cevrilecekDeger)
                float cevrilecekBir = Convert.ToSingle(cevrilecekDeger)
                
            Convert sınıfı bizim her tipteki veriyi, istediğimiz bir tipe olanak sağlar, eğer benim çevireceğim daha bir string ise o zaman veri tiplerinin tanımlandığı struct'lar içerisinde ki parse methodlarını kullanabilirim.
             */
            Console.ReadLine();

        }
    }
}
