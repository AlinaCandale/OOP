using System;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    string[] result = input.Split(" ");
                    MathUtil.Calculation(result[0], Convert.ToDouble(result[1]), Convert.ToDouble(result[2]));
                }
            }
        }
    }

    class MathUtil
    {
        public static void Calculation(string input, double nr1, double nr2)
        {
            switch (input)
            {
                case "Sum":
                    Console.WriteLine((nr1 + nr2).ToString("n2"));
                    break;
                case "Subtract":
                    Console.WriteLine((nr1 - nr2).ToString("n2"));
                    break;
                case "Multiply":
                    Console.WriteLine((nr1 * nr2).ToString("n2"));
                    break;
                case "Divide":
                    Console.WriteLine((nr1 / nr2).ToString("n2"));
                    break;
                case "Percentage":
                    Console.WriteLine((nr1 * nr2 / 100).ToString("n2"));
                    break;
            }
        }
    }
}

/*
Basic Math
Define MathUtil class that supports basic mathematical operations:
• Sum <first number> <second number>
• Subtract <first number> <second number>
• Multiply <first number> <second number>
• Divide <dividend> <divisor>
• Percentage <total number> <percent of that number>
Use static methods and make sure that the application will work with floating point numbers.
Read from the console until you receive command “End”. Results must be formatted with 2 digits after the floating point.
*/
