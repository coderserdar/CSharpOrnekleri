using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                DEĞİŞKEN NEDİR?

            Değişkenleri en sabit şekilde verilerin depolandığı yerler olarak tanımlayabiliriz. Değişkenlerin içine verilerimizi koyabiliriz veya değişkenlerimizin içindeki verileri C# programındaki işlemlerimiz için kullanabiliriz.

            Değişken Kuralları

            1) Kullanmayacağımız değişkenleri asla tanımlamamalıyız.
            2) Değer aralıklarına göre doğru veri tiplerini seçmeye özen göstermeliyiz... (Değişken Yönetimi = Performans Yönetimi)
            3) Bir değişken adi asla iki kelimeden oluşamaz.. Eğer iki kelimeden oluşacak bir değişkeniniz varsa camelCase olarak yazmalısınız.
            4) Değişken adları asla sayıyla başlamaz, ancak sayıyla bitebilir.
             */

            //SAYISAL VERİ TİPLERİ

            //Değiken Tanımlama Formatı
            //veriTipi degiskenAdi = degiskenDegeri;

            // sbyte => 8 bit
            // MaxValue => 127
            // MinValue => -128;
            sbyte degiskenBir = 24;

            // byte => 8 bit
            // MaxValue => 255
            // MinValue => 0
            byte degiskenıki = 255;

            // short => 16 bit
            // MaxValue => 32767
            // MinValue => -32768;
            short degiskenUc = -23456;

            // ushort => 16 bit
            // MaxValue => 65535
            // MinValue => 0
            ushort degiskenDort = 65456;

            // int => 32 bit
            // MaxValue => 2.147.483.647; 2.1 Milyar
            // MinValue => -2.147.483.648; - 2.1 Milyar
            int degiskenBes = 65456;

            // uint => 32 Bit
            // MaxValue => 4.267.967.295 => 4.2 milyar
            // Min Value => 0
            uint degiskenAlti = 4236549871;

            // long => 64 Bit
            // MaxValue =>  9.2 Katrilyon
            // Min Value => -9.2 Katrilyon
            uint degiskenYedi = 4236549871;


            // ulong => 64 Bit
            // MaxValue => 18.4 Katrilyon
            // Min Value => 0
            uint degiskenSekiz = 4236549871;

            //////////////////// ONDALIKLI VERİ TİPLERİ ///////////////
            ///float => .'dan sonra 7 hane desteği => 32 Bit
            ///
            float ondalikliBir = 1.245F;

            //Double => .'dan sonra 13-14 hane desteği => 64 Bit
            double ondalikliIki = 2.3434343;

            //decimal => .'dan sonra 27-28 hane desteği => 128 Bit
            decimal ondalikliUc = 5.32132145125M;

            // Metinsel Veri Tipleri

            //char => Üzerinde tek karakteri barındırabilen veri tipimizdir..
            char basHarfim = 'B'; // 16 Bit => Unicode Karakter

            //string =>  Üzerinde ansiklopedik verilerden tutun da iki - tek karakterlik verilere kadar tüm metinsel ifadeleri üzerinde barındıran veri tipimizdir.
            string bosMetinn = "";
            string uzunMetin = "Buraya öyle uzun bir metin yazılırdıkii..";

            //  \n => Bir alt satıra geçmek için kullanılır
            string ikiSatirliMetin = "Burası birinci satırım\nBurası da ikinci satırım";
            Console.WriteLine(ikiSatirliMetin);

            // \t => metni bir tab öteye taşır.
            string tabliMetin = "Buraya yazdım.\tBu metin bir tab ötede.";
            Console.WriteLine(tabliMetin);

            //Escape Sequences - Kaçış Karakterleri

            string ciftTirnakliMesaj = "Benim adım \"Barkın\"";
            Console.WriteLine(ciftTirnakliMesaj);

            // MANTIKSAL VERİ TİPİ
            bool bugunTatilMi = false;

            bool kayitVarmi = false;

            bool buyukMu = 10 > 2;

            Console.ReadLine();
        }
    }
}
