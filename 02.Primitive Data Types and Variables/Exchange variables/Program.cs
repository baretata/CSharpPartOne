using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int five = 5;
        int ten = 10;
        int temp;
        temp = five;
        five = ten;
        ten = temp;
        Console.WriteLine("{0}, {1} ", five, ten);
    }
}
