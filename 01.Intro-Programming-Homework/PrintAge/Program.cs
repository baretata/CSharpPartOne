using System;

class PrintAge
{
    static void Main()
    {
        Console.Write("Enter your age in format DD/MM/YYYY: ");
        DateTime today = DateTime.Today;
        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
        int age = 0;
        if (birthDate.Month > today.Month)
        {
            age = today.Year - birthDate.Year - 1;
        }
        else if (birthDate.Month < today.Month)
        {
            age = today.Year - birthDate.Year;
        }
        else
        {
            if (birthDate.Day > today.Day)
            {
                age = today.Year - birthDate.Year - 1;
            }
            else
            {
                age = today.Year - birthDate.Year;
            }
        }
        Console.WriteLine("Your age is {0}. After 10 year your age will be {1}.", age, age + 10);
    }
}
