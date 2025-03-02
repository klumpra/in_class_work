using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    internal class Rectangle: Shape
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

    }
}
