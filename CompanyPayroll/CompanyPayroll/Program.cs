/*
 * In this example, we will create a tool for calculating the total payroll for a company. 
 * You will ask the user to enter the hours worked and hourly pay rate for each employee. 
 * A sliding tax scale will be used to determine the tax rate for each person. As each person's 
 * paycheck is processed, we will print their gross pay, net pay, and taxes to the screen. 
 * After processing an employee, you will ask the user if they have another employee to process. 
 * At the end of the program, we will show the total amount paid to the employees and the 
 * average pay per employee.
 */
using static System.Console;
namespace CompanyPayroll
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
            string doAgain;
            int empCount = 0;  // which employee am I on?
            double hoursWorked, payRate, gross, taxes, taxRate, net, totalPay=0, averagePay;
            do
            {
                empCount = empCount + 1; // I'm working with the next employee
                WriteLine($"Employee #{empCount}");
                Write("Enter the hours worked: ");
                hoursWorked = double.Parse(ReadLine());
                Write("Enter the pay rate: ");
                payRate = double.Parse(ReadLine());
                gross = hoursWorked * payRate;
                // determine tax rate based on gross pay
                if (gross >= 2000)
                {
                    taxRate = 0.25;
                } else if (gross >= 1000)
                {
                    taxRate = 0.15;
                } else
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
                Write("Do you have another employee? ");
                doAgain = ReadLine().ToUpper();
            } while (doAgain == "Y");
            WriteLine();
            WriteLine($"The total gross pay was {totalPay,0:C}.");
            averagePay = totalPay / empCount;
            WriteLine($"The average gross pay per employee was {averagePay,0:C}.");
            WriteLine("Thank you for using this program.");
        }
    }
}
