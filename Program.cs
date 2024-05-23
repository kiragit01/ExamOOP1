using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP1
{
    class Program
    {
        static void Main()
        {
            Console.Write("side1 = ");
            double side1 = int.Parse(Console.ReadLine());
            Console.Write("side2 = ");
            double side2 = int.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Area = {rectangle.Area}");
            Console.WriteLine($"Perimeter = {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
