/* based on the grade the user enters, comment on it. 
 * Illustrates using switch statements. */
using static System.Console;
namespace GradeCommentor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your letter grade: ");
            string letterGrade = ReadLine().ToUpper(); // makes what they typed upper case
            switch (letterGrade)
            {
                case "A":
                    WriteLine("Congratulations! You're pretty smart.");
                    break;
                case "B":
                    WriteLine("Good job. Keep it up.");
                    break;
                case "C":
                    WriteLine("C is for cookie, and cookies are delicious.");
                    break;
                case "D":
                    WriteLine("D is for diploma.");
                    break;
                case "F":
                    WriteLine("Mom and Dad are going to be mad.");
                    break;
                default:
                    WriteLine("You're so dumb.");
                    break;
            }
            /*
            if (letterGrade == "A")
            {
                WriteLine("Smart");
            } else if (letterGrade == "B")
            {
                WriteLine("Good");
            } else
            {
                WriteLine("You're so dumb.");
            }
            */
        }
    }
}
