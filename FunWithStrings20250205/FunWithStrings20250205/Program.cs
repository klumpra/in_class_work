/* this demonstrates various built-in methods of the string data type. */
using static System.Console;
namespace FunWithStrings20250205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a greeting: ");
            string greeting = ReadLine();
            int numChars = greeting.Length;
            WriteLine($"You entered this phrase:\n\t{greeting}");
            string shouted = greeting.ToUpper();
            WriteLine($"That has {numChars} characters in it.");
            WriteLine($"Uppercased, that's {shouted}");
            string part = greeting.Substring(2, 5); //starting at position 2, return 5 chars
            WriteLine($"The substring is {part}");
            Write("Enter a substring to find: ");
            string findThis = ReadLine();
            int pos = greeting.IndexOf(findThis);
            if (pos == -1)
            {
                WriteLine("The string you specified was not found.");
            } else
            {
                WriteLine($"The substring {findThis} was located at position {pos}.");
            }
            Write("What do you want to replace? ");
            string replaceThis = ReadLine();
            Write("Replace with what? ");
            string replaceWith = ReadLine();
            if (greeting.IndexOf(replaceThis) < 0)
            {
                WriteLine("not found");
            } else
            {
                greeting = greeting.Replace(replaceThis, replaceWith);
                WriteLine($"The new string is {greeting}.");
            }
        }
    }
}
