using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        private double AreaCalculator()
        {
            return side2 * side1;
        }
        private double PerimeterCalculator()
        {
            return side1 * 2 + side2 * 2;
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2;
            Console.Write("Введiть side1: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть side2: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Rectangle rectangle = new Rectangle(s1, s2);
            Console.WriteLine($"\nПериметр прямокутника = {rectangle.Perimeter}");
            Console.WriteLine($"Площа прямокутника = {rectangle.Area}\nНажмiть будь-яку клавiшу для завершення програми");
            Console.ReadKey();
        }
    }
}
