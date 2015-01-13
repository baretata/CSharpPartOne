using System;

class Combinatorics
{
    static void Main()
    {
        Console.WriteLine("Calculating equation N!/K!*(K-N)!");
        Console.WriteLine("Enter N (N > K):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (K < N):");
        int k = int.Parse(Console.ReadLine());
        decimal resultN = 1;
        decimal resultK = 1;

        if (n > 1 && k > 1 && n > k)
        {
            for (int i = k+1; i <= n; i++)
            {
                resultN *= i;
            }
            for (int j = 1; j <= (n-k); j++)
            {
                resultK *= j;
            }
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
        decimal finalResult = resultN / resultK;
        Console.WriteLine("Result is: {0}", finalResult);
    }
}