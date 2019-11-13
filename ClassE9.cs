using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE9
    {
        public ClassE9()
        {
            IsLand();
        }

        static void IsLand()
        {
            int landCount = 0;
            // String[] is almost a jagged array of char[][]
            string[] lines = System.IO.File.ReadAllLines(
                @"C:\Users\Madelen\Documents\Visual Studio 2017\Projects\oop19\oop19\files_extern\map.txt");

            Console.WriteLine("Contents of file: ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                foreach (var letter in line)
                {
                    if (letter == '#')
                    {
                        landCount++;
                    }
                }
            }
            Console.WriteLine("Number of land tiles in map: " + landCount);
        }
    }
}
