using System;
using System.Text;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            AcronymConvertor text = new AcronymConvertor("Three Letter Acronyms");
            text.Print();

            AcronymConvertor anothertext = new AcronymConvertor("Portable Network Graphics");
            anothertext.Print();
        }
    }

    class AcronymConvertor
    {
        StringBuilder result = new StringBuilder();
        public AcronymConvertor(string textToConvert)
        {
            result.Append(textToConvert[0]);
            for (int i = 1; i < textToConvert.Length - 1; i++)
            {
                if (textToConvert[i] == ' ')
                {
                    result.Append(textToConvert[i + 1]);
                }
            }
        }

        public void Print()
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
