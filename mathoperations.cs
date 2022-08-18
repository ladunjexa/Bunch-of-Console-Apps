using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3DChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("Task 1:\n");
            printEvenNumbers();

            // Task 2
            Console.WriteLine("Task 2:\n");
            int[] 
                arr = {-90, 25, 12, -1, -4, 90, 23, 40, 452, -4, 23};
            int 
                j = arr.Length, 
                    negative = 0
                ;
            // a, b
            for(int i = 0; i < j; i++)
            {
                 if(arr[i] < 0)
                     negative++;
            }
            Console.WriteLine("Negative numbers in array 'arr': {0}\nPositive numbers in array 'arr': {1}", negative, (j - negative));
            // c
            int
                countRepeat = 0;
            for (int i = 0; i < j; i++)
            {
                for (int k = 0; k < j; k++)
                {
                    if (i == k) continue;
                    if (arr[i] == arr[k])
                        countRepeat++;
                }
            }
            Console.WriteLine("There are {0} repeatative elements in array 'arr'.", countRepeat);

            // Task 3
            Console.WriteLine("Task 3:\n");
            Console.WriteLine(Math.Pow(5, 3));
            int value = 2;
            for (int power = 0; power <= 32; power++)
                Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})",
                                  value, power, (long)Math.Pow(value, power));
            Console.WriteLine(Mathpower(5, 3));

            // Task 4
            Console.WriteLine("Task 4:\n");
            string
                arrStr = "דיון האתגרים - חשיבה מחוץ לקופסא";
            int
                index = -1,
                    nLength = 0
            ;
            char tempChar = ' ';
            while(++index < arrStr.Length)
            {
                tempChar = arrStr[index];
                if (tempChar != ' ')
                    nLength++;
            }
            Console.WriteLine("Length: " + nLength);

            // Task 5
            Console.WriteLine("Task 5:\n");
            index = 0;
            while(index++ < 200)
            {
                if(index % 2 != 0)
                    Console.Write(index + " ");
            }

            // Task 6
            Console.WriteLine("Task 6:\n");
            char[,] arr2D =
            {
                {'2', '3', '4'},
                {'4', '5', '6'},
                {'6', '7', '8'},
                {'a', 'b', 'c'}
            };
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0} {1} {2}", arr2D[i, 0], arr2D[i, 1], arr2D[i, 2]);
            }

            // Task 7
            Console.WriteLine("Task 7:\n");
            CalculateDaysToRelase();

            // Task 8
            Console.WriteLine("Task 8:\n");
            for (int i = 0; i <= 1000; i++)
            {
                if (isFastNum(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            // Count number of digits
            Console.WriteLine("Task 9 (CNOD):\n");
            Console.WriteLine("{0}, {1}, {2}",
                CountNumberOfDigits(71231235), CountNumberOfDigits_UsingLog(612312), CountNumberOfDigits(123));

            int nPressed = 0;
            while (nPressed != -1)
            {
                Console.Write("\nPress a number (-1 to exit): ");
                nPressed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The reverse number of '{0}' is: {1}", nPressed, reverseNumber(nPressed));
            }
            /*
             * Console.ReadKey();
             */
            
        }
        static int reverseNumber(int number)
        {
            if (number < 10) return number; // same value.
            int
                result = 0,
                    nSize = CountNumberOfDigits_UsingLog(number)
            ;
            for (int i = 0; i < nSize; i++)
                { result *= 10; result += number % 10; number = number / 10; }
            return result;
        }
        static int CountNumberOfDigits_UsingLog(int number)
        {
            return (int)(Math.Log10((double)number) + 1);
        }
        static int CountNumberOfDigits(int number)
        {
            int numdgits = 0;
            do
            {
                number = number / 10;
                numdgits++;
            } while (number > 0);
            return numdgits;
        }
        public static bool isFastNum(int num)
        {
            return (((num % 10) < ((num / 10) % 10)) && (((num / 10) % 10) < ((num / 100) % 10))) ? true : false;
        }
        public static void CalculateDaysToRelase()
        {
            const string
                strDaysToRelease = "||||||||||||||||";
            int
                nLen = strDaysToRelease.Length;
            
            Console.WriteLine("Criminals Days To Release:\n\tCriminal A: {0}\n\tCriminal B: {1}\n\tCriminal C: {2}"
                , Convert.ToString(nLen, 2).PadLeft(8, '0'), Convert.ToString(((nLen * 50) / 100), 2).PadLeft(8, '0'), Convert.ToString(((nLen * 75) / 100), 2).PadLeft(8, '0'));
        }
        public static int Mathpower(int nBase, int nExponent)
        {
	        if (nBase == 0) return 0;

	        int nRes = 1;
	        if (nExponent > 0)
	        {
		        for (int i = 0; i < nExponent; i++)
			        nRes *= nBase;
	        }
            else if (nExponent < 0) nRes = Mathpower((1 / nBase), -nExponent);
	        return nRes;
        }
        public static void printEvenNumbers(int nFirst = 0, int nLast = 100)
        {
            for (int i = nFirst; i <= nLast; i++)
                if (i % 2 == 0) Console.Write(i + " ");
            // for(int i = nFirst; i <= nLast; i+= 2) Console.Write(i + " ");
        }
    }
}
