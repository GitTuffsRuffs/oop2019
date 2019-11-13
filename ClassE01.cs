using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE01
    {
        public ClassE01() {
            int x = ReadInt("Type a number: ");
            int y = ReadInt("Type another number: ");

            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        //Exercise 1
        public static int ReadInt(String text)
        {
            Console.WriteLine(text);
            string inputText = Console.ReadLine();
            int input;

            while (!int.TryParse(inputText, out input))
            {
                Console.WriteLine("Input not a number, try agine");
                Console.WriteLine(text);
                inputText = Console.ReadLine();
            }

            input = int.Parse(inputText);
            return input;
        }
    }
}
