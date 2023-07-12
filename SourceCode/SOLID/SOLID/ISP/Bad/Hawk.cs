using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Bad
{
    public class Hawk : IBird
    {
        public string Fly() => "Bu şahin uçabilir";

        public string Swim() => "Bu şahin yüzemez";

        public string Walk() => "Bu şahin yüreyibilir.";
    }
}
