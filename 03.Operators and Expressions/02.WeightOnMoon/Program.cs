using System;
namespace _02.WeightOnMoon
{
    class WeightOnMoon      
    {
        static void Main()
        {
            Console.Write("Enter your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());
            double moonWeight = weight * 17 / 100;

            Console.WriteLine("Your weight on the moon will be {0}", moonWeight);
        }
    }
}
