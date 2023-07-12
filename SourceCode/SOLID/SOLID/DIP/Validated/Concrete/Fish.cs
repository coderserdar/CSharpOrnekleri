using SOLID.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Validated.Concrete
{
    class Fish : IProduct
    {
        public string GetCookingInstructions() => "Fırında iyi gider";
    }
}
