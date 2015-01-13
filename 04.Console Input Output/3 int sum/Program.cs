using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine("The sum of the numbers: {0}, {1} and {2} is: {3}", a, b, c, sum);
    }
}
