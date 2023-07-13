namespace SOLID.LSP.Bad
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRectangle rectangle) => rectangle.Height * rectangle.Width;

        public static double CalculateArea(BadSquare square) => square.Height * square.Width;

        //Bu metotları console üzerinde test edelim.
    }
}
