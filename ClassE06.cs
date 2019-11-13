using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE06
    {
        public ClassE06()
        {
            RandomGameAI();
        }

        //Exercise 6
        static void RandomGameAI()
        {
            int lowInt = 1;
            int higInt = 100;

            var random = new Random();
            var number = random.Next(lowInt, higInt+1);

            int guss;
            int gussComputer;
            string clue = "";

            bool win = false;

            Console.WriteLine("Human vs super advanced AI computer. FIGHT!");

            //--//
            while (!win)
            {
                Console.WriteLine("Guess a number between " + lowInt + "-" + higInt);
                try
                {
                    guss = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not a number, try agine");
                    continue;
                }

                if (guss > 100 || guss < 1)
                {
                    Console.WriteLine("Guess is outside the number rage, guess agine.");
                    continue;
                }

                Console.WriteLine("Human guess: " + guss);
                if (guss == number)
                {
                    Console.WriteLine("Human win!");
                    win = true;
                    break;
                }
                else if (guss > number)
                {
                    if (guss < higInt)
                    {
                        higInt = guss;
                    }

                    clue = "too high";
                    Console.WriteLine(clue);
                }
                else if (guss < number)
                {
                    if (guss > lowInt)
                    {
                        lowInt = guss;
                    }

                    clue = "too low";
                    Console.WriteLine(clue);
                }

                //Computers turn
                //Random a new nember betwin higInt, lowInt
                //gussComputer = random.Next(lowInt, higInt);
                gussComputer = (lowInt + higInt) / 2;

                Console.WriteLine("Computers guess: " + gussComputer);
                if (gussComputer == number)
                {
                    Console.WriteLine("Computer wins!");
                    win = true;
                    break;
                }
                else if (gussComputer > number)
                {
                    if (gussComputer < higInt)
                    {
                        higInt = gussComputer;
                    }

                    clue = "too high";
                    Console.WriteLine(clue);
                }
                else if (gussComputer < number)
                {
                    if (gussComputer > lowInt)
                    {
                        lowInt = gussComputer;
                    }

                    clue = "too low";
                    Console.WriteLine(clue);
                }
            }
        }
    }
}
