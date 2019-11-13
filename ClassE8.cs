using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE8
    {
        public ClassE8()
        {
            //CrissmasTree();
            CrissmasTree2();
        }

        //Exercise 8
        static void CrissmasTree()
        {
            Console.WriteLine("Your getting a crissmas tree, how high do you whant it?");
            int number, i, row, count = 1;

            number = int.Parse(Console.ReadLine());
            count = number - 1;

            //Tree
            for (row = 1; row <= number; row++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;

                for (i = 1; i <= 2 * row - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Foot
            for (i = 1; i <= number - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("[ ]");
        }

        static void CrissmasTree2()
        {            
            Console.WriteLine("Your getting a crissmas tree, how high do you whant it?");
            int number = int.Parse(Console.ReadLine());

            //Tree
            for (int row = 0; row < number; row++)
            {
                Console.Write(new string(' ', number - row));
                Console.Write(new string('*', row * 2 + 1));
                Console.WriteLine();
            }

            //Foot
            Console.Write(new string(' ', number - 1));
            Console.Write("[ ]");
        }
    }
}
