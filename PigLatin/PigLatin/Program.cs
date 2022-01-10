using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            EnglishToPigLatin first = new EnglishToPigLatin("my big sister");
            first.TranslateEnglishToPigLatin();
        }
    }

    public class EnglishToPigLatin
    {
        string text;

        public EnglishToPigLatin(string text)
        {
            this.text = text;
        }

        public void TranslateEnglishToPigLatin()
        {
            string[] textToConvert = text.Split(' ', ',', '.');
            foreach (var word in textToConvert)
            {
                Console.Write(CovertWordToPigLatin(word));
            }
        }

        string CovertWordToPigLatin(string word)
        {
            string pigLatinWord;
            if ("aeiouAEIOU".Contains(word[0]))
            {
                pigLatinWord = word + "ay ";
            }
            else
            {
                pigLatinWord = word.Substring(1) + word[0] + "ay ";
            }

            return pigLatinWord;
        }
    }
}

/*
Implement a program that translates from English to Pig Latin.
Pig Latin is a made-up children's language that's intended to be confusing. It obeys a few simple rules (below).

Rule 1: If a word begins with a vowel sound, add an "ay" sound to the end of the word.
Rule 2: If a word begins with a consonant sound, move it to the end of the word, and then add an "ay" sound to the end of the word. 
There are a few more rules for edge cases, and there are regional variants too.
*/
