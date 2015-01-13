using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers to sort them from bigger to smaller:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("From bigger to smaller: {0}, {1}, {2} ", a, b, c);
                }
                else
                {
                    Console.WriteLine("From bigger to smaller: {0}, {1}, {2} ", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("From bigger to smaller: {0}, {1}, {2} ", c, a, b);
            }
        }
        if (b > a)
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("From bigger to smaller: {0}, {1}, {2} ", b, a, c);
                }
                else
                {
                    Console.WriteLine("From bigger to smaller: {0}, {1}, {2} ", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("From bigger to smaller: {0}, {1}, {2} ", c, b, a);
            }
        }
    }
}