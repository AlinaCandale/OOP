using System;
using System.Collections;
using System.Collections.Generic;

namespace DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Transform(10));
            Console.WriteLine(Transform(1024));
        }

        static string Transform(int nr)
        {
            Stack<int> myStack = new Stack<int>();
            if (nr == 0)
            {
                Console.WriteLine(0);
            }

            while (nr >= 1)
            {
                myStack.Push(nr % 2);
                nr = nr / 2;
            }

            string joinedString = String.Join("", myStack);
            return joinedString;
        }
    }
}
/*
Decimal to Binary Converter
Create a simple program that can convert a decimal number to its binary representation. 
Implement an elegant solution using a Stack.
Print the binary representation back at the terminal.
Hints
• If the given number is 0, just print 0
• Else, while the number is greater than zero, divide it by 2 and push the remainder into the stack
• When you are done dividing, pop all remainders from the stack – that is the binary representation
*/
