using static System.Console;
namespace Cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Coffee Shop!");
            WriteLine();
            string firstItemName, secondItemName;
            double firstPrice, secondPrice;
            int firstQuantity, secondQuantity;
            Write("Enter the name of the first item: ");
            firstItemName = ReadLine().Trim();
            try
            {
                Write($"Enter the price of the {firstItemName}: ");
                firstPrice = double.Parse(ReadLine());
                Write($"Enter the quantity of the {firstItemName}: ");
                firstQuantity = int.Parse(ReadLine());
            } catch (Exception ex)
            {
                WriteLine("The price must be a floating-point number, and the quantity must be an integer. ");
                WriteLine("Exiting now.");
                return;
            }
            WriteLine();
            Write("Enter the name of the second item: ");
            secondItemName = ReadLine().Trim();
            try
            {
                Write($"Enter the price of the {secondItemName}: ");
                secondPrice = double.Parse(ReadLine());
                Write($"Enter the quantity of the {secondItemName}: ");
                secondQuantity = int.Parse(ReadLine());
            }
            catch (Exception ex)
            {
                WriteLine("The price must be a floating-point number, and the quantity must be an integer. ");
                WriteLine("Exiting now.");
                return;
            }
            double firstTotal = firstPrice * firstQuantity;
            double secondTotal = secondPrice * secondQuantity;
            double subTotal = firstTotal + secondTotal;
            const double TAXRATE = 0.08;
            double salesTax = TAXRATE * subTotal;
            double finalTotal = subTotal + salesTax;
            WriteLine();
            WriteLine("Receipt:");
            WriteLine(new string('-', 40));
            WriteLine($"{"Item",-10}{"Quantity",-10}{"Price",10}{"Total",10}");
            WriteLine($"{firstItemName,-10}{firstQuantity,-10}{firstPrice,10:C}{firstTotal,10:C}");
            WriteLine($"{firstItemName,-10}{firstQuantity,-10}{firstPrice,10:C}{secondTotal,10:C}");
            WriteLine(new string('-', 40));
            WriteLine($"{"Subtotal:",-30}{subTotal,10:C}");
            WriteLine($"{"Sales Tax (8%):",-30}{salesTax,10:C}");
            WriteLine($"{"Final Total:",-30}{finalTotal,10:C}");
        }
    }
}
