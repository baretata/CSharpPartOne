using System;

class PointWithinCircle
{
    static void Main()
    {
        double r = 2;
        double x = 1;
        double y = 2;
        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("Point ({0};{1}) is within the circle: {2}", x, y, true);
        }
        else
        {
            Console.WriteLine("Point ({0};{1}) is within the circle: {2}", x, y, false);
        }
    }
}
