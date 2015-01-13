using System;

class BitExchange
{
    static int ChangeBits(int number, int firstPos, int secondPos)
    {
        number ^= (1 << firstPos);
        return number ^ (1 << secondPos);

    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number + " in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        for (int i = 3, j = 24; i < 6; i++, j++)
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                number = ChangeBits(number, i, j);
            }
        }
        Console.WriteLine(number + " in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
