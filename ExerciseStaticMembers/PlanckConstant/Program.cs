using System;

namespace PlanckConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation.ReducedPlanck());
        }
    }

    class Calculation
    {
        public const double Planck = 6.62606896e-34;
        public const double Pi = 3.14159;

        public static double ReducedPlanck()
        {
            return Planck / (2 * Pi);
        }
    }
}

/*
Planck Constant
Create class Calculation. Define static constant with value 6.62606896e-34 (Planck constant) and 3.14159 (Pi). 
Add static method that returns reduced Planck constant by the formula:
{Planck constant} / (2 * {Pi constant})
Print the result of the method on a single line on the console. Do not format in any way the result.
*/

