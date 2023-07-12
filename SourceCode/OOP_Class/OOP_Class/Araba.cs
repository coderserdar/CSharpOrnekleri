using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class
{
    // Constructor - Yapıcı/Kurucu Metotlar
    // Yapıcı metotlardan kısaca bahsedersek, statik olmayan bir sınıf içeriisindeki propertylere sınıfın instance alımı esnasında değerler verme işlemidir. Bu metotlar tıpkı void metodu gibi çalışır ve geriye herhangi bir tipte değer döndürmezler ancak bu metodun bir adı da olmaz çünkü yapıcı metotlar sınıfın birebir kendi adıyla yazılmak zorundadırlar.
    class Araba
    {
        //1 - Class'a nesi vardır sorusu size Property'lerini teslim eder.
        //2- Bu Class ne yapar sorusu size cevap olarak bu classın metodlarını teslim eder.

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Motor { get; set; }

        //Constructor Tanımlama:

        //Property'lere bu şekilde daha önceki C# derslerimizde değer vermeyi tanımlamıştırk, şimdi tekrar bilgisayar classına geri dönelim ve constructor metot yazalım. Hatırlarsanız ctor metotlar içinde bulunduğu sınıfın adını alır demiştik ve bu metotların parametreleride olabilir.
        //Constructor metotları parametreleri, içinde bulunduğun sınıfın hangi prop'larına değerler atamak istiyorsak o şekilde yazılırlar ve varsayılan larak sınıfımızdaki propertl'lere yapıcı metomuz üzerinden değerler vereceğiz
        
        public Araba(string marka, string model, int motor)
        {
            Marka = marka;
            Model = model;
            Motor = motor;
        }

    }
}
