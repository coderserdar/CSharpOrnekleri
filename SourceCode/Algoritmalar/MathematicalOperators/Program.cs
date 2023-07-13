using System;

namespace MatmeticalOparetors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematiksel İşlemler");
            Console.WriteLine("------------------");

            #region Toplama İşlemi
            int sayiBir = 102;
            int sayiIki = 25;

            int toplam = sayiBir + sayiIki;

            Console.WriteLine("Toplama işlemi sonucu => " + toplam); //127
            Console.WriteLine("Toplama işlemi sonucu => " + sayiBir + sayiIki);//10225
            Console.WriteLine("Toplama işlemi sonucu => " + (sayiBir + sayiIki)); //127
            #endregion

            Console.WriteLine("----------------------");

            #region Çıkarma İşlemi
            int fark = sayiBir - sayiIki;
            Console.WriteLine("Çıkarma işlemi sonucu => " + fark);
            Console.WriteLine("Çıkarma işlemi sonucu => " + (sayiBir - sayiIki));
            #endregion

            Console.WriteLine("---------------------------");
            #region Çarpma İşlemi
            int carpim = sayiBir * sayiIki;
            Console.WriteLine("Çarpma işlemi sonucu => " + carpim);
            Console.WriteLine("Çarpma işlemi sonucu => " + (sayiIki * sayiBir));
            #endregion

            Console.WriteLine("---------------------------");
            #region Bölme İşlemi
            int bolum = sayiBir / sayiIki;
            Console.WriteLine("Bölme işlemi sonucu => " + bolum);
            Console.WriteLine("Bölme işlemi sonucu => " + (sayiIki / sayiBir));
            #endregion

            #region Mod Alma
            int mod = sayiBir % sayiIki;
            Console.WriteLine("Mod işlemi sonucu => " + mod);
            Console.WriteLine("Mod işlemi sonucu => " + (sayiIki % sayiBir));
            #endregion
            #region Sayıyı Bir Arttırma
            int sayi = 15;
            Console.WriteLine("Sayını ilk değeri => " + sayi);
            sayi = sayi + 1;
            Console.WriteLine("Sayının bir üst değere atanmış hali => " + sayi);
            sayi += 1;
            Console.WriteLine("Sayının bir üst değere atanmış hali => " + sayi);
            sayi++;
            Console.WriteLine("Sayının bir üst değere atanmış hali => " + sayi);
            // ++sayi => Bir sayı artırma yöntemidir fakat işlem önceliğini sayıyı arttırmak olarak algılayıp sonrasında işlemine devam eder.
            #endregion

            #region Sayıyı Bir Azaltma
            int x = 15;
            Console.WriteLine("Sayını ilk değeri => " + x);
            x = x - 1;
            Console.WriteLine("Sayının bir alt değere atanmış hali => " + x);
            x -= 1;
            Console.WriteLine("Sayının bir üst değere atanmış hali => " + x);
            x--;
            Console.WriteLine("Sayının bir üst değere atanmış hali => " + x);
            // -sayi => Bir sayı azaltma yöntemidir fakat işlem önceliğini sayıyı arttırmak olarak algılayıp sonrasında işlemine devam eder.
            #endregion
        }
    }
}
