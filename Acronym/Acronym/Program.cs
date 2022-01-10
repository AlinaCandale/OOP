using System;
using System.Text;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            AcronymConvertor text = new AcronymConvertor();
            text.ConvertToAcronym("Three Letter Acronyms");

            AcronymConvertor text2 = new AcronymConvertor();
            text2.ConvertToAcronym("Three  Letter ,   Acronyms");

            AcronymConvertor anothertext = new AcronymConvertor();
            anothertext.ConvertToAcronym("Portable Network Graphics");
        }
    }

    class AcronymConvertor
    {
        StringBuilder result = new StringBuilder();
        public void ConvertToAcronym(string textToConvert)
        {
            result.Append(textToConvert[0]);
            for (int i = 1; i < textToConvert.Length - 1; i++)
            {
                if (textToConvert[i] == ' ' && Char.IsLetter(textToConvert[i + 1]))
                {
                    result.Append(textToConvert[i + 1]);
                }
                else
                {
                    continue;
                }
            }
            Print();
        }

        void Print()
        {
            Console.WriteLine(result.ToString().ToUpper());
        }
    }
}

/*
Write a class with all the logic needed to convert a phrase to its acronym.
Techies love their TLA (Three Letter Acronyms)!
Help generate some jargon by writing a program that converts a long name like Portable Network Graphics to its acronym (PNG).
*/
