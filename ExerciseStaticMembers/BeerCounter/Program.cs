using System;

namespace BeerCounter
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
                    BeeerCounter.Print();
                    break;
                }
                else
                {
                    string[] result = input.Split(" ");
                    BeeerCounter.BuyBeer(Convert.ToInt32(result[0]));
                    BeeerCounter.DrinkBeer(Convert.ToInt32(result[1]));
                }
            }
        }
    }

    class BeeerCounter
    {
        static int beerInStock;
        static int beersDrankCount;

        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beersDrankCount += bottlesCount;
            beerInStock -= bottlesCount;
        }

        public static void Print()
        {
            Console.WriteLine($"{beerInStock} {beersDrankCount}");
        }
    }
}

/*
Beer Counter
Define class BeerCounter holding static field beerInStock that shows how many beers you bought and static field beersDrankCount that shows how many beers you have drunk. 
Manipulate the static fields through static methods BuyBeer(int bottlesCount) and DrinkBeer(int bottlesCount). 
On every input line you will get pair of beers you bought and beers you drank, until you receive command “End”.
• BuyBeer – add beers to the beers in stock
• DrinkBeer – add beers to the drunk beers counter and subtract beers in stock
After that print beersInStock and beersDrankCount on the same line separated by 1 space.
*/
