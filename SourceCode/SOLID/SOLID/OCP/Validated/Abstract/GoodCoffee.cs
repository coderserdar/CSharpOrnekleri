using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Validated.Abstract
{
    public abstract class GoodCoffee
    {
        public abstract double GetTotalPrice(double amount);
    }
}
