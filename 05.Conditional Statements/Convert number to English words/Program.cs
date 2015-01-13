using System;

class ConvertNumbersToWords
{
    static void Main()
    {
        Console.WriteLine("Enter a from 0 to 999:");
        int n = int.Parse(Console.ReadLine());
        string word = "";

        string[] ones = new string[] 
        { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        string[] tens = new string[] 
        { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

            
        if (n <= 999)
        {
            if (n > 100)
            {
                Console.Write("{0} hundred{1}", ones[n/100], n%100==0?"":" and ");
                if (n % 100 != 0)
                {
                    n = (n - ((n / 100)*100));
                    if (n < 100)
                    {
                        if (n < 20)
                        {
                            word = ones[n];
                        }
                        else
                        {
                            word = tens[n / 10];

                            if ((n % 10) != 0)
                            {
                                word += "-" + ones[n % 10];
                            }
                        }
                    }
                    Console.Write(word);
                }
            }
            else
	        {
                if (n >= 0 && n < 100)
                {
                    if (n < 20)
                    {
                        word = ones[n];
                    }
                    else
                    {
                        word = tens[n / 10];

                        if ((n % 10) != 0)
                        {
                            word += "-" + ones[n % 10];
                        }
                    }
                }
                Console.Write(word);
	        }
        Console.WriteLine();
        }
        else
	    {
            Console.WriteLine("Invalid input!");
	    }
    }
}