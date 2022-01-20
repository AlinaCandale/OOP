using System;
using System.Collections.Generic;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapElementsAtIndex(1, 2, new List<int> { 0, 1, 2, 3, 4, 5 });
            SwapElementsAtIndex(1, 2, new List<string> { "miau", "mau", "mu", "mor", "nihau" });
        }

        static void SwapElementsAtIndex<T>(int index1, int index2, List<T> myList)
        {
            var temp = myList[index1];
            myList[index1] = myList[index2];
            myList[index2] = temp;
            PrintList<T>(myList);
        }

        static void PrintList<T>(List<T> myList)
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
Create a generic method that receives a list containing any type of data and swaps the elements at two given indexes.
*/
