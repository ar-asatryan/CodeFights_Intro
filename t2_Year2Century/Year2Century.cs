using System;

namespace t2_Year2Century
{
    class Year2Century
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert any year to get its Century:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(Year2Century.CenturyFromYear(year));
        }

        static int CenturyFromYear(int year)
        {
            if (year % 100 == 0)
            {

                return year / 100;
            }
            else
            {

                return year / 100 + 1;
            }
        }

    }
}
