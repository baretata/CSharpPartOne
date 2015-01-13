using System;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("First Name: ");
        string fname = Console.ReadLine();
        Console.WriteLine("Middle Name: ");
        string midname = Console.ReadLine();
        Console.WriteLine("Last Name: ");
        string lname = Console.ReadLine();
        Console.WriteLine("Holder Name: {0} {1} {2}", fname, midname, lname);
        decimal amount = 100;
        Console.WriteLine("Balance: {0:C}", amount);
        string bankname = "OBB";
        Console.WriteLine("Bank: {0}", bankname);
        ulong iban = 91299292922;
        Console.WriteLine("IBAN Number: {0}", iban);
        int cc1 = 2131406480;
        Console.WriteLine("Credit Card Number: {0}", cc1);
            
    }
}
