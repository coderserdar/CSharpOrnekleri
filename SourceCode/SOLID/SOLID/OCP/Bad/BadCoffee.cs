using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Bad
{
    public enum CoffeType
    {
        Latte, Espresso, Macchiato
    }
    public class BadCoffee
    {
        public double GetTotalPrice(double amount, CoffeType coffeType)
        {
            //Burada daha fazla kahve çeşidi eklenirse, kodumuda bir tane daha if-else/switch-case eklememiz gerekecek. 
            //Burada source koda müdahele etmek de open/closed prensibini ihlal etmektir.
            double totalPrice = 0;
            switch (coffeType)
            {
                case CoffeType.Latte: totalPrice = amount * 4.5;
                    break;
                case CoffeType.Espresso: totalPrice = amount * 5.5;
                    break;
                case CoffeType.Macchiato:totalPrice = amount * 6.5;
                    break;
            }

            return totalPrice;
        }
    }
}
