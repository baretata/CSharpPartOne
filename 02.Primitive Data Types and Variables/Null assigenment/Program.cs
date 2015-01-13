using System;

class NullAssigenment
{
    static void Main()
    {
        int? intNum = null;
        Console.WriteLine("Integer null: {0}", intNum);
        Console.WriteLine("Integer null + 5: {0}", intNum + 5);
        intNum = 5;
        Console.WriteLine("Integer null with assigned value: {0}", intNum);

        double? doubleNum = null;
        Console.WriteLine("Double null: {0}", doubleNum);
        Console.WriteLine("Double null + 5: {0}", doubleNum + 5);
        doubleNum = 2.2;
        Console.WriteLine("Double null with assigned value: {0}", doubleNum);
    }
}
