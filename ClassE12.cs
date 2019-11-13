using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE12
    {
        public ClassE12()
        {
            var block = new int[,] {
                            { 0, 0, 0, 0 },
                            { 1, 1, 1, 1 },
                            { 0, 1, 0, 1 },
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

            Console.WriteLine();
            block = RotateLeft(block);
            PrintBlock(block);

            Console.WriteLine();
            block = RotateLeft(block);
            PrintBlock(block);

            Console.WriteLine();
            block = RotateLeft(block);
            PrintBlock(block);

            Console.WriteLine();
            block = RotateLeft(block);
            PrintBlock(block);
        }

        static int[,] RotateRight(int[,] block)
        {
            var oldHeight = block.GetLength(0);
            var oldWidth = block.GetLength(1);

            var newHeight = oldWidth;
            var newWidth = oldHeight;

            int[,] rotetedBlock = new int[newHeight, newWidth];

            for (int row = 0; row < newHeight; row++)
            {
                for (int colum = 0; colum < newWidth; colum++)
                {
                    rotetedBlock[row, colum] = block[newWidth - 1 - colum, row];
                }
            }
            return rotetedBlock;
        }

        static int[,] RotateLeft(int[,] block)
        {
            var oldHeight = block.GetLength(0);
            var oldWidth = block.GetLength(1);

            var newHeight = oldWidth;
            var newWidth = oldHeight;

            int[,] rotetedBlock = new int[newHeight, newWidth];

            for (int row = 0; row < newHeight; row++)
            {
                for (int colum = 0; colum < newWidth; colum++)
                {
                    rotetedBlock[row, colum] = block[colum, newHeight - 1 - row];
                }
            }
            return rotetedBlock;
        }

        static void PrintBlock(int[,] block)
        {
            var height = block.GetLength(0);
            var width = block.GetLength(1);

            //--Print--//
            for (int a = 0; a < height; a++)
            {
                for (int b = 0; b < width; b++)
                {
                    if(block[a, b] > 0)
                    {
                        Console.Write("#");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
