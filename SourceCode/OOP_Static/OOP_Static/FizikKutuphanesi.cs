using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{   /*
         STATIC CLASS

        Eğer nesneye bağınmlı işlemler gerçekleştirmiyorsanız - yani amaç sadece belirli bir duruma hizmet eden brden fazla öğeyi bir araya toplamak iste - ilhili sınıfı static olarak işaretleyebilir ve içerisinde tüm öğelere instancedan bağımsız olarak ulaşabilirsiniz.

        Static sınıflar içerisinde yalnızca static öğeler barındırabilirler (field, property, method..)

        Static bir class başka bir classtan kalıtım alamaz!! Ancak .NET framework mantığı gereği, tüm sınıflar System.Object sınıfından kalıtım alırlar. Static sınıflar da bu kalıtım işlemine dahildir..

        Static sınıflara en güzel iki örnek Math ve File sınıflarıdır. Aynı amaca (Math => Matematiksel işlemlerin bir arada tutulması; File => Dosya bazlı işlemler gerçekleştiren birden fazla işlemin bir arada tutulması) hizmet eden öğereleri içerisinde barındıran ve hızlıca ulaşmamızı sağlayan sınıflardır.

        Ancak her sınıf static olarak işaretlenmemelidir. Çünkü tanımlamış olduğunuz her static sınıf size ufak da olsa performans kaybı olarak dönecektir.
    */
    public static class FizikKutuphanesi
    {
        public static decimal YerCekimiKuvveti { get => 9.80665M; }

        //const => Sabit değer... Kendiliğinden static olma sahip olma özelliğine sahiptir, dolasıyla static olarak işaretlenemez;
        public const int KaldirmaKuvveti = 12;

        //readonly => Sadece okunabilir değişkenler oluşturmak için kullanılan anahtar kelimedir.
        public static readonly int IndirmeKuvverti = 2;

        public static void Kaldir() { }
    }
}
