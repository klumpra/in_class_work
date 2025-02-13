using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FunWithCircles20250212
{
    internal class Circle
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)  // value is a reserved word
                {
                    radius = 0;
                }
                else
                {
                    radius = value;
                }
            }
        }
        public double X { get; set; }
        public double Y { get; set; }

        //default constructor
        public Circle()
        {  // in constructors, use the names of your properties
            X = 0;
            Y = 0;
            Radius = 0;
        }

        //non-default constructor
        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double CalculatePerim()
        {
            return 2 * Math.PI * Radius;
        }
        // add a ToString function to represent a circle object as a string
        public override string ToString()
        {
            return $"{X,0:F2}\t{Y,0:F2}\t{Radius,0:F2}";
        }
    }
}
