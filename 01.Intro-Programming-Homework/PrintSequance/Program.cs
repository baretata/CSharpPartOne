using System;

class PrintSequance
{
    static void Main()
    {
        for (int i = 2, j = -3; i <= 20; i += 2, j -= 2)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
