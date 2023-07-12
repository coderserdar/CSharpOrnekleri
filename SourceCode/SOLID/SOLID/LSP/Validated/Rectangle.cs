using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Validated
{
    public class Rectangle : Shape
    {
        public Rectangle(int heigth, int width)
        {
            Height = heigth;
            Width = width;
        }
        public int Height { get; set; }
        public int Width { get; set; }
        public override double CalculateArea() => Height * Width;
    }
}
