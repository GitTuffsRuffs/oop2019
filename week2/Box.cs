using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class Box
    {
        public int startPointX;
        public int startPointY;
        public int boxWidth;
        public int boxHeight;
        public ConsoleColor ForegroundColor;

        public Box()
        {
            startPointX = 0;
            startPointY = 0;
            boxWidth = 1;
            boxHeight = 1;
            ForegroundColor = ConsoleColor.White;
        }

        public Box(int startPointX,int startPointY, int boxWidth, int boxHeight, string color)
        {
            this.startPointX = startPointX;
            this.startPointY = startPointY;
            this.boxWidth = boxWidth;
            this.boxHeight = boxHeight;

            try
            {
                ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            }
            catch
            {
                ForegroundColor = ConsoleColor.White;
            }
        }

        public Box(int startPointX, int startPointY, int boxWidth, int boxHeight, ConsoleColor color)
        {
            this.startPointX = startPointX;
            this.startPointY = startPointY;
            this.boxWidth = boxWidth;
            this.boxHeight = boxHeight;
            this.ForegroundColor = color;
        }

        public void Draw()
        {
            Console.BackgroundColor = ForegroundColor;

            for (int j = 0; j < boxHeight; j++)
            {
                Console.SetCursorPosition(startPointX, startPointY + j);
                Console.Write(new string(' ', boxWidth));
                Console.WriteLine("");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
