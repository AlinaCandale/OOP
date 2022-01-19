using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] players = input.Split(" ");
            int exitNr = Convert.ToInt32(Console.ReadLine());
            HotPotatos game = new HotPotatos(new Queue<string>(players), exitNr);

            game.MovePotato();
        }
    }

    class HotPotatos
    {
        Queue<string> myQueue;
        int exitNr;

        public HotPotatos(Queue<string> myQueue, int exitNr)
        {
            this.exitNr = exitNr;
            this.myQueue = myQueue;
        }

        public void MovePotato()
        {
            while (myQueue.Count > 1)
            {
                for (int i = 1; i < exitNr; i++)
                {
                    MoveToTheBackOfQueue();
                }
                RemovePlayer();
            }
            Console.WriteLine($"Last is {myQueue.Dequeue()}");
        }

        void RemovePlayer()
        {
            Console.WriteLine($"Removed {myQueue.Dequeue()}");
        }

        void MoveToTheBackOfQueue()
        {
            myQueue.Enqueue(myQueue.Dequeue());
        }
    }
}

/*
Hot potato is a game in which children form a circle and start passing a hot potato. 
The counting starts with the fist kid. Every nth toss the child left with the potato leaves the game. 
When a kid leaves the game, it passes the potato along. This continues until there is only one kid left.
Create a program that simulates the game of Hot Potato. Print every kid that is removed from the circle. In the end, print the kid that is left last.
*/

