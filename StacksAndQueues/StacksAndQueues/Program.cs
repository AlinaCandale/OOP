using System;
using System.Collections;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(StringReverseUsingStack(input));
        }

        static string StringReverseUsingStack(string input)
        {
            string reversedStr = "";
            Stack myStack = new Stack();
            foreach (var i in input)
            {
                myStack.Push(i);
            }
            while (myStack.Count > 0)
            {
                reversedStr += myStack.Pop();
            }
            
            return reversedStr;
        }
    }
}

/*
Reverse Strings
Write program that:
• Reads an input string
• Reverses it using a Stack<T>
• Prints the result back at the terminal
*/
