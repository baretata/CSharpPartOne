using System;

class NOnThePowerOfXSum
{
    static void Main()
    {
        Console.WriteLine("Calculating equation Sum = 1 + 1!/X + 2!/X^2..N!/X^n");
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X:");
        int x = int.Parse(Console.ReadLine());
        decimal resultN = 1;
        decimal resultX = 1;
        decimal sum = 0;

        for (int i = 1; i <= n; i++)
        {
            resultN *= i;
            resultX *= x;
            sum += (resultN / resultX);
        }
        Console.WriteLine("Result: {0:F5}", sum + 1);
    }
}
