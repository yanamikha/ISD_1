using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Figure(new Point(-1, 5, "A"), new Point(-1, 2, "B"), new Point(3, 2, "C"));
            Figure quadrangle = new Figure(new Point(0, 0, "A"), new Point(0, 2, "B"), new Point(3, 2, "C"), new Point(3, 0, "D"));
            Figure pentagon = new Figure(new Point(2, 4, "A"), new Point(12, 4, "B"), new Point(-2, 4, "C"), new Point(-2, 0, "D"), new Point(3, 4, "E"));

            Console.WriteLine($"Perimetr of {triangle.Name()}: {triangle.PerimeterCalculator()}");
            Console.WriteLine($"Perimetr of {quadrangle.Name()}: {quadrangle.PerimeterCalculator()}");
            Console.WriteLine($"Perimetr of {pentagon.Name()}: {pentagon.PerimeterCalculator()}");
        }
    }
    class Point
    {
        int x;
        int y;
        string title;

        public int X { get=>x; }
        public int Y { get=>y; }
        public string Title { get=>title; }

        public Point(int x, int y, string title)
        {
            this.x = x;
            this.y = y;
            this.title = title;
        }
    }
    class Figure
    {
        List<Point> points = new List<Point>();

      
            public Figure(Point point_1, Point point_2, Point point_3)
        {
            points.Add(point_1);
            points.Add(point_2);
            points.Add(point_3);
        }
        public Figure(Point point_1, Point point_2, Point point_3, Point point_4) : this(point_1, point_2, point_3)
        {
            points.Add(point_4);
        }
            public Figure(Point point_1, Point point_2, Point point_3, Point point_4, Point point_5) : this(point_1, point_2, point_3, point_4)
        {
            points.Add(point_5);
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public double PerimeterCalculator()
        {

            int numberOfSides = points.Count;
            double perimetr = 0;
            for (int i = 0; i < numberOfSides - 1; i++)
            {
                perimetr += LengthSide(points[i], points[i + 1]);
            }
            perimetr += LengthSide(points[0], points[numberOfSides - 1]);
            return perimetr;
        }
        public string Name()
        {
            switch (points.Count)
            {
                case 3:
                    return "triangle";
                case 4:
                    return "quadrangle";
                case 5:
                    return "pentagon";
            }
            return "Error!";
        }
    }
}
