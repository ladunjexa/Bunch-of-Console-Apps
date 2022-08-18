using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UserProgram
{
    class Program
    {
        const int 
            MAX_ENCRYPTIONS = 50, 
                MAX_NAME_SIZE = 20, 
                MIN_NAME_SIZE = 7
        ;
        static string[] g_Encryptions = new string[MAX_ENCRYPTIONS];
        public static readonly Random _rng = new Random();
        public const string _chars = "AbCdEfGhIjKlMnOpQrStUvWxYz";
        static void Main(string[] args)
        {
            for (int i = 0; i < MAX_ENCRYPTIONS; i++)
            {
                // Title print.
                if (i % 10 == 0) 
                    ColoredConsoleWrite(ConsoleColor.Cyan, "\n " + i + " ENTRIES WAS PRINTED.\n");
                // Generate random encrypt
                g_Encryptions[i] = randomEncrypt(_rng.Next(MIN_NAME_SIZE, MAX_NAME_SIZE));
                // Encryption array print.
                c_writeEncryptValue(i);
                Console.WriteLine();
            }
            // Print&Change 'g_Encryption' array specific values.
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nIf you want to change value of any-cell type 'YES', otherwise type 'NO'");
            Console.ForegroundColor = ConsoleColor.White;
            if(Console.ReadLine().ToUpper().Equals("YES"))
                goto Step_setValues;
            else goto Step_endProgram;
        Step_setValues:
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n____________________ Program: Next Level ____________________");
                Console.WriteLine("Please enter a cell number to change (to stop -> 'stop') ");
                Console.ForegroundColor = ConsoleColor.White;
                string rl = Console.ReadLine();
                while (!rl.ToUpper().Equals("STOP"))
                {
                    int c = Convert.ToInt32(rl);
                    Console.WriteLine("\t\t\t----");
                    c_writeEncryptValue(c);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\ttype new value to set new value for cell '{0}'\n", c);
                    ColoredConsoleWrite(ConsoleColor.Cyan, "NEW VALUE: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string newValue = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\ng_Encryption[{0}] value successfully changed to '{1}' from '{2}'", c, newValue, g_Encryptions[c]);
                    g_Encryptions[c] = newValue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t----\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please enter a cell number to change (to stop -> 'stop') ");
                    Console.ForegroundColor = ConsoleColor.White;
                    rl = Console.ReadLine();
                }
            }
        Step_endProgram: 
            {
                Console.Clear(); 
                Console.WriteLine("what to do?"); 
            }
            Console.ReadKey();
        }
        public static void c_writeEncryptValue(int cell, bool noPrintCell = false)
        {
            ColoredConsoleWrite(ConsoleColor.White, "Encryption[");
            ColoredConsoleWrite(ConsoleColor.Blue, "{0}", cell);
            ColoredConsoleWrite(ConsoleColor.White, "]");
            ColoredConsoleWrite(ConsoleColor.Red, " = ");
            if (!noPrintCell) ColoredConsoleWrite(ConsoleColor.Green, "'{0}'", g_Encryptions[cell]);
        }
        public static void ColoredConsoleWrite(ConsoleColor color, string text, object arg0 = null)
        {
            Console.ForegroundColor = color;
            Console.Write(text, arg0);
        }
        public static string randomEncrypt(int size)
        {
            char[] buffer = new char[size];
            for (int i = 0; i < size; i++)
                buffer[i] = _chars[_rng.Next(_chars.Length)];

            return new string(buffer);
        }
    }
}
