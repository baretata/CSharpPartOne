using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter number to extract third bit from: ");
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int numAndMask = number & mask;
        int bit = numAndMask >> p;
        Console.WriteLine(bit);
    }
}
