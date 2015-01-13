using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomizeNumbersFromOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        var ints = numbers.OrderBy(item => rnd.Next());
        Console.WriteLine(string.Join(", ", ints));
    }
}
