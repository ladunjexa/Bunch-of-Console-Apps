using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Please enter a number -> ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "\n\tInformation about the number '{0}':\n{1}{2}{3}{4}{5}{6}",
                n,
                ternaryOperator(isPalindrome(n.ToString()), "- Palindrome\n"),
                ternaryOperator(isPrime(n), "- Prime\n"),
                ternaryOperator(n > 0, "- Positive\n", "- Negative\n"),
                ternaryOperator(sameDigits(n), "- Same Digits\n"),
                ternaryOperator(withoutRemainder(n), "- Without remainder\n", "- With remainder\n"),
                ternaryOperator(isFastNumber(n), "- Fast number\n")
            );
            Console.ReadKey();
        }
        static string ternaryOperator(bool operation, string msg1, string msg2 = "")
        {
            return operation ? (msg1) : (msg2);
        }
        static bool isFastNumber(int num)
        {
            while (num != 0)
            {
                if (((num % 10) >= ((num / 10) % 10)) && num > 9) return false;
                num /= 10;
            }
            return true;
        }
        static bool withoutRemainder(int n)
        {
            return (n % 10 == 0);
        }
        static bool sameDigits(int n)
        {
            if (n >= 1 && n <= 9) return true;
            int tempNumber = n % 10;
            while (n != 0)
            {
                if (tempNumber != (n % 10)) 
                    return false;
                n /= 10;
            }
            return true;
        }
        static bool isPalindrome(string n)
        {
            if (int.Parse(n) >= 1 && int.Parse(n) <= 9) return true;
            char[] charArray = n.ToCharArray(); // create n(string) as char array.
            char[] reverseArray = n.ToCharArray(); // create n(string)as char array to reversed.
            Array.Reverse(reverseArray); // making array.reversing for reverseArray (than the char-arrays will be compared after conversion to string)

            return (new string(charArray) == new string(reverseArray));
        }
        static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }
    }
}
