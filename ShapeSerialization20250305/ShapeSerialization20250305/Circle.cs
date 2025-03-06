using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    [Serializable]
    public class Circle: Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double x, double y, double radius) : base(x, y) { Radius = radius; }
        public override string GetType() => "Circle";
        public override double CalculateArea() => Math.PI * Radius * Radius;
        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override string ToTabDelimitedString()
        {
            return $"{base.ToTabDelimitedString()}\t{Radius,0:F3}";
        }

        public override Shape CreateShape(string desc)
        {
            string[] parts = desc.Split("\t");
            double x = double.Parse(parts[1]);
            double y = double.Parse(parts[2]);
            double r = double.Parse(parts[3]);
            return new Circle(x, y, r);
        }
    }
}
