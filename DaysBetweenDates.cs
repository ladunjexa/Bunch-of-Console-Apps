using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two date (Format dd.mm.yy)");
            Console.Write("Date 1 -> ");
            DateTime toDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Date 2 -> ");
            DateTime fromDate = DateTime.Parse(Console.ReadLine());

            int difference =
                Math.Abs((toDate - fromDate).Days),
                totalDays = difference;

            int years = difference / 365;
            difference %= 365;
            int months = difference / DateTime.DaysInMonth(toDate.Year, toDate.Month);
            difference %= 30;
            int weeks = difference / 7;
            difference %= 7;

            Console.WriteLine(
                "\nDifference\n{0} years, {1} months, {2} weeks, {3} days\n\nTotal days: {4}",
                years, months, weeks, difference, totalDays);
            Console.ReadKey();
        }
    }
}
