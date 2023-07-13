using SOLID.ISP.Validated.Abstract;

namespace SOLID.ISP.Validated.Concrete
{
    public class GoodHawk : IUcabilenler, IYuruyebilenler
    {
        public string Fly() => "Bu şahin yürür";
        public string Walk() => "Bu şahin uçar";
    }
}
