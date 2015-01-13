using System;

class HexadecimalFormat
{
    static void Main()
    {
        int value = 254;
        string hex = value.ToString("X");
        int dec = Convert.ToInt32(hex, 16);
        Console.WriteLine("Hexadecimal result: {0}", hex);
        Console.WriteLine("Decimal result: {0}", dec);
    }
}

