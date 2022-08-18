using System;
using System.Threading;
using System.IO;

namespace CHPro
{
    class Program
    {
        public static readonly Random _rnd = new Random();
        static string SECURITY_CODE = "CODETOCRACK";
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PasswordCracker_Base1();
        }
        static void PasswordCracker_Base1()
        {
            /*
             * PC: Base1
             */

            bool method = false;
            /*
             * Upping-Method: False
             * Random-Method: True
             */
            // Variables
            string FUNC_SECURITY_CODE = "";
            int scLen = SECURITY_CODE.Length;
            int found = 0;
            int c = 32;
            int NOS = scLen;

            printNOS(NOS);
            while (found != scLen)
            {
                char c1 = method == false ? (char)c++ : (char)_rnd.Next(32, 255 + 1);
                printNecasseryInformation(scLen, FUNC_SECURITY_CODE, c1, clear: true);
                Console.Write(FUNC_SECURITY_CODE + c1);
                printNOS(NOS - 1);
                if (SECURITY_CODE[found] == c1)
                {
                    found++;
                    NOS--;
                    printNecasseryInformation(scLen, FUNC_SECURITY_CODE, c1, clear: true);
                    Console.Write(FUNC_SECURITY_CODE + c1);
                    printNOS(NOS, '_');
                    FUNC_SECURITY_CODE += c1;
                    Thread.Sleep(100);
                    c = 32;
                }
            }
            Console.Clear();
            Console.WriteLine("The SYSTEM cracked the security-password sucessfully. \nthe S-C is: {'" + FUNC_SECURITY_CODE + "'}.\nACTION COMPLETED.");
            Console.ReadKey();
        }

        // Sub-Functions:
        static void printNOS(int amount, char s = '_')
        { for (int i = 0; i < amount; i++) Console.Write(s); }
        static void printNecasseryInformation(int SECURITY_CODE_LENGTH, string FUNC_SECURITY_CODE, char CURRENTLY_CHAR, bool clear = false)
        { if (clear == true) Console.Clear(); Console.WriteLine("Neccassery Information:\nSecurity-Code Length: {0}\nFunc: Security-Code = '{1}' (Remained {2} characters to cracking) \nCurrently Char: '{3}'\n\n", SECURITY_CODE_LENGTH, FUNC_SECURITY_CODE, (SECURITY_CODE_LENGTH - FUNC_SECURITY_CODE.Length), CURRENTLY_CHAR); }
    }
}
