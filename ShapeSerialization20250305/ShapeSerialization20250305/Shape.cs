using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShapeSerialization20250305
{
    [Serializable]
    [XmlInclude(typeof(Circle)),XmlInclude(typeof(Rectangle))]
    [JsonDerivedType(typeof(Circle), "circle")]
    [JsonDerivedType(typeof(Rectangle), "rectangle")]
    public abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        protected Shape() { }
        protected Shape(double x, double y) { X = x; Y = y; }

        public abstract string GetType();
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public virtual string ToTabDelimitedString()
        {
            return $"{GetType()}\t{X,0:F3}\t{Y,0:F3}";
        }
        // desc is tab-delimitd. This will create and return a Shape from it
        public abstract Shape CreateShape(string desc);

    }
}
