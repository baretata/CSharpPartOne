using System;
using System.IO;

class ListOfIDEs
{
    static void Main()
    {
        StreamReader reader = new StreamReader("list-of-IDEs.txt");
        using (reader)
        {
            string fileContent = reader.ReadToEnd();
            Console.WriteLine(fileContent);
            Console.WriteLine();
        }
    }
}
