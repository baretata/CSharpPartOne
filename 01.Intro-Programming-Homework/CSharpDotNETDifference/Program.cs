using System;
using System.IO;

class CSharpDotNETDifference
{
    static void Main()
    {
        StreamReader reader = new StreamReader("csharp-and-dot-net-framework.txt");
        using (reader)
        {
            string fileContent = reader.ReadToEnd();
            Console.WriteLine(fileContent);
            Console.WriteLine();
        }
    }
}
