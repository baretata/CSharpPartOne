using System;

class PrintLongSequance
{
    static void Main()
    {
        int lineCount = 1;
        for (int i = 2, j = -3; i < 1001; i+=2, j-=2)
        {
            Console.WriteLine("Seqance {0}: {1}, {2}", lineCount, i, j);
            lineCount++;
        }
    }
}
