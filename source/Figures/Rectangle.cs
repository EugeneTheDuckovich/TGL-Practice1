using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_source.Figures
{
    internal class Rectangle : Figure
    {
        public readonly double Height;
        public readonly double Width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area() => Height * Width;

        public override double Perimeter() => 2 * (Width + Height);
    }
}
