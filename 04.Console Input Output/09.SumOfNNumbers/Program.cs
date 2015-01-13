using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to calculate: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers: ");
        double[] numbers = new double[n];
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine("The sum of your numbers is: {0}", sum);
    }
}

