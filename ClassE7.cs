using System;

namespace oop19
{
    public class ClassE7
    {
        public ClassE7()
        {
            LoadingBarEyeRape();
        }

        static void LoadingBarEyeRape()
        {
            var width = Console.WindowWidth;

            //Loop until keep presst
            while (!Console.KeyAvailable)
            {
                var random = new Random();
                var color = random.Next(8, 16);   // 16 is exclusive
                Console.BackgroundColor = (ConsoleColor)color;

                var repeated = new string(' ', Console.BufferWidth-1);
                Console.WriteLine(repeated);
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
