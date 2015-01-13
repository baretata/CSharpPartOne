using System;

class FactorialNDivideK
{
    static void Main()
    {
        Console.WriteLine("DIvide N!/K!");
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        int temp = 1;
        if (n > 1 && k > 1)
        {
            for (int i = (k+1); i <= n; i++)
            {
                result = temp * i;
                temp = result;
            }
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
            
        Console.WriteLine("Result of N!/K! = {0}", result);
    }
}
