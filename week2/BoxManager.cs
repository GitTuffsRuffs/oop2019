using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    class BoxManager
    {
        //List all boxes
        public List<Box> boxList = new List<Box>();

        //List all boxes
        public void listAllBoxes()
        {
            foreach(var box in boxList)
            {
                Console.WriteLine(box.boxHeight + "x" + box.boxWidth);
            }
        }

        //Draw in center
        public void DrawInCenter()
        {
            var height = Console.WindowHeight;
            var width = Console.WindowWidth;

            Console.Clear();
            Console.WriteLine("H: "+height+ " : W: "+width);

            for(int i = 0; i < boxList.Count; i++)
            {
                boxList[i].startPointY = height/2 - (boxList[i].boxHeight/2);
                boxList[i].startPointX = width/2 - (boxList[i].boxWidth/2);
                boxList[i].Draw();
            }
        }       
    }
}
