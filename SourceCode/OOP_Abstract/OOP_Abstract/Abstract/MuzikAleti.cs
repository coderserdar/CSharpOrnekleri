using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract.Abstract
{
    //Abstract Class'lar, sadece base class olarak davranmasını (yani inherit edilebilmesi) ve kendisinden Instance çıkartılmamasını istediğimiz durumlarda kullanılır.
    public abstract class MuzikAleti
    {
        //Abstract olarak işaretlenmiş tüm yapılar mutlaka override edilmek zorundadır.

        // Abstract Classların en büyük özelliği, içeriisnde Abstract olan ya da olmayan metodları barındırabilmesidir. Abstract metodlar, kalıtım aldığı classta implement edilerek kullanılacak metotlardır yani tanımlandığı yerlerde herhangi bir kod bloğu bulundurmazlar

        public string Markasi { get; set; }
        public string Aciklamasi { get; set; }

        public abstract string Cal();
    }

    /*
     * Ancak Abstract metotları tanımlarken aşağıdaki kurallara dikkat etmeliyiz.
     * Abstract metodlar, private olarak tanımlanamazlar. Çünkü, private metodlar, miras alınan classlar tarafından implement edilmediklerinden dolayı, abstract yapısına ters düşmektedir.
     * Abstract metodlar sadece Abstract classlar içerisinde tanımlanabilir.
     * Abstract metodlar, virtual olarak tanımlanamazlar. Her abstract class virtualdır. Abstract classın da amacı miras alındığı classta implemente edilmek olduğu için Virtual yazıldığı takdirde hata alınacaktrı.
     * Abstract metodlar, static olarak tanımlanamazlar. Statik kavramı, class özelliği yada metodu olduğu için instance çıkarmaya gerek yoktur. Halbu ki, statik olmayan metotlar instance metodlarıdır.(Static keywordunu görmediğin her öğe bir instance memberdır)
     * Abstract bir classta, abstract olmayan static bir metod tanımlayabiliyorken, miras alındığı classta implemente edilme zorunluluğu olduğundan, abstract metodlar static olarak tanımlanamazlar.
     * Abstract metodların gövdesi olamaz. Çünkü onlar sadece miras alındığı classlarda implement edilebilir
     * Implement => Görevi belli olmayan yapıların görevlerinin tanımlanmasıdır.
     */
}
