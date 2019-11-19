using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE02
    {
        public ClassE02()
        {
            LeapYear();
        }

        public ClassE02(int year1, int year2)
        {
            LeapYear(year1, year2);
        }

        static void LeapYear()
        {
            int inputYearStart = 0;
            int inputYearEnd = 9999;

            //Get input, cheek if ok
            Console.WriteLine("-- Amazing Leap Year Calculator 2019 --");

            //Input 1
            while (true)
            {
                inputYearStart = ClassE01.ReadInt("First year:");

                if (inputYearStart < 0 || inputYearStart > 9999)
                {
                    Console.WriteLine("Year must be between 0 and 9999.");
                }
                else
                {
                    break;
                }
            }

            //Input 2
            while (true)
            {
                inputYearEnd = ClassE01.ReadInt("Secound year:");

                if (inputYearEnd < inputYearStart || inputYearEnd > 9999)
                {
                    Console.WriteLine("Year must be between " + inputYearStart + " and 9999.");
                }
                else
                {
                    break;
                }
            }

            //Date times
            Console.WriteLine();
            for (int year = inputYearStart; year <= inputYearEnd; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine(year + "*");
                }
                else
                {
                    Console.WriteLine(year + "");
                }
            }
        }

        static void LeapYear(int inputYearStart, int inputYearEnd)
        {
            Console.WriteLine("-- Amazing Leap Year Calculator 2019 --");
            Console.WriteLine();

            for (int year = inputYearStart; year <= inputYearEnd; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine(year + "*");
                }
                else
                {
                    Console.WriteLine(year + "");
                }
            }
        }
    }
}
