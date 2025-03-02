using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    internal abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        protected Shape() { }
        protected Shape(double x, double y) { X = x; Y = y; }

        public abstract string GetType();
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
