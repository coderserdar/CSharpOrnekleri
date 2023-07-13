using SOLID.OCP.Validated.Abstract;

namespace SOLID.OCP.Validated.Concrete
{
    class Frappichino:GoodCoffee
    {
        public override double GetTotalPrice(double amount) => amount * 7.5;
    }
}
