using System;
using System.Collections.Generic;
using System.Text;

namespace oop19
{
    public class ClassE11
    {
        public ClassE11()
        {
            Console.WriteLine("1+2 * 3 = " + CalculateString("1+2 * 3"));
            Console.WriteLine("9/3/3 = " + CalculateString("9/3/3"));
            Console.WriteLine("4 - 50 * 3 + 200 + 18 / 4 = " + CalculateString("4 - 50 * 3 + 200 + 18 / 4"));
        }

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

        static float Plus(string in_a, string in_b)
        {
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
    }
}
