using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        long companyPhone = long.Parse(Console.ReadLine());
        Console.Write("Enter company fax number: ");
        long companyFax = long.Parse(Console.ReadLine());
        Console.Write("Enter company website address: ");
        string companyWebsite = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Company's Manager Info \r\nFirst name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        long managerPhone = long.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("{0} \r\nAddress: {1} \r\nTel. {2} \r\nFax: {3} \r\nWebsite: {4} \r\n\r\nManager info: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, companyPhone, companyFax, companyWebsite, managerFirstName, managerLastName, managerAge, managerPhone);
        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
    }
}
