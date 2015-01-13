using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Calculating the sign of 3 numbers.\r\nEnter 3 numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("Sign is \'+\'");
                }
                else
                {
                    Console.WriteLine("Sign is \'-\'");
                }
            }
            if (b < 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("Sign is \'-\'");
                }
                else
                {
                    Console.WriteLine("Sign is \'+\'");
                }
            }
        }
        if (a < 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("Sign is \'-\'");
                }
                else
                {
                    Console.WriteLine("Sign is \'+\'");
                }
            }
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("Sign is \'-\'");
                }
                else
                {
                    Console.WriteLine("Sign is \'+\'");
                }
            }
        }
    }
}
