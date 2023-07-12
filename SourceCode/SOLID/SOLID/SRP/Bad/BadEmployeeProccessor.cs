using SOLID.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Bad
{
    class BadEmployeeProccessor
    {
        //Alltaki işlemlere bakarsak, sınıf içerisinde çalışan ekleme kodumuzda birden fazla iş yapıldığını görebilmekteyiz. Hem ekleme, hemde log işlemleri bir arada gitmektedir. Alttaki kod bu nedenle Single Responsibility Prensibimize ters düşmektedir.
        //alttaki yöntemde, loglama ile ilgili bir süreç değiştiğüinde, sınıflara müdahele etmemiz gereklidir.(Farklı bir dosya, farklı yol veya farklı bir loglama çeşidi olabilir.)
        //Bu durumlar projenin genişletilebilir olmasını engeller, hata riskini arttırır.
        // bunun yanında tamamen SRP üzerinden gidersek, console yazma işlemi de bu sınıfta yer almamalıdır. Platform değişiklikleri veya kullanıcın bilgilerinde bilgilendirme işlemlerinde yaşanacak değişiklik aynı şekilde sınıfın çalışmasını bozacaktır.
        public void InsertEmployee(Employee model)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(model.Id);
                sb.AppendLine();
                sb.Append(model.FirstName);
                sb.AppendLine();
                sb.Append(model.LastName);
                sb.AppendLine();
                sb.Append(model.HireDate);

                File.WriteAllText(@"C:\EmployeeData.txt", sb.ToString());

                sb = new StringBuilder();
                sb.Append("Kayıt Eklenme Tarihi :");
                sb.Append(DateTime.Now.ToShortDateString());
                sb.AppendLine();
                sb.Append("Personel ID :");
                sb.Append(model.FirstName).Append(" ").Append(model.LastName);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());

                Console.WriteLine("Çalışan Başarıyla Kaydedildi!");
            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi : ");
                sb.Append(DateTime.Now.ToShortDateString());
                sb.AppendLine();
                sb.Append("Hata Mesajı : ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());

                Console.WriteLine("Hata");
            }
        }
    }
}
