using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Hello! I can calculate Area and Perimetr of rectangle

Input 1st side: ");
            double side_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd side: ");
            double side_2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side_1, side_2);
          
            Console.WriteLine($"\nArea is: {rectangle.Area}\nPerimetr is: {rectangle.Perimetr}");

        }
    }
    class Rectangle
    {
        double side1;
        double side2;

        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Area { get => AreaCalculator(); }
        public double Perimetr { get => PerimetrCalculator(); }
        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimetrCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
}
