using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("First Name:");
        string fname = Console.ReadLine();
        Console.Write("Last Name:");
        string lname = Console.ReadLine();
        Console.Write("Age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Gender (m/f):");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter Your ID Number (27560000 to 27569999):");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("First Name: {0} \nLast Name: {1} \nAge: {2} \nGender: {3} \nID Number: {4}", fname, lname, age, gender, id);
        if (gender == 'm') 
        {
            Console.WriteLine("You are Male.");
        }
        else if (gender == 'f')
        {
            Console.WriteLine("You are Woman.");
        }
        else
        {
            Console.WriteLine("Wrong symbol!");
        }
        if ((id < 27560000) || (id > 27569999))
        {
            Console.WriteLine("Wrong ID!");
        }
        else
        {
            Console.WriteLine("ID Number: {0}", id);
        }
    }
}
