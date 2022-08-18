using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FoundNumber
{
    class Program
    {
        private static readonly Random _rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine
                ("Please enter the type of method you want\n\tPress 1 to selection mode\n\tPress 2 to automatically-testing mode\nEnjoy. (Developed by T3D)");
            if (Console.ReadLine()[0] == '1') methodSelection();
            else methodTesting();
        }
        static void methodSelection()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t----------------------------\n\t\t\tNumber-Counter Application\n\t\t\t\tSelection Mode\n\t\t\t----------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.Green;

            int maxNumber = 100, minNumber = 1;
            int educatedGuess = (maxNumber / 2);
            bool e = false;
            int i = 0;

            while (e != true)
            {
                i++;
                Console.WriteLine("The educated guess is: {0}\n\t (L)ess / (M)ore / (E)xactly?", educatedGuess);
                switch (Console.ReadLine()[0])
                {
                    case 'E':
                        {
                            Console.WriteLine("Exactly");
                            e = true;
                            break;
                        }
                    case 'L':
                        {
                            Console.WriteLine("Less");
                            maxNumber = educatedGuess;
                            educatedGuess -= ((educatedGuess - minNumber) / 2) - 2; break;
                        }
                    case 'M':
                        {
                            Console.WriteLine("More");
                            minNumber = educatedGuess;
                            educatedGuess += ((maxNumber - educatedGuess) / 2) + 1; break;
                        }
                }
            }
        }
        static void methodTesting()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t----------------------------\n\t\t\tNumber-Counter Application\n\t\t\t\tTesting Mode\n\t\t\t----------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\nPlease enter number (radius: 2 - 100)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe number choosed is:\n\t" + n);

            int maxNumber = 100, minNumber = 1;
            int educatedGuess = (maxNumber / 2);
            bool e = false;
            int i = 0;

            while (e != true)
            {
                i++;
                Console.WriteLine("The educated guess is: {0}", educatedGuess);
                if (n == educatedGuess)
                {
                    Console.WriteLine("Exactly");
                    e = true;
                }
                else if (n < educatedGuess) // Down
                {
                    Console.WriteLine("Less");
                    maxNumber = educatedGuess;
                    educatedGuess -= ((educatedGuess - minNumber) / 2) - 1;
                    educatedGuess -= 1;
                }
                else if (n > educatedGuess)
                {
                    Console.WriteLine("More");
                    minNumber = educatedGuess;
                    educatedGuess += ((maxNumber - educatedGuess) / 2) + 1;
                    educatedGuess += 1;

                }
            }
            Console.ReadKey();
        }
    }
}
