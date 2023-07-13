using SOLID.OCP.Validated.Abstract;

namespace SOLID.OCP.Validated.Concrete
{
    class Espresso:GoodCoffee
    {
        public override double GetTotalPrice(double amount) => amount * 5.5;

    }
}
