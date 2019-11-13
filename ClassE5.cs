using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE5
    {
        public ClassE5()
        {
            RandomGame();
        }

        static void RandomGame()
        {
            var random = new Random();
            var number = random.Next(1, 101);
            bool win = false;

            //--//
            while (!win)
            {
                Console.WriteLine("Guess a number between 1-100: ");
                int guss;

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

                if (guss == number)
                {
                    Console.WriteLine("You win!");
                    win = true;
                }
                else if (guss > number)
                {
                    Console.WriteLine("too high");
                    continue;
                }
                else if (guss < number)
                {
                    Console.WriteLine("too low");
                    continue;
                }
            }
        }
    }
}
