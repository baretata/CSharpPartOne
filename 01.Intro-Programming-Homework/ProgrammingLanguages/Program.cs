using System;
using System.IO;

class ProgrammingLanguages
{
    static void Main()
    {
        //StreamReader is a class that reads text files from the computer.
        StreamReader reader = new StreamReader("programming-languages.txt");   
        using (reader)
        {
            string fileContent = reader.ReadToEnd();
            Console.WriteLine(fileContent);
            Console.WriteLine();
        }
    }
}
