using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit you want to extract: ");
        int point = int.Parse(Console.ReadLine());
        int mask = 1 << point;
        int numAndMask = number & mask;
        int bit = numAndMask >> point;
        Console.WriteLine("Bit on position {0} is: {1}", point, bit);
            
    }
}
