using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSerialization20250305
{
    internal class ShapeReader
    {
        public static List<Shape> ReadFromFile(string fname, ShapeFactory factory)
        {
            try
            {
                List<Shape> result = new List<Shape>();
                string line;
                using (StreamReader sr = new StreamReader(fname))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (line.Length > 0)
                        {
                            result.Add(factory.BuildShape(line));
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
