using System;
using System.Linq;

namespace Greater_of_5_numbers
{
    class BiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double[] numbers = {a, b, c, d, e};
            Console.WriteLine("Greatest number is: {0}", numbers.Max());
        }
    }
}
