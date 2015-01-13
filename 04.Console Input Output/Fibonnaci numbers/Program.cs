using System;

class FibonnaciNumbers
{
    static void Main()
    {
        Console.Write("Enter how many of the Fibonnaci numbers you want to print: ");
        int input = int.Parse(Console.ReadLine());
        long a = 0;
        long b = 1;
        long curr = 0;
        for (int i = 0; i < input; i++)
        {
            curr = a + b;
            a = b;
            b = curr;
            Console.WriteLine(curr);
        }
    }
}
