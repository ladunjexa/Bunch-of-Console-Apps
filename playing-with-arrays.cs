using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 8, 8, 8, 12, 24, 7, 7, 6 }, b = { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0, c = 0; i < (a.Length - 1); i++)
                if (a[i] == a[i + 1]) b[c++] = a[i];

            Console.Write("new Array ('b'): \n\t{ ");
            for (int i = 0; i < b.Length; i++) 
                Console.Write((b[i]) + ((i < b.Length - 1) ? (", ") : ("")));
            Console.WriteLine(" }\n");
            //
            Random rnd = new Random();
            int[,] arr = new int[42, 52];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rnd.Next(-10, 500);

            int countPL = 0, countPR = 0, max = Math.Max(arr.GetLength(0), arr.GetLength(1)), min = Math.Min(arr.GetLength(0), arr.GetLength(1));
            for (int i = 0; i < max; i++)
            {
                if (i < min)
                    countPR += PositiveRow(arr, i);
                countPL += PositiveLine(arr, i);
            }
            Console.WriteLine("countPL (Positive Lines): {0}\ncountPR (Positive Rows): {1}\n", countPL, countPR);
            //
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(0, 10);
                Console.WriteLine("num[{0}] = '{1}'", i, num[i]);
            }
            Console.WriteLine();
            //
            double[] results = { CalculateArr(num, 0), CalculateArr(num, 1), CalculateArr(num, 2), Average(num) };
            for (int i = 0; i < results.Length; i++)
                Console.WriteLine("Result {0}: {1}", (i + 1), results[i]);
            Console.WriteLine();
            //
            int n1 = 5, n2 = 7;
            DateTime t1 = DateTime.Now;
            Console.WriteLine("n1 = {0}\nn2 = {1}", n1.ToString(), n2.ToString());
            for (int i = 0; i < 10000000; i++) swap1(ref n1, ref n2); // swap2(..), swap3(..)
            Console.WriteLine("n1 = {0}\nn2 = {1}", n1.ToString(), n2.ToString());
            Console.WriteLine("It took " + (DateTime.Now - t1).TotalMilliseconds + " ms to run this code");

            DateTime t2 = DateTime.Now;
            Console.WriteLine("n1 = {0}\nn2 = {1}", n1.ToString(), n2.ToString());
            for (int i = 0; i < 10000000; i++) swap2(ref n1, ref n2); // swap2(..), swap3(..)
            Console.WriteLine("n1 = {0}\nn2 = {1}", n1.ToString(), n2.ToString());
            Console.WriteLine("It took " + (DateTime.Now - t2).TotalMilliseconds + " ms to run this code");

            DateTime t3 = DateTime.Now;
            Console.WriteLine("n1 = {0}\nn2 = {1}", n1.ToString(), n2.ToString());
            for (int i = 0; i < 10000000; i++) swap3(ref n1, ref n2); // swap2(..), swap3(..)
            Console.WriteLine("n1 = {0}\nn2 = {1}", n1.ToString(), n2.ToString());
            Console.WriteLine("It took " + (DateTime.Now - t3).TotalMilliseconds + " ms to run this code");

            // THE FASTEST FUNCTION IS: swap2 (swap1 - lowest)
            Console.ReadKey();
        }
        static void swap1(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
        static void swap2(ref int x, ref int y)
        {
            x ^= y;
            y ^= x;
            x ^= y;
        }
        static void swap3(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
        static void printSum(int minValue, int maxValue)
        {
            int sum = 0;
            for (int i = minValue; i <= maxValue; i++)
                sum += i;
            Console.WriteLine(sum);
        }
        static double Average(int[] arr)
        {
            return (double) CalculateArr(arr, 1) / arr.Length;
        }
        static double CalculateArr(int[] arr, int method = -1) // 0 - Minus, 1 - Plus, 2 - Kefel
        {
            double sum = (method == 2) ? 1 : 0;
            for (int i = 0; i < arr.Length; i++)
                sum =
                    (method == 0) ? (sum - arr[i]) : (method == 1) ? (sum + arr[i]) : (sum * arr[i]);
            return (double) sum;
        }
        static int PositiveLine(int[,] arr, int k)
        {
            int c = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                if (arr[i, k] < 0) 
                    c++;
            return (c == 0) ? 1 : 0;
        }
        static int PositiveRow(int[,] arr, int j)
        {
            int c = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                if (arr[j, i] < 0) 
                    c++;
            return (c == 0) ? 1 : 0;
        }
    }

}
