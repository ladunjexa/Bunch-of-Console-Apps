using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication_Maturitytest
{
    class Program
    {
        private static readonly Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Exercise_ (1-10) ->");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1: goto Exercise_1;
                case 2: goto Exercise_2;
                case 3: goto Exercise_3;
                case 4: goto Exercise_4;
                case 5: goto Exercise_5;
                case 6: goto Exercise_6;
                case 7: goto Exercise_7;
                case 8: goto Exercise_8;
                case 9: goto Exercise_9;
                case 10: goto Exercise_10;
                default: goto Exercise_1;
            }
        Exercise_1:
            {
                int n1 = 0, n2 = 0;
                for (int i = 0; i <= 4; i++) // for(before-statement (i - iteration); condition (i <= 4); after-statement (i++))
                {
                    Console.WriteLine("Please enter two numbers -> ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        (n1 + n2) <= (n1 - n2) ? ("Hello") : ("Bye"));
                }
                goto Exercise_2;
            }
        Exercise_2:
            {
                Console.WriteLine("Please enter the number of floors in the building ->");
                Console.WriteLine("Elevator: {0}", Convert.ToInt32(Console.ReadLine()) > 3 ? ("Yes") : ("No"));
                goto Exercise_3;
            }
        Exercise_3:
            {
                int a = 10,
                    b = 5,
                    c = 15,
                    k1 = Big(a, b),
                    k2 = Big(a, c);
                Console.WriteLine((k1 == k2) ? ("yes") : ("no"));
                goto Exercise_4;
            }
        Exercise_4:
            {
                int[] arr = new int[20];
                for (int i = 0, j = arr.Length; i < j; i++)
                {
                    arr[i] = rand.Next(0, 1000);
                    Console.Write("arr:[{0},{1}]{2}", i, arr[i], ((i+1) % 5 == 0) ? ("\n") : (" "));
                }
                Console.WriteLine();
                int count = 0;
                for (int i = 0, j = arr.Length; i < j; i++)
                {
                    if (arr[i] >= 100 && arr[i] <= 450)
                        count++;
                }
                Console.WriteLine("\nAmount of elements in the array whose value is between 100 to 450:\n\t" + count);
                goto Exercise_5;
            }
        Exercise_5:
            {
                int sum = 0;
                for (int i = 1; i < 4; i++)
                {
                    sum += int.Parse(Console.ReadLine());
                    Console.WriteLine(sum > 10? ("***") : ("---"));
                }
                goto Exercise_6;
            }
        Exercise_6:
            {
                string[] arst = 
                    {"Dan", "Amud", "Yarkon", "Sorek", "Arugot"};
                string str = "streams: ";
                for(int i = 0, j = arst.Length; i < j; i++)
                {
                    if(arst[i].Length <= 4)
                        str = str + arst[i];
                }
                Console.WriteLine(str); // streams: DanAmud
                goto Exercise_7;
            }
        Exercise_7: 
                Console.WriteLine(isNumberRange(int.Parse(Console.ReadLine()), 15, 18));
                goto Exercise_7b;
        Exercise_7b:
            {
                int lAge = 0,
                    lHours = 0,
                    listenersCount = 0;
            
                for(int i = 1; i <= 492; i++)
                {
                        /*
                        * Console.WriteLine("Please enter the listener age and hour listening ->");
                        * lAge = int.Parse(Console.ReadLine());
                        * lHours = int.Parse(Console.ReadLine());
                        */
                    lAge = rand.Next(1, 30);
                    lHours = rand.Next(1, 5);
                    if(isNumberRange(lAge, 15, 18) && lHours > 3)
                        listenersCount++;
                }
                Console.WriteLine("Total Listeners: " + listenersCount);
            }
        Exercise_8:
            {
                string s_Name = "";
                int s_Calories = 0,
                    s_Fatweight = 0,
                    s_Unhealthy = 0,
                    s_Healthy = 0
                ;
                do
                {
                    Console.WriteLine("Please enter 3 data (in order):\n\t- snack name\n\t- snack calories\n\t- snack fatweight");
                    s_Name = Console.ReadLine();
                    s_Calories = int.Parse(Console.ReadLine());
                    s_Fatweight = int.Parse(Console.ReadLine());

                    if (s_Calories < 130 && s_Fatweight < 5)
                        Console.WriteLine("{0}. {1} (c: {2}, fw: {3})", s_Healthy++, s_Name, s_Calories, s_Fatweight);
                    else s_Unhealthy++;
                }
                while (s_Healthy < 10);
                Console.WriteLine("totalSnacks: " + (s_Unhealthy + s_Healthy));
                goto Exercise_9;
            }
        Exercise_9:
            {
                int[,] arr2D = 
	                {
		                //0		1	2	3	4	5
		                {45,	9,	11,	65,	5,	12},
		                {2,		4,	7,	17,	23,	67},
		                {61,	38,	24,	89,	9,	11},
		                {34,	2,	4,	89,	9,	11},
		                {65,	42,	11,9,	38,	4}
	                };
                Console.WriteLine(arrFunction(arr2D, 2, 3)); // True
                for(int i = 0; i < arr2D.GetLength(0); i++) // עמודה
                {
	                for(int j = 0; j < arr2D.GetLength(1); j++) // שורה
	                {
		                if(i != (arr2D.GetLength(0) - 1) && arr2D[i,j] == arr2D[(i+1),j])
			                Console.WriteLine("{0} ({1}, {2})", arr2D[i,j], i, j);
	                }
                }
                goto Exercise_10;
            }
        Exercise_10:
            {
                // A +B B
                int[] acts = new int[3];
                Console.WriteLine("Please enter the number of registers ->");
                int totalRegisters = int.Parse(Console.ReadLine());
                acts = actRegistrations(acts, totalRegisters, true);
                for(int i = 0; i < acts.Length; i++)
			        Console.WriteLine("acts[{0}] = {1} (rooms required: {2})", i, acts[i], allocationRooms(acts, i));
            
                // C
                Console.WriteLine("C. Please enter new number of registers ->");
                totalRegisters = int.Parse(Console.ReadLine());
                int count = 0;
                acts = actRegistrations(acts, totalRegisters, true);
                for (int i = 0; i < acts.Length; i++)
                {
                    count += allocationRooms(acts, i);
                }
                Console.WriteLine("total Rooms: " + count + "\n\n");

                int[] val = { 123, 527, 745, 7231, 7223 };
                Console.WriteLine("/// BEFORE:");
                for (int i = 0; i < val.Length; i++)
                    Console.WriteLine("val[{0}] = {1}", i, val[i]);
                val = Reverse(val);
                Console.WriteLine("/// AFTER:");
                for (int i = 0; i < val.Length; i++)
                    Console.WriteLine("val[{0}] = {1}", i, val[i]);
            }
            Console.WriteLine("You've finished the maturity test sucessfully, good job!");
            Console.ReadKey();
        }
        public static int allocationRooms(int[] arr, int actNumber) {
            return (arr[actNumber] < 40) ? 1 : 2;
        }
        // Exercise 10a
        public static int[] Reverse(int[] array)
        {
            int reversed = 0;
            for (int i = 0; i < array.Length; i++)
            {
               while(array[i] != 0)
               {
                   reversed = (reversed * 10) + array[i] % 10;
                   array[i] /= 10;
               }
               array[i] = reversed;
               reversed = 0;
            }
            return array;
        }
        public static int[] actRegistrations(int[] arr, int numOfRegisters, bool method = false)
        {
            if (!method)
            {
                Console.WriteLine("Please enter a number activity for each user ->\nActivities:\n\t0 - Drawing\n\t1 - Theatre\n\t2 - Poetry");
                for (int i = 1; i <= numOfRegisters; i++)
                {
                    Console.Write("reg({0}): ", i);
                    arr[int.Parse(Console.ReadLine())]++;
                }
            }
            else
            {
                for(int i = 1; i <= numOfRegisters; i++)
                    arr[(rand.Next(0,3))]++;
            }
            return arr;
        }
        public static bool arrFunction(int[,] arr, int k, int j)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                if (arr[i,j] == arr[i,(k + 1)])
                    return true;
            return false;
        }
        public static bool isNumberRange(int n, int minValue, int maxValue)
        {
            return (n >= minValue && n <= maxValue) ? true : false;
        }
        public static int Big(int y, int x)
        {
            return (x > y) ? x : y;
        }
    }
}
