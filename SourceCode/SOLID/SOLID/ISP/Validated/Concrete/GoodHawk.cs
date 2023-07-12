using SOLID.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Validated.Concrete
{
    public class GoodHawk : IUcabilenler, IYuruyebilenler
    {
        public string Fly() => "Bu şahin yürür";
        public string Walk() => "Bu şahin uçar";
    }
}
