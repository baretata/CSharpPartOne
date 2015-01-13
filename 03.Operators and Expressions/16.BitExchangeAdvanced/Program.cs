using System;

class BitExchange
{
    static long ChangeBits(long number, int firstPos, int secondPos)
    {
        number ^= (1 << firstPos);
        return number ^ (1 << secondPos);

    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter position P to exchange from: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter position Q to exchange to: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter step K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(number + " in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        for (int i = p, j = q, l = k; (i <= 32 && j <= 32) && l > 0; i++, j++, l--)
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                number = ChangeBits(number, i, j);
            }
        }
        Console.WriteLine(number + " in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
