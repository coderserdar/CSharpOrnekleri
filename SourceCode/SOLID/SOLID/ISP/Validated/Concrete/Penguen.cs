using SOLID.ISP.Validated.Abstract;

namespace SOLID.ISP.Validated.Concrete
{
    class Penguen : IYuzebilenler, IYuruyebilenler
    {
        public string Swim() => "Bu penguen yüzebilir";

        public string Walk() => "Bu penguen koşar";
    }
}
