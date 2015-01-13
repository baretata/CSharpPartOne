using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a position: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value(0 or 1): ");
        int v = Convert.ToInt32(Console.ReadLine());
        int mask;
        int result;

        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
            Console.WriteLine(result);
        }
        else
        {
            mask = 1 << p;
            result = n | mask;
            Console.WriteLine(result);
        }
    }
}
