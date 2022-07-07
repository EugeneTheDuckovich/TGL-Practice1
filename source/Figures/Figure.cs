using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_source.Figures
{
    internal abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"Area = {Area()}, Perimeter = {Perimeter()}";
        }
    }
}
