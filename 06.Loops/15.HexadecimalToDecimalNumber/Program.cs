using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimal
{
    static int Pow(int sqr)
    {
        return (1 << (sqr * 4));
    }

    static void Main()
    {
        Console.Write("Convert hex to decimal: ");
        string hexNum = Console.ReadLine();
        long result = 0;
        int count = hexNum.Length - 1;
        int digit = 0;

        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case 'A':
                case 'a': digit = 10; break;
                case 'B':
                case 'b': digit = 11; break;
                case 'C':
                case 'c': digit = 12; break;
                case 'D':
                case 'd': digit = 13; break;
                case 'E':
                case 'e': digit = 14; break;
                case 'F':
                case 'f': digit = 15; break;
                default: digit = int.Parse(Convert.ToString(hexNum[i])); break;
            }
            result += digit * Pow(count);
            count--;
        }
        Console.WriteLine(result);
    }
}
