using System;

namespace TemperatureConverter
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
                    Calculate(result[1], Convert.ToInt32(result[0]));
                }
            }
        }

        static void Calculate(string input, int nr)
        {
            if (input == "Celsius")
            {
                CelsiusToFahrenheit(nr);
            }
            else
            {
                FahrenheitToCelsius(nr);
            }
        }

        static void CelsiusToFahrenheit(int celsius)
        {
            double result = (1.8 * celsius) + 32;
            Console.WriteLine($"{result.ToString("n2")} Fahrenheit");
        }

        static void FahrenheitToCelsius(int fahrenheit)
        {
            double result = (fahrenheit - 32) * 0.5555;
            Console.WriteLine($"{result.ToString("n2")} Celsius");
        }
    }
}


/*
Temperature Converter
Create a program that converts temperature from Celsius to Fahrenheit and vice versa. Use static methods. 
The input data will be in format: {temperature} {unit}. 
Temperatures will be in integer number and units will be one of these two values: Celsius / Fahrenheit. 
Output value must be double value following of empty space and the converted unit. 
You are going to receive input, until you receive command “End”. The output must be formatted 2 digits after floating point.
*/
