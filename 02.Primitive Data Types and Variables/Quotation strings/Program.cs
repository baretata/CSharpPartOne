using System;

class QuotedStrings
{
    static void Main()
    {
        string withQuotes = "The \"use\" of quotations causes difficulties.";
        string withoutQuotes = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0} \r\n{1}", withQuotes, withoutQuotes);
    }
}
