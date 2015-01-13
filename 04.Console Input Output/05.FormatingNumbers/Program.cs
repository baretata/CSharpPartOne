using System;

class FormatingNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter floating number:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter second floating number:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0, -10}|{1}|{2, 10:F2}|{3, -10:F3}|", a.ToString("X"), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}
