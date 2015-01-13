using System;

class IntDoubleStringChoice
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for integer, 2 for double and 3 for string:");
        byte choice = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter value:");
        switch (choice)
        {
            case 1: int i = int.Parse(Console.ReadLine());
                Console.WriteLine(i + 1); break;
            case 2: double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d + 1); break;
            case 3: string s = Console.ReadLine();
                Console.WriteLine(s + "*"); break;
            default: Console.WriteLine("Wrong input!"); break;
        }
    }
}
