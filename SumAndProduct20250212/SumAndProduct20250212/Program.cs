namespace SumAndProduct20250212
{
    internal class Program
    {
        static void PrintWelcome()
        {
            Console.WriteLine("Hey. This is fun. Wanna see?");
        }
        static int ComputeSum(int num1, int num2, int num3)
        {
            int result;   //local variable
            result = num1 + num2 + num3;
            return result;
        }
        static int ComputeProd(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        static void Main(string[] args)
        {
            PrintWelcome();
            int num1, num2, num3;
            Random rnd = new Random();
            num1 = rnd.Next(1, 10);
            num2 = rnd.Next(1, 10);
            num3 = rnd.Next(1, 10);
            int sum, prod;
            sum = ComputeSum(num1, num2, num3);
            prod = ComputeProd(num1, num2, num3);
            Console.WriteLine($"The sum is {sum}, and the prod is {prod}.");
        }
    }
}
