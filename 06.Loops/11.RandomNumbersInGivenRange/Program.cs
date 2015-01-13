using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter how much numbers to generate: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max value: ");
        int max = int.Parse(Console.ReadLine());
        Random randomGen = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", randomGen.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}

