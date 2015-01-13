using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        int divideHundreds = number / 100;
        int result = divideHundreds % 10;
        if (result == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
