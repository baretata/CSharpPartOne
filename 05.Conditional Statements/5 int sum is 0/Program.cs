using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers:");
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == 0)
	        {
		        Console.WriteLine("{0}", arr[i]);
                break;
	        }
		}
        for (int i = 0; i < arr.Length-1; i++)
        { 
            if (arr[i] == 0)
            {
                Console.WriteLine("{0}", arr[i]);
            }
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == 0)
                {
                    Console.WriteLine("{0}, {1}", arr[i], arr[j]);
                }
                for (int k = j+1 ; k < arr.Length; k++)
                {
                    if (arr[i] + arr[j] + arr[k] == 0)
                    {
                        Console.WriteLine("{0}, {1}, {2}", arr[i], arr[j], arr[k]);
                    }
                    for (int m = k+1; m < arr.Length; m++)
                    {
                        if (arr[i] + arr[j] + arr[k] + arr[m] == 0)
                        {
                            Console.WriteLine("{0}, {1}, {2}, {3}", arr[i], arr[j], arr[k], arr[m]);
                        }
                    }
                }
            }
        }
    }
}
