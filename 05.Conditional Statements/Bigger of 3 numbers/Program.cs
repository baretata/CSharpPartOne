using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Comparing 3 numbers.\r\nEnter 3 numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Bigger number is: {0}", a);                
            }
            else
            {
                Console.WriteLine("Bigger number is: {0}", c);   
            }
        }
        if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("Bigger number is: {0}", b);
            }
            else
            {
                Console.WriteLine("Bigger number is: {0}", c);   
            }
        }
    }
}
