using static System.Console;
namespace ShapeExample20250219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle defaultCircle = new Circle();
            Circle customCircle = new Circle(7, 3, 5);
            Rectangle defaultRectangle = new Rectangle();
            Rectangle customRectangle = new Rectangle(12, 5, 8, 10);
            WriteLine("Here are your circles:");
            WriteLine(defaultCircle);
            WriteLine(customCircle);
            WriteLine($"The area of the circle is {customCircle.CalculateArea(),0:F2}, and the perimeter is {customCircle.CalculatePerimeter(),0:F2}.");
            WriteLine("Here are your rectangles:");
            WriteLine(defaultRectangle);
            WriteLine(customRectangle);
            WriteLine($"The area of the rectangle is {customRectangle.CalculateArea(),0:F2}, and the perimeter is {customRectangle.CalculatePerimeter(),0:F2}.");

        }
    }
}
