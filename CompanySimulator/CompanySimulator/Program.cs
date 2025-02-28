namespace CompanySimulator
{
    internal class Program  // controller
    {
        static void Main(string[] args)
        {
            Company company = new Company("Lewis Industries", 1932);
            company.AddEmployee("Ray", "Klump", 42.50);
            company.AddEmployee("Joe", "Schmoe", 37.75);
            CompanyWriter.WriteCompanyToScreen(company);
            double maxPayout = company.CalculateTotalFullTimePay();
            Console.WriteLine($"The maximum weekly payout is {maxPayout,0:C}.");
            Console.WriteLine("Now we will compute the pay for an employee you choose...");
            Console.WriteLine("Enter first and last name separated by a space: ");
            string response = Console.ReadLine();
            string[] parts = response.Split(" ");
            double hoursWorked;
            Console.WriteLine("Enter hours worked: ");
            hoursWorked = double.Parse(Console.ReadLine());
            double payAmount;
            try
            {
                payAmount = company.GetPayAmount(parts[0], parts[1], hoursWorked);
                Console.WriteLine($"{parts[0]} {parts[1]} earned {payAmount,0:C}.");
            } catch (Exception ex)
            {
                Console.WriteLine("That employee was not found.");
            }
        }
    }
}
