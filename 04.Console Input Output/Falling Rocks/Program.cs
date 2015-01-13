using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class FallingRocks
{
    static void SetFieldSize()
    {
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 40;
    }
    static void PrintOnPosition(int x, int y, char symbol, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(symbol);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }
    struct Unit
    {
        public int x;
        public int y;
        public char symbol;
        public ConsoleColor color;
    }

    static void Main()
    {
        SetFieldSize();
        Random randomGen = new Random();
        char[] rocks = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        List<Unit> RocksList = new List<Unit>();
        int livesCount = 1;
        int score = 0;

        //Create dwarf
        Unit dwarf = new Unit();
        dwarf.x = (Console.WindowWidth / 2) - 1;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.symbol = '@';
        dwarf.color = ConsoleColor.White;
        
        while (true)
        {
            bool hitted = false;

            //Spawn rock
            Unit createRock = new Unit();
            createRock.x = randomGen.Next(0, Console.WindowWidth - 2);
            createRock.y = 5;
            createRock.symbol = rocks[randomGen.Next(0, 9)];
            createRock.color = (ConsoleColor)randomGen.Next(0, 16);
            RocksList.Add(createRock);

            //Move dwarf
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x > 0)
                    {
                        dwarf.x --;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x < Console.WindowWidth - 2)
                    {
                        dwarf.x ++;
                    }
                }
            }

            //Move rocks
            List<Unit> newList = new List<Unit>();
            for (int i = 0; i < RocksList.Count; i++)
            {
                Unit oldRock = RocksList[i];
                Unit newRock = new Unit();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.symbol = oldRock.symbol;
                newRock.color = oldRock.color;

                if ((newRock.x == dwarf.x) && (newRock.y == dwarf.y))
                {
                    livesCount--;
                    hitted = true;
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(2,2, "GAME OVER!", ConsoleColor.DarkRed);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
                else
                {
                    score++;
                }
            }
            RocksList = newList;

            //Clear all
            Console.Clear();

            //Draw dwarf
            if (hitted)
            {
                RocksList.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);
            }

            //Draw rocks
            foreach (Unit rock in RocksList)
            {
                PrintOnPosition(rock.x, rock.y, rock.symbol, rock.color);
            }

            //Print score and lives
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                PrintOnPosition(i, 5, '-', ConsoleColor.Gray);
            }
            PrintStringOnPosition(15, 2, "Lives: " + livesCount, ConsoleColor.Green);
            PrintStringOnPosition(15, 3, "Score: " + score, ConsoleColor.Green);

            //Game speed
            Thread.Sleep(150);
        }
    }
}

