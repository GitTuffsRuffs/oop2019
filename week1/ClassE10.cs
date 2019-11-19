using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE10
    {
        public ClassE10()
        {
            Console.Clear();
            SpaceInvader();
        }

        static void SpaceInvader()
        {
            var invader = new[,]
            {
                { 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
                { 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
                { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
                { 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0 }
            };

            var height = invader.GetLength(0);
            var width = invader.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (invader[i, j] == 0)
                    {
                        Console.Write("  ");
                    }
                    else if (invader[i, j] == 1)
                    {
                        Console.Write("**");
                    }
                }
                Console.WriteLine("");
            }

            while (!Console.KeyAvailable)
            {
                var random = new Random();

                for (int r = 0; r < 10 && !Console.KeyAvailable; r++)
                {
                    var rand = random.Next(1, 11);
                    if (rand == 10)
                    {
                        //Move down
                        Console.MoveBufferArea(0, 0, 60, 60, 0, 1);
                    }

                    //Move rigt
                    System.Threading.Thread.Sleep(500);
                    Console.MoveBufferArea(0, 0, 60, 60, 1, 0);
                }

                for (int l = 0; l < 10 && !Console.KeyAvailable; l++)
                {
                    var rand = random.Next(1, 11);
                    if (rand > 8)
                    {
                        //Move down
                        Console.MoveBufferArea(0, 0, 60, 60, 0, 1);
                    }

                    //Move left
                    System.Threading.Thread.Sleep(500);
                    Console.MoveBufferArea(1, 0, 60, 60, 0, 0);
                }
            }
        }
    }
}
