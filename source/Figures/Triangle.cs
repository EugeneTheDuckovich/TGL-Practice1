using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_source.Figures
{
    internal class Triangle : Figure
    {
        public readonly double Side1;
        public readonly double Side2;
        public readonly double Side3;
        private readonly double SemiSum;

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;  
            Side2 = side2;
            Side3 = side3;
            SemiSum = (side1 + side2 + side3) / 2;
        }

        public override double Area() => Math.Sqrt(SemiSum * (SemiSum - Side1) * (SemiSum - Side2) * (SemiSum - Side3));

        public override double Perimeter() => Side1 + Side2 + Side3;
    }
}
