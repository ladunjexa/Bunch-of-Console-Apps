using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Pythagorean triple");
            Random rnd = new Random();
            int count = 0, a = 0, b = 0, c = 0;
            for (int i = 1; i <= 100000; i++)
            {
                a = 3 * (i * 10); b = 4 * (i * 10); c = 5 * (i * 10);
                if (Pitagouras(a, b, c))
                {
                    Console.WriteLine("{0}^2 + {1}^2 = {2}^2", a, b, c);
                    count++;
                }
            }
            for (int i = 1; i <= 100000; i++)
            {
                a = 5 * (i * 10); b = 12 * (i * 10); c = 13 * (i * 10);
                if (Pitagouras(a, b, c))
                {
                    Console.WriteLine("{0}^2 + {1}^2 = {2}^2", a, b, c);
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
            Console.ReadKey();

        }
        static bool Pitagouras(double n1, double n2, double n3)
        {
            return ((Math.Pow(n1, 2)) + (Math.Pow(n2, 2)) == (Math.Pow(n3, 2))) ? true : false;
        }
    }
}
