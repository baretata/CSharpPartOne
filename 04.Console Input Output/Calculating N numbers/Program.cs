using System;

class NumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Printing numbers from 1 to N!");
            Console.Write("Enter N: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
