/* use a for loop to sum up all the number up to the number entered by the user. */
using static System.Console;
namespace SumTheNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cap;
            Write("Enter the number you want to sum up to ...");
            cap = int.Parse(ReadLine());
            int sum = 0;
            for (int i = 1; i <= cap; i++)
            {
                sum = sum + i;
            }
            WriteLine($"The sum is {sum}.");
        }
    }
}
