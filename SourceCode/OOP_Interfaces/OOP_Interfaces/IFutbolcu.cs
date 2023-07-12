using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interfaces
{
    #region Açıklamalar
    /*
        Interfaceler, class veya struct gibi türler için oluşturulmuş modellerdir.
        Interfaceler bir sınıfın temelde hangi üyelerden oluşacağını belirleyen şablon yapılardır.
        Bu sayede, oluşturulacak sınıflara öncülük edilie ve içermeleri gerekn üyelerin ne olacağının standartı belirlenir. 
        Kullanılması zorunlu olan metotlar fakat metot içerikleri doldurulmaz. 
        Simülasyon metot olarak hazırladıktan sonra, yetenek olarak kazandırıldıları Class'a bu metotlar implement edilir.
        Metot içerikleri class içerisinde doldurulur.
        -----------------------------------------------
        * Interfaceler kesinlikle bir class değildir.!!!
        * Bir interface'in içeriisnde herhangi bir öğenin alabileceği min. erişim belirteci publictir(.NET Framework için geçerlidir, .NET Core'da erişim belirteçleri alabilir.
        * Bir interface içerisindeki öğeye açıkça erişim belirteci yazılmaz!! İçlerindeki öğeler varsayılan olarak her zaman public'tir. (.NET Framework)
        * Bir class sadece bir class'tan miras alabilirken, isteidği kadar interfaceden miras alabilir.
        * Interfaceler sınıflardan miras alamaz. Ama birbirlerinden alabilirler.
        * Interfacelerim miras verildikleri yerde implement edilmeleri zorunludur.
        * Interfaceler içlerinde field barındıramaz (.NET Framework)
        * Interfacelerin instance'ı alınamaz.
        * Interfacelerin constructor'ı yoktur.
        * Interfaceler dikkatli kullanılmadıkları takdirde size sunduğu tüm avantajları dezavantaja çevirirler(OOP prensiplerini bozar)
        
        --------------------    Interface ve Abstract Class Arasındaki Farklar    --------------------------
        
         * Abstract Class'lar bir classtır. Dolayısıyla Classın bütün kurallarına uymak zorundadır.
         * Bir class (abstract olsun/olmasın) sadece bir class'tan miras alabilir.
         * Interface'ler içlerinde field barındıramazlar(.net framework)
         * Abstract class ile Interface arasındaki fark, abstract bir classın sonuşta bir class olduğu için içerisinde yaşam alanı bulundurabilen öğeleri barındırmasıdır.
         * Abstarct bir class olduğu için içerisinde abstract öğelerde barındırabilir ancak normal öğerler barındırıması da her zaman mümkündür. Interface'lerde bu mümkün değilidr ve asbtract class'lar multiInheritance desteklemez.
    */
    #endregion
    public interface IFutbolcu
    {
        string AdiSoyadi { get; set; }
        string FormaNumarasi { get; set; }
        byte SutGucu { get; set; }
        byte Refleks { get; set; }
        byte Agresiflik { get; set; }
        byte Boyu { get; set; }
        bool MilliMi { get; set; }

        void SutCek();
        void TopKurtar();
    }
}
