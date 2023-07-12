using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Bad
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRectangle rectangle) => rectangle.Height * rectangle.Width;

        public static double CalculateArea(BadSquare square) => square.Height * square.Width;

        //Bu metotları console üzerinde test edelim.
    }
}
