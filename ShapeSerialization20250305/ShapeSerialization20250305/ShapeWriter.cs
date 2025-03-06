using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    internal class ShapeWriter
    {
        public static void WriteToScreen(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToTabDelimitedString());
            }
        }
        public static bool WriteToFile(string fname, List<Shape> shapes)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fname, false))
                {
                    foreach (Shape shape in shapes)
                    {
                        sw.WriteLine(shape.ToTabDelimitedString());
                    }
                }
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}
