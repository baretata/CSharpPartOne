using System;

class SumOfDigits
{
    static void ExchangeFirstAndLastDigit(string input)
    {
        char[] digits = input.ToCharArray();
        char firstDigit = digits[0];
        digits[0] = digits[digits.Length - 1];
        digits[digits.Length - 1] = firstDigit;
        Console.WriteLine("Exchanged first and last digit: {0}", new string(digits));
    }

    static void ExchangeSecondAndThirdDigit(string input)
    {
        char[] digits = input.ToCharArray();
        char secondDigit = digits[1];
        digits[1] = digits[2];
        digits[2] = secondDigit;
        Console.WriteLine("Exchanged second and third digit: {0}", new string(digits));
    }

    static void ReversedNumber(int number)
    {
        int rev = 0;
        int left = number;
        while (left > 0)
        {
            int r = left % 10;
            rev = rev * 10 + r;
            left /= 10;
        }
        Console.WriteLine("Reversed number is: {0}", rev);
    }

    static void DigitsSum(int number)
    {
        int digit = 0;
        int sum = 0;

        while (number > 0)
        {
            digit = number % 10;
            sum += digit;
            number /= 10;
        }
        Console.WriteLine("Your number's sum is: {0}", sum);
    }

    static void Main()
    {
        Console.WriteLine("Calculating the sum of the digits of given number.");
        Console.Write("Please enter 4 digit number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        DigitsSum(number);
        ReversedNumber(number);
        ExchangeFirstAndLastDigit(input);
        ExchangeSecondAndThirdDigit(input);
    }
}
