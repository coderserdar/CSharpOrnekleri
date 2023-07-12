using SOLID.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Validated.Concrete
{
    class Penguen : IYuzebilenler, IYuruyebilenler
    {
        public string Swim() => "Bu penguen yüzebilir";

        public string Walk() => "Bu penguen koşar";
    }
}
