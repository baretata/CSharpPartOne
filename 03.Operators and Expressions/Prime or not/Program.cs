using System;

class PrimeOrNot
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = false;
        if (n == 0 || n == 1)
        {
            Console.WriteLine("Is {0} prime: {1}", n, isPrime);
        }
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Is {0} prime: {1}", n, isPrime);
                    return;
                }
            }
            isPrime = true;
            Console.WriteLine("Is {0} prime: {1}", n, isPrime);
        }
    }
}