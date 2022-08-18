using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please enter number of players in 'Maccabi TLV' -> ");
            int numOfPlayers = int.Parse(Console.ReadLine()),
                max = 0,
                id = -1,
                x = -1,
                y = -1;
            int[] shirts = new int[numOfPlayers];
            Console.WriteLine();
            for (int i = 1; i <= numOfPlayers; i++)
            {
            chooseID:
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter ID of player " + i);
                    x = int.Parse(Console.ReadLine());
                    foreach (int j in shirts)
                    {
                        if (x == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Error: ");
                            goto chooseID;
                        }
                    }

                    shirts[i - 1] = x;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please enter the shots-number of " + x);
                y = int.Parse(Console.ReadLine());
                if (max < y)
                { max = y; id = x; }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The best player is {0}, with {1} shots!\n", id, max);
            for (int i = 0; i < shirts.Length; i++)
                Console.WriteLine(shirts[i]);

            Console.ReadKey();
        }
    }
}
