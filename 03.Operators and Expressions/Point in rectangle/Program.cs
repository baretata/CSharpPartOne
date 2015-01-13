using System;

class PointWithinCircleAndOutOfRectangle
{
    static void Main()
    {
        double center = 1;
        double r = 1.5;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

            
        if ((x < -1 || x > 5) || (y > 1 || y < -1))
        {
            if ((x - center) * (x - center) + (y - center) * (y - center) <= r * r)
            {
                Console.WriteLine("Point ({0};{1}) is in the circle and outside of the rectangle: YES, it is!", x, y);
            }
            else
            {
                Console.WriteLine("Point ({0};{1}) is in the circle and outside of the rectangle: NO, it is not!", x, y);
            }
        }
    }
}
