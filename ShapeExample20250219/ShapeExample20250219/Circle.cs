using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExample20250219
{
    internal class Circle: Shape
    {
        // we already have X and Y properties
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    radius = 0;
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Circle()
        {
            // automatically calls the default constructor of the parent
            Radius = 0;
        }
        public Circle(double x, double y, double radius):base(x,y)
        {
            Radius = radius;
        }
        public override string GetType()
        {
            return "circle";    
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Radius,0:F2}";
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
