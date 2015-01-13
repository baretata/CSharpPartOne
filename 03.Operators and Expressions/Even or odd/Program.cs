using System;

class EvenOrOdd
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number % 2 == 0) ? "It's even!" : "It's odd!");
    }
}
