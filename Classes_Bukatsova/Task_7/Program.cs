using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee director = new Employee("Elon", "Musk");
            director.Position = Positions.director.ToString();
            director.Experience = 5;
            director.RecalculateSalaryAndTaxes();
            Console.WriteLine($"{director.LastName} {director.FirstName} is {director.Position} and has {director.Salary:F2} with taxes: {director.Tax:F2}");
          
            director.Position = Positions.accountant.ToString();
            director.RecalculateSalaryAndTaxes();
            Console.WriteLine($"{director.LastName} {director.FirstName} is {director.Position} and has {director.Salary:F2} with taxes: {director.Tax:F2}");

            director.Position = Positions.programmer.ToString();
            director.RecalculateSalaryAndTaxes();
            Console.WriteLine($"{director.LastName} {director.FirstName} is {director.Position} and has {director.Salary:F2} with taxes: {director.Tax:F2}");

        }
    }
    enum Positions
    {
        director = 5,
        accountant = 2,
        manager = 4,
        programmer = 3
    }
    class Employee
    {
        string firstName;
        string lastName;

        public string FirstName { get=> firstName; }
        public string LastName{ get=> lastName; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }
        public double Tax { get; set; }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void RecalculateSalaryAndTaxes()
        {
            int quotient;

            quotient = (int)Enum.Parse(typeof(Positions), Position);

            Salary = (Experience * 0.02 + quotient)*2000;
            Tax = Salary * 0.18; 
        }
    }
}
