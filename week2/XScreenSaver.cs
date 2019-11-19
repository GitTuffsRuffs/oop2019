using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace oop19
{
    class XScreenSaver
    {
        Random rand = new Random();
        
        public void StartScrensaver()
        {
            Console.Clear();
            
            //Run scrensaver
            while (!Console.KeyAvailable)
            {
                var width = Console.WindowWidth;
                var height = Console.WindowHeight;

                //Random a box
                var color = (ConsoleColor)rand.Next(1, 16);

                //Generare boxH, boxW               
                var boxWidth = rand.Next(0, width);
                var boxHeight = rand.Next(0, height);

                //Generate w_x, w_y
                var positionX = rand.Next(0, width - boxWidth);
                var positionY = rand.Next(0, height - boxHeight);

                //Draw box
                Box newBox = new Box(positionX, positionY, boxWidth, boxHeight, color);
                newBox.Draw();
                Thread.Sleep(200);
            }
        }





    }
}
