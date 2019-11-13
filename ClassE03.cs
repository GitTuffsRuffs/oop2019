using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace oop19
{
    public class ClassE03
    {
        public ClassE03()
        {
            Console.WriteLine("palindrome : " + IsPalindrome("palindrome")); // fals
            Console.WriteLine("Abba : " + IsPalindrome("Abba")); // true
            Console.WriteLine("nurses run : " + IsPalindrome("nurses run")); // true
            Console.WriteLine("Madam, I'm Adam : "+ IsPalindrome("Madam, I'm Adam")); // true
            Console.WriteLine("I saw desserts; I'd no lemons; alas, no melon. Distressed was I. : " + IsPalindrome("I saw desserts; I'd no lemons; alas, no melon. Distressed was I.")); // true
            Console.WriteLine("10 / 02 / 2001 : " + IsPalindrome("10 / 02 / 2001")); // true
            Console.WriteLine("'Not for Cecil ?' asks Alice Crofton. : " + IsPalindrome("'Not for Cecil ?' asks Alice Crofton.")); // true
        }

        //Exercise 3
        static bool IsPalindrome(string text)
        {
            text = text.ToLower();
            text = text.Replace(" ", String.Empty);
            text = Regex.Replace(text, "[^a-zA-Z0-9]", "");
            return text.SequenceEqual(text.Reverse());
        }
    }
}
