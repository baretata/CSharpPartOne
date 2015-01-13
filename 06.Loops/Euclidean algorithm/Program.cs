using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Calculating GCD of 2 integers.");
        Console.Write("Enter first integer:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer:");
        int b = int.Parse(Console.ReadLine());

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }
        if (a == 0)
        {
            Console.WriteLine("GCD is: {0}", b);
        }
        else
        {
            Console.WriteLine("GCD is: {0}", a);
        }
    }
}
