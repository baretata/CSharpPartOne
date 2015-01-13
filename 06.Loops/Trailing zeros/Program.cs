using System;

class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Counting trailing zeros in N!.");
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 5; i <= n; i *= 5)
        {
            sum = sum + (n/i);
        }
        Console.WriteLine("Number {0} got {1} traling zeros!", n, sum);
    }
}