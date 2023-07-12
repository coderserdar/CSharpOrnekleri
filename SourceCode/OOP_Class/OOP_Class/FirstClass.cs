using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class
{
    //CLASS: Bir veri tipimi modellemek için kullandığımız yapılara sınıf/class denir. Bir sınıf, kapsüllenmiş verileri, bu veriler üzerinde işlem yapacak metotları ve bu verilere ait özellikleri içerebilir. Beni gerçek hayattaki nesnelerimi şablon halinde tutabilen yapılardır.
    class FirstClass
    {
        public FirstClass()
        {

        }

        //Field: C#'ta alanlar, bir sınıf ya da bir sınıf örneği ile ilişkilendirilmiş değişkenlerdir. İçerisinde değer saklamak amacıyla kullanılırlar.
        //1. -> Bu şekilde field tanımlanırsa otomatikman private olarak atanır.

        //Eğer ben bir class'a erişim belirteci (Access Modifiers) belirtmezsen varsayılan olarak INTERNAL gelir.

        //-Internal: Bulunduğu assembly'nin(DLL veya EXE dosyası) içinde erişime açık olan yapıdır. DLL veya exe dosyasının içeriisnde erişim için kısıtlama yoktur, ama dışarıdan erişilemez.
        //aynı zamanda class seviyesinde tanımlanan öğeler de (değişken, metot gibi) yine varsayılan olarak private erişim belirleyici ile tanımlanırlar.

        //private => Bir değerin private olarak tanımlanması demek, o değişkene sadece kendi class'ı içerisinden ulaşılabileceği anlamına gelmektedir. Program içinde kesinlikle değiştirilmemesi gereken, kritik kodlarda kullanılmaktadır.

        //int Id;
        //string Isim;
        //string Soyisim;

        //public -> Bir değerin public olarak belirtilmesi; o değerin, kod içinde herhangi bir yerden erişilebilir durumda olmasını sağlamaktır. Public erişim belirleyici tipinde hiç bir kısıtlama yoktur..!

        //2.
        public int Id;
        public string Isim;
        public string Soyisim;
        public int Boy;
        public int Kilo;

        //3
        int _yas;
        public int Yas 
        {
            get { return _yas; }
            set
            {
                if (value >= 10 && value <= 80) 
                    _yas = value;
                else System.Windows.Forms.MessageBox.Show("Yaş aralığı 10'dan küçük veya 80'den büyük olamaz!!");
            } 
        }

        //Yukarıda yaptığım işlem encapsulation işlemidir.

        //Encapsulation: Nesnenin üyerlerine yapılan erişimin kontrol altına alınmasına ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamaktır. Amaç field'ları private/protected yaparak bu alanlara dışarıdan erişimi önlemek ve get-set metotları ile kontrolü sağlamaktır.

        // Arka plan kodlarını gizleme: Oluşturulan clas siçeriisnd ekullanıcın işlemlerini daha kolay gerçekleştirebilmesi için bazı işlemleri birleştirerek (kapsüllenerek) tek işlem gibi gösterilir. Örneği veritabanına bağlantı işleminde, biz sadece bağlantı değişkeninin Open() methodunu kullanmaktayız.Fakat class içerisinde kullanıcdan aldığı parametreleri kullanarak bağlantıyı gerçekleştirek için birçok metot bulunmaktadır. Bu metodları kullanıcıya gösteripo bağlantıyı sağlayabilmek için bunları şu şekilde birleştirin demek yerine bu işlem sınıfı içerisinde yapılmıiş ve kullanıcın kolaylıkla kullanabilmesi için Open() methodu oluşturulmuştur.

        // Değişkenlere tam erişimi engelleme: Class içerisinde oluşturduğumuz değişkenlere dışarınan erişmek için public olarak tanımlama yapmaktayız. Fakat bazen bu değişkenlerin değerlerini değiştirmek istemeyebiliriz. Fakat kullanmamız da gerekebilir. Bu durumda değişkenimizi kapsüllememiz gerekmektedir. Yani, bu değişkeni private olarak tanımlamak ve bir read-only propert ile bu değişkenin yazma iznini ortadan kaldırmamız demektir
    }
}
