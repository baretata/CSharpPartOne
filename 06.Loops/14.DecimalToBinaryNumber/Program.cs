using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinaryNumber
{
    static List<long> inBinary = new List<long>();
    static long number;

    static void DecToBinary()
    {
        while (number > 0)
        {
            inBinary.Add(number % 2);
            number = number / 2;
        }
        inBinary.Reverse();

        for (int i = 0; i < inBinary.Count; i++)
        {
            Console.Write("{0} ", inBinary[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter decimal number to convert in binary: ");
        number = long.Parse(Console.ReadLine());
        DecToBinary();
    }
}