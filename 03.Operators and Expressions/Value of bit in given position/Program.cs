using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Checking if given bit at a position you enter is 1.");
        Console.Write("First enter a number you want to check: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Now enter the number of the bit you want to check: ");
        int p = Convert.ToInt32(Console.ReadLine());
        int mask = 1 << p;
        int numAndMask = number & mask;
        int bit = numAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
