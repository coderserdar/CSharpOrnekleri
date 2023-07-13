namespace SOLID.ISP.Bad
{
    public class Hawk : IBird
    {
        public string Fly() => "Bu şahin uçabilir";

        public string Swim() => "Bu şahin yüzemez";

        public string Walk() => "Bu şahin yüreyibilir.";
    }
}
