using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace oop19
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 1
            int x = ReadInt("Type a number: ");
            int y = ReadInt("Type another number: ");

            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.ReadKey();
            */

            /* Exercise 2
            LeapYear();
            LeapYear(1982, 1988);
            */

            /* Exercise 3
            Console.WriteLine(IsPalindrome("palindrome")); // fals
            Console.WriteLine(IsPalindrome("Abba")); // true
            Console.WriteLine(IsPalindrome("nurses run")); // true
            Console.WriteLine(IsPalindrome("Madam, I'm Adam")); // true
            Console.WriteLine(IsPalindrome("I saw desserts; I'd no lemons; alas, no melon. Distressed was I.")); // true
            Console.WriteLine(IsPalindrome("10 / 02 / 2001")); // true
            Console.WriteLine(IsPalindrome("'Not for Cecil ?' asks Alice Crofton.")); // true
            */

            /* Exercise 4
            FizzBuzz();
            */

            /* Exercise 5
            RandomGame();
            */

            /* Exercise 6
            RandomGameAI();
            */

            /* Exercise 7
            LoadingBarEyeRape();
            */

            /* Exercise 8
            CrissmasTree();
            CrissmasTree2();
            */

            /* Exercise 9
            IsLand();
            */

            /* Exercise 10
            SpaceInvader();
            */

            /* Exercise 11 (p)
            Console.WriteLine(CalculateString("1+2 * 3"));
            Console.WriteLine(CalculateString("9/3/3"));
            Console.WriteLine(CalculateString("4 - 50 * 3 + 200 + 18 / 4"));
            */

            /* Exercise 12 (p)
            
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
            */

            Console.ReadKey();
        }

        //Exercise 1
        static int ReadInt(String text)
        {
            Console.WriteLine(text);
            string inputText = Console.ReadLine();
            int input;

            while (!int.TryParse(inputText, out input))
            {
                Console.WriteLine("Input not a number, try agine");
                Console.WriteLine(text);
                inputText = Console.ReadLine();
            }

            input = int.Parse(inputText);
            return input;
        }

        //Exercise 2
        static void LeapYear()
        {
            int inputYearStart = 0;
            int inputYearEnd = 9999;
            bool inputBAD = true;

            //Get input, cheek if ok
            Console.WriteLine("-- Amazing Leap Year Calculator 2019 --");

            //Input 1
            while (inputBAD)
            {

                inputYearStart = ReadInt("First year:");

                if (inputYearStart < 0 || inputYearStart > 9999)
                {
                    Console.WriteLine("Year must be between 0 and 9999.");
                }
                else
                {
                    inputBAD = false;
                }
            }

            //Input 2
            inputBAD = true;
            while (inputBAD)
            {
                inputYearEnd = ReadInt("Secound year:");

                if (inputYearEnd < inputYearStart || inputYearEnd > 9999)
                {
                    Console.WriteLine("Year must be between " + inputYearStart + " and 9999.");
                }
                else
                {
                    inputBAD = false;
                }
            }

            //Date times
            Console.WriteLine();
            for (int yearStart = inputYearStart; yearStart <= inputYearEnd; yearStart++)
            {
                if (DateTime.IsLeapYear(yearStart))
                {
                    Console.WriteLine(yearStart + "*");
                }
                else
                {
                    Console.WriteLine(yearStart + "");
                }
            }
        }
        static void LeapYear(int inputYearStart, int inputYearEnd)
        {
            Console.WriteLine("-- Amazing Leap Year Calculator 2019 --");
            Console.WriteLine();

            for (int yearStart = inputYearStart; yearStart <= inputYearEnd; yearStart++)
            {
                if (DateTime.IsLeapYear(yearStart))
                {
                    Console.WriteLine(yearStart + "*");
                }
                else
                {
                    Console.WriteLine(yearStart + "");
                }
            }
        }

        //Exercise 3
        static bool IsPalindrome(string text)
        {
            text = text.ToLower();
            text = text.Replace(" ", String.Empty);
            text = Regex.Replace(text, "[^a-zA-Z0-9]", "");
            return text.SequenceEqual(text.Reverse());
        }

        //Exercise 4
        static void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Exercise 5
        static void RandomGame()
        {
            var random = new Random();
            var number = random.Next(1, 11);
            bool win = false;

            //--//
            while (!win)
            {
                Console.WriteLine("Guess a number between 1-10: ");
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

        //Exercise 6
        static void RandomGameAI()
        {
            int lowInt = 1;
            int higInt = 101;

            var random = new Random();
            var number = random.Next(lowInt, higInt);

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
                gussComputer = random.Next(lowInt, higInt);

                Console.WriteLine("The computers guess is: " + gussComputer);
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

        //Exercise 7
        static void LoadingBarEyeRape()
        {
            var height = Console.WindowHeight;
            var width = Console.WindowWidth;
            int time = 50;
            int loop = 0;

            while (loop < time)
            {
                var random = new Random();
                var color = random.Next(8, 16);   // 16 is exclusive

                for (int i = 0; i < width; i++)
                {
                    Console.BackgroundColor = (ConsoleColor)color;
                    Console.Write(" ");   // draw a box in some random color
                }
                loop++;
            }
        }

        //Exercise 8
        static void CrissmasTree()
        {
            Console.WriteLine("Your getting a crissmas tree, how high do you whant it?");
            int number, i, row, count = 1;

            number = int.Parse(Console.ReadLine());
            count = number - 1;

            //Tree
            for (row = 1; row <= number; row++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;

                for (i = 1; i <= 2 * row - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Foot
            for (i = 1; i <= number - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("[ ]");
        }
        static void CrissmasTree2()
        {
            Console.WriteLine("Your getting a crissmas tree, how high do you whant it?");
            int number = int.Parse(Console.ReadLine());

            //Tree
            for (int row = 0; row < number; row++)
            {
                Console.Write(new string(' ', number - row));
                Console.Write(new string('*', row * 2 + 1));
                Console.WriteLine();
            }

            //Foot
            Console.Write(new string(' ', number - 1));
            Console.Write("[ ]");
        }

        //Exercise 9
        static void IsLand()
        {
            int landCount = 0;
            // String[] is almost a jagged array of char[][]
            string[] lines = System.IO.File.ReadAllLines(
                @"C:\Users\Madelen\Documents\Visual Studio 2017\Projects\oop19\oop19\files_extern\map.txt");

            Console.WriteLine("Contents of file: ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                foreach (var letter in line)
                {
                    if (letter == '#')
                    {
                        landCount++;
                    }
                }
            }
            Console.WriteLine("Number of land tiles in map: " + landCount);
        }

        //Exercise 10
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

            while (true) {
                var random = new Random();

                for (int r = 0; r < 10; r++) {
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

                for (int l = 0; l < 10; l++) {
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

        //Exercise 11
        static float CalculateString(string formula)
        {
            var splitAdd = formula.LastIndexOf('+');
            var splitSub = formula.LastIndexOf('-');
            var splitMult = formula.LastIndexOf('*');
            var splitDiv = formula.LastIndexOf('/');

            if (splitAdd > 0)
            {
                string string1 = formula.Substring(0, splitAdd);
                string string2 = formula.Substring(splitAdd + 1);

                //Console.WriteLine(string1 + " : " + string2);
                return Plus(string1, string2);
            }

            if (splitSub > 0)
            {
                string string1 = formula.Substring(0, splitSub);
                string string2 = formula.Substring(splitSub + 1);

                //Console.WriteLine(string1 + " : " + string2);
                return Minus(string1, string2);
            }

            if (splitMult > 0)
            {
                string string1 = formula.Substring(0, splitMult);
                string string2 = formula.Substring(splitMult + 1);

                //Console.WriteLine(string1 + " : " + string2);
                return Multi(string1, string2);
            }

            if (splitDiv > 0)
            {
                string string1 = formula.Substring(0, splitDiv);
                string string2 = formula.Substring(splitDiv + 1);

                //Console.WriteLine(string1 + " : " + string2);
                return Divide(string1, string2);
            }

            return float.Parse(formula);
        }

        static float Plus(string in_a, string in_b) {
            float ut_a = CalculateString(in_a);
            float ut_b = CalculateString(in_b);

            return ut_a + ut_b;
        }
        static float Minus(string in_a, string in_b)
        {
            float ut_a = CalculateString(in_a);
            float ut_b = CalculateString(in_b);

            return ut_a - ut_b;
        }
        static float Multi(string in_a, string in_b)
        {
            float ut_a = CalculateString(in_a);
            float ut_b = CalculateString(in_b);

            return ut_a * ut_b;
        }
        static float Divide(string in_a, string in_b)
        {
            float ut_a = CalculateString(in_a);
            float ut_b = CalculateString(in_b);

            return ut_a / ut_b;
        }

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
