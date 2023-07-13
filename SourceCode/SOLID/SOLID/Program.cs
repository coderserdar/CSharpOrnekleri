using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID Prensipleri => Solid, beş öenmli OOP prensiplerinin kısaltılmaıdır.
            //Temiz, modüler ve genişletilebilir kod yazımında önemli kuralları tanımlar.
            //Aynı zamanda Agile/Adaptive yaızlım geliştirme için gereklidir.
            //--------- SRP
            //Bir class/method sadece bir işi yapıyor olmalı.
            //BadEmployeeProccessor emp = new BadEmployeeProccessor();
            //emp.InsertEmployee(new SRP.Model.Employee
            //{
            //    FirstName = "Barkın",
            //    LastName = "Bayzin",
            //    HireDate = DateTime.Now.AddYears(-1),
            //    Id = 1
            //});

            //GoodEmployeeProcessor goodEmp = new GoodEmployeeProcessor();

            //Console.WriteLine(
            //goodEmp.InsertEmployee(new SRP.Model.Employee
            //{
            //    FirstName = "Barkın",
            //    LastName = "Bayzin",
            //    HireDate = DateTime.Now.AddYears(-1),
            //    Id = 1
            //}) ? "Başarılı!" : "Başarısız");

            //---------------------- OCP
            //sınıflar ve metotlar genişletmeye açık, değişikliğe kapalı olmalıdır.
            //Her ihtiyaç değiştiğinde, yazdığımız kodu değiştirmek zorunda kalmamak, işlerimizi uzun vadede çok kolaylaştıracaktır.

            //GoodCoffee latte = new Latte();
            //GoodCoffee macchiato = new Macchiato();
            //GoodCoffee esspresso = new Espresso();
            //GoodCoffee frappechino = new Frappichino();

            //double price = 0;
            //price += latte.GetTotalPrice(20);
            //price += macchiato.GetTotalPrice(20);
            //price += esspresso.GetTotalPrice(20);
            //price += frappechino.GetTotalPrice(10);

            //Console.WriteLine("Kahvelerin toplam fiyatı => " + price);

            //---------------------------------------------
            // LSP => Liskov Substution Principle
            //Bir sınıftan türetilen sınıflar, base sınıfın yerine de kullanılabilmelidir.
            //Bu örnek için Square ve Rectangle sınıflarına bakıyoruz.
            //AreaCalculator sınıfı üzerinden alan hesaplama testi yapalım

            //BadRectangle rectangle = new BadRectangle();
            //rectangle.Width = 2;
            //rectangle.Height = 3;

            //İstenirse, bu noktada Assertipon için Unit Test örneği de yapılabilir.

            //if (BadAreaCalculator.CalculateArea(rectangle) != 6)
            //    Console.WriteLine("Dörtgen alan hesaplamasında hatalı işlem.");

            //Square için deniyoruz.
            //BadSquare kare = new BadSquare();
            //kare.Height = 3;

            //if(BadAreaCalculator.CalculateArea(kare) != 9)
            //    Console.WriteLine("Kare alan hesaplama işlemi hatalıdır.");

            //Üstteki testlerde bir hata alınmayacaktır. Şimdi yerlerini değiştirelim.
            //BadRectangle badRectangle = new BadSquare();
            //badRectangle.Height = 4;
            //badRectangle.Width = 6;
            //if (BadAreaCalculator.CalculateArea(badRectangle) != 24)
            //    Console.WriteLine("Hata!");
            //Üstteki kod hata verecektir.
            //Validated klasöründe oluşturduğumuz sınıflarımızla tekrar deniyoruz.

            //Rectangle rectangle = new Rectangle
            //(
            //    2, 3
            //);
            //if (rectangle.CalculateArea() != 6)
            //    Console.WriteLine("Dörtgen alan hesaplamasında hatalı işlem.");

            //Square square = new Square
            //{
            //    Width = 4
            //};
            //if (square.CalculateArea() != 16)
            //    Console.WriteLine("Kare alan hesaplamasında hatalı işlem.");

            //Shape rec = new Rectangle(2,3);
            //if (rec.CalculateArea() != 6)
            //    Console.WriteLine("Dörtgen alan hesaplamasında hatalı işlem.");
            //LSP'ye uygunluk tam olarak sınfılardan beklenen davranışları karşılayabilecek bir hiyerarşik düzeni oluşturarak sınıf yapılarımızı geliştirmektir.
            //-----------------

            //ISP => Interface Segragation Principle
            //Sınıflar ihtiyaçları olmayan özellik ve davranışları içeren interfaceleri almamalıdır.


            Console.ReadLine();
        }
    }
}
