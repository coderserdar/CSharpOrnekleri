using SOLID.OCP.Validated.Abstract;

namespace SOLID.OCP.Validated.Concrete
{
    public class Macchiato : GoodCoffee
    {
        public override double GetTotalPrice(double amount) => amount * 4.5;
    }
}
