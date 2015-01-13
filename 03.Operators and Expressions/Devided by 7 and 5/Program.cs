using System;

class DevidedBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool isDivided = false;
        if ((number % 5 == 0) && (number % 7 == 0))
	    {
		    isDivided = true;
	    }
        else
	    {
            isDivided = false;
	    }
        Console.WriteLine("Divided by 5 and 7: {0}", isDivided);
    }
}
