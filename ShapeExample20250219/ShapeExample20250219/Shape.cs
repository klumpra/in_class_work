using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExample20250219
{
    internal abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Shape()
        {
            X = 0;
            Y = 0;
        }
        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual string GetType()
        {
            return "shape";
        }
        public override string ToString()
        {
            return $"{GetType()} {X,0:F2} {Y,0:F2}";
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

    }
}
