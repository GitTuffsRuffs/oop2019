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
                switch (ClassE01.ReadInt("Pick Exercise 1-13, 0 to exit."))
                {
                    //Exercise 1
                    case 1:
                        ClassE01 exersise1 = new ClassE01();
                        break;

                    case 2:
                        ClassE02 exersise2 = new ClassE02();
                        break;

                    case 3:
                        ClassE03 exersise3 = new ClassE03();
                        break;

                    case 4:
                        ClassE04 exersise4 = new ClassE04();
                        break;

                    case 5:
                        ClassE05 exersise5 = new ClassE05();
                        break;

                    case 6:
                        ClassE06 exersise6 = new ClassE06();
                        break;

                    case 7:
                        ClassE07 exersise7 = new ClassE07();
                        break;

                    case 8:
                        ClassE08 exersise8 = new ClassE08();
                        break;

                    case 9:
                        ClassE09 exersise9 = new ClassE09();
                        break;

                    case 10:
                        ClassE10 exersise10 = new ClassE10();
                        break;

                    case 11:
                        ClassE11 exersise11 = new ClassE11();
                        break;

                    case 12:
                        ClassE12 exersise12 = new ClassE12();
                        break;

                    case 13:
                        ClassE13 exersise13 = new ClassE13(7,4);

                        int l = 0;
                        int pice;

                        while(l <= 5)
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
        }
    }
}
