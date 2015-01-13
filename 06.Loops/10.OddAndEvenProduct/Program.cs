using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter how much numbers to calculate: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int oddSum = 1;
        int evenSum = 1;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0, j = 0; j < n; i+=2, j+=2)
        {
            oddSum *= numbers[i];
            evenSum *= numbers[i+1];
        }
        Console.WriteLine(oddSum == evenSum ? "YES, products are equal." : "NO, products are not equal.");
    }
}