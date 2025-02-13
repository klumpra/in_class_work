using static System.Console;
namespace FunWithCircles20250212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter x, y, and radius: ");
            string response = ReadLine();
            string[] parts = response.Split(" ");
            double x, y, rad;
            x = double.Parse(parts[0]);
            y = double.Parse(parts[1]);
            rad = double.Parse(parts[2]);
            Circle c = new Circle(x, y, rad);  // c is a Circle OBJECT
            double area, circumference;
            area = c.CalculateArea();
            circumference = c.CalculatePerim();
            WriteLine("Here is the circle: ");
            WriteLine(c);   // c is represented with its circle-related data thanks to ToString
            WriteLine($"Area = {area,0:F2}, Circumference = {circumference,0:F2}");
        }
    }
}
