using System;

class QuadraticEquationSolution
    {
        static void Main()
        {
            Console.Write("Quadratic equation solution:\r\nEnter \'a\':");
            string a = Console.ReadLine();
            double aNum = double.Parse(a);
            Console.Write("Enter \'b\':");
            string b = Console.ReadLine();
            double bNum = double.Parse(b);
            Console.Write("Enter \'c\':");
            string c = Console.ReadLine();
            double cNum = double.Parse(c);
            double x1 = (-bNum + Math.Sqrt(Math.Pow(bNum, 2) - 4 * aNum * cNum)) / (2 * aNum);
            double x2 = (-bNum - Math.Sqrt(Math.Pow(bNum, 2) - 4 * aNum * cNum)) / (2 * aNum);
            Console.WriteLine("The roots of the equation: {0}x^2 + {1}x + {2} = 0 are:\r\nx1 = {3} and x2 = {4}", a, b, c, x1, x2);

        }
    }
}
