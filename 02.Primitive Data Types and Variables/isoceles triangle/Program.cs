using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IsocelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char symbol = '\u00A9';

        double count = 1;
        int row = 3;
        double col = 2 * row - 1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (j < (col / 2 - count / 2) || j > (col / 2 + count / 2 - 1))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(symbol); 
                }
            }
            count = count + 2;
            Console.WriteLine();
        }
    }
}
