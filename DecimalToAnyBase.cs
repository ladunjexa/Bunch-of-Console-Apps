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
            /*// 1 2 4 8 16 32 64 128 256 512 1024
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = Convert.ToInt32(Math.Pow(2, i));
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int value = 92;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("The binary value is: " + binary);
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
            string[] bases = {"Binary", "Ternary", "Quintal", "Octal", "Decimal", "Hexadecimal"};
            Console.Write("Base: ");
            int iBase = int.Parse(Console.ReadLine());
            string nBase = (iBase == 2) ? ("Binary") : (iBase == 8) ? ("Octal") : (iBase == 16) ? ("Hexadecimal") : ("Unknown base.");
            Console.Write("Decimal: ");
            int iNumber = int.Parse(Console.ReadLine());
            string result = DecimalToAnyBase(iNumber, iBase);
            Console.WriteLine("{0}: {1}", nBase, result);*/
            /*string[] bases = { "Binary", "Ternary", "Quintal", "Octal", "Decimal", "Duodecimal", "Hexadecimal" };*/
            Console.Write("Base: ");
            int baseValue = int.Parse(Console.ReadLine());
            string baseName =
                (baseValue == 2) ? ("Binary") : 
                (baseValue == 3) ? ("Ternary") : 
                (baseValue == 5) ? ("Quintal") : 
                (baseValue == 8) ? ("Octal") : 
                (baseValue == 10) ? ("Decimal") : 
                (baseValue == 12) ? ("Duodecimal") : 
                (baseValue == 16)? ("Hexadecimal") : 
                ("Base-" + baseValue);
            Console.Write("Decimal: ");
            int decimalValue = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}: {1}", baseName, DecimalToAnyBase(decimalValue, baseValue));
            Console.WriteLine();
            Console.ReadKey();
        }
        public static string DecimalToAnyBase(int decimalNumber, int nBase)
        {
            if (nBase == 10) return Convert.ToString(decimalNumber);
            string result = string.Empty;
            if (nBase == 2 || nBase == 8 || nBase == 16)
            {
                result = Convert.ToString(decimalNumber, nBase);
                return result;
            }



            int remainder;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % nBase;
                decimalNumber /= nBase;
                result = remainder.ToString() + result;
            }
            return result;
        }
    }
}
