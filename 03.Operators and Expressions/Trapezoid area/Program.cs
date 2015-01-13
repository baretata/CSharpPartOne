using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.WriteLine("Enter side A:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter side B:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter height:");
        int h = Convert.ToInt32(Console.ReadLine());
        int result = ((a + b) * h) / 2;
        Console.WriteLine(result);
    }
}
