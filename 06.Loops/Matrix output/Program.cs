using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size:");
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine();
            for (int col = row; col < row + n; col++)
            {
                Console.Write("{0,3}", col);
            }
            Console.WriteLine();
        }
            
    }
}
