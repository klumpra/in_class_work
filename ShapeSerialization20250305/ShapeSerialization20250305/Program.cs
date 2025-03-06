using System.Xml.Serialization;
using static System.Console;
namespace ShapeSerialization20250305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization", true);
            Circle c = new Circle(7, 3, 4);
            Rectangle r = new Rectangle(4, 5, 1, 9);
            List<Shape> shapes = new List<Shape>() { c, r }; // initializer list syntax
            ShapeWriter.WriteToScreen(shapes);
            string fname = @"c:\temp\shapes.txt";  // @ suppresses interpretation of \ sequences
            if (ShapeWriter.WriteToFile(fname,shapes))
            {
                Console.WriteLine("The shapes were written to a text file.");
            } else
            {
                Console.WriteLine("The shapes could not be written.");
            }
            WriteLine("Now going to read that file...");
            ShapeFactory sf = new ShapeFactory();
            List<Shape> readFromFile = ShapeReader.ReadFromFile(fname, sf);
            if (readFromFile != null)
            {
                ShapeWriter.WriteToScreen(readFromFile);
            } else
            {
                WriteLine("Could not read the shapes.");
            }
            WriteLine("Now going to write in binary ...");
            string binFileName = @"c:\temp\shapes.bin";
            DataSerializer ds = new DataSerializer();
            ds.SerializeBinary(shapes, binFileName);
            WriteLine("Now read back from binary ...");
            List<Shape> readFromBinary = ds.DeserializeBinary(binFileName) as List<Shape>;
            ShapeWriter.WriteToScreen(readFromBinary);
            WriteLine("Now write in Xml and read back ...");
            string xmlFileName = @"c:\temp\shapes.xml";
            ds.SerializeXml<List<Shape>>(shapes, xmlFileName);
            List<Shape> readFromXml = ds.DeserializeXml<List<Shape>>(xmlFileName);
            ShapeWriter.WriteToScreen(readFromXml);
            WriteLine("Now write and read in Json...");
            string jsonFileName = @"c:\temp\shapes.json";
            ds.SerializeJson<List<Shape>>(shapes, jsonFileName);
            List<Shape> jsonShapes = ds.DeserializeJson<List<Shape>>(jsonFileName);
            ShapeWriter.WriteToScreen(jsonShapes);
        }
    }
}