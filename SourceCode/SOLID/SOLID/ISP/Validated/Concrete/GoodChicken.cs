using SOLID.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Validated.Concrete
{
    class GoodChicken : IYuruyebilenler
    {
        public string Walk() => "Bu Tavuk Koşar";
    }
}
