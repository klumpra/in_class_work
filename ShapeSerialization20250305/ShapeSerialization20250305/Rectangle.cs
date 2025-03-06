using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    [Serializable]
    public class Rectangle: Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle() { }
        public Rectangle(double x, double y, double length, double width) : base(x, y)
        {
            Length = length;
            Width = width;
        }
        public override string GetType() => "Rectangle";
        public override double CalculateArea() => Width * Length;
        public override double CalculatePerimeter() => 2 * (Length + Width);

        public override string ToTabDelimitedString()
        {
            return $"{base.ToTabDelimitedString()}\t{Length,0:F3}\t{Width,0:F3}";
        }
        public override Shape CreateShape(string desc)
        {
            string[] parts = desc.Split("\t");
            double x = double.Parse(parts[1]);
            double y = double.Parse(parts[2]);
            double length = double.Parse(parts[3]);
            double width = double.Parse(parts[4]);
            return new Rectangle(x, y, length, width);
        }
    }
}
