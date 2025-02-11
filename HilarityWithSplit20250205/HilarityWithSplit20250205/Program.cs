/* demonstrates the split function */
using static System.Console;
namespace HilarityWithSplit20250205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter words separated by spaces: ");
            string[] parts;
            string[] seps = { ", ", " ", "\t", ". " };
            string response = ReadLine();
            parts = response.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in parts)
            {
                WriteLine(part);
            }
        }
    }
}
