using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Calculating Catalan's equation:");
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        decimal factOne = 1;
        decimal factTwo = 1;
        decimal resultN = 1;

        for (int i = 1, j = (n+1); i <= n; i++, j++)
        {
            factOne *= i;
            factTwo *= j;
        }

        resultN = (factOne * factTwo) / (((n + 1) * factOne) * factOne);
        Console.WriteLine("Result is: {0}", resultN);
    }
}