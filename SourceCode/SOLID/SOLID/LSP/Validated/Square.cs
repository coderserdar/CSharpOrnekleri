using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Validated
{
    public class Square : Shape
    {
        public Square()
        {

        }
        public Square(int width)
        {
            Width = width;
        }
        public int Width { get; set; }

        public override double CalculateArea() => Width * Width;
    }
}