using System;

class NumbersDividedWithoutReminder
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                count++;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Numbers divided by 5 in this range: {0}", count);
    }
}
