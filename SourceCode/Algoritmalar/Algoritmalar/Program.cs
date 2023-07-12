using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan kaç adet fibonacci sayı dizisini göstermek istediğini sorgulayan ve yazan algoritma

            // 0 1 1 2 3 5 8 13 21...n

            Console.WriteLine("Bir sayı girin : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;
            Console.Write(a + "  " + b);

            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                Console.Write(" " + c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
