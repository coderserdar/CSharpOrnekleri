using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Bad
{
    public class Chicken : IBird
    {
        public string Fly() => "Bu tavuk uçamaz";

        public string Swim() => "Bu tavuk yüzemez";

        public string Walk() => "Bu tavuk yüreyibilir.";
    }
}
