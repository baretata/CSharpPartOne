using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long decNum = long.Parse(Console.ReadLine());
        StringBuilder hexNum = new StringBuilder();
        while (decNum > 0)
        {
            switch (decNum % 16)
            {
                case 10: hexNum.Append('A'); break;
                case 11: hexNum.Append('B'); break;
                case 12: hexNum.Append('C'); break;
                case 13: hexNum.Append('D'); break;
                case 14: hexNum.Append('E'); break;
                case 15: hexNum.Append('F'); break;
                default: hexNum.Append(decNum % 16); break;
            }
            decNum = decNum / 16;
        }
        string finalHex = hexNum.ToString();
        for (int i = finalHex.Length - 1; i >= 0; i--)
        {
            Console.Write(finalHex[i]);
        }
        Console.WriteLine();
    }
}