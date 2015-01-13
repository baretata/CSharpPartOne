using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string destination = "right";
        int maxRotation = n * n;

        for (int i = 1; i <= maxRotation; i++)
        {
            if (destination == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                destination = "down";
                col--;
                row++;
            }
            if (destination == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                destination = "left";
                col--;
                row--;
            }
            if (destination == "left" && (col < 0 || matrix[row, col] != 0))
            {
                destination = "up";
                col++;
                row--;
            }
            if (destination == "up" && (row < 0 || matrix[row, col] != 0))
            {
                destination = "right";
                col++;
                row++;
            }

            matrix[row, col] = i;
            if (destination == "right")
            {
                col++;
            }
            if (destination == "down")
            {
                row++;
            }
            if (destination == "left")
            {
                col--;
            }
            if (destination == "up")
            {
                row--;
            }
        }
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,4}", matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}