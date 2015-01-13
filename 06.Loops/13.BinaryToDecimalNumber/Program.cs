using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter binary number to convert: ");
        long sum = 0;
        string strNumber = Console.ReadLine();
        int number = int.Parse(strNumber);
        for (int i = 0; i < strNumber.Length; i++)
        {
            long lastDigit = number % 10;
            sum = sum + lastDigit * (long)(Math.Pow(2, i));
            number = number / 10;
        }
        Console.WriteLine("The decimal representation of your number is: {0}", sum);
    }
}
