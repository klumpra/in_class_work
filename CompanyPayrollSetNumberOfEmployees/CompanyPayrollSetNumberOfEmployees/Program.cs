/* Payroll example with a user-specified number of employees */
using static System.Console;
namespace CompanyPayrollSetNumberOfEmployees
{
    internal class Program
    {
        static void PrintHeading()
        {
            WriteLine(new string('*', 50));
            WriteLine("             Paycheck Calculator V1.0");
            WriteLine(new string('*', 50));
            WriteLine();
        }
        static void Main(string[] args)
        {
            PrintHeading();
            int empCount;
            double hoursWorked, payRate, gross, taxes, taxRate, net, totalPay = 0, averagePay;
            Write("Enter number of employees: ");
            empCount = int.Parse(ReadLine());
            for (int i = 1; i <= empCount; i++) 
            {
                WriteLine($"Employee #{i}");
                Write("Enter the hours worked: ");
                hoursWorked = double.Parse(ReadLine());
                Write("Enter the pay rate: ");
                payRate = double.Parse(ReadLine());
                gross = hoursWorked * payRate;
                // determine tax rate based on gross pay
                if (gross >= 2000)
                {
                    taxRate = 0.25;
                }
                else if (gross >= 1000)
                {
                    taxRate = 0.15;
                }
                else
                {
                    taxRate = 0.1;
                }
                taxes = taxRate * gross;
                net = gross - taxes;
                totalPay = totalPay + gross;
                // print the paycheck summary
                WriteLine("Here is a summary:");
                WriteLine($"{"Gross pay",-15}{gross,10:C}");
                WriteLine($"{"Taxes",-15}{taxes,10:C}");
                WriteLine($"{"Net pay",-15}{net,10:C}");
                WriteLine();
            }
            WriteLine();
            WriteLine($"The total gross pay was {totalPay,0:C}.");
            averagePay = totalPay / empCount;
            WriteLine($"The average gross pay per employee was {averagePay,0:C}.");
            WriteLine("Thank you for using this program.");
        }
    }
}
