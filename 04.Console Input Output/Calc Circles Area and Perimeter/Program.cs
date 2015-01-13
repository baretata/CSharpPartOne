using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter circle's R:");
        double r = Convert.ToDouble(Console.ReadLine());
        float pi = 3.14159206f;
        Console.WriteLine("Circle's Perimeter is: 2*pi*r = 2*{0:F2}*{1} = {2:F2}", pi, r, 2*pi*r);
        Console.WriteLine();
        Console.WriteLine("Circle's Area is: pi*r^2 = {0:F2}*{1}*{2} = {3:F2}", pi, r, r, pi*r*r);
        Console.WriteLine();
    }
}
