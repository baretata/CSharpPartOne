using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nums = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += double.Parse(nums[i]);
        }

        Console.WriteLine("Sum is: {0}", sum);
    }
}
