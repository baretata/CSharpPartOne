using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (byte count = 0; count < 255; count++)
        {
            Console.WriteLine((char)count);
        }
    }
}
