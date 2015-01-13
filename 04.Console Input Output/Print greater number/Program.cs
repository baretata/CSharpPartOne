using System;

class PrintGreaterNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Greater number is: {0}", a > b ? a : b);
    }
}
