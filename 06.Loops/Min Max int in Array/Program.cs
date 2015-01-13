using System;
using System.Linq;

class MinMaxSumAverageOfSequance
{
    static void Main()
    {
        Console.WriteLine("Enter how much numbers do you want:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers: ", num);
        int[] arr = new int[num];

        for (int i = 0; i < num; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Max value of the sequance is: {0}", arr.Max());
        Console.WriteLine("Min value of the sequance is: {0}", arr.Min());
        Console.WriteLine("Sum of the sequance is: {0}", arr.Sum());
        Console.WriteLine("Average value of the sequance is: {0}", arr.Average());
    }
}