using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Açıklamalar

            /*
                HATA / İSTİSNA TİPLERİ

                Çalışma Zamanı Hataları (RunTime Exception) => Çoğunlukla kullanıcı kaynaklı hatalardır. (Verinin yanlış, eksik ya da boş girilmesi). Çözüm yolu, try-catch ile hataları ele alabilirsiniz.

                Derleme Zamanı Hataları(Compile Exception) => Tamamen  yazılımcı kaynaklı hatalardır. Yazım hataları meydana geldiğinde devreye girer. En kolay çözülen hata tipidir. visual Studio sizi uyarır (Error List içerisinde görülür). İlgiyi hataya çift tıklayıp detaya gelebilir ve hatayı anında düzeltebiliriz.

                Mantıksal Hatalar(Logic Exception) => Tamamen programcı kaynaklı hatalardır. Uygulamanın algoritmasında meydana gelir. Örneğin bölme yapılacak yerde işlem unutulması, değerin yanlış bir değerle değiştirilemesi... Çözülmesi en zor hatalardır. Anlık olarak derleme aşamasını takip etmeli ve değerlerinizi gözlemelemelisiniz. Bu konuda Visual Studio size sağladığı tool'lar ile yardımcı olur.(Immediate Window, Watch, BreakPoint)


                BreakPoint => Derleme aşamasına adım adım dahil olmak için kullandığımız yardımcı tooldur. Yapmanız gereken tek şey, hangi satırdan derleme aşamasına dahil olmak istiyorsanız, ilgili satırın en sol kısmına gelip(gri alan) sol click ile break point bırakabilirsiniz. Artık derleyici bu satıra geldiği zaman sizi olaya dahil edecektir.

                F11 ile adım adım izleyebilrirsiniz. Değişkenlerin üzerine gelip o anki değerlerini öğrenebilirsiniz, işlemin bittiğine inanıyorsanız F5'e basıp break pointten çıkabilir ve işlemin kendisini devam ettirmesini sağlayabilirsiniz.

                Sol blokta çıkan sarı ok, derlenen satırının işaretcisidir. Mouse yardımıyla ileri ya da geri oynatabilir yani adımları atlayabilir yada tekrarlatabilirsiniz.

                Watch
                Yalnızca run-time'da  - çalışma zamanı - kullanabileceğimiz bir tool'dur. Dolayısıyla pencereyi sadece çalışma zamanında görürsünüz.
                Ilk ayarlarınızda watch window kapalı olabilşir. Uygulamanızı çalıştırıp "ctrl+alt+w" ardından 1'e basarsınız Wathc pencerisini getirebilirsiniz.
                Run-time'de elinizde olan değerleri (kontrol değerler, değişken değerleri) değiştirmenize, izlemenize olanak sağlayan yardımcı tool'dur. Açılan penceredeki "Name" alanına ilgili değişkenin adını yazıp Enter'a basarsanız, "Value" alanında o anki değerini gözlemleyebilirsiniz. Hatta değiştiredebilirisiniz.
                "Name" alanına değeri ilk girdiğimiz anda intellisense size destek vermez. Ancak ctrl+space kombinasyonu ile intellisense'i aktif hale getirebilirsiniz. Hatta çoğu zaman kendisi otomatik tamamlar.
                Noktalar, virgüller, noktalı virgüller - yani tüm sytanx kuralları watch penceresi için de geçerlidir.

                Eğer dışarıdan bir veri alıyorsanız, verinin tutarlılığından emin de değilseniz, orada mutlaka hata riski vardır.

            */

            // dışarıdan girilen telefon numarası doğru formatta girilmediğinde FormatException hatasını alacağımı öngörüyorum, derlenme sırasında hata almamak için try-catch ile yöetmek istiyorum.
            #endregion

            try
            {
                //Bu alana hata riski olan kodlar yazılır
                Console.WriteLine("Telefon Numarası Giriniz : ");
                int telefon = int.Parse(Console.ReadLine());
                Console.WriteLine("Bravoo!");
            }
            catch (FormatException ex) //format hata tipi
            {
                Console.WriteLine("Telefon numarası girmeyi bile beceremedin.");
            }
            catch (DivideByZeroException ex) // sıfıra bölme hata tipi
            {
                Console.WriteLine("Sıfıra bölme hatası, sistemin mesajı => " +ex.Message);
            }
            catch(OverflowException ex)//veri tipinin boyutunu aşması durumunda alınan hata tipi
            {
                Console.WriteLine("Veri Boyutunu aştın, sistemin mesajı => " + ex.Message);
            }
            catch (Exception ex)//Exception sınıfı tanımlı olan hatalar haricinde bir hata ile karşılaşırsa ise, bu alandaki hata bloğu çalışacaktır.
            {
                // Try bloğu içerisine yazmış olduğunuz kodlarda herhangi bir hata meydana gelirse, catch bloğu devreye girer.
                //catch ifadesinin yanındaki "Exception"ın kelime anlamı istisnadır..
                //uygulamanızız kararlılığını bozan istisnai durumla ilgi size detayları teslim eder.
                Console.WriteLine("Öngörülemeyen bir hata ile karşılaşıldı\nSistem Mesajı => " + ex.Message);//Ex'in sistem tarafından atanan mesajını size teslim eder.
            }
            finally
            {
                // Hata olsa da olmasa da çalışması istediğiniz kodları yazdığınız alandır. Try-Catch-Finally üçlüsünde en son çalışır.
                Console.WriteLine("hata var mı yok mu bilmiyorum ama çalıştım");
            }

            Console.ReadLine();
        }
    }
}
