using System;

namespace RainDrops
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter the number to transform: ");
			string input = Console.ReadLine();
			int number = 1;
			if (int.TryParse(input, out number))
			{
				string converted = PlingPlangPlong(number);
				Console.WriteLine(converted);
			}
			else
			{
				Console.WriteLine("Invalid input. Enter a valid number.");
				do
				{
					input = Console.ReadLine();
				}
				while (!int.TryParse(input, out number));
				string converted = PlingPlangPlong(number);
				Console.WriteLine(converted);
			}
		}

		public static string PlingPlangPlong(int number)
		{
			string result = "";
			if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
			{
				result = number.ToString();
			}
			if (number % 3 == 0)
			{
				result += "Pling";
			}
			if (number % 5 == 0)
			{
				result += "Plang";
			}
			if (number % 7 == 0)
			{
				result += "Plong";
			}
			return result;
		}
	}
}

/*
Convert a number to a string, the contents of which depend on the number's factors.
If the number has 3 as a factor, output 'Pling'.
If the number has 5 as a factor, output 'Plang'.
If the number has 7 as a factor, output 'Plong'.
If the number does not have 3, 5, or 7 as a factor, just pass the number's digits straight through.
Examples
28's factors are 1, 2, 4, 7, 14, 28.
In raindrop-speak, this would be a simple "Plong".
30's factors are 1, 2, 3, 5, 6, 10, 15, 30.
In raindrop-speak, this would be a "PlingPlang".
34 has four factors: 1, 2, 17, and 34.
In raindrop-speak, this would be "34".
*/