using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_source.Figures
{
    internal class Circle : Figure
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area() => Math.PI * Radius * Radius;

        public override double Perimeter() => 2 * Math.PI * Radius;
    }
}
