using System;

class ComparingFloats
{
    static void Main()
    {
        float floatOne = 6.1f;
        float floatTwo = 5.3f;
        bool isEqual = Math.Abs(floatOne - floatTwo) < 0.000001;
        float differenceOne = floatOne - floatTwo;
        Console.WriteLine("The numbers are{0}equal!", isEqual ? " " : " not ");
    }
}
