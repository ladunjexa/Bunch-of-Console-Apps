using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RandomValues
{
    class Program
    {
        public static readonly Random rnd = new Random();
        static string _char_set_ = "";

        const int NUMBER_OF_SEARCH = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("There are 3 questions, please answer Y(es), otherwise any-key: ");
            Console.Write("\t1. There is symbols in the string? -> ");
            _char_set_ += (Console.ReadLine().ToUpper()[0] == 'Y') ? ("!@#$%^&*()_+=-/[]\';/.,{}|:<>?") : ("");
            Console.Write("\t2. There is letters in the string? -> ");
            _char_set_ += (Console.ReadLine().ToUpper()[0] == 'Y') ? ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ") : ("");
            Console.Write("\t3. There is numbers in the string? -> ");
            _char_set_ += (Console.ReadLine().ToUpper()[0] == 'Y') ? ("0123456789") : ("");

            Console.WriteLine("\nThe 'charset' is:\n\t" + _char_set_);
            Thread.Sleep(2000);

            Console.Clear();

            string[] randomGenerated = new string[(int)Math.Pow(NUMBER_OF_SEARCH, 4)];
            for (int i = 0; i < randomGenerated.Length; i++)
                randomGenerated[i] = RND_Generator(4);
            Console.WriteLine("Array: 'randomGenerated' Have been created sucessfully.");
            int r = 0, 
                numOfFlags = 0;
            string[] STR_ARR = new string[NUMBER_OF_SEARCH];
            int[] RUN_ARR = new int[NUMBER_OF_SEARCH];
            while (numOfFlags < NUMBER_OF_SEARCH)
            {
                string x = RND_Generator(4);
                if ((++r) % 10 == 0) Console.WriteLine(r + " runs");
                for (int k = 0; k < randomGenerated.Length; k++)
                {
                    if (x.ToUpper().Equals(randomGenerated[k].ToUpper()))
                    {
                        STR_ARR[numOfFlags] = x; 
                        RUN_ARR[numOfFlags] = r;
                        numOfFlags++;
                        randomGenerated[k] = "NaN";
                    }
                }
            }
            for (int i = 0; i < STR_ARR.Length; i++)
                Console.Write("\n{0} ( {1} runs )", STR_ARR[i], RUN_ARR[i]);

            if (r % 10 == 0)
                Console.WriteLine("\ntotal runs: " + r);
            else
                Console.WriteLine("\ntotal runs: {0} ({1})", r - (r % 10), r);
            Console.ReadKey();
        }
        static string RND_Generator(int cells)
        {
            char[] newString = new char[cells + 1];
            for (int i = 0; i < cells; i++)
            {
                newString[i] += _char_set_[rnd.Next((_char_set_.Length) - 1)];
            }
            return new string(newString);
        }
    }
}
