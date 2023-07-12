using SOLID.OCP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Validated.Concrete
{
    public class Macchiato : GoodCoffee
    {
        public override double GetTotalPrice(double amount) => amount * 4.5;
    }
}
