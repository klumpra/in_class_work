using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySimulator
{
    internal class Company
    {
        public string Name { get; set; }
        private int yearFounded;
        public int YearFounded
        {
            get
            {
                return yearFounded;
            }
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value > currentYear || value < 1000)
                {
                    throw new ArgumentException("Invalid year");
                } else
                {
                    yearFounded = value;
                }
            }
        }
        public List<Employee> Employees { get; private set; }
        public Company()
        {
            Name = "";
            YearFounded = 2000;
            Employees = new List<Employee>();
        }
        public Company(string name, int yearFounded)
        {
            Name = name;
            YearFounded = yearFounded;
            Employees = new List<Employee>();
        }
        public Employee AddEmployee(string firstName, string lastName, double payRate)
        {
            Employee employee = new Employee(firstName, lastName, payRate);
            Employees.Add(employee);
            return employee;
        }
        public double CalculateTotalFullTimePay()
        {
            double result = 0;
            foreach (Employee employee in Employees)
            {
                result = result + employee.CalculatePay(40);
            }
            return result;
        }
        /*GetPayAmount determines the amount to pay a given employee.
         * You provide the employee's first name and last name.
         * If the employee is found, we calculate that employee's pay and return it.
         * If the employe is not found, we thrown an exception
         */
        public double GetPayAmount(string firstName, string lastName, double hoursWorked)
        {
            // find the employee
            // if found, tell it to CalculatePay(hoursWorked)
            Employee? emp = FindEmployee(firstName, lastName);
            if (emp != null)
            {
                return emp.CalculatePay(hoursWorked);
            } else
            {
                throw new Exception("Employee not found");
            }

        }
        public Employee? FindEmployee(string firstName, string lastName)  // ? means the return value might be null
        {
            try
            {
                return Employees.Where(e => e.FirstName == firstName && e.LastName == lastName).ToList()[0];
            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
