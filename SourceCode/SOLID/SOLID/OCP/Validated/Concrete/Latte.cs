using SOLID.OCP.Validated.Abstract;

namespace SOLID.OCP.Validated.Concrete
{
    public class Latte : GoodCoffee
    {
        public override double GetTotalPrice(double amount) => amount * 4.5;
    }
}
