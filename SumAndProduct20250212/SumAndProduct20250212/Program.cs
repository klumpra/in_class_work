namespace SumAndProduct20250212
{
    internal class Program
    {
        static void PrintWelcome()
        {
            Console.WriteLine("Hey. This is fun. Wanna see?");
        }
        static int ComputeSum(params int[] nums)
        {
            int result = 0;   //local variable
            foreach (int num in nums)
            {
                result = result + num;
            }
            return result;
        }
        static int ComputeProd(params int[] nums)
        {
            int result = 1;
            foreach (int num in nums)
            {
                result = result * num;
            }
            return result;
        }
        static void Main(string[] args)
        {
            PrintWelcome();
            int sum, prod;
            sum = ComputeSum(7, 3, 5, 8, 2);
            prod = ComputeProd(1, 5);
            Console.WriteLine($"The sum is {sum}, and the prod is {prod}.");
        }
    }
}
