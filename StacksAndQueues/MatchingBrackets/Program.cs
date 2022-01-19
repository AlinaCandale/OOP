using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            FindBrackets("(2 + 3) - (2 + 3)");
            FindBrackets("1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5");
        }

        static void FindBrackets(string input)
        {
            Stack<int> myStack = new Stack<int>();
            Stack<string> resultStack = new Stack<string>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '(')
                {
                    myStack.Push(i);
                }
                if (input[i] == ')')
                {
                    resultStack.Push(input.Substring(myStack.Peek(), i - myStack.Pop() + 1));
                }
            }
            if (myStack.Count > 0)
            {
                resultStack.Push(input.Substring(myStack.Pop()));
            }

            while (resultStack.Count > 0)
            {
                Console.WriteLine(resultStack.Pop());
            }
        }
    }
}
/*
Matching Brackets
We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.
Print the result back at the terminal.
Hints
• Scan through the expression searching for brackets
o If you find an opening bracket, push the index into the stack
o If you find a closing bracket pop the topmost element from the stack. This is the index of the opening bracket.
o Use the current and the popped index to extract the sub-expression
*/