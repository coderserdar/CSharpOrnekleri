using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Bad
{
    public interface IBird
    {
        string Fly();
        string Walk();
        string Swim();
    }
}
