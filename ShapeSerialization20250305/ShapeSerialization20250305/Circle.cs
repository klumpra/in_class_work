using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    internal class Circle: Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double x, double y, double radius) : base(x, y) { Radius = radius; }
        public override string GetType() => "Circle";
        public override double CalculateArea() => Math.PI * Radius * Radius;
        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

    }
}
