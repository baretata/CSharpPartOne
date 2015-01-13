using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object compile = hello + " " + world;
        string display = (string)compile;
        Console.WriteLine("{0}", display);
    }   
}
