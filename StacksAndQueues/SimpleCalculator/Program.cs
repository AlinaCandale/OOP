using System;
using System.Collections;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Calculator(input));
        }

        static int Calculator(string input)
        {
            string[] result = input.Split(" ");
            Array.Reverse(result);
            Stack myStack = new Stack(result);

            int sum = Convert.ToInt32(myStack.Pop());

            while (myStack.Count > 0)
            {
                if ((string)myStack.Pop() == "+")
                {
                    sum += Convert.ToInt32(myStack.Pop());
                }
                else
                {
                    sum -= Convert.ToInt32(myStack.Pop());
                }
            }

            return sum;
        }
    }
}

/*
Simple Calculator
Create a simple calculator that can evaluate simple expressions with only addition and subtraction. There will not be any parentheses.
Solve the problem using a Stack.
*/
