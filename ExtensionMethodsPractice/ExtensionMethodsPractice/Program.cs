using System;
using System.Collections.Generic;

namespace ExtensionMethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " Maine merg la piata";
            string v = "word";
            decimal sum = 100m;
            Console.WriteLine(s.CheckCapitalLetter());

            Console.WriteLine(s.AppendS());
            Console.WriteLine(s.CapitalizeWord());
            Console.WriteLine(s.CountChars());
            Console.WriteLine(sum.ApplyVat());
            v.CapitalizeAndPluralizeWord();
            s.CapitalizeAndPluralizeWord();
        }
    }

    public static class Extensions
    {
        //Write an extension method to check if a string starts with a capital letter or not.
        public static bool CheckCapitalLetter(this string stringToCkeck)
        {
            if (!string.IsNullOrEmpty(stringToCkeck))
            {
                return char.IsUpper(stringToCkeck[0]);
            }
            else
                return false;
        }

        //Write an extension method that appends an ‘s’ to a string.
        public static string AppendS(this string stringToCkeck)
        {
            return stringToCkeck += "s";
        }

        //Write an extension method that will capitalize a word.
        public static string CapitalizeWord(this string stringToCkeck)
        {
            return stringToCkeck.ToUpper();
        }

        //Write an extension method what will count the number of characters in a string.
        public static int CountChars(this string stringToCkeck)
        {
            return stringToCkeck.Length;
        }

        //Write a program that will capitalize a string , and pluralize the same string.
        public static void CapitalizeAndPluralizeWord(this string text)
        {
            string[] words = text.Trim().Split(" ");
            var listWords = new List<string>(words);

            for (int i = 0; i < listWords.Count; i++)
            {
                listWords[i] = char.ToUpper(listWords[i][0]) + listWords[i].Substring(1) + "s";
                Console.WriteLine(listWords[i]);
            }
        }

        //Write an extension method that will apply a VAT of 24% on an input.
        public static decimal ApplyVat(this decimal amount) 
        {
            return amount += amount * 24 / 100;
        }
    }
}

