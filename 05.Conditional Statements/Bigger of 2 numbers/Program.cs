using System;

class GreaterOfTwoNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Comapring 2 numbers.\r\nEnter 2 numbers:");
        int smaller = int.Parse(Console.ReadLine());
        int bigger = int.Parse(Console.ReadLine());
        if (smaller > bigger)
        {
            bigger = smaller;
        }

        Console.WriteLine(bigger + " " + smaller);
    }
}
