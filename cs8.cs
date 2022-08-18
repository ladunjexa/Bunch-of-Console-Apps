using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] seriesDown = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] seriesUp = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] Negative = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] Positive = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] Even = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int[] Odd = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine();
            Console.WriteLine(
                "arr1: {0}\narr2: {1}\narr3: {2}\narr4: {3}\narr5: {4}\narr6: {5}",
                IP_Function(seriesDown), IP_Function(seriesUp), IP_Function(Negative), IP_Function(Positive), IP_Function(Even), IP_Function(Odd));
            //
            int y = 0;
            int chance = 0;
            int[] randArr = new int[10];
            for (int i = 0; i < randArr.Length; i++)
                randArr[i] = rnd.Next(-1999, 2000);
            Console.WriteLine("\narr7: " + IP_Function(randArr));
                chance = 0;
                while (chance != 10)
                {
                    for (int i = 0; i < randArr.Length; i++)
                        randArr[i] = rnd.Next(-199, 200);

                    foreach (int n in randArr)
                        Console.Write(n + " ");
                    string r = IP_Function(randArr);
                    Console.WriteLine("\narr7: " + r);
                    if (!(r.Equals("Doesn't knows")))
                        chance++;
                    y++;

                }
                Console.WriteLine("Runs: " + y);
            Console.WriteLine("\n\n");
            bool BitFlag = true;
            int j = 0;
            while(j < 4)
            {
                Console.WriteLine("Enter number (i: {0}, BitFlag: {1}) -> ", j, BoolAsNumber(BitFlag));
                int x = int.Parse(Console.ReadLine());
                if (BitFlag != false && x % 2 != 0)
                    BitFlag = false;
                j++;
            }
            Console.WriteLine("BitFlag: {0}", BitFlag ? ("true") : ("false"));
            //

            int n1 = int.Parse(Console.ReadLine()),
                n1Pos = (n1 > 0) ? 1 : 0;
            int n2 = int.Parse(Console.ReadLine()),
                n2Pos = (n2 > 0) ? 1 : 0;

            if (n1Pos != n2Pos)
                Console.WriteLine("No-same symbols");
            else
                Console.WriteLine("Same symbols");
            //
            /*
             * Console.ReadKey();
             */
            Console.ReadKey();
        }
        static string IP_Function(params int[] det)
        {
            /*
             * Check if is even number
             */
            bool BitFlag = true;
            foreach (int n in det)
            {
                if (BitFlag != false && (n % 2) != 0)
                    BitFlag = false;
            }
            if (BitFlag)
                return "Even numbers";
            /*
             * Check if is odd number
             */
            BitFlag = true;
            foreach (int n in det)
                if (BitFlag != false && (n % 2) == 0)
                    BitFlag = false;
            if (BitFlag)
                return "Odd numbers";
            /*
             * Check if is series up
             */
            BitFlag = true;
            for (int i = 1; i < det.Length; i++)
            {
                if (BitFlag != false && det[i] < det[i - 1])
                    BitFlag = false;
            }
            if (BitFlag)
                return "Series up numbers";
            /*
             * Check if is down up
             */
            BitFlag = true;
            for (int i = 1; i < det.Length; i++)
            {
                if (BitFlag != false && det[i] > det[i - 1])
                    BitFlag = false;
            }
            if (BitFlag)
                return "Series down numbers";
            /*
             * Check if is positive numbers only!
             */
            BitFlag = true;
            foreach (int n in det)
                if (BitFlag != false && n < 0)
                    BitFlag = false;
            if (BitFlag)
                return "Positive numbers";
            /*
             * Check if is negative numbers only!
             */
            BitFlag = true;
            foreach (int n in det)
                if (BitFlag != false && n > 0)
                    BitFlag = false;
            if (BitFlag)
                return "Negative numbers";

            return "Doesn't knows";
        }
        static int BoolAsNumber(bool var)
        {
            return !var ? 0 : 1;
        }
        static void startOver()
        {
            int n1Positive = 0;
            int n1 = int.Parse(Console.ReadLine());
            if (n1 > 0) n1Positive = 1;
            int n2Positive = 0;
            int n2 = int.Parse(Console.ReadLine());
            if (n2 > 0) n2Positive = 1;
            if (n2Positive != n1Positive)
                Console.WriteLine("No same symbols");
            else
                Console.WriteLine("Same symbols");

            startOver();
        }
    }
}
