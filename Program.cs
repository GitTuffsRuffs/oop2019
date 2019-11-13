using System;
using System.Collections.Generic;
using System.Linq;

namespace oop19
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                switch (ClassE1.ReadInt("Pick Exercise 1-13, 0 to exit."))
                {
                    //Exercise 1
                    case 1:
                        ClassE1 exersise1 = new ClassE1();
                        break;

                    case 2:
                        ClassE2 exersise2 = new ClassE2();
                        break;

                    case 3:
                        ClassE3 exersise3 = new ClassE3();
                        break;

                    case 4:
                        ClassE4 exersise4 = new ClassE4();
                        break;

                    case 5:
                        ClassE5 exersise5 = new ClassE5();
                        break;

                    case 6:
                        ClassE6 exersise6 = new ClassE6();
                        break;

                    case 7:
                        ClassE7 exersise7 = new ClassE7();
                        break;

                    case 8:
                        ClassE8 exersise8 = new ClassE8();
                        break;

                    case 9:
                        ClassE9 exersise9 = new ClassE9();
                        break;

                    case 10:
                        ClassE10 exersise10 = new ClassE10();
                        break;

                    case 11:
                        ClassE11 exersise11 = new ClassE11();
                        break;

                    case 12:
                        break;

                    case 13:
                        ClassE13 exersise13 = new ClassE13(7);

                        int l = 0;
                        int pice;

                        while(l <= 10)
                        {
                            for(int i = 0; i < 7; i++) { 
                                pice = exersise13.GenerateNewPice();
                                Console.Write(pice);
                            }
                            Console.WriteLine();
                            l++;
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Number not in list.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
            /*
            
            // Exercise 12 (p)
            var block = new int[,] {
                { 0, 0, 0 },
                { 1, 1, 1 },
                { 0, 1, 0 },
            };

            PrintBlock(block);
  
            Console.WriteLine();
            block = RotateRight(block);
            PrintBlock(block);

            Console.WriteLine();
            block = RotateRight(block);
            PrintBlock(block);

            Console.WriteLine();
            block = RotateRight(block);
            PrintBlock(block);

            Console.WriteLine();
            block = RotateRight(block);
            PrintBlock(block);
            //
            */

            Console.ReadKey();
        }


        //---------Not done, fixe matris size----------//

        //Exercise 12
        static int[,] RotateRight(int[,] block)
        {
            int[,] y = new int[3,3];
            int[,] x = block;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    y[i,j] = x[2 - j, i];
                }
            }

            return y;
        }
        static int[,] RotateLeft(int[,] block)
        {
            int[,] y = new int[3, 3];
            int[,] x = block;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    y[i, j] = x[j, 2 - i];
                }
            }

            return y;
        }
        static void PrintBlock(int[,] block)
        {
            //--Print--//
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.Write(block[a, b]);
                }
                Console.WriteLine();
            }
        }

    }
}
