using static System.Console;
namespace Paycheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hoursWorked, payRate, taxes, gross, net;
            const double TAXRATE = 0.08;
            try
            {
                Write("Enter hours worked: ");
                hoursWorked = double.Parse(ReadLine());
                Write("Enter pay rate: ");
                payRate = double.Parse(ReadLine());
                gross = hoursWorked * payRate;
                taxes = TAXRATE * gross;
                net = gross - taxes;
            } catch (Exception ex)
            {
                WriteLine("The hourly pay rate and hours worked must be numbers.");
                return;
            }
            WriteLine($"{"Hours worked:",-20}{hoursWorked,10:F2}");
            WriteLine($"{"Pay rate:",-20}{payRate,10:C}");
            WriteLine($"{"Gross pay:",-20}{gross,10:C}");
            WriteLine($"{"Taxes:",-20}{taxes,10:C}");
            WriteLine($"{"Net pay:",-20}{net,10:C}");
        }
    }
}
