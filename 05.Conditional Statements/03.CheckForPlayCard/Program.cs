using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("Enter input to check if it is a play card: ");
        string input = Console.ReadLine();
        string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool equal = false;
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == input) 
            {
                equal = true;
            }
        }
        Console.WriteLine("Is it real play card? --> {0}", equal ? "YES": "NO");
    }
}
